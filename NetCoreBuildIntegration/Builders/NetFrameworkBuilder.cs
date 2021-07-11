using NetCoreBuildIntegration.VSVersion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreBuildIntegration.Builders
{
    /// <summary>
    /// Средства работы со сборкой .NET Framework
    /// </summary>
    public class NetFrameworkBuilder : ISolutionBuilder
    {
        private readonly string msBuildPath;
        /// <summary>
        /// Команд запуска консоли.
        /// </summary>
        private const string CONSOLE_EXECUTING_COMAND = "cmd";
        /// <summary>
        /// Путь к файлу решения.
        /// </summary>
        public string SolutionFilePath { get; set; }
        private VsVersionItem selectedVsVersion;

        public NetFrameworkBuilder(string msBuildPath, VsVersionItem vsVersion=null)
        {
            // задаём путь к MSBuild.exe
            this.msBuildPath = msBuildPath;
            // Включаем поддержку кодировки вывода консоли.
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            selectedVsVersion = vsVersion;
        }

        /// <summary>
        /// Сборка решения.
        /// </summary>
        /// <returns>Вывод сообщений компилятора.</returns>
        public string Build()
        {
            Process builderProcess;
            if ((selectedVsVersion == null) || (selectedVsVersion==SupportedVsVersions.DefaultVersion)) {
                builderProcess = PrepareBuilderProcess($"/c \"{msBuildPath}\" {SolutionFilePath}");
            }
            else
            {
                builderProcess = PrepareBuilderProcess($"/c \"{msBuildPath}\" {SolutionFilePath} /p:VisualStudioVersion={selectedVsVersion.Version}");
            }
            var sb = new StringBuilder();
            builderProcess.Start();
            while (!builderProcess.StandardOutput.EndOfStream)
            {
                sb.Append($"{builderProcess.StandardOutput.ReadLine()}\n\r"); ;
            }
            string sourceOutput = sb.ToString();
            return sourceOutput;
        }
        /// <summary>
        /// Асинхронная сборка решения.
        /// </summary>
        /// <returns>Асинхронный вывод сообщений компилятора.</returns>
        public Task<string> BuildAsync()
        {
            return Task<string>.Factory.StartNew(() => Build());
        }


        private Process PrepareBuilderProcess(string command)
        {
            Process builderProcess = new Process();
            builderProcess.StartInfo.FileName = CONSOLE_EXECUTING_COMAND;
            builderProcess.StartInfo.Arguments = command;
            builderProcess.StartInfo.RedirectStandardOutput = true;
            builderProcess.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
            builderProcess.StartInfo.CreateNoWindow = true;
            return builderProcess;
        }
    }
}

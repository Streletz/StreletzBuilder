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
        private readonly string _msBuildPath;
        /// <summary>
        /// Команд запуска консоли.
        /// </summary>
        private const string ConsoleExecutingCommand = "cmd";
        /// <summary>
        /// Путь к файлу решения.
        /// </summary>
        public string SolutionFilePath { get; set; }
        private VsVersionItem _selectedVsVersion;

        public NetFrameworkBuilder(string msBuildPath, VsVersionItem vsVersion=null)
        {
            // задаём путь к MSBuild.exe
            this._msBuildPath = msBuildPath;
            // Включаем поддержку кодировки вывода консоли.
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            _selectedVsVersion = vsVersion;
        }

        /// <summary>
        /// Сборка решения.
        /// </summary>
        /// <returns>Вывод сообщений компилятора.</returns>
        public string Build()
        {
            Process builderProcess;
            if ((_selectedVsVersion == null) || (_selectedVsVersion==SupportedVsVersions.DefaultVersion)) {
                builderProcess = PrepareBuilderProcess($"/c \"{_msBuildPath}\" {SolutionFilePath}");
            }
            else
            {
                builderProcess = PrepareBuilderProcess($"/c \"{_msBuildPath}\" {SolutionFilePath} /p:VisualStudioVersion={_selectedVsVersion.Version}");
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
            builderProcess.StartInfo.FileName = ConsoleExecutingCommand;
            builderProcess.StartInfo.Arguments = command;
            builderProcess.StartInfo.RedirectStandardOutput = true;
            builderProcess.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
            builderProcess.StartInfo.CreateNoWindow = true;
            return builderProcess;
        }
    }
}

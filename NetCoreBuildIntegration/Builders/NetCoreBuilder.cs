using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NetCoreBuildIntegration.Builders
{
    /// <summary>
    /// Средства работы со сборкой .NET Core
    /// </summary>
    public class NetCoreBuilder
    {
        /// <summary>
        /// Консольная команда для сборки.
        /// </summary>
        private const string BUILD_COMMAND = "dotnet build";
        /// <summary>
        /// Команд запуска консоли.
        /// </summary>
        private const string CONSOLE_EXECUTING_COMAND = "cmd";
        /// <summary>
        /// Путь к файлу решения.
        /// </summary>
        public string SolutionFilePath { get; set; }       

        public NetCoreBuilder()
        {
            // Включаем поддержку кодировки вывода консоли.
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        /// <summary>
        /// Сборка решения.
        /// </summary>
        /// <returns></returns>
        public string Build()
        {
            Process builderProcess = PrepareBuilderProcess($"/c {BUILD_COMMAND} {SolutionFilePath} ");
            var sb = new StringBuilder();
            builderProcess.Start();
            while (!builderProcess.StandardOutput.EndOfStream)
            {
                sb.Append($"{builderProcess.StandardOutput.ReadLine()}\n\r"); ;
            }
            string sourceOutput = sb.ToString();
            return sourceOutput;            
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

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreBuildIntegration.Builders
{
    /// <summary>
    /// Средства работы со сборкой .NET Core
    /// </summary>
    public class NetCoreBuilder : ISolutionBuilder
    {
        /// <summary>
        /// Консольная команда для сборки.
        /// </summary>
        private const string BuildCommand = "dotnet build";
        /// <summary>
        /// Команд запуска консоли.
        /// </summary>
        private const string ConsoleExecutingCommand = "cmd";
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
        /// <returns>Вывод сообщений компилятора.</returns>
        public string Build()
        {
            Process builderProcess = PrepareBuilderProcess($"/c {BuildCommand} {SolutionFilePath} ");
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

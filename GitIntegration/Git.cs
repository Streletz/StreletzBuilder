using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GitIntegration
{
    /// <summary>
    /// Класс для работы с Git
    /// </summary>
    public class Git
    {
        /// <summary>
        /// Команда получения изменений из удалённого репозитория.
        /// </summary>
        private const string PULL = "pull";
        /// <summary>
        /// Путь к папке с репозиторием Git.
        /// </summary>
        public string RepositoryPath { get; set; }
        /// <summary>
        /// Путь к сиполняемому файлу Git
        /// </summary>
        public string GitPath { get; set; }
        /// <summary>
        /// Выполнение команды получения изменений из удалённого репозитория (git pull).
        /// </summary>
        /// <returns>Вывод Git.</returns>
        public string Pull()
        {
            Process gitProcess = PrepareGitProcess(PULL);
            var sb = new StringBuilder();
            gitProcess.Start();
            while (!gitProcess.StandardOutput.EndOfStream)
            {
                sb.Append($"{gitProcess.StandardOutput.ReadLine()}\n\r");
            }
            return sb.ToString();
        }

        private Process PrepareGitProcess(string gitCommand)
        {
            Process gitProcess = new Process();
            gitProcess.StartInfo.FileName = GitPath;
            gitProcess.StartInfo.Arguments = gitCommand;
            gitProcess.StartInfo.WorkingDirectory = RepositoryPath;
            gitProcess.StartInfo.RedirectStandardOutput = true;
            gitProcess.StartInfo.CreateNoWindow = true;
            return gitProcess;
        }
    }
}

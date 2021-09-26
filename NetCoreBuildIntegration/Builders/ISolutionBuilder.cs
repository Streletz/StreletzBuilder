using System.Threading.Tasks;

namespace NetCoreBuildIntegration.Builders
{
    public interface ISolutionBuilder
    {
        string SolutionFilePath { get; set; }
        /// <summary>
        /// Сборка решения.
        /// </summary>
        /// <returns>Вывод сообщений компилятора.</returns>
        string Build();
        /// <summary>
        /// Асинхронная сборка решения.
        /// </summary>
        /// <returns>Асинхронный вывод сообщений компилятора.</returns>
        Task<string> BuildAsync();
    }
}
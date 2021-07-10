using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBuildIntegration.VSVersion
{
    /// <summary>
    /// Информация о версии Visual Studio.
    /// </summary>
    [Serializable]
    public class VsVersionItem
    {
        private readonly string version;
        private readonly string name;

        public VsVersionItem()
        {

        }
        public VsVersionItem(string version, string name)
        {
            this.version = version;
            this.name = name;
        }
        /// <summary>
        /// Название версии Visual Studio.
        /// </summary>
        public string Name { get { return name; } }
        /// <summary>
        /// Версия Visual Studio.
        /// </summary>
        public string Version { get { return version; } }

        public override string ToString()
        {
            return name;
        }

    }
}

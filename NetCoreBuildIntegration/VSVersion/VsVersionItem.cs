using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NetCoreBuildIntegration.VSVersion
{
    /// <summary>
    /// Информация о версии Visual Studio.
    /// </summary>
    [Serializable]
    public class VsVersionItem
    {
        public VsVersionItem()
        {
        }
        public VsVersionItem(string version, string name)
        {
            this.Version = version;
            this.Name = name;
        }
        /// <summary>
        /// Название версии Visual Studio.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Версия Visual Studio.
        /// </summary>
        public string Version { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}

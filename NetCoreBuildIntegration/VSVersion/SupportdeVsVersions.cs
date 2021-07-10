using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBuildIntegration.VSVersion
{
    /// <summary>
    /// Поддерживаемые в программе версии Visual Studio.
    /// </summary>
    class SupportdeVsVersions
    {
        private readonly VsVersionItem defaultVersion = new VsVersionItem("0", "По умолчанию");
        private readonly VsVersionItem vs2015 = new VsVersionItem("14.0", "Visual Studio 2015");
        private readonly VsVersionItem vs2017 = new VsVersionItem("15.0", "Visual Studio 2019");
        private readonly VsVersionItem vs2019 = new VsVersionItem("16.0", "Visual Studio 2019");
        /// <summary>
        /// Версия Visual Studio по ьумолчанию (играент роль маркера для логики программы).
        /// </summary>
        public VsVersionItem DefaultVersion { get { return defaultVersion; } }
        /// <summary>
        /// Данные о версии Visual Studio 2015.
        /// </summary>
        public VsVersionItem Vs2015 { get { return vs2015; } }
        /// <summary>
        /// Данные о версии Visual Studio 2017.
        /// </summary>
        public VsVersionItem Vs2017 { get { return vs2017; } }
        /// <summary>
        /// Данные о версии Visual Studio 2019.
        /// </summary>
        public VsVersionItem Vs2019 { get { return vs2019; } }

        public List<VsVersionItem> SupportedVersions()
        {
            return new List<VsVersionItem>
            {
                defaultVersion,
                vs2015,
                vs2017,
                vs2019
            };
        }
    }
}

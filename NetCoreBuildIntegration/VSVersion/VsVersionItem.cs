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

        public override bool Equals(object obj)
        {
            if (!(obj is VsVersionItem))
            {
                return false;
            }
            VsVersionItem objItem = (VsVersionItem)obj;
            return (this.Name == objItem.Name) && (this.Version == objItem.Version);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Version);
        }

        public static bool operator ==(VsVersionItem item1, VsVersionItem item2)
        {
            return item1.Equals(item2) == true;
        }

        public static bool operator !=(VsVersionItem item1, VsVersionItem item2)
        {
            return item1?.Equals(item2) == false;
        }

    }
}

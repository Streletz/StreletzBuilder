using NetCoreBuildIntegration.VSVersion;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace StreletzBuilder.Settings
{
    /// <summary>
    /// Настройки программы.
    /// </summary>
    [Serializable]    
    public class Settings
    {       
        public string GitPath { get; set; }        
        public string RepositoryPath { get; set; }        
        public string SolutionFilePath { get; set; }        
        public string MsBuildExePath { get; set; }        
        public bool UseMsBuild { get; set; }        
        public VsVersionItem SelectedVsVersion { get; set; }

    }
}

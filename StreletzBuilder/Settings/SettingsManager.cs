using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace StreletzBuilder.Settings
{
    /// <summary>
    /// Управление настройками программы.
    /// </summary>
    public class SettingsManager
    {
        private static SettingsManager instance;

        private Settings settings;

        private SettingsManager()
        {
            settings = ReadSettingsFromFile();
        }

        public static SettingsManager GetInstance()
        {
            if (instance == null)
            {
                instance = new SettingsManager();
            }
            return instance;
        }

        public Settings Settings { get { return settings; } }
        /// <summary>
        /// Показывает заданы ли все необходимые настройки для работы программы.
        /// </summary>
        public bool Ready
        {
            get
            {
                return !String.IsNullOrEmpty(settings.GitPath)
                    && !String.IsNullOrEmpty(settings.RepositoryPath)
                    && !String.IsNullOrEmpty(settings.SolutionFilePath)
                    && ((settings.UseMsBuild && (!string.IsNullOrEmpty(settings.MsBuildExePath) && !string.IsNullOrWhiteSpace(settings.MsBuildExePath))) || !settings.UseMsBuild);
            }
        }

        private void SaveSettingsToFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            using (FileStream fs = new FileStream("config.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, settings);
            }
        }

        private Settings ReadSettingsFromFile()
        {
            Settings settingsData;
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            try
            {
                using (FileStream fs = new FileStream("config.xml", FileMode.Open))
                {
                    settingsData = (Settings)serializer.Deserialize(fs);
                }
            }
            catch (FileNotFoundException ex)
            {
                settingsData = new Settings();
            }
            return settingsData;
        }

        public void Save()
        {
            SaveSettingsToFile();
        }
    }
}

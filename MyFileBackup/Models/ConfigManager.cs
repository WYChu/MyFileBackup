using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MyFileBackup.Models
{
    public class ConfigManager
    {
        private const String PATH = @"../../Configs/";

        /// <summary>
        /// Field
        /// </summary>
        [JsonProperty("configs")]
        private List<Config> configs;

        /// <summary>
        /// Property
        /// </summary>
        public int Count
        {
            get
            {
                return this.configs.Count;
            }
        }

        /// <summary>
        /// Method
        /// </summary>
        public List<Config> ProcessConfigs()
        {
            ReadConfig();

            return configs;
        }

        private static ConfigManager GetConfigManager(string configValue)
        {
            return JsonConvert.DeserializeObject<ConfigManager>(configValue);
        }

        private static string GetConfigValue()
        {
            return File.ReadAllText(PATH + "config.json");
        }

        private void ReadConfig()
        {
            string configValue = GetConfigValue();

            ConfigManager configManager = GetConfigManager(configValue);
        }
    }
}
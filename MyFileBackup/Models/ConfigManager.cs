using System;
using System.Collections.Generic;
using System.IO;

namespace MyFileBackup.Models
{
    public class ConfigManager
    {
        // 定義設定檔資料夾路徑
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
            this.configs = new List<Config>();
            try
            {
                dynamic configObj = GetConfig();

                foreach (var item in configObj["configs"])
                {
                    string connectionString = item["connectionString"];
                    string destination = item["destination"];
                    string dir = item["dir"];
                    string ext = item["ext"];
                    string handler = item["handler"];
                    string location = item["location"];
                    bool remove = item["remove"];
                    bool subDirectory = item["subDirectory"];
                    string unit = item["unit"];
                    Config config = new Config(connectionString, destination, dir, ext, handler, location, remove, subDirectory, unit);

                    this.configs.Add(config);
                }
            }
            catch (Exception)
            {
                // TODO：設定檔讀取錯誤
                // throw;
            }

            return configs;
        }

        /// <summary>
        /// 取得設定檔物件
        /// </summary>
        /// <returns>設定檔物件</returns>
        private static dynamic GetConfig()
        {
            string configValue = GetConfigValue();

            dynamic configObj = JsonConvert.DeserializeObject(configValue);

            return configObj;
        }

        /// <summary>
        /// 讀取設定檔內容
        /// </summary>
        /// <returns>設定檔內容</returns>
        private static string GetConfigValue()
        {
            return File.ReadAllText(PATH + "config.json");
        }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MyFileBackup.Models
{
    public class ConfigManager : JsonManager
    {
        // 定義設定檔資料夾路徑
        private const String PATH = @"../../Configs/config.json";

        /// <summary>
        /// Field
        /// </summary>
        [JsonProperty("configs")]
        private List<Config> configs = new List<Config>();

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
        /// 索引子
        /// </summary>
        /// <param name="index"></param>
        /// <returns>指定索引config物件</returns>
        public Config this[int index]
        {
            get
            {
                return this.configs[index];
            }
        }

        /// <summary>
        /// Method
        /// </summary>
        public override void ProcessJsonConfig()
        {
            try
            {
                dynamic configObj = this.GetJsonObject(PATH);

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
        }
    }
}
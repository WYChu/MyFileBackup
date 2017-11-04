using Newtonsoft.Json;
using System.IO;

namespace MyFileBackup.Handlers
{
    public abstract class JsonManager
    {
        /// <summary>
        /// 處理設定檔
        /// </summary>
        public abstract void ProcessJsonConfig();

        /// <summary>
        /// 取得設定檔物件
        /// </summary>
        /// <returns>設定檔物件</returns>
        protected dynamic GetJsonObject(string filePath)
        {
            string configValue = GetConfigValue(filePath);

            dynamic configObj = JsonConvert.DeserializeObject(configValue);

            return configObj;
        }

        /// <summary>
        /// 讀取設定檔內容
        /// </summary>
        /// <returns>設定檔內容</returns>
        private static string GetConfigValue(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
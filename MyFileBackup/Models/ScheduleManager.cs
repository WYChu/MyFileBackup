using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MyFileBackup.Models
{
    public class ScheduleManager
    {
        // 定義設定檔資料夾路徑
        private const String PATH = @"../../Configs/schedule.json";

        /// <summary>
        /// Field
        /// </summary>
        [JsonProperty("schedules")]
        private List<Schedule> schedules = new List<Schedule>();

        /// <summary>
        /// Property
        /// </summary>
        public int Count
        {
            get
            {
                return this.schedules.Count;
            }
        }

        /// <summary>
        /// 索引子
        /// </summary>
        /// <param name="index"></param>
        /// <returns>指定索引config物件</returns>
        public Schedule this[int index]
        {
            get
            {
                return this.schedules[index];
            }
        }

        /// <summary>
        /// Method
        /// </summary>
        public void ProcessSchedules()
        {
            try
            {
                dynamic scheduleObj = GetSchedule();

                foreach (var item in scheduleObj["schedules"])
                {
                    string ext = item["ext"];
                    string interval = item["interval"];
                    string time = item["time"];
                    Schedule schedule = new Schedule(ext, interval, time);

                    this.schedules.Add(schedule);
                }
            }
            catch (Exception)
            {
                // TODO：設定檔讀取錯誤
                // throw;
            }
        }

        /// <summary>
        /// 取得設定檔物件
        /// </summary>
        /// <returns>設定檔物件</returns>
        private static dynamic GetSchedule()
        {
            string configValue = GetScheduleValue();

            dynamic configObj = JsonConvert.DeserializeObject(configValue);

            return configObj;
        }

        /// <summary>
        /// 讀取設定檔內容
        /// </summary>
        /// <returns>設定檔內容</returns>
        private static string GetScheduleValue()
        {
            return File.ReadAllText(PATH);
        }
    }
}
using MyFileBackup.Medels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MyFileBackup.Handlers
{
    public class ScheduleManager : JsonManager
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
        public override void ProcessJsonConfig()
        {
            try
            {
                dynamic scheduleObj = this.GetJsonObject(PATH);

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
    }
}
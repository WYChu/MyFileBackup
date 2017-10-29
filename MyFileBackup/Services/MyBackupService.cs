using MyFileBackup.Models;
using System.Collections.Generic;

namespace MyFileBackup.Services
{
    public class MyBackupService
    {
        /// <summary>
        /// 設定檔管理器
        /// </summary>
        private List<JsonManager> managers = new List<JsonManager>();

        /// <summary>
        /// 建構子
        /// </summary>
        public MyBackupService()
        {
            this.managers.Add(new ConfigManager());
            this.managers.Add(new ScheduleManager());
            //this.managers.Add(new PlateformManager());
        }

        /// <summary>
        /// 處理設定檔
        /// </summary>
        public void ProcessJsonConfigs()
        {
            for (int i = 0; i < this.managers.Count; i++)
                this.managers[i].ProcessJsonConfig();
        }
    }
}
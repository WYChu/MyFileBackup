using MyFileBackup.CandidateFactory;
using MyFileBackup.Factories;
using MyFileBackup.Handlers;
using MyFileBackup.Interfaces;
using System;
using System.Collections.Generic;

namespace MyFileBackup.Services
{
    public class MyBackupService
    {
        /// <summary>
        /// 設定檔管理器
        /// </summary>
        private List<JsonManager> managers = new List<JsonManager>();

        private TaskDispatcher taskDispatcher;

        /// <summary>
        /// 建構子
        /// </summary>
        public MyBackupService()
        {
            this.managers.Add(new ConfigManager());
            this.managers.Add(new ScheduleManager());
            //this.managers.Add(new PlateformManager());
            this.taskDispatcher = new TaskDispatcher();

            this.Init();
        }

        /// <summary>
        /// 處理設定檔
        /// </summary>
        public void ProcessJsonConfigs()
        {
            for (int i = 0; i < this.managers.Count; i++)
            {
                this.managers[i].ProcessJsonConfig();
            }
        }

        /// <summary>
        /// 排程備份
        /// </summary>
        public void ScheduleBackup()
        {
            this.taskDispatcher.ScheduleTask(managers);
        }

        /// <summary>
        /// 簡易備份
        /// </summary>
        public void SimpleBackup()
        {
            this.taskDispatcher.SimpleTask(managers);
        }

        /// <summary>
        /// 找尋待備份檔案
        /// </summary>
        /// <returns>檔案清單</returns>
        private List<Candidate> FindFiles()
        {
            throw new NotImplementedException();
        }

        private void Init()
        {
            this.ProcessJsonConfigs();
        }
    }
}
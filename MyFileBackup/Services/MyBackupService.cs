using MyFileBackup.Factories;
using MyFileBackup.Handlers;
using MyFileBackup.Interfaces;
using MyFileBackup.Models;
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
        /// 執行備份作業
        /// </summary>
        public void DoBackup()
        {
            List<Candidate> candidates = this.FindFiles();
            foreach (Candidate candidate in candidates)
            {
                this.BroadcastToHandlers(candidate);
            }
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
        /// 依據檔案選擇處理方式
        /// </summary>
        /// <param name="candidate">待處理檔案</param>
        private void BroadcastToHandlers(Candidate candidate)
        {
            List<IHandler> handlers = this.FindHandlers(candidate);
            byte[] target = null;
            foreach (IHandler handler in handlers)
            {
                target = handler.Perform(candidate, target);
            }
        }

        /// <summary>
        /// 找尋待備份檔案
        /// </summary>
        /// <returns>檔案清單</returns>
        private List<Candidate> FindFiles()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 找尋備份處理器
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns>處理器的 interface</returns>
        private List<IHandler> FindHandlers(Candidate candidate)
        {
            List<IHandler> handlers = new List<IHandler>
            {
                HandlerFactory.Create("file")
            };

            foreach (string handler in candidate.Config.Handlers)
            {
                handlers.Add(HandlerFactory.Create(handler));
            }

            handlers.Add(HandlerFactory.Create(candidate.Config.Destination));
            return handlers;
        }
    }
}
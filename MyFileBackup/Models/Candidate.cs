using MyFileBackup.Medels;
using System;

namespace MyFileBackup.CandidateFactory
{
    /// <summary>
    /// Candiate
    /// </summary>
    public class Candidate
    {
        /// <summary>
        /// 設定檔物件
        /// </summary>
        private readonly Config config;

        /// <summary>
        /// 檔案的日期與時間
        /// </summary>
        private readonly DateTime fileDateTime;

        /// <summary>
        /// 檔案名稱
        /// </summary>
        private readonly string name;

        /// <summary>
        /// 處理檔案的 process
        /// </summary>
        private readonly string processName;

        /// <summary>
        /// 檔案 size
        /// </summary>
        private readonly int size;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="config">Config.</param>
        internal Candidate()
        {
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="config">設定檔</param>
        /// <param name="name">檔名</param>
        /// <param name="fileDatetime">建立時間</param>
        /// <param name="size">檔案大小</param>
        internal Candidate(Config config, string name, DateTime fileDatetime, int size)
        {
            this.config = config;
            this.name = name;
            this.fileDateTime = fileDatetime;
            this.size = size;
        }

        /// <summary>
        /// 設定檔
        /// </summary>
        /// <value>The config.</value>
        public Config Config
        {
            get
            {
                return this.config;
            }
        }

        /// <summary>
        /// 檔案日期時間
        /// </summary>
        /// <value>The file date time.</value>
        public DateTime FileDateTime
        {
            get
            {
                return this.fileDateTime;
            }
        }

        /// <summary>
        /// 檔案名稱
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// 處理檔案的 process
        /// </summary>
        /// <value>The name of the process.</value>
        public string ProcessName
        {
            get
            {
                return this.processName;
            }
        }

        /// <summary>
        /// 檔案 size
        /// </summary>
        /// <value>The size.</value>
        public int Size
        {
            get
            {
                return this.size;
            }
        }
    }
}
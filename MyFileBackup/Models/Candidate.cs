using MyFileBackup.Medels;

namespace MyFileBackup.Models
{
    /// <summary>
    /// Candiate
    /// </summary>
    public class Candidate
    {
        /// <summary>
        /// 設定檔物件
        /// </summary>
        private Config config;

        /// <summary>
        /// 檔案的日期與時間
        /// </summary>
        private string fileDataTime;

        /// <summary>
        /// 檔案名稱
        /// </summary>
        private string name;

        /// <summary>
        /// 處理檔案的 process
        /// </summary>
        private string processName;

        /// <summary>
        /// 檔案 size
        /// </summary>
        private string size;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="config">Config.</param>
        public Candidate(Config config)
        {
            this.config = config;
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
        public string FileDateTime
        {
            get
            {
                return this.fileDataTime;
            }
            set
            {
                this.fileDataTime = value;
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
            set
            {
                this.name = value;
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
            set
            {
                this.processName = value;
            }
        }

        /// <summary>
        /// 檔案 size
        /// </summary>
        /// <value>The size.</value>
        public string Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
    }
}
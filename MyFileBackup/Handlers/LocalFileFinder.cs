using MyFileBackup.CandidateFactory;
using MyFileBackup.Medels;
using System;
using System.IO;
using System.Linq;

namespace MyFileBackup.Handlers
{
    /// <summary>
    /// 本機檔案尋找
    /// </summary>
    public class LocalFileFinder : AbstractFileFinder
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public LocalFileFinder()
        {
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="config"></param>
        public LocalFileFinder(Config config) : base(config)
        {
            if (config.SubDirectory)
            {
                this.files = this.GetSubDirectoryFiles(config);
            }
            else
            {
                this.files = Directory.GetFiles(config.Location, "*." + config.Ext);
            }
        }

        /// <summary>
        /// 建立檔案資訊
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected override Candidate CreateCandidate(string fileName)
        {
            int size = 0;
            string name = string.Empty;
            DateTime fileDatetime = DateTime.Now;
            // TODO
            Candidate candidate = CandidateFactories.Create(config, name, fileDatetime, size);
            return candidate;
        }

        /// <summary>
        /// 取得子目錄下檔案
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        private string[] GetSubDirectoryFiles(Config config)
        {
            // 先取得第一層目錄下的檔案
            this.files = Directory.GetFiles(config.Location, "*." + config.Ext);

            // 迴圈找尋子目錄下的檔案
            DirectoryInfo directoryInfo = new DirectoryInfo(config.Location);
            foreach (DirectoryInfo dirInfo in directoryInfo.GetDirectories())
            {
                string[] currencyDirectoryFiles = Directory.GetFiles(dirInfo.FullName, "*." + config.Ext);
                this.files = this.files.Concat(currencyDirectoryFiles).ToArray();
            }

            return this.files;
        }
    }
}
using Newtonsoft.Json;

namespace MyFileBackup.Models
{
    public class Config
    {
        private string connectionString;

        private string destination;

        private string dir;

        private string ext;

        private string handler;

        private string location;

        private bool remove;

        private bool subDirectory;

        private string unit;

        /// <summary>
        /// 建構子
        /// </summary>
        public Config()
        {
        }

        [JsonProperty("connectionString")]
        public string ConnectionString
        {
            get
            {
                return this.connectionString;
            }
        }

        [JsonProperty("destination")]
        public string Destination
        {
            get
            {
                return this.destination;
            }
        }

        [JsonProperty("dir")]
        public string Dir
        {
            get
            {
                return this.dir;
            }
        }

        [JsonProperty("ext")]
        public string Ext
        {
            get
            {
                return this.ext;
            }
        }

        [JsonProperty("handler")]
        public string Handler
        {
            get
            {
                return this.handler;
            }
        }

        [JsonProperty("location")]
        public string Location
        {
            get
            {
                return this.location;
            }
        }

        [JsonProperty("remove")]
        public bool Remove
        {
            get
            {
                return this.remove;
            }
        }

        [JsonProperty("subDirectory")]
        public bool SubDirectory
        {
            get
            {
                return this.subDirectory;
            }
        }

        [JsonProperty("unit")]
        public string Unit
        {
            get
            {
                return this.unit;
            }
        }
    }
}
using Newtonsoft.Json;

namespace MyFileBackup.Medels
{
    public class Schedule
    {
        private string ext;

        private string interval;

        private string time;

        public Schedule(string ext, string interval, string time)
        {
            this.ext = ext;
            this.interval = interval;
            this.time = time;
        }

        [JsonProperty("ext")]
        public string Ext
        {
            get
            {
                return this.ext;
            }
        }

        [JsonProperty("interval")]
        public string Interval
        {
            get
            {
                return this.interval;
            }
        }

        [JsonProperty("time")]
        public string Time
        {
            get
            {
                return this.time;
            }
        }
    }
}
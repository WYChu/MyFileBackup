using Newtonsoft.Json;

namespace MyFileBackup.Models
{
    public class Schedule
    {
        public Schedule()
        {
        }

        [JsonProperty("ext")]
        public string Ext { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }
}
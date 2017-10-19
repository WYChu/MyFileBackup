using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

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
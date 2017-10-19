using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MyFileBackup.Models
{
    public class ScheduleManager
    {
        [JsonProperty("schedules")]
        public List<Schedule> Schedules { get; set; }
    }
}
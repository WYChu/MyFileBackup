using Newtonsoft.Json;
using System.Collections.Generic;

namespace MyFileBackup.Models
{
    public class ScheduleManager
    {
        [JsonProperty("schedules")]
        public List<Schedule> Schedules { get; set; }
    }
}
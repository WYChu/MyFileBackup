using MyFileBackup.Interfaces;
using MyFileBackup.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileBackup.Factories
{
    public static class TaskFactory
    {
        public static ITask Create(string task)
        {
            if (task == "simple")
            {
                return new SimpleTask();
            }
            else if (task == "scheduled")
            {
                return new ScheduleTask();
            }
            else
            {
                return null;
            }
        }
    }
}
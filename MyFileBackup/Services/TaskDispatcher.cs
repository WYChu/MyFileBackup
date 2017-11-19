using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFileBackup.Handlers;
using MyFileBackup.Factories;
using MyFileBackup.Interfaces;

namespace MyFileBackup.Services
{
    public class TaskDispatcher
    {
        private ITask task;

        internal void ScheduleTask(List<JsonManager> managers)
        {
            this.task = Factories.TaskFactory.Create("scheduled");
            this.task.Execute(configs, schedules);
        }

        internal void SimpleTask(List<JsonManager> managers)
        {
            this.task = Factories.TaskFactory.Create("simple");
            this.task.Execute(configs, null);
        }
    }
}
using MyFileBackup.Medels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileBackup.Interfaces
{
    public interface ITask
    {
        void Execute(Config config, Schedule shedule);
    }
}
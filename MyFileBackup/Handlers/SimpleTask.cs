using MyFileBackup.CandidateFactory;
using MyFileBackup.Medels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileBackup.Handlers
{
    public class SimpleTask : AbstractTask
    {
        public override void Execute(Config config, Schedule schedule)
        {
            base.Execute(config, schedule);
            foreach (Candidate candidate in this.fileFinder)
            {
                this.BroadcastToHandlers(candidate);
            }
        }
    }
}
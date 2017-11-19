using MyFileBackup.CandidateFactory;
using MyFileBackup.Factories;
using MyFileBackup.Interfaces;
using MyFileBackup.Medels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileBackup.Handlers
{
    public class AbstractTask : ITask
    {
        protected IFileFinder fileFinder;

        public virtual void Execute(Config config, Schedule schedule)
        {
            this.fileFinder = FileFinderFactory.Create("file", config);
        }

        protected void BroadcastToHandlers(Candidate candidate)
        {
            List<IHandler> handlers = this.FindHandlers(candidate);
            byte[] target = null;
            foreach (IHandler handler in handlers)
            {
                target = handler.Perform(candidate, target);
            }
        }

        protected List<IHandler> FindHandlers(Candidate candidate)
        {
            List<IHandler> handlers = new List<IHandler>
            {
                HandlerFactory.Create("file")
            };

            foreach (string handler in candidate.Config.Handlers)
            {
                handlers.Add(HandlerFactory.Create(handler));
            }

            handlers.Add(HandlerFactory.Create(candidate.Config.Destination));
            return handlers;
        }
    }
}
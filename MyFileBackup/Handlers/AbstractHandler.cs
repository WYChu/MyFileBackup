using MyFileBackup.CandidateFactory;
using MyFileBackup.Interfaces;

namespace MyFileBackup.Handlers
{
    public abstract class AbstractHandler : IHandler
    {
        public virtual byte[] Perform(Candidate candidate, byte[] target)
        {
            return target;
        }
    }
}
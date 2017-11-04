using MyFileBackup.Interfaces;
using MyFileBackup.Models;

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
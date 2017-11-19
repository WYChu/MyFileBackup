using MyFileBackup.CandidateFactory;

namespace MyFileBackup.Interfaces
{
    public interface IHandler
    {
        byte[] Perform(Candidate candidate, byte[] target);
    }
}
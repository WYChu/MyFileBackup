using MyFileBackup.Medels;
using System;

namespace MyFileBackup.CandidateFactory
{
    public class CandidateFactories
    {
        public static Candidate Create(Config config, string name, DateTime fileDateTime, int size)
        {
            return new Candidate(config, name, fileDateTime, size);
        }
    }
}
using MyFileBackup.CandidateFactory;
using MyFileBackup.Interfaces;
using MyFileBackup.Medels;
using System.Collections;
using System.Linq;

namespace MyFileBackup.Handlers
{
    /// <summary>
    ///
    /// </summary>
    public abstract class AbstractFileFinder : IFileFinder
    {
        protected Config config;
        protected string[] files;
        protected int index = -1;

        protected AbstractFileFinder()
        {
        }

        protected AbstractFileFinder(Config config)
        {
            if (config != null)
                this.config = config;
        }

        // IEnumerator
        public object Current =>
        this.CreateCandidate(this.files[this.index]);

        // IEnumerable
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        // IEnumerator
        public bool MoveNext()
        {
            this.index++;
            return (this.index < this.files.Count());
        }

        // IEnumerator
        public void Reset()
        {
            this.index = -1;
        }

        protected abstract Candidate CreateCandidate(string fileName);
    }
}
using MyFileBackup.CandidateFactory;
using System.IO;
using System.IO.Compression;

namespace MyFileBackup.Handlers
{
    public class ZipHandler : AbstractHandler
    {
        public override byte[] Perform(Candidate candidate, byte[] target)
        {
            byte[] result = target;
            base.Perform(candidate, target);
            if (target != null)
            {
                result = this.ZipData(candidate, target);
            }
            return result;
        }

        private byte[] ZipData(Candidate candidate, byte[] target)
        {
            MemoryStream memoryStream = new MemoryStream();

            using (GZipStream compressedzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                compressedzipStream.Write(target, 0, target.Length);
            }

            return memoryStream.ToArray();
        }
    }
}
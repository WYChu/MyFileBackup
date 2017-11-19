using MyFileBackup.CandidateFactory;
using System.IO;

namespace MyFileBackup.Handlers
{
    /// <summary>
    /// 檔案處理器
    /// </summary>
    public class FileHandler : AbstractHandler
    {
        public override byte[] Perform(Candidate candidate, byte[] target)
        {
            byte[] result = target;
            base.Perform(candidate, target);
            if (target == null)
            {
                result = this.ConvertFileToByteArray(candidate);
            }
            else
            {
                this.ConvertByteArrayToFile(candidate, target);
            }
            return result;
        }

        /// <summary>
        /// 轉換成檔案
        /// </summary>
        /// <param name="candidate">檔案</param>
        /// <param name="target">來源</param>
        private void ConvertByteArrayToFile(Candidate candidate, byte[] target)
        {
            using (FileStream fileStream = new FileStream(candidate.Name, FileMode.Create))
            {
                fileStream.Write(target, 0, target.Length);
            }
        }

        /// <summary>
        /// 轉換成 byte
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns></returns>
        private byte[] ConvertFileToByteArray(Candidate candidate)
        {
            return File.ReadAllBytes(candidate.Name);
        }
    }
}
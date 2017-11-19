using MyFileBackup.CandidateFactory;
using MyFileBackup.Services;

namespace MyFileBackup.Handlers
{
    public class EncodeHandler : AbstractHandler
    {
        private const string password = "5dpnYvF1MOH90kDkcoPhMWHqP42m0f00";
        private const string salt = "LhmnRxTDxG";

        /// <summary>
        /// perform
        /// </summary>
        /// <param name="candidate"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public override byte[] Perform(Candidate candidate, byte[] target)
        {
            byte[] result = target;
            base.Perform(candidate, target);
            if (target != null)
            {
                result = this.EncodeData(candidate, target);
            }

            return result;
        }

        /// <summary>
        /// 資料加密
        /// </summary>
        /// <param name="candidate"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private byte[] EncodeData(Candidate candidate, byte[] target)
        {
            SecurityEncoding securityEncoding = new SecurityEncoding();

            return securityEncoding.AesEncoding(target, password, salt);
        }
    }
}
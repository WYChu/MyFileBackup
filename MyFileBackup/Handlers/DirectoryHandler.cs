using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFileBackup.Models;
using System.IO;

namespace MyFileBackup.Handlers
{
    public class DirectoryHandler : AbstractHandler
    {
        public override byte[] Perform(Candidate candidate, byte[] target)
        {
            byte[] result = target;
            base.Perform(candidate, target);
            if (target != null)
            {
                result = this.CopyToDirectory(candidate, target);
            }
            return result;
        }

        private byte[] CopyToDirectory(Candidate candidate, byte[] target)
        {
            string destnation = candidate.Config.Dir + candidate.Name;
            using (FileStream fileStream = new FileStream(destnation, FileMode.Create, FileAccess.Write))
            {
                fileStream.Write(target, 0, target.Length);
            }

            return target;
        }
    }
}
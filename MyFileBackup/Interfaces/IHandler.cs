using MyFileBackup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileBackup.Interfaces
{
    public interface IHandler
    {
        byte[] Perform(Candidate candiate, byte[] target);
    }
}
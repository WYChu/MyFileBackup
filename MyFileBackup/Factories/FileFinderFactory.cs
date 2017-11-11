using MyFileBackup.Handlers;
using MyFileBackup.Interfaces;
using MyFileBackup.Medels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFileBackup.Factories
{
    public class FileFinderFactory
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="finder"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IFileFinder Create(string finder, Config config)
        {
            if (finder == "file")
            {
                return new LocalFileFinder(config);
            }
            else
            {
                return null;
            }
        }
    }
}
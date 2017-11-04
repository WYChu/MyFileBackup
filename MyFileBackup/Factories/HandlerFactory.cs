using MyFileBackup.Handlers;
using MyFileBackup.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyFileBackup.Factories
{
    public static class HandlerFactory
    {
        private static Dictionary<string, string> handlerDictionary;

        static HandlerFactory()
        {
            string jsonString = File.ReadAllText("../../Configs/handler_mapping.json");
            HandlerFactory.handlerDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
        }

        /// <summary>
        /// Create the specified key.
        /// </summary>
        /// <returns>The create.</returns>
        /// <param name="key">Key.</param>
        public static IHandler Create(string key)
        {
            return (IHandler)Activator.CreateInstance("MyBackupService", HandlerFactory.handlerDictionary[key]).Unwrap();
        }
    }
}
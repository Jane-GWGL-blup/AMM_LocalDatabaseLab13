using LocalDatabase13.iOS.Implementations;
using LocalDatabaseLab13.Interfaces;
using System;
using System.IO;
using Xamarin.Forms;


[assembly: Dependency(typeof(ConfigDataBase))]
namespace LocalDatabase13.iOS.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", databaseFileName);
        }
    }
}

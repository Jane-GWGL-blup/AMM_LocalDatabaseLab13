using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LocalDatabaseLab13.Droid.Implementations;
using LocalDatabaseLab13.Interfaces;
using System.IO;
using Xamarin.Forms;



[assembly: Dependency(typeof(ConfigDataBase))]

namespace LocalDatabaseLab13.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}

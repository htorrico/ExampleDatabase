using ExampleDatabase.Droid.Implementations;
using ExampleDatabase.Interfaces;
using System.IO;
using Xamarin.Forms;



[assembly: Dependency(typeof(ConfigDataBase))]
namespace ExampleDatabase.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}
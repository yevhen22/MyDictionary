using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.UWP;
using System;
using System.IO;
using Xamarin.Forms;
using Windows.Storage;
using test;

[assembly: Dependency(typeof(SQLite_UWP))]
namespace test.UWP
{
    class SQLite_UWP : ISQLite
    {
        public SQLite_UWP() { }
        public string GetDataPath(string filename)
        {
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
            return path;
        }
    }
}


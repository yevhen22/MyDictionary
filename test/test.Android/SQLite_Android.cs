using System;
using System.IO;
using Xamarin.Forms;
using test.Droid;
using test;



[assembly: Dependency(typeof(SQLite_Android))]
namespace test.Droid
{
    class SQLite_Android:ISQLite
    {
        public SQLite_Android(string filename) { }
        public string GetDataPath(string filename) {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, filename);
            return path;
        }
    }
}
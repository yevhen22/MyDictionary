using System;
using test.Droid;
using System.IO;
using Xamarin.Forms;
using test;

[assembly: Dependency(typeof(SQLite_Android))]
namespace test.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public string GetDataPath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}
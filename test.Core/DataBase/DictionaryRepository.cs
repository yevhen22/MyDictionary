using System;
using System.Collections.Generic;
using System.Text;
using test.DataBase;
using test.Models;
using Xamarin.Forms;
using test;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SQLite;
/*
    Class which define all methods for work with database 
*/

namespace test.DataBase
{
    public class DictionaryRepository
    {
        DictionaryContext db;
        public DictionaryRepository(string path) {
            string basepath = DependencyService.Get<ISQLite>().GetDataPath(path);
            db = new DictionaryContext(basepath);
        }

        public IEnumerable<EnglishWord> GetEnglish() {
            var res = new List<EnglishWord>();
            if (db.Englishword != null)
            {
                res = db.Englishword.ToList();
            }
            return res;
        }

        public IEnumerable<UAWord> UAWord()
        {
            var res = db.Uaword.ToList();
            return res;
        }


        public IEnumerable<UAWord> GetAll()
        {
            var res = db.Uaword.Include(p => p.EnglishWord).ToList();
            return res;
        }

        public void SaveEngItem(ref EnglishWord word) {
            if (word.ID != 0)
            {
                db.Update(word);

            }
            else
            {
                db.Englishword.Add(word);
            }
        }

        public void SaveUaItem(UAWord word)
        {
            if (word.ID != 0)
            {
                db.Update(word);

            }
            else
            {
                db.Uaword.Add(word);
            }
        }

        public void SetUpConnection(EnglishWord word,UAWord uAWord) {
            word.uaword.Add(uAWord);
            db.Update(word);
        }
    }
}

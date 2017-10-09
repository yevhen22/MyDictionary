using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.Sqlite;

using SQLite;
/*
    |--Class that contain Ukrainian words--|
    |--Joined with "EnglishWord" class [ManyToOne] by EnglishWord auto property--|
*/
namespace test.Models
{
    [Table("UAWords")]
    public class UAWord
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        public string Uaword { get; private set; }
        public int EnglishWordId { get; set; }
        public EnglishWord Englishword { get; private set; }


        public void SetEngID(int id) {
            EnglishWordId = id;
        }

        public void SetUaWord(string word)
        {
            Uaword = word;
        }

        public void SetConn(EnglishWord englishWord)
        {
            Englishword = englishWord;
        }
        
    }
}

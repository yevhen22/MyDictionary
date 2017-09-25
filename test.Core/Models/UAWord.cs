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
        public int id { get; set; }
        public string uaword { get; set; }
        public int englishWordId { get; set; }
        public EnglishWord englishword { get; set; }

        /* private int id;
         private string uaword;
         private int englishWordId;
         private EnglishWord englishword;


         public event PropertyChangedEventHandler PropertyChanged;

         public string UAword {
             get { return uaword; }
             set
             {
                 if (uaword !=value) {
                     uaword = value;
                     OnPropertyChanged(nameof(UAWord));
                 }
             }
         }
         [PrimaryKey, AutoIncrement, Column("id")]
         public int ID
         {
             get { return id; }
             set
             {
                 if (id != value)
                 {
                     id = value;
                     OnPropertyChanged(nameof(ID));
                 }
             }
         }

         public int EnglishID
         {
             get { return englishWordId; }
             set
             {
                 if (englishWordId != value)
                 {
                     englishWordId = value;
                     OnPropertyChanged(nameof(EnglishID));
                 }
             }
         }


         public EnglishWord EnglishWord
         {
             get { return englishword; }
             set
             {
                 if (englishword != value)
                 {
                     englishword = value;
                     OnPropertyChanged(nameof(EnglishWord));
                 }
             }
         }

         protected void OnPropertyChanged(string prop)
         {
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
         }
         */
    }
}

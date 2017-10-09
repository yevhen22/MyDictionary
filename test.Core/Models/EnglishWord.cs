using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using Microsoft.Extensions;
using SQLite;


namespace test.Models
{
    [Table("EnglishWords")]
    public class EnglishWord
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get;  set; }
        public string Engword { get; private set; }
        public DateTime Currenttime { get; private set; }
        public ICollection<UAWord> uaword { get; private set; }

        public EnglishWord()
        {
            uaword = new List<UAWord>();
        }
        public void AddUkrainianWord(UAWord words)
        {
            uaword.Add(words);
        }
       
      
        public void SetengWord(string eng){
            Engword = eng; 
        }
       
        public void SetDateTime(DateTime time) {
            Currenttime = time;
        }
        
     
    }
}

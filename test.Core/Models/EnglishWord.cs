using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;
using Microsoft.Data.Sqlite;
using SQLite;

namespace test.Models
{
    [Table("EnglishWords")]
    public class EnglishWord:INotifyPropertyChanged
    {

        private int id;
        private string engword;
        private DateTime currenttime;

        public event PropertyChangedEventHandler PropertyChanged;
       
        public ICollection<UAWord> uaword { get; private set; }

        public EnglishWord() {
            uaword = new List<UAWord>();
        }
        [PrimaryKey,AutoIncrement,Column("id")]
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

      
        public string EngWord {
            get { return engword; }
            set
            {
                if (engword != value)
                {
                    engword = value;
                    OnPropertyChanged(nameof(EngWord));
                }
            }
        }

       
       public DateTime DataTime {
            get { return currenttime; }
            set
            {
                if (currenttime != value)
                {
                    currenttime = value;
                    OnPropertyChanged(nameof(DataTime));
                }
            }
        }

        public void AddUkrainianWord(UAWord words) {
            uaword.Add(words);
        }

        protected void OnPropertyChanged(string prop) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using test.Models;
using Xamarin.Forms;

namespace test.ViewModel
{
    public class ViewModelData:INotifyPropertyChanged
    {
        UAWord aWord;
        EnglishWord englishWord;
        ObservableCollection<UAWord> Collection { get; set; }

        public ICommand SaveData {  get; protected set; }
        public ICommand NewOne { get; set; }

        public ViewModelData()
        {
            englishWord = new EnglishWord();
            aWord = new UAWord();
            SaveData = new Command(Save);
            Collection = new ObservableCollection<UAWord>();
        }

        public string Englword
        {
            get { return englishWord.Engword; }
            set
            {
                englishWord.SetengWord(value);
                OnPropertyChanged(nameof(Englword));

            }
        }

        public string Ukrword
        {
            get { return aWord.Uaword; }
            set
            {
                aWord.SetUaWord(value);
                OnPropertyChanged(nameof(Ukrword));
            }
        }

        public void Save()
        {
            if ((string.Empty != Englword) && (Ukrword != string.Empty))
            {
                englishWord.SetDateTime(DateTime.Now);
                englishWord.AddUkrainianWord(aWord);
                App.Database.SaveEngItem(ref englishWord);

                App.Database.SaveUaItem(aWord);
                App.Database.SetUpConnection(englishWord, aWord);
            }
            else {
                Ukrword = "One of the entries are empty";
            }
            Ukrword = String.Empty;
            Englword = string.Empty;
        }

        public void NewWord()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

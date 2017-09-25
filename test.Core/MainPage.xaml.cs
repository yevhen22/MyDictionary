using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using test.Views;
using test.Models;
using test.DataBase;
using Microsoft.EntityFrameworkCore;

namespace test
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
             EnglishWord english = new EnglishWord();
             english.SetengWord("book");
             english.SetDateTime(DateTime.Now);

             UAWord word = new UAWord();
             word.SetUaWord("книга");

            UAWord word1 = new UAWord();
            word1.SetUaWord("бронювати");

            english.AddUkrainianWord(word);
            english.AddUkrainianWord(word1);
            /*EnglishWord english = new EnglishWord
            {
                Engword = "hello",
                Currenttime = DateTime.Now,
            };
            UAWord word = new UAWord
            {
                Uaword = "Привіт",
            };
            english.AddUkrainianWord(word);*/

            App.Database.SaveEngItem(ref english);
            App.Database.SaveUaItem(word);
            App.Database.SetUpConnection(english, word);
        }
        

        /*Method that open page for create new word group*/
        public async void CreateWord(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddWord());
        }
    }
}

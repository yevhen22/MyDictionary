using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using test.Views;
using test.Models;
using test.DataBase;

namespace test
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            ICollection<EnglishWord> list;
            InitializeComponent();
            /* EnglishWord english = new EnglishWord
             {
                 engword = "hello",
                 currenttime = DateTime.Now,
             };

             UAWord word = new UAWord
             {
                 uaword = "Привіт",
             };

             english.AddUkrainianWord(word);

             App.Database.SaveEngItem(ref english);
             App.Database.SaveUaItem(word);
             App.Database.SetUpConnection(english,word);*/
            list = new List<EnglishWord>();
            list = App.Database.GetEnglishList();
        }
        

        /*Method that open page for create new word group*/
        public async void CreateWord(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddWord());
        }
    }
}

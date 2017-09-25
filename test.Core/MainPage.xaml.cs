using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using test.Views;
using test.Models;

namespace test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            EnglishWord english = new EnglishWord();
            english.EngWord = "hello";
            english.DataTime = DateTime.Now;
            english.ID = 1;

            UAWord word = new UAWord();
            word.UAword = "Привіт";
            word.ID = 1;

            english.AddUkrainianWord(word);

            App.Database.SaveEngItem(ref english);
            App.Database.SaveUaItem(word);
            App.Database.SetUpConnection(english,word);
        }
        protected override void OnAppearing()
        {
            //listData.ItemsSource = App.Database.GetEnglish();
            base.OnAppearing();
        }

        /*Method that open page for create new word group*/
        public async void CreateWord(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddWord());
        }
    }
}

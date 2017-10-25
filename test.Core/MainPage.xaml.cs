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
            this.BindingContext = this;
        }

        protected override void OnAppearing()
        {
            dict.BeginRefresh();
            dict.ItemsSource = App.Database.GetEnglish();
            this.BindingContext = this;
            dict.EndRefresh();
            base.OnAppearing();
        }

        /*Method that open page for create new word group*/
        public async void CreateWord(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AddWord());
        }
    }
}

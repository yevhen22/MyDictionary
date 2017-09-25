using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft;
using test.DataBase;

using Xamarin.Forms;

namespace test
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "dictionary.db";
        public static DictionaryRepository database;
        public static DictionaryRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new DictionaryRepository(DATABASE_NAME);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

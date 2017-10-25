using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.ViewModel;
using test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using test.ViewModel;

namespace test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddWord : ContentPage
    {
        public AddWord()
        {
            InitializeComponent();
            BindingContext = new ViewModelData();
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExampleDatabase.ViewModels;

namespace ExampleDatabase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonView : ContentPage
    {
        public PersonView()
        {
            InitializeComponent();
            this.BindingContext = new PersonViewModel();
        }
    }
}
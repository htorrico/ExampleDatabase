using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ExampleDatabase.Services;
using ExampleDatabase.Models;

namespace ExampleDatabase
{
    public partial class MainPage : ContentPage
    {
        PersonService service = new PersonService();
        public MainPage()
        {
            InitializeComponent();         
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            lvPeople.ItemsSource = service.Get();

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            int personId = service.Get().Count + 1;
            service.Create(new Person { PersonId = personId, 
                                        FirstName = eFirstName.Text, 
                                        LastName = eLastName.Text });
            eFirstName.Text = string.Empty;
            eLastName.Text = string.Empty;
            


        }
    }
}

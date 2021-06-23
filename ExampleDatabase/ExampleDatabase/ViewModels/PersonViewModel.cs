using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using ExampleDatabase.Models;
using Xamarin.Forms;
using System.Windows.Input;
using ExampleDatabase.Services;


namespace ExampleDatabase.ViewModels
{
    public class PersonViewModel : ViewModels.BaseViewModel
    {
        #region Propiedades

        private string firstName;
        public string FirstName
        {
            get { return this.firstName; }
            set { SetValue(ref this.firstName, value); }
        }

        private string lastName;
        public string LastName
        {
            get { return this.lastName; }
            set { SetValue(ref this.lastName, value); }
        }

        private ObservableCollection<Person> people;
        public ObservableCollection<Person> People
        {
            get { return this.people; }
            set { SetValue(ref this.people, value); }
        }

        #endregion


        public ICommand CreateCommand { protected set; get; }
        public ICommand GetCommand { protected set; get; }


        public PersonViewModel()
         {
            PersonService service = new PersonService();

            CreateCommand = new Command(() =>
            {

                int personId = service.Get().Count + 1;
                service.Create(new Person
                {
                    PersonId = personId,
                    FirstName = FirstName,
                    LastName = LastName
                });
                FirstName = string.Empty;
                LastName = string.Empty;
            });

            GetCommand = new Command(() =>
            {

                People = new ObservableCollection<Person>(service.Get());
            });

        }



    }
}

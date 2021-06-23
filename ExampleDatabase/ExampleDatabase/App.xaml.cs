using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ExampleDatabase.DataContext;
using ExampleDatabase.Interfaces;

namespace ExampleDatabase
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GetContext().Database.EnsureCreated();
            //MainPage = new MainPage();
            MainPage = new Views.PersonView();
        }

        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

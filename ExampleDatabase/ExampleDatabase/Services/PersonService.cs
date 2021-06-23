using ExampleDatabase.DataContext;
using ExampleDatabase.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ExampleDatabase.Interfaces;
using System.Linq;
namespace ExampleDatabase.Services
{
    public class PersonService
    {
        private readonly AppDbContext _context;

        //public PersonService() => _context = App.GetContext();
        public PersonService()
        {

            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");
            _context = new AppDbContext(DbPath);
            _context.Database.EnsureCreated();
        }


        public List<Person> Get()
        {

            //"SELECT * FROM PEOPLE"
            return _context.People.ToList();
        }

        public void Create( Person person)
        {
            //"INSERT INTO PEOPLE VALUES ("+"'person.Id"
            _context.People.Add(person);
            _context.SaveChanges();

        }

        public void Update(Person person,int id)
        {
            var oldPerson = _context.People.Where(x => x.PersonId == id).FirstOrDefault();
            oldPerson.FirstName = person.FirstName;
            oldPerson.LastName = person.LastName;
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var oldPerson = _context.People.Where(x => x.PersonId == id).FirstOrDefault();
            _context.Remove(oldPerson);
            _context.SaveChanges();
        }
    }

}

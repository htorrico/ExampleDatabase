using ExampleDatabase.Models;
using Microsoft.EntityFrameworkCore;


namespace ExampleDatabase.DataContext
{
    class AppDbContext: DbContext
    {

        string DbPath = string.Empty;

        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }


        
        public DbSet<Person> People { get; set; }
        public DbSet<Course> Courses { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");

        }


    }
}

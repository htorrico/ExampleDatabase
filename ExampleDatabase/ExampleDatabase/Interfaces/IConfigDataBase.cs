using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleDatabase.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}

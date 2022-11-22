using System;
using System.Collections.Generic;
using System.Text;

namespace LocalDatabaseLab13.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}


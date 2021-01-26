using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DemoLib.Utilities
{
    public class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Data");
        }
        public void SaveData(string name)
        {
            Console.WriteLine($"Saving {name}");
        }
    }
}

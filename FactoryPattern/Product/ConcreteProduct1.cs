using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    //SeaLogistics
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result Of Concrete Product 1}";
        }
    }
}

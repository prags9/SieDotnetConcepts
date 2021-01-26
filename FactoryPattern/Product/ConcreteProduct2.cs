using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    //RoadLogistics
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result Of Concrete Product 2}";
         }
    }
}

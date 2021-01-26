using AbstractFactoryPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factory
{
    // Each Concrete Factory has a corresponding product variant.
    public class VictorianFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }
}

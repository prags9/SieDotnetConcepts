using AbstractFactoryPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factory
{
    public class ModernFactory : IAbstractFactory
    {
        // Concrete Factories produce a family of products that belong to a single
        // variant. The factory guarantees that resulting products are compatible.
        // Note that signatures of the Concrete Factory's methods return an abstract
        // product, while inside the method a concrete product is instantiated.
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }
}

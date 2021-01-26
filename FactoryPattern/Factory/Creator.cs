using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        //Objects returned by a factory method are often referred to as products.
        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Creator: The same creators code has just worked with " + product.Operation();
            return result;
        }
    }
}

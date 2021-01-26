using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product
{
    // Here's the the base interface of another product. All products can
    // interact with each other, but proper interaction is possible only between
    // products of the same concrete variant.
    public interface ICoffeeTable
    {
        // Product CoffeeTable is able to do its own thing...
        public string PutOn();

        // ...but it also can collaborate with the Product Chair.
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        string AnotherUsefulFunctionCoffeeTable(IChair collaboratorChair);
    }
}

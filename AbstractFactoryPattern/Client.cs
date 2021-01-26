using AbstractFactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    public class Client
    {
        public  void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Testing with first factory type...");
            ClientMethod(new ModernFactory());
            Console.WriteLine();

            Console.WriteLine("Testing with factory 2");
            ClientMethod(new VictorianFactory());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var chair = factory.CreateChair();
            var table = factory.CreateCoffeeTable();

            Console.WriteLine(table.PutOn());
            Console.WriteLine(table.AnotherUsefulFunctionCoffeeTable(chair));

        }
    }
}

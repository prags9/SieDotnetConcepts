using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product
{
    
    public class VictorianCoffeeTable : ICoffeeTable
    {
        public string PutOn()
        {
            return "Put on Victorian Coffee table";
        }

        // The variant, Product Victorian CoffeeTable, is only able to work correctly with the
        // variant, Product Victorian Chair. Nevertheless, it accepts any instance of
        // IChair as an argument.
        public string AnotherUsefulFunctionCoffeeTable(IChair collaboratorChair)
        {
            var result = collaboratorChair.SitOn();
            return $"The result of Victorian coffee Table collaborating with {result}";
        }

    }
}

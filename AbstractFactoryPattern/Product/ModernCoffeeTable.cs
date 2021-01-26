using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product
{
    public class ModernCoffeeTable : ICoffeeTable
    {
        public string AnotherUsefulFunctionCoffeeTable(IChair collaboratorChair)
        {
            var result = collaboratorChair.SitOn();
            return $"The result of Modern coffee Table collaborating with {result}";
        }

        public string PutOn()
        {
            return "Put on Modern coffee table";
        }
    }
}

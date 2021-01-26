using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product
{
    public class VictorianChair : IChair
    {
        public string SitOn()
        {
            return "victorian chair";
        }
    }
}

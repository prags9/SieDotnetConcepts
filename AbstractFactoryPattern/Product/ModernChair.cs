using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product
{
    public class ModernChair : IChair
    {
        public string SitOn()
        {
            return "Modern Chair";
        }
    }
}

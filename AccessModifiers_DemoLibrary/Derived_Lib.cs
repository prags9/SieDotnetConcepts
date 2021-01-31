using AccessModifiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers_DemoLibrary
{
    public class Derived_Lib
    {
        public void Method2()
        {
            Base b = new Base();
            b.Public();
            
        }
    }
}

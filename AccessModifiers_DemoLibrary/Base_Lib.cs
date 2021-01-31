using AccessModifiers;
using System;

namespace AccessModifiers_DemoLibrary
{
    public class Base_Lib : Base
    {
        public void DemoLibMethod()
        {
            Base b = new Base();
            b.Public();
            ProtectedInternal();
            
        }
    }
}

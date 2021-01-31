using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class Derived : Base
    {
        public override void BaseMethod()
        {
            base.BaseMethod();
            Console.WriteLine("Inside Derived Class");
        }
        public void DerivedMethod()
        {
            Console.WriteLine("Derived method inside derived Class");
        }
        public void InsideDerived()
        {
            Base b = new Base();

            b.Internal();
            b.ProtectedInternal();
            ProtectedInternal();
            PrivateProtected();
            Internal();
            Public();
            
        }
        public static void Main()
        {
            //base.BaseMethod();
            Base bb = new Derived();
            Derived d = new Derived();
            d.DerivedMethod();
            bb.BaseMethod();
        }
    }
}

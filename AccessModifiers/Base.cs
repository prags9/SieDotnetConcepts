using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class Base
    {
        public virtual void BaseMethod()
        {
            Console.WriteLine("Inside Base Class");
        }
        protected internal class NestedClass
        {

        }
        public void Public()
        {

        }
        private void Private()
        {

        }
        internal void Internal()
        {

        }
        private protected void PrivateProtected()
        {

        }

        protected internal void ProtectedInternal()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App Launched with Concrete Creator 1");
            ClientCode(new ConcreteCreator1());
            Console.WriteLine("");
            Console.WriteLine("App Launched with Concrete Creator 2");
            ClientCode(new ConcreteCreator2());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Hey client! I am not aware of creator's class, but it still works!!"+creator.SomeOperation());

        }
    }
}

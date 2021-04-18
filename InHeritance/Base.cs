using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InHeritance
{
    class Car
    {
        Queue q;
        static Car()
        {
            Console.WriteLine("base class static constructor");
        }

        /* public void DescribeCar()
{
    System.Console.WriteLine("Four wheels and an engine.");
    ShowDetails();
}*/

        public virtual void ShowDetails()
        {
            System.Console.WriteLine("Standard transportation.");
        }
    }
    class ConvertibleCar : Car
    {
        IEnumerable<string> s = new List<string>();
        object[] array = new String[10];
        
        public override void ShowDetails()
        {
            array[0] = 10;
            System.Console.WriteLine("A roof that opens up.");
        }
    }
    public class Base
    {
   public static void Main()
        {
            Car c = new Car();
            //c.DescribeCar();
            c.ShowDetails();

            Car cc = new ConvertibleCar();
            //cc.DescribeCar();
            c.ShowDetails();
        }
    }
}

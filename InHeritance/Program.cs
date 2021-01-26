using System;
using System.Collections.Generic;

namespace InHeritance
{
    class Car
    {
        public void DescribeCar()
        {
            System.Console.WriteLine("Four wheels and an engine.");
            ShowDetails();
        }

        public virtual void ShowDetails()
        {
            System.Console.WriteLine("Standard transportation.");
        }
    }
    class ConvertibleCar : Car
    {
        public new void ShowDetails()
        {
            System.Console.WriteLine("A roof that opens up.");
        }
    } 
    class Minivan : Car
    {
        public override void ShowDetails()
        {
            System.Console.WriteLine("Carries seven people.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\nTestCars1");
            System.Console.WriteLine("----------");

            Car car11 = new Car();
            car11.DescribeCar();
            System.Console.WriteLine("----------");

            ConvertibleCar car21 = new ConvertibleCar();
            car21.DescribeCar();
            System.Console.WriteLine("----------");

            Minivan car31 = new Minivan();
            car31.DescribeCar();
            System.Console.WriteLine("----------");
            
            /*
            System.Console.WriteLine("\nTestCars2");
            System.Console.WriteLine("----------");

           
            System.Console.WriteLine("----------");
            var cars = new List<Car> { new Car(), new ConvertibleCar(),
                                                                        new Minivan() };

            foreach (var car in cars)
            {
                car.DescribeCar();
                System.Console.WriteLine("----------");
            }
*/
            System.Console.WriteLine("\nTestCars3");
            System.Console.WriteLine("----------");
            ConvertibleCar car2 = new ConvertibleCar();
            Minivan car3 = new Minivan();
            car2.ShowDetails();
            car3.ShowDetails();

            System.Console.WriteLine("\nTestCars4");
            System.Console.WriteLine("----------");
            Car car4 = new ConvertibleCar();
            Car car5 = new Minivan();
            car4.ShowDetails();
            car5.ShowDetails();

        }
    }
}

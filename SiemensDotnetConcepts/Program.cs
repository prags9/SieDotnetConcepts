using DemoLibrary1;
using System;

namespace SiemensDotnetConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Praggy"; owner.LastName = "Piggs"; 
            owner.EmailAddress = "praggy@p.com"; owner.PhoneNumber = "123-909";


            IChores chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash"; chore.Owner = owner;
            
            chore.PerformedWork(3);
            chore.PerformedWork(1.8);
            chore.CompleteChore();

            Console.ReadLine();
            
        }
    }
}

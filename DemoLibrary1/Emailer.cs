using System;

namespace DemoLibrary1
{
    public class Emailer : IMesaageSender
    {
        public void SendMessage(IPerson owner, string v)
        {
            Console.WriteLine($"Simulating sending an email to {owner.EmailAddress}");
        }
    }
}
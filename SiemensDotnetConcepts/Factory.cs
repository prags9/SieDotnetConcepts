using DemoLibrary1;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiemensDotnetConcepts
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChores CreateChore()
        {
            return new Chores(CreateLogger(), CreateMessageSender());
        }
        public static ILogger CreateLogger()
        {
            return new Logger();
        }
        public static IMesaageSender CreateMessageSender()
        {
            return new Emailer();
        }
    }
}

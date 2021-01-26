using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary1
{
    public class Chores : IChores
    {
        private readonly ILogger _logger;
        private readonly IMesaageSender _mesaageSender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public Double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chores(ILogger logger, IMesaageSender mesaageSender)
        {
            _logger = logger;
            _mesaageSender = mesaageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            Logger log = new Logger();
            log.Log($"Performed work on {ChoreName}");
        }
        public void CompleteChore()
        {
            IsComplete = true;
            //Logger log = new Logger();

            _logger.Log($"Completed {ChoreName}");

            //Emailer emailer = new Emailer();
            _mesaageSender.SendMessage(Owner, $"The core {ChoreName} is completed");
        }

    }
}

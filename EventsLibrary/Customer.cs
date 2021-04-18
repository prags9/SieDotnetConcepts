using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLibrary
{
    public class Customer
    {
        public string Name { get; set; }
        public Account SavingsAccount { get; set; }
        public Account CheckingAccount { get; set; }
    }
}

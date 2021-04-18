using System;
using System.Linq;
using System.Threading;

namespace Examples
{
    public class Base
    {
        public virtual void Do()
        {

        }
    }
    public  class Program  : Base
    {
        static void Main(string[] args)
        {
            string[] s = new string[] { "b", "a", "f", "c" };
            var query = s.Where(x=>x=="f").FirstOrDefault();
            Console.WriteLine(query);
        }

        
       
    }
}

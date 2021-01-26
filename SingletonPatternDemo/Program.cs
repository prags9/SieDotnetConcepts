using System;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    public class Program
    {
        private static TableServers Host1List = TableServers.GetInstance();
        private static TableServers Host2List = TableServers.GetInstance();
        static void Main(string[] args)
        {
            //TableServers servers = new TableServers();
            /*for(int i = 0; i <10; i++)
            {                
                    Host1GetServer();
                    Host2GetServer();                    
            }*/
            Parallel.Invoke(
                () => Host1GetServer(),
                () => Host2GetServer(),
                ()=>Host2GetServer()
                );
        }
        
        public static void Host1GetServer()
        {
            //Console.WriteLine("The next server is {0}", Host1List.GetNextServer());
            Console.WriteLine("Host1" + TableServers.GetInstance());
        }
        public static void Host2GetServer()
        {
            //Console.WriteLine("The next server is {0}", Host2List.GetNextServer());
            Console.WriteLine("Host1" + TableServers.GetInstance());
        }


    }
}

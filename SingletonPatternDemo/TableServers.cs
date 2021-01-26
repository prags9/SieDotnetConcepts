using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternDemo
{
    public sealed class TableServers
    {
        public List<string> servers = new List<string>();
        private static readonly TableServers _instance = new TableServers();
        public static int count = 0;
        public static object obj = new Object();

        private int nextServer = 0;

        private TableServers()
        {
            servers.Add("Kim");
            servers.Add("Bill");
            servers.Add("Sue");
            servers.Add("Tia");
            servers.Add("Mia");
            count++;
            Console.WriteLine("GetInstance count " + count);
        }
        public static TableServers GetInstance()
        { 
            return _instance;   
        }
        public string GetNextServer()
        {

            string output =  servers[nextServer];
            nextServer++;
            if (nextServer >= 5)
            {
                nextServer = 0;
            }
            return output;
        }
    }
}

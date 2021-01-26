using System;

namespace DemoLibrary1
{
    public class Logger : ILogger
    {
        public void Log(string v)
        {
            Console.WriteLine($"Write to console: {v}");
        }
    }
}
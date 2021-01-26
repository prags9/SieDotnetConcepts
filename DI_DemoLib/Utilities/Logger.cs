namespace DI_DemoLib.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string v)
        {
            System.Console.WriteLine($"Logging {v}");
        }
    }
}
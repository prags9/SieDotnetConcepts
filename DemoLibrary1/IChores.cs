namespace DemoLibrary1
{
    public interface IChores
    {
        string ChoreName { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteChore();
        void PerformedWork(double hours);
    }
}
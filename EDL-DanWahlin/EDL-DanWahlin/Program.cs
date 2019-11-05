using System;
using System.Reflection.Metadata.Ecma335;

namespace EDL_DanWahlin
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            // It also works: worker.WorkPerformed += worker_WorkPerformed;
            worker.WorkPerformed += Worker_WorkPerformed;
            worker.WorkCompleted += Worker_WorkCompleted;
            worker.DoWork(5, WorkType.GenerateReports);
            Console.Read();
        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventAgrs e)
        {
            Console.WriteLine($"Work type is: {e.WorkType} and hours worked: {e.Hours} and sender type is {sender.GetType()}");
        }

        public static void Worker_WorkCompleted(Object sender, EventArgs e)
        {
            Console.WriteLine($"Worker is done sender type is {sender.GetType()}");
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}

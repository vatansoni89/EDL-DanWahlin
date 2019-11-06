using System;
using System.Reflection.Metadata.Ecma335;

namespace EDL_DanWahlin
{
    public delegate int DelMathOperations(int x, int y);
    class Program
    {
        
        static void Main(string[] args)
        {
            DelMathOperations add = (a, b) => a + b;
            DelMathOperations mult = (a, b) => a * b;

            MathOperations mo = new MathOperations();
            mo.Calc(2,3,add);
            mo.Calc(2, 3, mult);

            var worker = new Worker();

            worker.WorkPerformed += (sender, e) => { Console.WriteLine($"Work type is: {e.WorkType} and hours worked: {e.Hours} and sender type is {sender.GetType()}"); };
            worker.WorkCompleted += Worker_WorkCompleted;
            worker.DoWork(5, WorkType.GenerateReports);
            Console.Read();
        }

        //private static void Worker_WorkPerformed(object sender, WorkPerformedEventAgrs e)
        //{
        //    Console.WriteLine($"Work type is: {e.WorkType} and hours worked: {e.Hours} and sender type is {sender.GetType()}");
        //}

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

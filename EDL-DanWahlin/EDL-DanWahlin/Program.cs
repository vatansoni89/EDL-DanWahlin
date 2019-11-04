using System;

namespace EDL_DanWahlin
{
    public delegate void WorkPerformedhandler(int hours, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WorkPerformedhandler del1 = new WorkPerformedhandler(WorkPerformed1);
            WorkPerformedhandler del2 = new WorkPerformedhandler(WorkPerformed2);
            //del1 += WorkPerformed2;

            del1(1, WorkType.Golf);
            DoWork(del2);

            Console.Read();
        }

        public static void DoWork(WorkPerformedhandler del)
        {
            del(5, WorkType.GoToMeetings);
        }

        public static void WorkPerformed1(int h, WorkType w)
        {
            Console.WriteLine("WorkPerformed 1 called..."+h.ToString());
        }
        public static void WorkPerformed2(int h, WorkType w)
        {
            Console.WriteLine("WorkPerformed 2 called..." + h.ToString());
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}

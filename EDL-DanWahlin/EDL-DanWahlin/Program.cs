using System;

namespace EDL_DanWahlin
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WorkPerformedhandler del1 = new WorkPerformedhandler(WorkPerformed1);
            WorkPerformedhandler del2 = new WorkPerformedhandler(WorkPerformed2);
            WorkPerformedhandler del3 = new WorkPerformedhandler(WorkPerformed3);

            del1 += del2 + del3;

            //del1(10, WorkType.GenerateReports);

            Console.WriteLine("final value is " + del1(10, WorkType.GenerateReports));

            Console.Read();
        }

        public static void DoWork(WorkPerformedhandler del)
        {
            del(5, WorkType.GoToMeetings);
        }

        public static int WorkPerformed1(int h, WorkType w)
        {
            Console.WriteLine("WorkPerformed 1 called..."+h.ToString());
            return h + 1;
        }
        public static int WorkPerformed2(int h, WorkType w)
        {
            Console.WriteLine("WorkPerformed 2 called..." + h.ToString());
            return h + 2;
        }
        public static int WorkPerformed3(int h, WorkType w)
        {
            Console.WriteLine("WorkPerformed 3 called..." + h.ToString());
            return h + 3;
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}

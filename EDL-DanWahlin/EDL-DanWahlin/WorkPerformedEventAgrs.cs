using System;
using System.Collections.Generic;
using System.Text;

namespace EDL_DanWahlin
{
    public class WorkPerformedEventAgrs : System.EventArgs
    {
        public WorkPerformedEventAgrs(int hours, WorkType w)
        {
            Hours = hours;
            WorkType = w;
        }
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}

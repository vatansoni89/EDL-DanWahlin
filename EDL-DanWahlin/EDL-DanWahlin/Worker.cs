using System;
using System.Collections.Generic;
using System.Text;

namespace EDL_DanWahlin
{
    public delegate int WorkPerformedhandler(int hours, WorkType workType);
    public class Worker
    {
        public event WorkPerformedhandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i+1, workType);
            }
            OnWorkCompleted();
        }

        public virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //if (WorkPerformed!=null)
            //{
            //    WorkPerformed(hours, workType);
            //}

            WorkPerformedhandler del = WorkPerformed as WorkPerformedhandler;
            if (del!=null)
            {
                del(hours, workType);
            }
        }

        public virtual void OnWorkCompleted()
        {
            EventHandler del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EDL_DanWahlin
{
    //public delegate int WorkPerformedhandler(Object sender, WorkPerformedEventAgrs e);

    public class Worker
    {
        //Behind the seen this will generate delegate: public delegate int WorkPerformedhandler(Object sender, WorkPerformedEventAgrs e);
        public event EventHandler<WorkPerformedEventAgrs> WorkPerformed;
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

            EventHandler<WorkPerformedEventAgrs> del = WorkPerformed as EventHandler<WorkPerformedEventAgrs>;
            if (del!=null)
            {
                del(this, new WorkPerformedEventAgrs(hours, workType));
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

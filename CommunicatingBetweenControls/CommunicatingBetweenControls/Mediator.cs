using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicatingBetweenControls.Model;

namespace CommunicatingBetweenControls
{
    public sealed class Mediator
    {
        private static readonly  Mediator _Instance = new Mediator();

        private Mediator()
        {
            
        }

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(Object sender, Job job)
        {
            var jobChangedDelegate = JobChanged as EventHandler<JobChangedEventArgs>;

            if (jobChangedDelegate != null)
            {
                jobChangedDelegate(sender,new JobChangedEventArgs{Job = job});
            }
        }
    }
}

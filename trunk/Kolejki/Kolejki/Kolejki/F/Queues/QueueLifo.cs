using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    public class QueueLifo : Queue
    {
        public QueueLifo(Scheduler s, int size) : base(s, size) { Name = "QLifo"; }


        public override Job Get()
        {
            Job job = null;
            if (Count > 0)
            {
                job = JobList.Last();
                JobList.Remove(job);
                AddEventGet();
                job.GetQueueTimeForQueue(this).stop = scheduler.timestamp;
            }
            return job;
        }

        public override Job Peak()
        {
            return JobList.Last();
        }

        public override bool Put(Job job)
        {
            return base.Put(job);
        }
    }
}

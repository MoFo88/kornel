using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    public class QueueRandom : Queue
    {

        public QueueRandom(Scheduler s, int size) : base(s, size) { Name = "QRandom"; }

        public override Job Get()
        {
            Job job = null;
            if (Count > 0)
            {

                Random rand = new Random();
                int x = rand.Next(Count);

                job = JobList[x];

                JobList.Remove(job);
                AddEventGet();
            }
            return job;
        }

        public override Job Peak()
        {
            throw new Exception("cannot implement");
        }

        public override bool Put(Job job)
        {
            if (!IsFull)
            {
                if (!JobList.Contains(job)) JobList.Add(job);

                AddEventPut();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    class QueueFifo : IQueue
    {
        public String Name { get; set; }
        public List<Job> JobList {get; set;}

        private Scheduler scheduler;
        
        public QueueFifo(Scheduler s, int size)
        {
            scheduler = s;
            Size = size;
            JobList = new List<Job>();
        }

        public override string ToString()
        {
            String s = Name + ": ";

            foreach (var x in JobList)
            {
                s += x.Id + ", ";
            }

            return s;
        }

        public Job Get()
        {
            Job job = null;
            if (Count > 0)
            {
                job = JobList.First();
                JobList.RemoveAt(0);
                AddEventGet();
            }
            return job;
        }

        public Job Peak()
        {
            return JobList.Last();
        }

        public bool Put(Job job)
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

        public int Size { get; set; }

        public int Count { get { return JobList.Count; } }

        public bool IsFull { get { if (Count >= Size) return true; return false; } }

        public bool IsEmpty { get { if (JobList.Count == 0) return true; return false; } }

        public void AddEventPut()
        {
            PutToQueueEvent ev = new PutToQueueEvent(scheduler.timestamp, this);
            scheduler.AddEvent(ev);
        }

        public void AddEventGet()
        {
            GetFromQueueEvent ev = new GetFromQueueEvent(scheduler.timestamp, this);
            scheduler.AddEvent(ev);
        }
       
    }
}

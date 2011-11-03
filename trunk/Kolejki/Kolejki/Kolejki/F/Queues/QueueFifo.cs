﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    class QueueFifo : Queue
    {
        
        public QueueFifo(Scheduler s, int size) : base(s, size){}

        public override Job Get()
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

        public override Job Peak()
        {
            return JobList.First();
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
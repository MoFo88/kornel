using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    public class JobGenerationEvent : Event
    {
        public Job job;

        public JobGenerationEvent(Job job, int timestamp):base(timestamp)
        {
            this.job = job;
        }
    }
}

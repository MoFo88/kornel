using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet;
using Kolejki.MyMath;

namespace Kolejki.F
{
    public static class JobExtension
    {
        public static Job Create(this List<Job> jobList , IDistribution distribution, List<Socket> globalSocketList, int timestamp, Scheduler s)
        {
            Job job = new Job(globalSocketList, distribution, timestamp);
            jobList.Add(job);

            JobGenerationEvent e = new JobGenerationEvent(job, timestamp);
            s.AddEvent(e);

            return job;
        }

        public static void Kill(this List<Job> jobList, Job job)
        {
            jobList.Remove(job);
        }
    }
}

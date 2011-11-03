using System;
using System.Collections.Generic;
namespace Kolejki.F
{
    public interface IQueue
    {
        String Name { get; set; }
        Job Get();
        Job Peak();
        bool Put(Job job);
        int Size { get; set; }
        int Count { get; }
        bool IsFull { get; }
        bool IsEmpty { get; }
        List<Job> JobList { get; set; }
    }
}

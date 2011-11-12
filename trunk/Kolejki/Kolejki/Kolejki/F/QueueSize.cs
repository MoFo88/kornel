using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    public class QueueSize
    {
        public int Timestamp{get; set;}
        public IQueue Queue { get; set; }
        public int Size { get; set; }
        public QueueSize(int timestamp, IQueue queue, int size) { Timestamp = timestamp; Queue = queue; Size = size; }
    }
}

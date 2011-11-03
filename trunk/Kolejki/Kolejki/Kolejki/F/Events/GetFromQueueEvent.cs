using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    class GetFromQueueEvent : Event
    {
        public int timestamp;
        public IQueue queue;

        public GetFromQueueEvent(int timestamp, IQueue queue)
            : base(timestamp)
        {
            this.timestamp = timestamp;
            this.queue = queue;
        }
    }
}

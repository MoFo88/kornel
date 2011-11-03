using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    class PutToQueueEvent : Event
    {
        public IQueue queue;

        public PutToQueueEvent(int timestamp, IQueue queue)
            : base(timestamp)
        {
            this.queue = queue;
        }
    }
}

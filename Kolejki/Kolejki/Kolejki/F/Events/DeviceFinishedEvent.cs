using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    class DeviceFinishedEvent : Event
    {
        public Device device;
        public Job job;

        public DeviceFinishedEvent(Device d, Job j, int timestamp)
            : base(timestamp + j.GetTimeForDevice(d))
        {
            this.device = d;
            this.job = j;
        }
    }
}

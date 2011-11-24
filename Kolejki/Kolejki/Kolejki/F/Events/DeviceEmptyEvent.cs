using System;
using System.Collections.Generic;
using System.Text;

namespace Kolejki.F
{
    public class DeviceEmptyEvent : Event
    {
        public Socket socket;
        public DeviceEmptyEvent(Socket soc, int t)
            : base(t)
        {
            socket = soc;
        }
    }
}

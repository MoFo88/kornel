using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    public class Device
    {
        static int lastId = 0;
        private Job currentJob;
        private int started = -1;
        public Socket socket;

        int Id { get; set; }
        public Job CurrentJob 
        { 
            get { return currentJob; } 
            set 
            { 
                currentJob = value; 
                IsWorking = true; 
                if (value == null) IsWorking = false;  
            } 
        }
        
        
        public bool IsWorking { get; set; }
        public bool IsBusy { get { if (CurrentJob == null) return false; return true; } }

        public Device()
        {
            Id = ++lastId;
        }

        public override string ToString()
        {
            String s = s = "dev " + Id + " - E ( w: " + IsWorking.ToString()[0] + " b:" + IsBusy.ToString()[0] + ")";
            if (CurrentJob != null) s = "dev " + Id + " - " + CurrentJob.GetTimeForDevice(this) + " (w: " + IsWorking.ToString()[0] + " b:" + IsBusy.ToString()[0] + ")";
            return s;
        }

        public bool RemoveJob(int timestamp, Socket socket)
        {
            this.CurrentJob = null;
            //
            //jesli maszyna sie zwolnila
            if (!this.IsBusy)
            {
                Event ev2 = new DeviceEmptyEvent(socket, timestamp);
                socket.scheduler.AddEvent(ev2);
                return true;
            }

            return false;
        }
    }
}

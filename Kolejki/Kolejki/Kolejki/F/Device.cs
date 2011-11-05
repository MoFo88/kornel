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
        public Socket socket;
        public int Id { get; set; }

        private int jobStart = -1;


        public Job CurrentJob 
        { 
            get { return currentJob; } 
            set 
            { 
                currentJob = value; 
                
                if (value == null) IsWorking = false;
                
                if (value != null)
                {
                    IsWorking = true; 
                    jobStart = socket.scheduler.timestamp;
                    currentJob.GetMachineTimeForDevice(this).start = socket.scheduler.timestamp;
                }
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
            if (CurrentJob != null) s = "dev " + Id + " - " + (socket.scheduler.timestamp - jobStart) + "/" +  CurrentJob.GetMachineTimeForDevice(this).sec +  " (w: " + IsWorking.ToString()[0] + " b:" + IsBusy.ToString()[0] + ")";
            return s;
        }

        public bool RemoveJob(int timestamp, Socket socket)
        {
            if (CurrentJob != null) CurrentJob.GetMachineTimeForDevice(this).stop = socket.scheduler.timestamp;

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

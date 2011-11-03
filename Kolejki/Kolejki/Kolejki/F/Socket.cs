using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    public class Socket
    {
        public Scheduler scheduler;

        public bool IsFirst { get; set; }
        public List<Device> deviceList;
        public List<Socket> prevSockets;
        public List<Socket> nextSockets;

        public IQueue queue;

        public Socket(IQueue q, Scheduler s,  bool isFirst = false)
        {
            this.IsFirst = isFirst;
            queue = q;
            deviceList = new List<Device>();
            prevSockets = new List<Socket>();
            nextSockets = new List<Socket>();
            scheduler = s;
        }

        public void AddDevice(Device dev)
        {
            deviceList.Add(dev);
        }

        public static void MakeConnection(Socket prev, Socket next)
        {
            if (!prev.nextSockets.Contains(next))
            {
                prev.nextSockets.Add(next);
            }

            if (!next.prevSockets.Contains(prev))
            {
                next.prevSockets.Add(prev);
            }
        }

        public  List<Device> GetFreeDevices()
        {
            return deviceList.Where(d => d.IsBusy == false).ToList();
        }

        public  Device GetFirstFreeDevice()
        {
            List<Device> list =  deviceList.Where(d => d.IsBusy == false).ToList();

            if (list.Count == 0) return null;
            return list.First();
        }

        public  Device AddJobToFirstFreeDevice(Job job)
        {
            //pierwsza wolna maszyna
            Device firstfreeDevice = this.GetFirstFreeDevice();

            if (firstfreeDevice != null)
            {
                //event: zadanie ukonczy sie w chwili t
                AddEventDeviceFinished(firstfreeDevice, job);

                firstfreeDevice.CurrentJob = job;
                return firstfreeDevice;
            }
            else
            {
                return null;
            }
        }

        public void AddEventDeviceFinished(Device d , Job job)
        {
            DeviceFinishedEvent ev = new DeviceFinishedEvent(d, job, scheduler.timestamp);
            scheduler.AddEvent(ev);
        }
    }
    
}

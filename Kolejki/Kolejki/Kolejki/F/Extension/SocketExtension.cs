using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    public static class SocketExtension
    {
        public static Socket GetFirstFreeSocket(this List<Socket> socketList)
        {
            List<Socket> sl = socketList.Where(s => s.IsFirst == true && !s.queue.IsFull).ToList();

            if (sl.Count == 0) return null;
            
            int count = sl.Count;

            int index = new Random().Next(0, count);

            Socket socket = sl[index];
            return socket;
        }

        public static Socket GetNextFreeSocket(this List<Socket> nextSocketList)
        {
            List<Socket> socList = nextSocketList.Where(s => !s.queue.IsFull).ToList();

            if (socList.Count == 0) return null;

            int probability = 0;
            socList.ForEach(s => probability += s.Probability);

            int ranNumber = new Random().Next(0, probability);

            int count = 0;
            foreach (var soc in socList)
            {
                count += soc.Probability;
                if (ranNumber <= count) return soc;
            }
            return socList.Last();
        }
            
        public static Socket GetSocketWithDevice(this List<Socket> socketList, Device dev)
        {
            return socketList.SingleOrDefault( s => s.deviceList.Contains(dev) == true );
        }

        public static Device GetBusyDevice(this List<Socket> socketList)
        {
            List<Device> devList = new List<Device>();
            
            foreach (Socket s in socketList)
            {
                foreach (Device dev in s.deviceList)
                {
                    if (!dev.IsWorking && dev.IsBusy) devList.Add(dev);
                }
            }

            if (devList.Count == 0) return null;

            int rand = new Random().Next(0, devList.Count);
            return devList[rand];

        }
    }
}

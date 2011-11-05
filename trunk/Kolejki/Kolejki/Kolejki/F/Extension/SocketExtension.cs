using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.F
{
    public static class SocketExtension
    {
        public static Socket GetFirstSocket(this List<Socket> socketList)
        {
            List<Socket> sl = socketList.Where(s => s.IsFirst == true).ToList();
            Socket socket = sl.First();
            return socket;
        }

        public static Socket GetNextSocket(this List<Socket> nextSocketList)
        {
            List<Socket> socList = nextSocketList.Where(s => !s.queue.IsFull).ToList();
            if (socList.Count > 0) return socList.First();
            return null;
        }
            
        public static Socket GetSocketWithDevice(this List<Socket> socketList, Device dev)
        {
            return socketList.SingleOrDefault( s => s.deviceList.Contains(dev) == true );
        }

        public static Device GetFirstBusyDevice(this List<Socket> socketList)
        {
            foreach (Socket s in socketList)
            {
                foreach (Device dev in s.deviceList)
                {
                    if (!dev.IsWorking && dev.IsBusy) return dev;
                }
            }

            return null;
        }
    }
}

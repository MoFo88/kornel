using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kolejki.MyMath;
using System.Drawing;

namespace Kolejki.F
{
    public class Job
    {
        private static int ID = 0;
        
        public List<MachineTime> deviceTimeList;
        public List<QueueTime> queueTimeList;

        public int Id { get; set; }
        public String Name { get; set; }
        public String ToStr { get { return Id + "[" + Start + "], " + Distribution.Name[0]; } }
        public int Start {get; set;}
        public int Stop { get; set; }
        IDistribution Distribution { get; set; }

        public Color color;

        public override string ToString()
        {
            return  ToStr;
        }

        /// <summary>
        /// constructor - initialize job
        /// </summary>
        /// <param name="globalSocketList"></param>
        /// <param name="distr"></param>
        public Job(List<Socket> globalSocketList, IDistribution distr, int time)
        {
            Job.ID++;
            Id = Job.ID;
            Name = "Zadanie " + Id;
            Distribution = distr;

            //
            //lista czasów wykonywania zdania na maszynach
            deviceTimeList = new List<MachineTime>();
            queueTimeList = new List<QueueTime>();

            color = Color.FromArgb(((Id+10) * 20) % 255, (Id * 30) % 255, (Id * 40) % 255);

            foreach (Socket socket in globalSocketList)
            {
                //initialize device time list
                foreach (Device device in socket.deviceList)
                {
                    MachineTime mt = new MachineTime();
                    mt.device = device;
                    mt.sec = Distribution.NextValue();

                    deviceTimeList.Add(mt);
                }

                //initialize queue time list
                IQueue queue = socket.queue;

                QueueTime qt = new QueueTime();
                qt.queue = queue;

                queueTimeList.Add(qt);
            }

            Start = time;
        }

        public MachineTime GetMachineTimeForDevice(Device device)
        {
            return deviceTimeList.SingleOrDefault(t => t.device == device);
        }

        public QueueTime GetQueueTimeForQueue(IQueue queue)
        {
            return queueTimeList.SingleOrDefault(t => t.queue == queue);
        }

        internal void Kill()
        {
            throw new  NotImplementedException();
        }
    }
}

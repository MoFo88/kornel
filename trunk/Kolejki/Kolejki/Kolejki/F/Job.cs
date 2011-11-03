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
        
        List<MachineTime> timeList;

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

            timeList = new List<MachineTime>();

            color = Color.FromArgb(((Id+10) * 20) % 255, (Id * 30) % 255, (Id * 40) % 255);

            foreach (Socket socket in globalSocketList)
            {
                foreach (Device device in socket.deviceList)
                {
                    MachineTime mt = new MachineTime();
                    mt.device = device;
                    mt.sec = Distribution.NextValue();

                    timeList.Add(mt);
                }
            }

            Start = time;
        }

        public int GetTimeForDevice(Device device)
        {
            return timeList.SingleOrDefault(t => t.device == device).sec;
        }

        internal void Kill()
        {
            throw new  NotImplementedException();
        }
    }
}

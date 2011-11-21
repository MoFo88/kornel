using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kolejki.MyMath;
using System.Diagnostics;
using Kolejki.F.MyMath;

namespace Kolejki.F
{
    public class Scheduler
    {
        public int timestamp;
         
        public List<Job> jobList;
        public List<Socket> socketList;
        public List<Event> eventList;
        public List<Job> killedJobsList;

        //
        //for stats
        public List<QueueSize> queueSize = new List<QueueSize>();
        
        public Form1 form;

        public void AddEvent(Event ev)
        {
            eventList.Add(ev);
        }

        public bool CheckIfGenerateJob(int prob)
        {
            UniformDistr uniformDistr = new UniformDistr(0, 100);
            double nextRandom = uniformDistr.NextValue();
 
            if ( nextRandom <= prob ) return true;
            return false;
        }


        public Scheduler()
        {
            socketList = new List<Socket>();
            eventList = new List<Event>();
            jobList = new List<Job>();
            killedJobsList = new List<Job>();
            this.form = new Form1(this);
            timestamp = 0;
        }

        public void JobGeneration()
        {
            if (CheckIfGenerateJob(Const.JOB_NORMAL_GENERATE_PROBABILITY))
            {
                Job job = jobList.Create( new NormalDistr(Const.NORMAL_MU, Const.NORLAN_SIGMA), socketList, this.timestamp, this);

                //
                //tell
                form.Notify(timestamp + ". " + "Zadanie dodane: " + job.ToString());
            }

            if (CheckIfGenerateJob(Const.JOB_UNIFORM_GENERATE_PROBABILITY))
            {
                Job job = jobList.Create(new UniformDistr(Const.UNIFORM_MIN, Const.UNIFORM_MAX), socketList, this.timestamp, this);

                //
                //tell
                form.Notify(timestamp + ". " + "Zadanie dodane: " + job.ToString());
            }
        }

        public void MakeStep()
        {
            //next step
            timestamp++;

            form.Notify("\n==" + this.timestamp + "==\n", 1);

            JobGeneration();

            //
            //obsługa zdarzeń
            while (eventList.Where(e => e.timestamp <= timestamp).ToList().Count > 0)
            {
                Event myEvent = eventList.Where(e => e.timestamp <= this.timestamp).First();
                HandleEvent(myEvent);

                eventList.Remove(myEvent);
            }

            //
            //remember queue size in timestamp
            foreach (Socket s in socketList)
            {
                IQueue q = s.queue;
                queueSize.Add(new QueueSize(timestamp, q, q.Count));
            }
        }

        public void MakeEventStep()
        {
            if (eventList.Where(e => e.timestamp <= timestamp).ToList().Count > 0)
            {
                Event myEvent = eventList.Where(e => e.timestamp <= this.timestamp).First();
                HandleEvent(myEvent);
                eventList.Remove(myEvent);
            }
            else
            {
                //next step
                timestamp++;
                form.Notify("\n==" + this.timestamp + "==\n",1);
                JobGeneration();

                //
                //remember queue size in timestamp
                foreach (Socket s in socketList)
                {
                    IQueue q = s.queue;
                    queueSize.Add(new QueueSize(timestamp, q, q.Count));
                }
            }
        }

        private void HandleEvent(Event myEvent)
        {
            if (myEvent is JobGenerationEvent)
            {
                //
                //tell
                String tell = "event JobGenerationEvent: ";

                JobGenerationEvent ev = (JobGenerationEvent)myEvent;
                Job job = ev.job;

                Socket s = socketList.GetFirstFreeSocket();

                bool added = false;
                if (s != null)  added = s.queue.Put(job);

                if (added)
                {
                    //
                    //tell
                    tell += timestamp + ": zad " + job.ToString() + " -> " + s.queue.ToString()+", ";
                }
                else
                {
                    jobList.Kill(killedJobsList, job );

                    //
                    //tell
                    tell += timestamp + ": zad " + job.ToString() + " zabite, ";
                }

                eventList.Remove(myEvent);

                form.Notify(tell);
            }
            else if (myEvent is PutToQueueEvent)
            {
                //
                //tell
                String tell = "event PutToQueueEvent:";

                PutToQueueEvent ev = (PutToQueueEvent)myEvent;
                IQueue queue = ev.queue;
                Socket socket = socketList.SingleOrDefault( s => s.queue == queue );

                //
                //dodaj zadanie na wolną maszynę
                
                //
                //sprawdz, czy wolna maszyna
                Device device = socket.GetFirstFreeDevice();

                if (device != null && !queue.IsEmpty)
                {
                    Job job = queue.Get();
                    socket.AddJobToFirstFreeDevice(job);
                    //
                    //tell
                    tell += timestamp + ": " + job.ToString() + " -> " + device.ToString() + ", ";
                }

                form.Notify(tell);
            }
            else if (myEvent is DeviceFinishedEvent)
            {
                
                //
                //tell
                String tell ="event DeviceFinishedEvent:";
                
                DeviceFinishedEvent ev = (DeviceFinishedEvent)myEvent;
                Device device = ev.device;
                Job job = ev.job;

                device.IsWorking = false;

                //
                //tell
                tell += timestamp + ". " + job.ToString() + " ukonczone na " + device.ToString();

                
                //
                //spróbój dodac zadanie do kolejki

                //pobierz socket maszyny
                Socket socket = socketList.SingleOrDefault( x => x.deviceList.Contains(device));
                
                //pobierz nastepny socket
                
                //
                //jesli ostatni socket, wyrzuc
                if (socket.nextSockets == null || socket.nextSockets.Count == 0)
                {
                    job.Stop = this.timestamp;
                    device.RemoveJob(timestamp, socket);

                    //
                    //to excel
                    form.AddToExcel4(((DeviceFinishedEvent)myEvent).job);


                    //
                    //tell
                    tell += timestamp + ". " + "Zadanie " + job.ToString() + "ukonczone całkowicie, ";

                }
                //
                // mamy nastepny socket, sprobój dodac zadanie do kolejki
                else
                {
                    Socket nextSocket = socket.nextSockets.GetNextFreeSocket();

                    if (nextSocket != null)
                    {
                        bool added = nextSocket.queue.Put(job);

                        if (added)
                        {
                            device.RemoveJob(timestamp, socket);
                            //
                            //tell
                            tell += timestamp + ". " + "Zadanie dodane do kolejki: " + job.ToString() + ", " + nextSocket.queue.ToString() + ", ";
                        }
                    }
                }

                form.Notify(tell);
            }
            else if (myEvent is DeviceEmptyEvent)
            {
                //
                //tell
                String tell = "event DeviceEmptyEvent:";

                DeviceEmptyEvent ev = (DeviceEmptyEvent)myEvent;
                Socket socket = ev.socket;
                IQueue q = socket.queue;

                if (!q.IsEmpty)
                {
                    Job job = q.Get();
                    socket.AddJobToFirstFreeDevice(job);
                }

                form.Notify(tell);

            }
            else if (myEvent is GetFromQueueEvent)
            {
                //
                //tell
                String tell = "event GetFromQueueEvent:";

                GetFromQueueEvent ev = (GetFromQueueEvent)myEvent;
                IQueue queue = ev.queue;
                Socket socket = socketList.SingleOrDefault(s => s.queue == queue);

                //
                //sprawdz, czy na poprzednich soketach nie ma maszyn z czekającymi zadaniami

                List<Socket> prevSocketList = socket.prevSockets;
                Device prevBusyDev = prevSocketList.GetBusyDevice();
                

                //
                //wrzuć na kolejkę
                if (prevBusyDev != null)
                {
                    Job job = prevBusyDev.CurrentJob;
                    bool t = queue.Put(job);

                    if (t)
                    {
                        prevBusyDev.RemoveJob(timestamp, socketList.GetSocketWithDevice(prevBusyDev));
                    }

                    //
                    //tell
                    tell += timestamp + ": " + job.ToString() + " -> " + queue.ToString() + ", ";
                }

                form.Notify(tell);
            }
            else
            {
                throw new ApplicationException(" Can't handle event  ");
            }
        }

        internal void AddEvent(JobGenerationEvent e)
        {
            eventList.Add(e);
        }

        #region statistics

        //
        //devices statistics
        public double AvgBusyTimeOnDevice(Device dev)
        {
            int sum = 0;
            int count = 0;
            
            //get jobs on device
            foreach (Job job in jobList)
            {
                MachineTime mt = job.GetMachineTimeForDevice(dev);
                int start, stop;

                if (mt.start < 0) continue;
                else
                {
                    count++;
                    start = mt.start;
                }
                
                if (mt.stop > 0) stop = mt.stop;
                else stop = timestamp;
                int worktime = stop - start;
                sum += worktime;
            }
            if (count == 0) return 0;
            return (double)sum/count;
        }

        public double AvgWorkTimeOnDevice(Device dev)
        {
            int sum = 0;
            int count = 0;

            //get jobs on device
            foreach (Job job in jobList)
            {
                MachineTime mt = job.GetMachineTimeForDevice(dev);

                int start, stop;

                if (mt.start < 0) continue;
                else
                {
                    count++;
                    start = mt.start;
                }

                if (mt.stop > 0) stop = mt.stop;
                else stop = timestamp;
                int worktime = stop - start;
                if (worktime > mt.sec) worktime = mt.sec;
                sum += worktime;
            }
            if (count == 0) return 0;
            return (double)sum / count;
        }

        public int AllWorkTimeOnDevice(Device dev)
        {
            int time = 0;
            int count = 0;

            //get jobs on device
            foreach (Job job in jobList)
            {
                MachineTime mt = job.GetMachineTimeForDevice(dev);
                int start, stop;

                if (mt.start < 0) continue;
                else
                {
                    count++;
                    start = mt.start;
                }

                if (mt.stop > 0) stop = mt.stop;
                else stop = timestamp;
                int worktime = stop - start;
                if (worktime > mt.sec) worktime = mt.sec;
                time += worktime;
            }

            return time;
        }

        public int AllBusyTimeOnDevice(Device dev)
        {
            int time = 0;
            int count = 0;

            //get jobs on device
            foreach (Job job in jobList)
            {
                MachineTime mt = job.GetMachineTimeForDevice(dev);
                int start, stop;

                if (mt.start < 0) continue;
                else
                {
                    count++;
                    start = mt.start;
                }

                if (mt.stop > 0) stop = mt.stop;
                else stop = timestamp;

                int worktime = stop - start;

                time += worktime;

            }

            return time;
        }

        public int AllStartedJobsCount(Device dev)
        {
            return jobList
                .Where
                (
                    j =>
                    j.GetMachineTimeForDevice(dev).start >= 0
                )
                .Count();
        }

        public int AllStartedUJobsCount(Device dev)
        {

            return jobList
                .Where
                (
                    j => 
                    j.Distribution is UniformDistr 
                    && j.GetMachineTimeForDevice(dev).start >= 0
                )
                .Count();
        }

        public int AllStartedNJobsCount(Device dev)
        {
            return jobList
                .Where
                (
                    j =>
                    j.Distribution is NormalDistr
                    && j.GetMachineTimeForDevice(dev).start >= 0
                )
                .Count();
        }

        //
        //queues statistics
        public double avgQueueTime(IQueue queue)
        {
            double avg = 0;
            int count = 0;

            foreach (Job job in jobList)
            {
                QueueTime qt = job.GetQueueTimeForQueue(queue);
                int start, stop;

                if (qt.start > 0)
                {
                    start = qt.start;

                    if (qt.stop < 0)
                    {
                        stop = timestamp;
                    }
                    else
                    {
                        stop = qt.stop;
                    }

                    count ++;
                    avg += stop - start;
                }
            }

            if (count == 0) return 0;
            return avg /= count;
        }

        public int sumQueueTime(IQueue queue)
        {
            int sum = 0;
            int count = 0;

            foreach (Job job in jobList)
            {
                QueueTime qt = job.GetQueueTimeForQueue(queue);
                int start, stop;

                if (qt.start > 0)
                {
                    start = qt.start;

                    if (qt.stop < 0)
                    {
                        stop = timestamp;
                    }
                    else
                    {
                        stop = qt.stop;
                    }

                    count++;
                    sum += stop - start;
                }
            }

            if (count == 0) return 0;
            return sum;
        }

        public int? maxQueueTime(IQueue queue)
        {
            int? resut = null;
            foreach (Job job in jobList)
            {
                QueueTime qt = job.GetQueueTimeForQueue(queue);
                int start, stop;

                if (qt.start > 0)
                {
                    start = qt.start;

                    if (qt.stop > 0)
                    {
                        stop = qt.stop;

                        int time = stop - start;

                        if (resut != null)
                        {
                            resut = Math.Max(time, resut.Value);
                        }
                        else
                        {
                            resut = time;
                        }
                    }
                }
            }

            return resut;
        }

        //
        public int maxQueueCount(IQueue queue)
        {
            List<QueueSize> queueSizes = queueSize.Where(x => x.Queue == queue).ToList();
            if (queueSizes.Count == 0) return 0;
            return queueSizes.Max(qs => qs.Size);
        }

        public double avgQueueCount(IQueue queue)
        {
            List<QueueSize> queueSizes = queueSize.Where(x => x.Queue == queue).ToList();
            if (queueSizes.Count == 0) return 0;

            int sumQueueCount = 0;

            for (int i = 1; i < timestamp; ++i )
            {
                sumQueueCount += queueSizes.SingleOrDefault(qs => qs.Timestamp == i).Size;
            }

            return (double)sumQueueCount / timestamp;

        }

        //
        //job statistics
        public int MaxTimeInSystem()
        {
            List<Job> x = jobList.Where(j => j.Start >= 0 && j.Stop >= 0).ToList();
            if (x.Count <= 0) return 0;
            return    x.Max(j => j.TimeInSystem);     
        }

        public int MinTimeInSystem()
        {
            List<Job> x = jobList.Where(j => j.Start >= 0 && j.Stop >= 0).ToList();
            if (x.Count <= 0) return 0;
            return x.Min(j => j.TimeInSystem);   
        }

        public double AvgTimeInSystem()
        {
            List<Job> x = jobList.Where(j => j.IsFinished).ToList();
            if (x.Count <= 0) return 0;

            return x.Average(j => j.TimeInSystem); 
        }

        public int MaxWorkTime()
        {
            List<Job> x = jobList.Where(j => j.IsFinished).ToList();
            if (x.Count <= 0) return 0;
            return x.Max(j => j.WorkedTime());   
        }

        public int MinWorkTime()
        {
            List<Job> x = jobList.Where(j => j.IsFinished).ToList();
            if (x.Count <= 0) return 0;
            return x.Min(j => j.WorkedTime());
        }

        public double AvgWorkingTime()
        {
            List<Job> x = jobList.Where(j => j.Start >= 0 && j.Stop >= 0).ToList();

            int sum = 0;
            int count = 0;

            if (x.Count == 0) return 0;

            foreach (Job j in x)
            {
                sum += j.WorkedTime();
                count++;
            }

            return (double)sum / (double)count;
        }

        public double StdVarTimeInSystem()
        {
            List<Job> x = jobList.Where(j => j.IsFinished).ToList();
            if (x.Count <= 1) return 0;

            return x.Select(j => (double)j.TimeInSystem).CalculateStdDev();
        }

        public double StdVarWorkTime()
        {
            List<Job> x = jobList.Where(j => j.IsFinished).ToList();
            if (x.Count <= 1) return 0;

            return x.Select(j => (double)j.WorkedTime()).CalculateStdDev();
        }

        public int MaxWastedTime()
        {
            List<Job> x = jobList.Where(j => j.IsFinished).ToList();
            if (x.Count <= 0) return 0;
            return x.Max(j => j.WastedTime());     
        }

        public int MinWastedTime()
        {
            List<Job> x = jobList.Where(j => j.IsFinished).ToList();
            if (x.Count <= 0) return 0;
            return x.Min(j => j.WastedTime());
        }

        public double AvgWastedTime()
        {
            List<Job> x = jobList.Where(j => j.IsFinished).ToList();

            int sum = 0;
            int count = 0;

            if (x.Count == 0) return 0;

            foreach (Job j in x)
            {
                sum += j.WastedTime();
                count++;
            }

            return (double)sum / (double)count;
        }

        public double StdVarWastedTime()
        {
            List<Job> x = jobList.Where(j => j.IsFinished).ToList();
            if (x.Count <= 1) return 0;

            return x.Select(j => (double)j.WastedTime()).CalculateStdDev();
        }

        #endregion statistics

    }
}

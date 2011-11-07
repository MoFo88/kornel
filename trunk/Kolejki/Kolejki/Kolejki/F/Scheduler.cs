﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kolejki.MyMath;
using System.Diagnostics;

namespace Kolejki.F
{
    public class Scheduler
    {
        public int timestamp;
         
        public List<Job> jobList;
        public List<Socket> socketList;
        public List<IQueue> queueList;
        public List<Event> eventList;
        public Form1 form;

        public void AddEvent(Event ev)
        {
            eventList.Add(ev);
        }

        public bool CheckIfGenerateJob()
        {
            UniformDistr uniformDistr = new UniformDistr(0, 100);
            double nextRandom = uniformDistr.NextValue();
 
            //TODO: mak as variable
            if ( nextRandom <= 35 ) return true;
            return false;
        }

        public Scheduler(Form1 form)
        {
            socketList = new List<Socket>();
            eventList = new List<Event>();
            jobList = new List<Job>();
            this.form = form;
            timestamp = 0;
        }

        public Scheduler()
        {
            socketList = new List<Socket>();
            eventList = new List<Event>();
            jobList = new List<Job>();
            this.form = new Form1();
            timestamp = 0;
        }

        //todo: remove hardcore data
        public void Initialize()
        {
            //hardcoded

            QueueFifo q = new QueueFifo(this, 15);
            q.Name = "kolejka 1";
            Socket s1 = new Socket(q, this, true);
            Device d1 = new Device();
            Device d2 = new Device();
            Device d8 = new Device();
            s1.AddDevice(d1);
            s1.AddDevice(d2);
            s1.AddDevice(d8);

            QueueLifo q2 = new QueueLifo(this, 1);
            q2.Name = "kolejka 2";
            Socket s2 = new Socket(q2, this);
            Device d3 = new Device();
            s2.AddDevice(d3);

            QueueLifo q3 = new QueueLifo(this, 500);
            q3.Name = "kolejka 3";
            Socket s3 = new Socket(q3, this);
            Device d4 = new Device();
            Device d5 = new Device();
            s3.AddDevice(d4);
            s3.AddDevice(d5);

            QueueLifo q4 = new QueueLifo(this, 10);
            q4.Name = "kolejka 4";
            Socket s4 = new Socket(q4, this);
            Device d6 = new Device();
            Device d7 = new Device();
            s4.AddDevice(d6);
            s4.AddDevice(d7);

            Socket.MakeConnection(s1, s2);
            Socket.MakeConnection(s1, s3);
            Socket.MakeConnection(s3, s4);
            Socket.MakeConnection(s2, s4);

            socketList.Add(s1);
            socketList.Add(s2);
            socketList.Add(s3);
            socketList.Add(s4);
        }

        //public void MakeStep()
        //{
        //    //next step
        //    timestamp++;

        //    form.Notify("\n==" + this.timestamp + "==\n");

        //    //
        //    //todo: wybierz, który rozkład, parametry rokładu   
        //    //wygenerój zadanie
        //    if (CheckIfGenerateJob())
        //    {
        //        Job job = jobList.Create(new NormalDistr(10, 5), socketList, this.timestamp, this);

        //        //
        //        //tell
        //        form.Notify(timestamp + ". " + "Zadanie dodane: " + job.ToString());
        //    }

        //    //
        //    //obsługa zdarzeń
        //    while (eventList.Where(e => e.timestamp <= timestamp).ToList().Count > 0)
        //    {
        //        Event myEvent = eventList.Where(e => e.timestamp <= this.timestamp).First();
        //        HandleEvent(myEvent);

        //        eventList.Remove(myEvent);
        //    }
        //}

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

                form.Notify("\n==" + this.timestamp + "==\n");

                //
                //todo: wybierz, który rozkład, parametry rokładu   
                //wygenerój zadanie
                if (CheckIfGenerateJob())
                {
                    Job job = jobList.Create(new NormalDistr(10, 5), socketList, this.timestamp, this);

                    //
                    //tell
                    form.Notify(timestamp + ". " + "Zadanie dodane: " + job.ToString() + ", ");
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

                Socket s = socketList.GetFirstSocket();

                bool added = s.queue.Put(job);

                if (added)
                {

                    //
                    //tell
                    tell += timestamp + ": zad " + job.ToString() + " -> " + s.queue.ToString()+", ";
                }
                else
                {
                    jobList.Kill( job );

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
                //spróbój doda zadanie do kolejki

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
                    //tell
                    tell += timestamp + ". " + "Zadanie " + job.ToString() + "ukonczone całkowicie, ";

                }
                //
                // mamy nastepny socket, sprobój dodac zadanie do kolejki
                else
                {
                    Socket nextSocket = socket.nextSockets.GetNextSocket();


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
                Device prevBusyDev = prevSocketList.GetFirstBusyDevice();
                

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
        public int AvgBusyTimeOnDevice(Device dev)
        {
            int avg = 0;
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

                avg += worktime;
            }
            if (count == 0) return 0;
            return avg/count;
        }

        public int AvgWorkTimeOnDevice(Device dev)
        {
            int avg = 0;
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

                avg += worktime;
            }
            if (count == 0) return 0;
            return avg / count;
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

        //
        //queues statistics
        public int avgQueueTime(IQueue queue)
        {
            int avg = 0;
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

        #endregion statistics
    }
}

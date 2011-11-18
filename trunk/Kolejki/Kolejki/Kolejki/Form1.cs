﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kolejki.F;
using Kolejki.MyMath;
using System.Drawing.Drawing2D;

namespace Kolejki 
{
    public partial class Form1 : Form
    {
        List<SocketControl> socketControlList;
        Scheduler scheduler;
        
        private void InitializeDgv(DataGridView dgv, List<Job> jobList)
        {
            foreach (var x in jobList)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = x.ToStr;
                row.Cells.Add(cell);
                row.DefaultCellStyle.BackColor = x.color;

                dgv.Rows.Add(row);
            }

            dgv.ClearSelection();
        }



        public void InitializeDgvQueue(int nr)
        {
            SocketControl cosCtrl = socketControlList[nr];
            DataGridView dgv = cosCtrl.Queue;
            dgv.Rows.Clear();

            cosCtrl.labebQueue.Text = cosCtrl.Socket.queue.ToString();

            List<Job> l = cosCtrl.Socket.queue.JobList;
            InitializeDgv(dgv, l);
        }

        public void InitializeDgvDevice(int socNr, int devNr)
        {
            SocketControl cosCtrl = socketControlList[socNr];
            DataGridView dgv = cosCtrl.DeviceList[devNr];
            Device dev = (Device)dgv.Tag;

            //todo: label device
            cosCtrl.devlabels[devNr].Text = dev.ToString();
            
            Job job = dev.CurrentJob;
            dgv.Rows.Clear();

            List<Job> jobList = new List<Job>();
            if (job != null) jobList.Add(job); ;

            if (dev.IsWorking)
            {
                dgv.BackgroundColor = Color.Lime;
            }
            else if (dev.IsBusy)
            {
                dgv.BackgroundColor = Color.DarkGreen;
            }
            else
            {
                dgv.BackgroundColor = Color.WhiteSmoke;
            }

            InitializeDgv(dgv, jobList);
          
        }

        public void Refresh()
        {
            
            int jobCount = scheduler.jobList.Count();

            labelJobsCount.Text = jobCount.ToString();
            labelKilledJobsCount.Text = scheduler.killedJobsList.Count().ToString();
            labelMaxTimeInSystem.Text = scheduler.MaxTimeInSystem().ToString();
            labelAvgTimeInSystem.Text = scheduler.AvgTimeInSystem().ToString();

              InitializeDevicesStatistics();
            InitializeQueuesStatistics();

            for (int i = 0; i < socketControlList.Count; i++)
            {
                SocketControl socCtrl = socketControlList[i];
                InitializeDgvQueue(i);

                for (int j = 0; j < socCtrl.DeviceList.Count; j++)
                {
                    InitializeDgvDevice(i, j);
                }
            }
        }

        private void InitializeDevicesStatistics()
        {
            dgvStatsDevice.Rows.Clear();
            foreach (Socket s in scheduler.socketList)
            {
                foreach (Device dev in s.deviceList)
                {
                    dgvStatsDevice.Rows.Add
                        (
                            dev.Id,
                            scheduler.AllWorkTimeOnDevice(dev),
                            scheduler.AllBusyTimeOnDevice(dev),
                            scheduler.AvgWorkTimeOnDevice(dev),
                            scheduler.AvgBusyTimeOnDevice(dev)
                        );
                }
            }
        }

        private void InitializeQueuesStatistics()
        {
            dgvStatsQueue.Rows.Clear();
            foreach (Socket s in scheduler.socketList)
            {
                
                dgvStatsQueue.Rows.Add
                    (
                        s.queue.Name,
                        scheduler.avgQueueTime(s.queue),
                        scheduler.sumQueueTime(s.queue),
                        scheduler.maxQueueTime(s.queue),
                        scheduler.maxQueueCount(s.queue),
                        scheduler.avgQueueCount(s.queue)
                    );
            }
        }
  
        public Form1(Scheduler s)
        {
            scheduler = s;
            InitializeComponent();
        }

        public void Notify(String message, int i  = 0)
        {
            if (i == 1) richTextBox.Text = message + "\n" +  richTextBox.Text; 
        }

        public void OnLoad()
        {
            try
            {
                this.panelSockets.Controls.Clear();
                socketControlList = new List<SocketControl>();

                //
                //create soc controls
                foreach (Socket soc in scheduler.socketList)
                {
                    SocketControl cosContr = new SocketControl(soc);
                    socketControlList.Add(cosContr);
                }

                foreach (var control in socketControlList)
                {
                    control.Location = new Point(control.Socket.X, control.Socket.Y);
                    this.panelSockets.Controls.Add(control);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OnLoad();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scheduler.MakeStep();
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scheduler.MakeEventStep();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scheduler.MakeStep();
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            //
            //lines
            foreach (var socketControl in socketControlList)
            {
                Socket prev = socketControl.Socket;

                //from 
                int prevX = prev.X + Const.CONTROL_SOCKET_WIDTH;
                int prevY = prev.Y + socketControl.Height/2;

                foreach (var next in prev.nextSockets)
                {
                    var nextSocketControl = socketControlList.SingleOrDefault( sc => sc.Socket == next );

                    //next
                    int nextX = next.X;
                    int nextY = next.Y + nextSocketControl.Height/2;
                    

                    //draw
                    Graphics formGraphics = this.panelSockets.CreateGraphics();

                    using (Brush aGradientBrush = new LinearGradientBrush(new Point(prevX, prevY), new Point(nextX, nextY), Color.Black, Color.Red))
                    {
                        using (Pen Pen = new Pen(aGradientBrush, 2))
                        {
                            formGraphics.DrawLine(Pen, prevX, prevY, nextX, nextY);
                        }
                        formGraphics.Dispose(); 
                    }
                }
            }

            
        }

        private void panelSockets_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = Int32.Parse(textBoxTimeInterval.Text);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
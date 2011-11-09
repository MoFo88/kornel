using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kolejki.F;
using Kolejki.MyMath;

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

        public void InitializeDgvJobs()
        {
            dgvJobs.Rows.Clear();
            List<Job> l = scheduler.jobList;
            
            InitializeDgv(dgvJobs, l);
        }

        public void InitializeDgvQueue(int nr)
        {
            SocketControl cosCtrl = socketControlList[nr];
            DataGridView dgv = cosCtrl.Queue;
            dgv.Rows.Clear();

            List<Job> l = cosCtrl.Socket.queue.JobList;
            InitializeDgv(dgv, l);
        }

        public void InitializeDgvDevice(int socNr, int devNr)
        {
            SocketControl cosCtrl = socketControlList[socNr];
            DataGridView dgv = cosCtrl.DeviceList[devNr];
            Device dev = (Device)dgv.Tag;

            //todo: label device
            //dev = scheduler.socketList[0].deviceList[0];
            //label1.Text = dev.ToString();
            

            Job job = dev.CurrentJob;
            dgv.Rows.Clear();

            List<Job> jobList = new List<Job>();
            if (job != null) jobList.Add(job); ;

            if (dev.IsWorking)
            {
                dgv.BackgroundColor = Color.Black;
            }
            else if (dev.IsBusy)
            {
                dgv.BackgroundColor = Color.Gray;
            }
            else
            {
                dgv.BackgroundColor = Color.WhiteSmoke;
            }

            InitializeDgv(dgv, jobList);
          
        }

        public void Refresh()
        {
            InitializeDevicesStatistics();
            InitializeQueuesStatistics();
            InitializeDgvJobs();

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
                        scheduler.avgQueueTime(s.queue)
                    );
            }
        }

        public Form1(Scheduler s)
        {
            InitializeComponent();
            scheduler = s;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            timer1.Start();
        }

       
        public void Notify(String message)
        {
            richTextBox.Text = message + "\n" +  richTextBox.Text; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scheduler.MakeEventStep();
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                socketControlList = new List<SocketControl>();

                //
                //create cos controls
                foreach (Socket soc in scheduler.socketList)
                {
                    SocketControl cosContr = new SocketControl(soc);
                    socketControlList.Add(cosContr);
                }

                foreach (var control in socketControlList)
                {
                    control.Location = new Point((control.Socket.Coll - 1) * (Const.CONTROL_SOCKET_WIDTH+15), (control.Socket.Row - 1) *( Const.CONTROL_SOCKET_HEIGHT+15));
                    this.panelSockets.Controls.Add(control);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

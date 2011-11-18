using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kolejki.F;

namespace Kolejki
{
    public partial class FormInit : Form
    {
        public Scheduler scheduler;

        public FormInit(Scheduler s)
        {
            InitializeComponent();
            scheduler = s;
        }

        #region add socket
        private void buttonAddSocket_Click(object sender, EventArgs e)
        {
            try
            {
                ResetScheduler();              

                int queueSize = Int32.Parse(textBoxQSize.Text);
                int X = Int32.Parse(textBoxX.Text);
                int Y = Int32.Parse(textBoxY.Text);
                int DevNr = Int32.Parse(textBoxNrOfDevices.Text);
                QueueTypeEnum queueType = (QueueTypeEnum)comboBoxQType.SelectedItem;
                bool isFirst = checkBoxIsFirst.Checked;


                IQueue queue;

                switch (queueType)
                {
                    case QueueTypeEnum.FIFO:
                        queue = new QueueFifo(this.scheduler, queueSize);
                        break;
                    case QueueTypeEnum.LIFO:
                        queue = new QueueLifo(this.scheduler, queueSize);
                        break;
                    case QueueTypeEnum.RANDOM:
                        queue = new QueueRandom(this.scheduler, queueSize);
                        break;
                    default:
                        throw new ApplicationException("Wrong queue type");
                }

                Socket socket = new Socket(queue, this.scheduler, isFirst);

                socket.X = X;
                socket.Y = Y;

                //
                //add devices
                for (int i = 1; i <= DevNr; i++)
                {
                    Device dev = new Device();
                    socket.AddDevice(dev);
 
                }


                scheduler.socketList.Add(socket);

                //
                InitializeCbTo();
                InitializeCbFrom();

                RefreshForm();

                MessageBox.Show("Socket " + socket.ToString() + " added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ResetScheduler()
        {
            scheduler.timestamp = 0;
            scheduler.queueSize = new List<QueueSize>();
            scheduler.killedJobsList = new List<Job>();
            scheduler.jobList = new List<Job>();
            scheduler.eventList = new List<Event>();

            foreach (Socket s in scheduler.socketList)
            {
                s.queue.JobList = new List<Job>();
                foreach (Device d in s.deviceList)
                {
                    d.CurrentJob = null;
                }
            }

        }

        public void RefreshForm()
        {
            bool open = false;
            foreach (Form s in Application.OpenForms)
            {
                if (s is Form1)
                {
                    open = true;
                }
            }

            //if (open) scheduler.form.Close();
            //scheduler.form = new Form1(scheduler);
            scheduler.form.OnLoad();
            //if (open) scheduler.form.Show();
        }

        public void InitializeComboBoxQueueType()
        {
            comboBoxQType.DataSource = Enum.GetValues(typeof(QueueTypeEnum));
        }
        #endregion add socket

        #region make connection

        public void InitializeCbFrom()
        {
            List<Socket> socList = new List<Socket>(scheduler.socketList);
            comboBoxFrom.DataSource = socList;
        }

        public void InitializeCbTo()
        {
            List<Socket> socList = new List<Socket>(scheduler.socketList);
            comboBoxTo.DataSource = socList;
        }

        #endregion 

        private void FormInit_Load(object sender, EventArgs e)
        {

            InitializeComboBoxQueueType();
            InitializeCbFrom();
            InitializeCbTo();

            scheduler.form.Show();

        }

        private void buttonmakeConnection_Click(object sender, EventArgs e)
        {
            try
            {
                //ResetScheduler();

                Socket soc1 = (Socket)comboBoxFrom.SelectedItem;
                Socket soc2 = (Socket)comboBoxTo.SelectedItem;
                int probaility = Int32.Parse(textBoxProbability.Text);

                Socket.MakeConnection(soc1, soc2, probaility);

                MessageBox.Show("Conn: " + soc1 + " -> " + soc2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ResetScheduler();
                

                QueueFifo q = new QueueFifo(this.scheduler, 5);
                Socket s1 = new Socket(q, this.scheduler, true);
                Device d1 = new Device();
                Device d2 = new Device();
                Device dd3 = new Device();
                Device dd4 = new Device();
                Device dd5 = new Device();
                Device dd6 = new Device();
                s1.AddDevice(d1);
                s1.AddDevice(d2);
                s1.AddDevice(dd3);
                s1.AddDevice(dd4);
                s1.AddDevice(dd5);
                s1.AddDevice(dd6);

                s1.X = 10;
                s1.Y = 30;

                QueueLifo q2 = new QueueLifo(this.scheduler, 2);
                Socket s2 = new Socket(q2, this.scheduler);
                Device d3 = new Device();
                Device ddd3 = new Device();
                Device ddd4 = new Device();
                s2.AddDevice(d3);
                s2.AddDevice(ddd3);
                s2.AddDevice(ddd4);

                s2.X = 190;
                s2.Y = 10;

                QueueLifo q3 = new QueueLifo(this.scheduler, 7);
                Socket s3 = new Socket(q3, this.scheduler);
                Device d4 = new Device();
                Device d5 = new Device();
                s3.AddDevice(d4);
                s3.AddDevice(d5);

                s3.X = 190;
                s3.Y = 280;

                QueueLifo q4 = new QueueLifo(this.scheduler, 4);
                Socket s4 = new Socket(q4, this.scheduler);
                Device d6 = new Device();
                Device d7 = new Device();
                
                s4.AddDevice(d6);
                s4.AddDevice(d7);

                s4.X = 380;
                s4.Y = 10;

                QueueLifo q5 = new QueueLifo(this.scheduler, 10);
                Socket s5 = new Socket(q5, this.scheduler);
                Device d8 = new Device();
                Device d9 = new Device();
                Device d10 = new Device();
                Device d11 = new Device();

                s5.AddDevice(d8);
                s5.AddDevice(d9);
                s5.AddDevice(d10);
                s5.AddDevice(d11);
   

                s5.X = 570;
                s5.Y = 120;

                Socket.MakeConnection(s1, s2);
                Socket.MakeConnection(s1, s3);
                Socket.MakeConnection(s3, s5);
                Socket.MakeConnection(s2, s4);
                Socket.MakeConnection(s4, s5);

                this.scheduler.socketList.Add(s1);
                this.scheduler.socketList.Add(s2);
                this.scheduler.socketList.Add(s3);
                this.scheduler.socketList.Add(s4);
                this.scheduler.socketList.Add(s5);


                InitializeCbTo();
                InitializeCbFrom();
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpadteParameters()
        {
            Const.UNIFORM_MIN = Int32.Parse(textBoxUnifMin.Text);
            Const.UNIFORM_MAX = Int32.Parse(textBoxUnifMax.Text);
            Const.NORMAL_MU = Int32.Parse(textBoxNormStd.Text);
            Const.NORLAN_SIGMA = Int32.Parse(textBoxNormMean.Text);
            Const.JOB_NORMAL_GENERATE_PROBABILITY = Int32.Parse(textBoxNormGenProb.Text);
            Const.JOB_UNIFORM_GENERATE_PROBABILITY = Int32.Parse(textBoxUnifGenProb.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UpadteParameters();

                ResetScheduler();
                scheduler.form = new Form1(scheduler);
                RefreshForm();
                scheduler.form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool open = false;
                foreach (Form s in Application.OpenForms)
                {
                    if (s is Form1)
                    {
                        open = true;
                    }
                }

                if (open) scheduler.form.Close();

                scheduler = new Scheduler();
                Device.lastId = 0;
                Queue.lastId = 0;
                Socket.lastId = 0;

                
                scheduler.form = new Form1(scheduler);
                if (open) scheduler.form.Show();

                InitializeCbFrom();
                InitializeCbTo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpadteParameters();
        }


    }
}

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

                QueueFifo q1 = new QueueFifo(this.scheduler, 5);
                Socket s1 = new Socket(q1, this.scheduler, true);

                Device d_1_1 = new Device();
                Device d_1_2 = new Device();
                Device d_1_3 = new Device();
                Device d_1_4 = new Device();


                s1.AddDevice(d_1_1);
                s1.AddDevice(d_1_2);
                s1.AddDevice(d_1_3);
                s1.AddDevice(d_1_4);


                s1.X = 20;
                s1.Y = 0;

                QueueFifo q2 = new QueueFifo(this.scheduler, 5);
                Socket s2 = new Socket(q2, this.scheduler, true);

                Device d_2_1 = new Device();
                Device d_2_2 = new Device();
                Device d_2_3 = new Device();
                Device d_2_4 = new Device();


                s2.AddDevice(d_2_1);
                s2.AddDevice(d_2_2);
                s2.AddDevice(d_2_3);
                s2.AddDevice(d_2_4);


                s2.X = 20;
                s2.Y = 280;

                QueueFifo q3 = new QueueFifo(this.scheduler, 5);
                Socket s3 = new Socket(q3, this.scheduler);
                Device d_3_1 = new Device();
                Device d_3_2 = new Device();
                Device d_3_3 = new Device();
                Device d_3_4 = new Device();


                s3.AddDevice(d_3_1);
                s3.AddDevice(d_3_2);
                s3.AddDevice(d_3_3);
                s3.AddDevice(d_3_4);


                s3.X = 280;
                s3.Y = 0;


                QueueFifo q4 = new QueueFifo(this.scheduler, 5);
                Socket s4 = new Socket(q4, this.scheduler);
                Device d_4_1 = new Device();
                Device d_4_2 = new Device();
                Device d_4_3 = new Device();
                Device d_4_4 = new Device();


                s4.AddDevice(d_4_1);
                s4.AddDevice(d_4_2);
                s4.AddDevice(d_4_3);
                s4.AddDevice(d_4_4);


                s4.X = 280;
                s4.Y = 280;

                Socket.MakeConnection(s1, s3);
                Socket.MakeConnection(s1, s4);
                Socket.MakeConnection(s2, s3);
                Socket.MakeConnection(s2, s4);

                this.scheduler.socketList.Add(s1);
                this.scheduler.socketList.Add(s2);
                this.scheduler.socketList.Add(s3);
                this.scheduler.socketList.Add(s4);

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
            Const.NORMAL_MU = Int32.Parse(textBoxNormMean.Text);
            Const.NORLAN_SIGMA =  Int32.Parse(textBoxNormStd.Text);
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

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
            Device.lastId = 0;
            Queue.lastId = 0;
            Socket.lastId = 0;

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

            scheduler.form.OnLoad();

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
            
        }

        public void UpadteParameters()
        {
            Const.UNIFORM_MIN = Int32.Parse(textBoxUnifMin.Text);
            Const.UNIFORM_MAX = Int32.Parse(textBoxUnifMax.Text);
            Const.NORMAL_MU = Int32.Parse(textBoxNormMean.Text);
            Const.NORMAL_SIGMA =  Int32.Parse(textBoxNormStd.Text);
            Const.JOB_NORMAL_GENERATE_PROBABILITY = Int32.Parse(textBoxNormGenProb.Text);
            Const.JOB_UNIFORM_GENERATE_PROBABILITY = Int32.Parse(textBoxUnifGenProb.Text);
            Const.JOB_EXPONENTIAL_GENERATE_PROBABILITY = Int32.Parse(textBoxGenExp.Text);
            Const.EXPONENTIAL_RATE = Double.Parse(textBoxLambda.Text);
        }

        public void Empty()
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
                Empty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                UpadteParameters();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                FastInit(Initialize1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FastInit(InitDelegate foo)
        {

            
            ResetScheduler();
            scheduler.socketList = new List<Socket>();

            foo.Invoke();

            InitializeCbTo();
            InitializeCbFrom();
            RefreshForm();
        }

        public delegate void InitDelegate();

        public  void Initialize1()
        {
            
            QueueFifo q1 = new QueueFifo(this.scheduler, 50);
            Socket s1 = new Socket(q1, this.scheduler, true);
            Device d_1_1 = new Device();
            //Device d_1_2 = new Device();
            
            s1.AddDevice(d_1_1);
            //s1.AddDevice(d_1_2);
                
            s1.X = 0;
            s1.Y = 0;

            this.scheduler.socketList.Add(s1);
        }

        public void Initialize2()
        {
            try
            {
                int CONTROL_SOCKET_HEIGHT_ = 220;

                ResetScheduler();

                QueueFifo q1 = new QueueFifo(this.scheduler, 30);
                Socket s1 = new Socket(q1, this.scheduler, true);
                Device d_1_1 = new Device();
                Device d_1_2 = new Device();
                Device d_1_3 = new Device();
                Device d_1_4 = new Device();
                Device d_1_5 = new Device();
                Device d_1_6 = new Device();
                Device d_1_7 = new Device();
                Device d_1_8 = new Device();
                Device d_1_9 = new Device();
                Device d_1_10 = new Device();

                s1.AddDevice(d_1_1);
                s1.AddDevice(d_1_2);
                s1.AddDevice(d_1_3);
                s1.AddDevice(d_1_4);
                s1.AddDevice(d_1_5);
                s1.AddDevice(d_1_6);
                s1.AddDevice(d_1_7);
                s1.AddDevice(d_1_8);
                s1.AddDevice(d_1_9);
                s1.AddDevice(d_1_10);
                s1.X = 0;
                s1.Y = 0;

                QueueFifo q2 = new QueueFifo(this.scheduler, 5);
                Socket s2 = new Socket(q2, this.scheduler);
                Device d_2_1 = new Device();
                Device d_2_2 = new Device();
                s2.AddDevice(d_2_1);
                s2.AddDevice(d_2_2);
                s2.X = 200;
                s2.Y = 0;

                QueueFifo q3 = new QueueFifo(this.scheduler, 5);
                Socket s3 = new Socket(q3, this.scheduler);
                Device d_3_1 = new Device();
                Device d_3_2 = new Device();
                s3.AddDevice(d_3_1);
                s3.AddDevice(d_3_2);
                s3.X = 400;
                s3.Y = 0;

                QueueFifo q4 = new QueueFifo(this.scheduler, 5);
                Socket s4 = new Socket(q4, this.scheduler);
                Device d_4_1 = new Device();
                Device d_4_2 = new Device();
                s4.AddDevice(d_4_1);
                s4.AddDevice(d_4_2);
                s4.X = 600;
                s4.Y = 0;

                QueueFifo q5 = new QueueFifo(this.scheduler, 10);
                Socket s5 = new Socket(q5, this.scheduler);
                Device d_5_1 = new Device();
                Device d_5_2 = new Device();
                Device d_5_3 = new Device();
                Device d_5_4 = new Device();
                s5.AddDevice(d_5_1);
                s5.AddDevice(d_5_2);
                s5.AddDevice(d_5_3);
                s5.AddDevice(d_5_4);
                s5.X = 800;
                s5.Y = 0;

                QueueFifo q6 = new QueueFifo(this.scheduler, 5);
                Socket s6 = new Socket(q6, this.scheduler);
                Device d_6_1 = new Device();
                Device d_6_2 = new Device();
                s6.AddDevice(d_6_1);
                s6.AddDevice(d_6_2);
                s6.X = 200;
                s6.Y = CONTROL_SOCKET_HEIGHT_;

                QueueFifo q7 = new QueueFifo(this.scheduler, 5);
                Socket s7 = new Socket(q7, this.scheduler);
                Device d_7_1 = new Device();
                Device d_7_2 = new Device();
                s7.AddDevice(d_7_1);
                s7.AddDevice(d_7_2);
                s7.X = 400;
                s7.Y = CONTROL_SOCKET_HEIGHT_;

                QueueFifo q8 = new QueueFifo(this.scheduler, 5);
                Socket s8 = new Socket(q8, this.scheduler);
                Device d_8_1 = new Device();
                Device d_8_2 = new Device();
                s8.AddDevice(d_8_1);
                s8.AddDevice(d_8_2);
                s8.X = 600;
                s8.Y = CONTROL_SOCKET_HEIGHT_;

                QueueFifo q9 = new QueueFifo(this.scheduler, 5);
                Socket s9 = new Socket(q9, this.scheduler);
                Device d_9_1 = new Device();
                Device d_9_2 = new Device();
                s9.AddDevice(d_9_1);
                s9.AddDevice(d_9_2);
                s9.X = 200;
                s9.Y = 2 * CONTROL_SOCKET_HEIGHT_;

                QueueFifo q10 = new QueueFifo(this.scheduler, 5);
                Socket s10 = new Socket(q10, this.scheduler);
                Device d_10_1 = new Device();
                Device d_10_2 = new Device();
                s10.AddDevice(d_10_1);
                s10.AddDevice(d_10_2);
                s10.X = 400;
                s10.Y = 2 * CONTROL_SOCKET_HEIGHT_;

                QueueFifo q11 = new QueueFifo(this.scheduler, 5);
                Socket s11 = new Socket(q11, this.scheduler);
                Device d_11_1 = new Device();
                Device d_11_2 = new Device();
                s11.AddDevice(d_11_1);
                s11.AddDevice(d_11_2);
                s11.X = 600;
                s11.Y = 2 * CONTROL_SOCKET_HEIGHT_;

                QueueFifo q12 = new QueueFifo(this.scheduler, 5);
                Socket s12 = new Socket(q12, this.scheduler);
                Device d_12_1 = new Device();
                Device d_12_2 = new Device();
                s12.AddDevice(d_12_1);
                s12.AddDevice(d_12_2);
                s12.X = 800;
                s12.Y = 2 * CONTROL_SOCKET_HEIGHT_;

                QueueFifo q13 = new QueueFifo(this.scheduler, 5);
                Socket s13 = new Socket(q13, this.scheduler);
                Device d_13_1 = new Device();
                Device d_13_2 = new Device();
                s13.AddDevice(d_13_1);
                s13.AddDevice(d_13_2);
                s13.X = 200;
                s13.Y = 3 * CONTROL_SOCKET_HEIGHT_;

                QueueFifo q14 = new QueueFifo(this.scheduler, 5);
                Socket s14 = new Socket(q14, this.scheduler);
                Device d_14_1 = new Device();
                Device d_14_2 = new Device();
                s14.AddDevice(d_14_1);
                s14.AddDevice(d_14_2);
                s14.X = 400;
                s14.Y = 3 * CONTROL_SOCKET_HEIGHT_;

                QueueFifo q15 = new QueueFifo(this.scheduler, 5);
                Socket s15 = new Socket(q15, this.scheduler);
                Device d_15_1 = new Device();
                Device d_15_2 = new Device();
                s15.AddDevice(d_15_1);
                s15.AddDevice(d_15_2);
                s15.X = 600;
                s15.Y = 3 * CONTROL_SOCKET_HEIGHT_;

                QueueFifo q16 = new QueueFifo(this.scheduler, 5);
                Socket s16 = new Socket(q16, this.scheduler);
                Device d_16_1 = new Device();
                Device d_16_2 = new Device();
                s16.AddDevice(d_16_1);
                s16.AddDevice(d_16_2);
                s16.X = 800;
                s16.Y = 3 * CONTROL_SOCKET_HEIGHT_;

                QueueFifo q17 = new QueueFifo(this.scheduler, 5);
                Socket s17 = new Socket(q17, this.scheduler);
                Device d_17_1 = new Device();
                Device d_17_2 = new Device();
                s17.AddDevice(d_17_1);
                s17.AddDevice(d_17_2);
                s17.X = 200;
                s17.Y = 4 * CONTROL_SOCKET_HEIGHT_;

                QueueFifo q18 = new QueueFifo(this.scheduler, 5);
                Socket s18 = new Socket(q18, this.scheduler);
                Device d_18_1 = new Device();
                Device d_18_2 = new Device();
                s18.AddDevice(d_18_1);
                s18.AddDevice(d_18_2);
                s18.X = 400;
                s18.Y = 4 * CONTROL_SOCKET_HEIGHT_;

                QueueFifo q19 = new QueueFifo(this.scheduler, 5);
                Socket s19 = new Socket(q19, this.scheduler);
                Device d_19_1 = new Device();
                Device d_19_2 = new Device();
                s19.AddDevice(d_19_1);
                s19.AddDevice(d_19_2);
                s19.X = 600;
                s19.Y = 4 * CONTROL_SOCKET_HEIGHT_;

                Socket.MakeConnection(s1, s2);
                Socket.MakeConnection(s1, s6);
                Socket.MakeConnection(s1, s9);
                Socket.MakeConnection(s1, s13);
                Socket.MakeConnection(s1, s17);

                Socket.MakeConnection(s2, s3);
                Socket.MakeConnection(s3, s4);
                Socket.MakeConnection(s4, s5);

                Socket.MakeConnection(s6, s7);
                Socket.MakeConnection(s7, s8);
                Socket.MakeConnection(s8, s5);

                Socket.MakeConnection(s9, s10);
                Socket.MakeConnection(s10, s11);
                Socket.MakeConnection(s11, s12);

                Socket.MakeConnection(s13, s14);
                Socket.MakeConnection(s14, s15);
                Socket.MakeConnection(s15, s16);

                Socket.MakeConnection(s17, s18);
                Socket.MakeConnection(s18, s19);

                this.scheduler.socketList.Add(s1);
                this.scheduler.socketList.Add(s2);
                this.scheduler.socketList.Add(s3);
                this.scheduler.socketList.Add(s4);
                this.scheduler.socketList.Add(s5);
                this.scheduler.socketList.Add(s6);
                this.scheduler.socketList.Add(s7);
                this.scheduler.socketList.Add(s8);
                this.scheduler.socketList.Add(s9);
                this.scheduler.socketList.Add(s10);
                this.scheduler.socketList.Add(s11);
                this.scheduler.socketList.Add(s12);
                this.scheduler.socketList.Add(s13);
                this.scheduler.socketList.Add(s14);
                this.scheduler.socketList.Add(s15);
                this.scheduler.socketList.Add(s16);
                this.scheduler.socketList.Add(s17);
                this.scheduler.socketList.Add(s18);
                this.scheduler.socketList.Add(s19);


                InitializeCbTo();
                InitializeCbFrom();
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Initialize3()
        {
            try
            {
                int CONTROL_SOCKET_HEIGHT_ = 350;

                ResetScheduler();

                QueueFifo q1 = new QueueFifo(this.scheduler, 30);
                Socket s1 = new Socket(q1, this.scheduler, true);
                Device d_1_1 = new Device();
                Device d_1_2 = new Device();
                Device d_1_3 = new Device();
                Device d_1_4 = new Device();
                Device d_1_5 = new Device();
                Device d_1_6 = new Device();
                Device d_1_7 = new Device();
                Device d_1_8 = new Device();
                Device d_1_9 = new Device();
                Device d_1_10 = new Device();

                s1.AddDevice(d_1_1);
                s1.AddDevice(d_1_2);
                s1.AddDevice(d_1_3);
                s1.AddDevice(d_1_4);
                s1.AddDevice(d_1_5);
                s1.AddDevice(d_1_6);
                s1.AddDevice(d_1_7);
                s1.AddDevice(d_1_8);
                s1.AddDevice(d_1_9);
                s1.AddDevice(d_1_10);
                s1.X = 0;
                s1.Y = 0;

                QueueFifo q2 = new QueueFifo(this.scheduler, 10);
                Socket s2 = new Socket(q2, this.scheduler);
                Device d_2_1 = new Device();
                Device d_2_2 = new Device();
                Device d_2_3 = new Device();
                Device d_2_4 = new Device();
                s2.AddDevice(d_2_1);
                s2.AddDevice(d_2_2);
                s2.AddDevice(d_2_3);
                s2.AddDevice(d_2_4);
                s2.X = 200;
                s2.Y = 0;

                QueueFifo q3 = new QueueFifo(this.scheduler, 10);
                Socket s3 = new Socket(q3, this.scheduler);
                Device d_3_1 = new Device();
                Device d_3_2 = new Device();
                Device d_3_3 = new Device();
                Device d_3_4 = new Device();
                s3.AddDevice(d_3_1);
                s3.AddDevice(d_3_2);
                s3.AddDevice(d_3_3);
                s3.AddDevice(d_3_4);
                s3.X = 400;
                s3.Y = 0;

                QueueFifo q4 = new QueueFifo(this.scheduler, 10);
                Socket s4 = new Socket(q4, this.scheduler);
                Device d_4_1 = new Device();
                Device d_4_2 = new Device();
                Device d_4_3 = new Device();
                Device d_4_4 = new Device();
                s4.AddDevice(d_4_1);
                s4.AddDevice(d_4_2);
                s4.AddDevice(d_4_3);
                s4.AddDevice(d_4_4);
                s4.X = 600;
                s4.Y = 0;

                QueueFifo q5 = new QueueFifo(this.scheduler, 10);
                Socket s5 = new Socket(q5, this.scheduler);
                Device d_5_1 = new Device();
                Device d_5_2 = new Device();
                Device d_5_3 = new Device();
                Device d_5_4 = new Device();
                s5.AddDevice(d_5_1);
                s5.AddDevice(d_5_2);
                s5.AddDevice(d_5_3);
                s5.AddDevice(d_5_4);
                s5.X = 800;
                s5.Y = 0;

                QueueFifo q6 = new QueueFifo(this.scheduler, 10);
                Socket s6 = new Socket(q6, this.scheduler);
                Device d_6_1 = new Device();
                Device d_6_2 = new Device();
                Device d_6_3 = new Device();
                Device d_6_4 = new Device();
                Device d_6_5 = new Device();
                Device d_6_6 = new Device();
                s6.AddDevice(d_6_1);
                s6.AddDevice(d_6_2);
                s6.AddDevice(d_6_3);
                s6.AddDevice(d_6_4);
                s6.AddDevice(d_6_5);
                s6.AddDevice(d_6_6);
                s6.X = 200;
                s6.Y = CONTROL_SOCKET_HEIGHT_;

                QueueFifo q7 = new QueueFifo(this.scheduler, 10);
                Socket s7 = new Socket(q7, this.scheduler);
                Device d_7_1 = new Device();
                Device d_7_2 = new Device();
                Device d_7_3 = new Device();
                Device d_7_4 = new Device();
                Device d_7_5 = new Device();
                Device d_7_6 = new Device();
                s7.AddDevice(d_7_1);
                s7.AddDevice(d_7_2);
                s7.AddDevice(d_7_3);
                s7.AddDevice(d_7_4);
                s7.AddDevice(d_7_5);
                s7.AddDevice(d_7_6);
                s7.X = 400;
                s7.Y = CONTROL_SOCKET_HEIGHT_;

                QueueFifo q8 = new QueueFifo(this.scheduler, 10);
                Socket s8 = new Socket(q8, this.scheduler);
                Device d_8_1 = new Device();
                Device d_8_2 = new Device();
                Device d_8_3 = new Device();
                Device d_8_4 = new Device();
                Device d_8_5 = new Device();
                Device d_8_6 = new Device();
                s8.AddDevice(d_8_1);
                s8.AddDevice(d_8_2);
                s8.AddDevice(d_8_3);
                s8.AddDevice(d_8_4);
                s8.AddDevice(d_8_5);
                s8.AddDevice(d_8_6);
                s8.X = 600;
                s8.Y = CONTROL_SOCKET_HEIGHT_;

                QueueFifo q9 = new QueueFifo(this.scheduler, 10);
                Socket s9 = new Socket(q9, this.scheduler);
                Device d_9_1 = new Device();
                Device d_9_2 = new Device();
                Device d_9_3 = new Device();
                Device d_9_4 = new Device();
                Device d_9_5 = new Device();
                Device d_9_6 = new Device();
                s9.AddDevice(d_9_1);
                s9.AddDevice(d_9_2);
                s9.AddDevice(d_9_3);
                s9.AddDevice(d_9_4);
                s9.AddDevice(d_9_5);
                s9.AddDevice(d_9_6);
                s9.X = 800;
                s9.Y = CONTROL_SOCKET_HEIGHT_;


                Socket.MakeConnection(s1, s2);
                Socket.MakeConnection(s1, s6);

                Socket.MakeConnection(s2, s3);
                Socket.MakeConnection(s3, s4);
                Socket.MakeConnection(s4, s5);

                Socket.MakeConnection(s6, s7);
                Socket.MakeConnection(s7, s8);
                Socket.MakeConnection(s8, s9);

                this.scheduler.socketList.Add(s1);
                this.scheduler.socketList.Add(s2);
                this.scheduler.socketList.Add(s3);
                this.scheduler.socketList.Add(s4);
                this.scheduler.socketList.Add(s5);
                this.scheduler.socketList.Add(s6);
                this.scheduler.socketList.Add(s7);
                this.scheduler.socketList.Add(s8);
                this.scheduler.socketList.Add(s9);


                InitializeCbTo();
                InitializeCbFrom();
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void  Initialize4()
        {
            try
            {
                ResetScheduler();

                QueueFifo q = new QueueFifo(this.scheduler, 5);
                Socket s1 = new Socket(q, this.scheduler, true);

                Device d_1_1 = new Device();
                Device d_1_2 = new Device();
                Device d_1_3 = new Device();
                Device d_1_4 = new Device();

                s1.AddDevice(d_1_1);
                s1.AddDevice(d_1_2);
                s1.AddDevice(d_1_3);
                s1.AddDevice(d_1_4);

                s1.X = 20;
                s1.Y = 120;

                QueueFifo q2 = new QueueFifo(this.scheduler, 5);
                Socket s2 = new Socket(q2, this.scheduler);
                Device d_2_1 = new Device();
                Device d_2_2 = new Device();

                s2.AddDevice(d_2_1);
                s2.AddDevice(d_2_2);

                s2.X = 250;
                s2.Y = 20;

                QueueFifo q3 = new QueueFifo(this.scheduler, 5);
                Socket s3 = new Socket(q3, this.scheduler);
                Device d_3_1 = new Device();
                Device d_3_2 = new Device();

                s3.AddDevice(d_3_1);
                s3.AddDevice(d_3_2);

                s3.X = 250;
                s3.Y = 250;

                QueueFifo q4 = new QueueFifo(this.scheduler, 5);
                Socket s4 = new Socket(q4, this.scheduler);
                Device d_4_1 = new Device();
                Device d_4_2 = new Device();

                s4.AddDevice(d_4_1);
                s4.AddDevice(d_4_2);

                s4.X = 450;
                s4.Y = 20;

                QueueFifo q5 = new QueueFifo(this.scheduler, 5);
                Socket s5 = new Socket(q5, this.scheduler);
                Device d_5_1 = new Device();
                Device d_5_2 = new Device();

                s5.AddDevice(d_5_1);
                s5.AddDevice(d_5_2);

                s5.X = 450;
                s5.Y = 250;

                QueueFifo q6 = new QueueFifo(this.scheduler, 10);
                Socket s6 = new Socket(q6, this.scheduler);
                Device d_6_1 = new Device();
                Device d_6_2 = new Device();
                Device d_6_3 = new Device();
                Device d_6_4 = new Device();

                s6.AddDevice(d_6_1);
                s6.AddDevice(d_6_2);
                s6.AddDevice(d_6_3);
                s6.AddDevice(d_6_4);

                s6.X = 650;
                s6.Y = 120;

                Socket.MakeConnection(s1, s2);
                Socket.MakeConnection(s1, s3);
                Socket.MakeConnection(s2, s4);
                Socket.MakeConnection(s3, s5);
                Socket.MakeConnection(s4, s6);
                Socket.MakeConnection(s5, s6);

                this.scheduler.socketList.Add(s1);
                this.scheduler.socketList.Add(s2);
                this.scheduler.socketList.Add(s3);
                this.scheduler.socketList.Add(s4);
                this.scheduler.socketList.Add(s5);
                this.scheduler.socketList.Add(s6);

                InitializeCbTo();
                InitializeCbFrom();
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FastInit(Initialize2);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FastInit(Initialize3);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FastInit(Initialize4);
        }

    }
}

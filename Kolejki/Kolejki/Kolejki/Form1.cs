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
using System.Drawing.Drawing2D;
using Kolejki.F.EstevesPlanner;

namespace Kolejki 
{
    public partial class Form1 : Form
    {
        List<SocketControl> socketControlList;
        Scheduler scheduler;
        Excel excel1;  
        
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
            if (checkBoxRefresh.Checked)
            {
                int jobCount = scheduler.jobList.Count();

                InitializeDevicesStatistics();
                InitializeQueuesStatistics();
                InitializeGlobalStatistics();

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

            WriteExcel();
        }

        public void WriteExcel()
        {
            //
            //excel
            if (excel1 != null && checkBox1.Checked)
            {
                RefreshExcelGlobalStatistics();
                RefreshExcelDeviceStatistics();
                RefreshExcelQueueStatistics();
            }
        }

        public void InitilizeExcel()
        {
            if (excel1 != null)
            {

                //excel initialize
                List<object> str = new List<object>();

                str.Add("czas");
                str.Add("liczba zadan");
                str.Add("liczba zabitych zadań");
                str.Add("max czas w systemie");
                str.Add("min czas w systemie");
                str.Add("średni czas w systemie");
                str.Add("odch. st. czasu w systemie");
                str.Add("max czas pracy zadania");
                str.Add("min czas pracy zadania");
                str.Add("średni czas pracy zadania");
                str.Add("odch. st. czasu pracy zadania");
                str.Add("max czas bezczynnosci");
                str.Add("min czas bezczynnosci");
                str.Add("średni czas bezczynnosci");
                str.Add("odch. st. czasu bezczynnosci");

                excel1.WriteRow(0, str);

                str = new List<object>();

                str.Add("Czas");


                foreach (Socket soc in scheduler.socketList)
                {
                    foreach (Device dev in soc.deviceList)
                    {
                        str.Add("Id.");
                        str.Add("Łączny czas pracy");
                        str.Add("Łączny czas zajęt.");
                        str.Add("śr. czas pracy");
                        str.Add("śr. czas zaj.");
                        str.Add("");
                    }
                }

                excel1.WriteRow(1, str);

                str = new List<object>();

                str.Add("Czas");

                foreach (Socket soc in scheduler.socketList)
                {
                    str.Add("Nazwa kolejki");
                    str.Add("śr. czas");
                    str.Add("łączny czas");
                    str.Add("max czas");
                    str.Add("max liczba zadan");
                    str.Add("śr. liczba zadan");
                    str.Add("");

                }

                excel1.WriteRow(2, str);


                str = new List<object>();

                str.Add("Czas");
                str.Add("Id");
                str.Add("Typ rozkładu");
                str.Add("Czas w systemie");
                str.Add("Czas pracy");
                str.Add("Czas bezczynności");
                str.Add("Min. czas pracy");
                str.Add("Maks. czas pracy");
                str.Add("Śr. Czas pracy");
                str.Add("Odchylenie std. czasu pracy");
                str.Add("");
                excel1.WriteRow(3, str);

                //
                str = new List<object>();

                excel1.WriteRow(4, new List<object> { "JOB_NORMAL_GENERATE_PROBABILITY", Const.JOB_NORMAL_GENERATE_PROBABILITY });
                excel1.WriteRow(4, new List<object> { "JOB_UNIFORM_GENERATE_PROBABILITY", Const.JOB_UNIFORM_GENERATE_PROBABILITY });
                excel1.WriteRow(4, new List<object> { "NORMAL_SIGMA", Const.NORMAL_SIGMA });
                excel1.WriteRow(4, new List<object> { "NORMAL_MU", Const.NORMAL_MU });
                excel1.WriteRow(4, new List<object> { "UNIFORM_MAX", Const.UNIFORM_MAX });
                excel1.WriteRow(4, new List<object> { "UNIFORM_MIN", Const.UNIFORM_MIN });
            }
        }        

        private void RefreshExcelGlobalStatistics()
        {

            //
            //excel
            var str = new List<object>();

            str.Add(scheduler.timestamp);
            str.Add(scheduler.jobList.Count());
            str.Add(scheduler.killedJobsList.Count());
            str.Add(scheduler.MaxTimeInSystem());
            str.Add(scheduler.MinTimeInSystem());
            str.Add(scheduler.AvgTimeInSystem());
            str.Add(scheduler.StdVarTimeInSystem());
            str.Add(scheduler.MaxWorkTime());
            str.Add(scheduler.MinWorkTime());
            str.Add(scheduler.AvgWorkingTime());
            str.Add(scheduler.StdVarWorkTime());
            str.Add(scheduler.MaxWastedTime());
            str.Add(scheduler.MinWastedTime());
            str.Add(scheduler.AvgWastedTime());
            str.Add(scheduler.StdVarWastedTime());
            str.Add("");

            excel1.WriteRow(0, str);
        }

        private void RefreshExcelDeviceStatistics()
        {
            //device statistics

            //
            //excel
            var str = new List<object>();

            str.Add( scheduler.timestamp );

            //
            //Write to excel

            foreach (Socket s in scheduler.socketList)
            {
                foreach (Device dev in s.deviceList)
                {
                    str.Add(dev.Id);
                    str.Add(scheduler.AllWorkTimeOnDevice(dev));
                    str.Add(scheduler.AllBusyTimeOnDevice(dev));
                    str.Add(scheduler.AvgWorkTimeOnDevice(dev));
                    str.Add(scheduler.AvgBusyTimeOnDevice(dev));
                    str.Add("");
                }
            }

            excel1.WriteRow(1, str);
        }

        private void RefreshExcelQueueStatistics()
        {

            //
            //excel
            var str = new List<object>();

            str.Add(scheduler.timestamp);

            //
            //Write to excel
            foreach (Socket s in scheduler.socketList)
            {
                str.Add(s.queue.Name);
                str.Add(scheduler.avgQueueTime(s.queue));
                str.Add(scheduler.sumQueueTime(s.queue));
                str.Add(scheduler.maxQueueTime(s.queue));
                str.Add(scheduler.maxQueueCount(s.queue));
                str.Add(scheduler.avgQueueCount(s.queue));
                str.Add("");
            }

            excel1.WriteRow(2, str);
        }

        public void AddToExcelJobStatistic(Job job)
        {
            if (excel1 != null)
            {
                //
                //excel
                var str = new List<object>();

                str.Add(scheduler.timestamp);
                str.Add(job.Id);
                str.Add(job.Distribution.Name);
                str.Add(job.TimeInSystem);
                str.Add(job.WorkedTime());
                str.Add(job.WastedTime());
                str.Add(job.MinWorkTime());
                str.Add(job.MaxWorkTime());
                str.Add(job.AvgWorkTime());
                str.Add(job.StdVarWorkTime());
                str.Add("");

                excel1.WriteRow(3, str);
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

        private void InitializeGlobalStatistics()
        {
            dgvStats.Rows.Clear();

            dgvStats.Rows.Add("liczba zadan", scheduler.jobList.Count());
            dgvStats.Rows.Add("liczba zabitych zadań", scheduler.killedJobsList.Count());
            dgvStats.Rows.Add("max czas w systemie", scheduler.MaxTimeInSystem());
            dgvStats.Rows.Add("min czas w systemie", scheduler.MinTimeInSystem());
            dgvStats.Rows.Add("średni czas w systemie", scheduler.AvgTimeInSystem());
            dgvStats.Rows.Add("odch. st. czasu w systemie", scheduler.StdVarTimeInSystem());
            dgvStats.Rows.Add("max czas pracy zadania", scheduler.MaxWorkTime());
            dgvStats.Rows.Add("min czas pracy zadania", scheduler.MinWorkTime());
            dgvStats.Rows.Add("średni czas pracy zadania", scheduler.AvgWorkingTime());
            dgvStats.Rows.Add("odch. st. czasu pracy zadania", scheduler.StdVarWorkTime());
            dgvStats.Rows.Add("max czas bezczynnosci", scheduler.MaxWastedTime());
            dgvStats.Rows.Add("min czas bezczynnosci", scheduler.MinWastedTime());
            dgvStats.Rows.Add("średni czas bezczynnosci", scheduler.AvgWastedTime());
            dgvStats.Rows.Add("odch. st. czasu bezczynnosci", scheduler.StdVarWastedTime());
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
            if (i == 1) richTextBoxCount.Text = message + "\n" + richTextBoxCount.Text;
            if (checkBoxRefresh.Checked) richTextBox.Text = message + "\n" + richTextBox.Text; 
        }

        public void OnLoad()
        {
            try
            {
                button4.Enabled = false;
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

                try
                {
                    excel1 = new Excel(5);
                }
                catch (Exception exWew)
                {
                    //nie zainstalowany excel
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool firstStep = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstStep)
            {
                InitilizeExcel();
                firstStep = false;
            }

            scheduler.MakeStep();
            Refresh();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstStep)
            {
                InitilizeExcel();
                firstStep = false;
            }

            scheduler.MakeEventStep();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (firstStep)
            {
                InitilizeExcel();
                firstStep = false;
            }

            timer1.Start();
            button4.Enabled = true;
            button3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scheduler.MakeStep();
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button3.Enabled = true;
            button4.Enabled = false;
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

            if (excel1 != null)
            {
                for (int i = 0; i <= 3; i++)
                {
                    excel1.ResetX(i);
                    excel1.ResetY(i);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ResetScheduler();

                if (firstStep)
                {
                    InitilizeExcel();
                    firstStep = false;
                }

                int steps = Int32.Parse(textBoxSteps.Text);

                for (int i = 0; i < steps; i++)
                {
                    scheduler.MakeStep();
                    Refresh();

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1);
                }

                //finished
                Const.JOB_NORMAL_GENERATE_PROBABILITY = 0;
                Const.JOB_UNIFORM_GENERATE_PROBABILITY = 0;

                while (!scheduler.SystemEmpty)
                {
                    scheduler.MakeStep();
                    Refresh();
                }

                MessageBox.Show("Symulacja ukończona: " + scheduler.timestamp);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

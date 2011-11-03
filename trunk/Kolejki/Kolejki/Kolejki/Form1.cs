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

        Scheduler scheduler;

        public void initializeApplication(){}

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
            DataGridView dgv;
            switch (nr)
            {
                case 1: 
                    dgv = dgvQueue1; 
                    break;
                case 2:
                    dgv = dgvQueue2;
                    break;
                default:
                    throw new ApplicationException("Nieznana kolejka (dgv)");
            }

            dgv.Rows.Clear();

            List<Job> l = scheduler.socketList[nr-1].queue.JobList;
            InitializeDgv(dgv, l);
        }

        public void InitializeDgvDevice(int nr)
        {
            DataGridView dgv;
            Device dev;
            switch (nr)
            {
                case 1:
                    dgv = dgvDevice1;
                    dev = scheduler.socketList[0].deviceList[0];
                    label1.Text = dev.ToString();
                    break;
                case 2:
                    dgv = dgvDevice2;
                    dev = scheduler.socketList[0].deviceList[1];
                    label2.Text = dev.ToString();
                    break;
                case 3:
                    dgv = dgvDevice3;
                    dev = scheduler.socketList[1].deviceList[0];
                    label3.Text = dev.ToString();
                    break;
           
                default:
                    throw new ApplicationException("Nieznana maszyna (dgv)");
            }

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
            InitializeDgvJobs();
            InitializeDgvQueue(1);
            InitializeDgvQueue(2);

            for (int i = 1; i <= 3; i++)
            {
                InitializeDgvDevice(i);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scheduler = new Scheduler(this);
            scheduler.Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            button1.Enabled = false;
            scheduler.MakeEventStep();
            Refresh();
            button1.Enabled = true;

            timer1.Start();
        }

       
        public void Notify(String message)
        {
            richTextBox.Text = message + "\n" +  richTextBox.Text; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false;
            scheduler.MakeEventStep();
            Refresh();
            button1.Enabled = true;
        }
    }
}

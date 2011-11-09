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
    public partial class FormInitialize : Form
    {
        private Scheduler scheduler;

        public FormInitialize(Scheduler s)
        {
            scheduler = s; 
            InitializeComponent();
        }

        private void buttonAddSocket_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormAddSocket(scheduler);
                form.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMakeConn_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new FormMakeConnection(scheduler);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFastInitialize_Click(object sender, EventArgs e)
        {
            try
            {

                QueueFifo q = new QueueFifo(this.scheduler, 15);
                q.Name = "kolejka 1";
                Socket s1 = new Socket(q, this.scheduler, true);
                Device d1 = new Device();
                Device d2 = new Device();
                Device d8 = new Device();
                s1.AddDevice(d1);
                s1.AddDevice(d2);
                s1.AddDevice(d8);

                s1.Coll = 1;
                s1.Row = 1;

                QueueLifo q2 = new QueueLifo(this.scheduler, 1);
                q2.Name = "kolejka 2";
                Socket s2 = new Socket(q2, this.scheduler);
                Device d3 = new Device();
                s2.AddDevice(d3);

                s2.Coll = 2;
                s2.Row = 1;

                QueueLifo q3 = new QueueLifo(this.scheduler, 500);
                q3.Name = "kolejka 3";
                Socket s3 = new Socket(q3, this.scheduler);
                Device d4 = new Device();
                Device d5 = new Device();
                s3.AddDevice(d4);
                s3.AddDevice(d5);

                s3.Row = 2;
                s3.Coll = 2;

                QueueLifo q4 = new QueueLifo(this.scheduler, 10);
                q4.Name = "kolejka 4";
                Socket s4 = new Socket(q4, this.scheduler);
                Device d6 = new Device();
                Device d7 = new Device();
                s4.AddDevice(d6);
                s4.AddDevice(d7);
               
                s4.Coll = 3;
                s4.Row = 1;
                

                Socket.MakeConnection(s1, s2);
                Socket.MakeConnection(s1, s3);
                Socket.MakeConnection(s3, s4);
                Socket.MakeConnection(s2, s4);

                s1.Name = "Socket1";
                s2.Name = "Socket2";
                s3.Name = "Socket3";
                s4.Name = "Socket4";

                this.scheduler.socketList.Add(s1);
                this.scheduler.socketList.Add(s2);
                this.scheduler.socketList.Add(s3);
                this.scheduler.socketList.Add(s4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                scheduler.form.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

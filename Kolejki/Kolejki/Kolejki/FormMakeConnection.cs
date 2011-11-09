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
    public partial class FormMakeConnection : Form
    {
        private Scheduler scheuler;


        public FormMakeConnection(Scheduler s)
        {
            scheuler = s;
            InitializeComponent();
            InitializeCbFrom();
            InitializeCbTo();
        }

        public void InitializeCbFrom()
        {
            List<Socket> socList = new List<Socket>(scheuler.socketList);
            comboBoxFrom.DataSource = socList;
        }

        public void InitializeCbTo()
        {
            List<Socket> socList = new List<Socket>(scheuler.socketList);
            comboBoxTo.DataSource = socList;
        }

        private void buttonMakeConn_Click(object sender, EventArgs e)
        {
            try
            {
                Socket soc1 = (Socket)comboBoxFrom.SelectedItem;
                Socket soc2 = (Socket)comboBoxTo.SelectedItem;

                Socket.MakeConnection(soc1, soc2);

                MessageBox.Show( "Conn: " + soc1 + " -> " + soc2 );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

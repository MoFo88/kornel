using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kolejki.F;

namespace Kolejki
{
    public partial class SocketControl : UserControl
    {
        public List<DataGridView> DeviceList;
        public DataGridView Queue;
        public Socket Socket;

        public SocketControl(Socket socket)
        {
            InitializeComponent();
            Socket = socket;

            Queue = new DataGridView();
            DataGridViewCell cellQ = new DataGridViewTextBoxCell();
            DataGridViewColumn collQ = new DataGridViewColumn(cellQ);
            Queue.Columns.Add(collQ);
            Queue.Height = Math.Min(Const.ROW_HEIGHT * socket.queue.Size, 200);
            Queue.Width = Const.ROW_WIDTH;
            Queue.RowHeadersVisible = false;
            Queue.ColumnHeadersVisible = false;
            Queue.Location = new Point(0,0);
            Queue.ScrollBars = ScrollBars.Vertical;
            Queue.AllowUserToAddRows = false;

            int count = 0;
            DeviceList = new List<DataGridView>();
            foreach (Device dev in socket.deviceList)
            {
                DataGridView d = new DataGridView();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                DataGridViewColumn coll = new DataGridViewColumn(cell);
                d.ColumnHeadersVisible = false;
                d.RowHeadersVisible = false;
                d.AllowUserToAddRows = false;
                d.Columns.Add(coll);
                d.ScrollBars = ScrollBars.None;
                d.Height = Const.ROW_HEIGHT;
                d.Width = Const.ROW_WIDTH;
                d.Location = new Point(Const.ROW_WIDTH + 5, count * (Const.ROW_HEIGHT+2));
                d.Tag = dev;
                
                DeviceList.Add(d);
                count ++;
            }

            this.Height = Math.Max(Queue.Size.Height , (DeviceList.Count) * (Const.ROW_WIDTH+5));
            this.Width = Const.CONTROL_SOCKET_WIDTH;

            //add to control
            this.Controls.Add(Queue);

            foreach (DataGridView dev in DeviceList)
            {
                this.Controls.Add(dev);
            }
        }
    }
}

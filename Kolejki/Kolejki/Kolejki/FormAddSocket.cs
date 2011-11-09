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
    public partial class FormAddSocket : Form
    {
        private Scheduler scheduler;

        public FormAddSocket(Scheduler s)
        {
            scheduler = s;
            InitializeComponent();
        }

        public void InitializeComboBoxQueueType()
        {
            comboBoxQueueType.DataSource = Enum.GetValues(typeof(QueueTypeEnum));
        }

        private void buttonAddSocket_Click(object sender, EventArgs e)
        {

            String socketName = textBoxName.Text;
            String queueName = textBoxQueueName.Text;
            int queueSize = Int32.Parse(textBoxQueueSize.Text);
            bool isFirst = checkBoxIsFirst.Checked;
            int nrOfDev = Int32.Parse(textBoxNrOfDev.Text);
            QueueTypeEnum queueType = (QueueTypeEnum)comboBoxQueueType.SelectedItem;
            int row = Int32.Parse( textBoxRow.Text);
            int coll = Int32.Parse(textBoxColl.Text);

            IQueue queue;

            switch (queueType)
            {
                case QueueTypeEnum.FIFO:
                    queue = new QueueFifo( this.scheduler, queueSize);
                    break;
                case QueueTypeEnum.LIFO:
                    queue = new QueueLifo( this.scheduler, queueSize);
                    break;
                case QueueTypeEnum.RANDOM:
                    queue = new QueueRandom( this.scheduler, queueSize);
                    break;
                default:
                    throw new ApplicationException("Wrong queue type"); 
            }

            Socket socket = new Socket(queue, this.scheduler, isFirst);
            socket.Name = socketName;
            socket.Row = row;
            socket.Coll = coll;

            scheduler.socketList.Add(socket);

            //
            //add devices
            for (int i = 1; i <= nrOfDev; i++)
            {
                Device dev = new Device();
                socket.AddDevice(dev);
            }

            MessageBox.Show("Socket " + socket.ToString() + " added");
        }

        private void FormAddSocket_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeComboBoxQueueType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

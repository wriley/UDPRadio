using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDPRadio
{
    public partial class Form1 : Form
    {
        public const int packetLength = 1024;
        public class CurrentState
        {
            public byte[] currentData = new byte[packetLength];
        }

        private BackgroundWorker bw = new BackgroundWorker();
        private bool mCompleted = false;
        private bool mClosePending = false;
        private float[] freqs = new float[6];

        public Form1()
        {
            InitializeComponent();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_GetData);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_DataReceived);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_Done);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bw_GetData(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            CurrentState state = new CurrentState();

            byte[] data = new byte[packetLength];

            UdpClient sendSocket = new UdpClient("127.0.0.1", 49000);
            IPEndPoint ipepSender = new IPEndPoint(IPAddress.Any, 0);
            IPEndPoint ipepReceiver = new IPEndPoint(IPAddress.Any, 49003);
            UdpClient socket = new UdpClient(ipepReceiver);

            // DSEL0 for data 96 (0x60) com1/com2
            byte[] selectPacket = new byte[] { 68, 83, 69, 76, 48, 96, 0, 0, 0 };
            try
            {
                sendSocket.Send(selectPacket, selectPacket.Length);
            }
            catch (Exception) { }

            while (worker.CancellationPending == false)
            {
                try
                {
                    data = socket.Receive(ref ipepSender);
                }
                catch (Exception)
                {
                }
                finally
                {
                    data.CopyTo(state.currentData, 0);
                    worker.ReportProgress(0, state);
                }
            }

            e.Cancel = true;
            socket.Close();
        }

        private void bw_DataReceived(object sender, ProgressChangedEventArgs e)
        {
            CurrentState state = (CurrentState)e.UserState;

            Debug("DATA: " + string.Join(", ", state.currentData));

            for (int j = 5; j < state.currentData.Length; j += 36)
            {
                if (state.currentData[j] == 96)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        try
                        {
                            freqs[i] = BitConverter.ToSingle(state.currentData, j + 4 + (i * 4));
                        }
                        catch (Exception ex)
                        {
                            Debug("Error converting data: " + ex.Message);
                        }
                    }

                    tbCOM1Active.Text = freqs[0].ToString();
                    tbCOM1Standby.Text = freqs[1].ToString();
                    tbCOM2Active.Text = freqs[3].ToString();
                    tbCOM2Standby.Text = freqs[4].ToString();

                }
            }
        }

        private void bw_Done(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Debug("Data thread cancelled");
            }
            else if (!(e.Error == null))
            {
                Debug("Data thread error: " + e.Error.Message);
            }
            else
            {
                Debug("Data thread done");
            }

            tbCOM1Active.Text = "";
            tbCOM1Standby.Text = "";
            tbCOM2Active.Text = "";
            tbCOM2Standby.Text = "";

            mCompleted = true;
            if (mClosePending) this.Close();
        }

        private void Debug(string msg)
        {
            textBox1.AppendText(msg + "\r\n");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy != true)
            {
                Debug("Connecting");
                bw.RunWorkerAsync();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (bw.WorkerSupportsCancellation == true)
            {
                Debug("Disconnecting");
                bw.CancelAsync();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if ((bw.IsBusy) && !mCompleted)
            {
                bw.CancelAsync();
                this.Enabled = false;
                e.Cancel = true;
                mClosePending = true;
                return;
            }
            base.OnFormClosing(e);
        }

        private void btnSetCOM1Active_Click(object sender, EventArgs e)
        {
            if (tbSetCOM1Active.Text.Length == 5)
            {
                byte[] freq = BitConverter.GetBytes(float.Parse(tbSetCOM1Active.Text));

                UdpClient sendSocket = new UdpClient("127.0.0.1", 49000);

                byte[] selectPacket = new byte[] { 68, 65, 84, 65, 0, 96, 0, 0, 0, 0, 192, 121, 196, 0, 192, 121, 196, 0, 192, 121, 196, 0, 192, 121, 196, 0, 192, 121, 196, 0, 192, 121, 196, 0, 192, 121, 196, 0, 192, 121, 196 };
                freq.CopyTo(selectPacket, 9);
                Debug("Sending: " + string.Join(", ", selectPacket));
                try
                {
                    sendSocket.Send(selectPacket, selectPacket.Length);
                }
                catch (Exception) { }
            }
            else
            {
                Debug("Invalid input");
            }
        }
    }
}

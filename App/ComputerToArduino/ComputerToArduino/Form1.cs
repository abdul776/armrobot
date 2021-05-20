using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ComputerToArduino
{
    public partial class Form1 : Form

    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            getAvailableComPorts();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }

        #region Connect
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            } else
            {
                disconnectFromArduino();
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            button1.Text = "Disconnect";
            label1.Text = "Arduino Connected";
            ResetServos();
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            button1.Text = "Connect";
        }
        #endregion

        #region trackbar
        private void trackBarServo_0_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_0.Value;
            if (port.IsOpen)
            {
                labelServoPos_0.Text = "Degree: " + servoPos.ToString();
                SendServoInfo(0, servoPos);
            }
        }

        private void trackBarServo_1_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_1.Value;
            if(port.IsOpen)
            {
                labelServoPos_1.Text = "Degree: " + servoPos.ToString();
                SendServoInfo(1, servoPos);
            }
        }

        private void trackBarServo_2_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_2.Value;
            if (port.IsOpen)
            {
                labelServoPos_2.Text = "Degree: " + servoPos.ToString();
                SendServoInfo(2, servoPos);
            }
        }

        private void trackBarServo_3_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_3.Value;
            if (port.IsOpen)
            {
                labelServoPos_3.Text = "Degree: " + servoPos.ToString();
                SendServoInfo(3, servoPos);
            }
        }
        #endregion

        #region servo reset and update
        private void SendServoInfo(int channel, int pos)
        {
            string message = channel.ToString() + ':' + pos.ToString() + '*';

            try
            {
                port.Write(message);
            }
            catch
            {

            }
        }

        private void ResetServos()
        {
            int centrePosition = 90;
            trackBarServo_0.Value = centrePosition;
            trackBarServo_1.Value = 65;
            trackBarServo_2.Value = 65;
            trackBarServo_3.Value = 80;

            labelServoPos_0.Text = "Degree: " + centrePosition.ToString();
            labelServoPos_1.Text = "Degree: " + 65.ToString();
            labelServoPos_2.Text = "Degree: " + 65.ToString();
            labelServoPos_3.Text = "Degree: " + 80.ToString();

            for(int channel = 0; channel < 4; channel++)
            {
                SendServoInfo(channel, centrePosition);
            }
        }

        private void buttoResetServos_Click(object sender, EventArgs e)
        {
            ResetServos();
        }
        #endregion

        #region drag Form
        bool gerakin;
        int psMouseX, psMouseY;
        private void borderForm_MouseDown(object sender, MouseEventArgs e)
        {
            psMouseX = e.X;
            psMouseY = e.Y;
            gerakin = true;
        }

        private void borderForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (gerakin)
            {
                SetDesktopLocation(MousePosition.X-psMouseX, MousePosition.Y-psMouseY);
            }
        }

        private void borderForm_MouseUp(object sender, MouseEventArgs e)
        {
            gerakin = false;
        }
        #endregion

        #region button
        private void buttonMinimize_MouseEnter(object sender, EventArgs e)
        {
            buttonMinimize.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void buttonMinimize_MouseLeave(object sender, EventArgs e)
        {
            buttonMinimize.BackColor = Color.Transparent;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(252, 116, 116);
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Transparent;
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}

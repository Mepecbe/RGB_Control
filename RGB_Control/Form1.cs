using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace RGB_Control
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        SerialPort Serial = new SerialPort("COM5", 9600);

        public Form1()
        {
            InitializeComponent();
            Serial.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            /*
            Serial.WriteLine(colorDialog1.Color.R.ToString());
            //Thread.Sleep(5);
            Serial.WriteLine(colorDialog1.Color.G.ToString());
            //Thread.Sleep(5);
            Serial.WriteLine(colorDialog1.Color.B.ToString());*/
            Serial.Write(new byte[] { colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B }, 0, 3);
        }
    }
}

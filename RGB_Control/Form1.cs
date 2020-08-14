using MetroFramework;
using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cyotek.Windows.Forms;

namespace RGB_Control
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        byte[] rgb = new byte[3]; 
        SerialPort Serial = new SerialPort("COM5", 9600);
        
        public Form1()
        {
            InitializeComponent();

            try
            {
                Serial.Open();
                Label_State.Text = "ПОДКЛЮЧЕН";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка открытия порта\n " + ex.Message);

                new Task(() => 
                {
                    while (true) {
                        try
                        {
                            Serial.Open();
                            Label_State.Text = "ПОДКЛЮЧЕН";
                            break;
                        } 
                        catch 
                        {

                        }

                        Thread.Sleep(TimeSpan.FromSeconds(3));
                    }
                }).Start();
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            rgb = new byte[]{
                colorWheel1.Color.R,
                colorWheel1.Color.G,
                colorWheel1.Color.B  
            };
            
            Serial.Write(rgb, 0, 3);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //+1
            byte value = 10;

            if (rgb[0] + 10 <= 255)
                rgb[0] += value;

            if (rgb[1] + 10 <= 255)
                rgb[1] += value;

            if (rgb[2] + 10 <= 255)
                rgb[2] += value;


            Serial.Write(rgb, 0, 3);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //-1
            byte value = 10;

            if(rgb[0]-10 > 0)
                rgb[0] -= value;

            if (rgb[1] > 0)
                rgb[1] -= value;

            if (rgb[2] > 0)
                rgb[2] -= value;

            Serial.Write(rgb, 0, 3);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            int H = int.Parse(metroTextBox1.Text);
            byte S = byte.Parse(metroTextBox2.Text);
            byte V = byte.Parse(metroTextBox3.Text);

            float Hi = H / 60 % 6 ;
            float Vmin = ((100 - S) * V) / 100;
            float a = V - Vmin * ((H % 60) / 60);

            byte Vinc  = Convert.ToByte((Vmin + a) * 255/100);
            byte Vdec = Convert.ToByte((V - a) * 255 / 100);
            /*
            switch (Convert.ToByte(Hi))
            {
                case 0: { rgb = new byte[] { V, Vinc, Convert.ToByte(Vmin * 255 / 100) };  break; }
                case 1: { rgb = new byte[] { Vdec, V, Convert.ToByte(Vmin * 255 / 100) }; break; }
                case 2: { rgb = new byte[] { Convert.ToByte(Vmin * 255 / 100), V, Vinc }; break; }
                case 3: { rgb = new byte[] { Convert.ToByte(Vmin * 255 / 100), Vdec, V }; break; }
                case 4: { rgb = new byte[] { Vinc, Convert.ToByte(Vmin * 255 / 100), V }; break; }
                case 5: { rgb = new byte[] { V, Convert.ToByte(Vmin * 255 / 100), Vdec }; break; }
            }*/

            rgb = new byte[] { V, Vinc, Convert.ToByte(Vmin) };

            {
                MessageBox.Show($" r {rgb[0]} \n" +
                                $" g {rgb[1]}\n" +
                                $" b {rgb[2]}");

                Serial.Write(rgb, 0, 3);
            }
        }
    }
}

using MetroFramework;
using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cyotek.Windows.Forms;
using System.Runtime.CompilerServices;

namespace RGB_Control
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        byte[] rgb = new byte[3]; 
        SerialPort Serial = new SerialPort("COM5", 9600);
        
        public Form1()
        {
            InitializeComponent();

            RGB_Control.RgbContoller.OnConnect += OnConnSuccess;
            RGB_Control.RgbContoller.EnableProbeConnect();
        }

        public void OnConnSuccess()
        {
            Label_State.Text = "ПОДКЛЮЧЕН";
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            rgb = new byte[]{
                colorWheel1.Color.R,
                colorWheel1.Color.G,
                colorWheel1.Color.B  
            };

            Serial.Write(new byte[] { 1, rgb[0], rgb[1], rgb[2] }, 0, 4);
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

            Serial.Write(new byte[] { 1, rgb[0], rgb[1], rgb[2] }, 0, 4);
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

            Serial.Write(new byte[] { 1, rgb[0], rgb[1], rgb[2] }, 0, 4);
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

                Serial.Write(new byte[] { 1, rgb[0], rgb[1], rgb[2] }, 0, 4);
            }
        }


        private void OnReceive(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buff = new byte[3] { 0, 0, 0 };
            Serial.Read(buff, 0, 3);

            Switch1.Text       = buff[0].ToString();
            Switch2.Text       = buff[1].ToString();
            RezistorValue.Text = buff[2].ToString();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            Serial.Write(new byte[] { 1, 0, 0, 0 }, 0, 4);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //Режим 1
        }
    }



    /// <summary>
    /// 
    /// </summary>
    static class RGB_Control
    {
        public static class RgbContoller
        {
            public static event Action OnConnect;
            public static event Action OnDisconnect;
            public static event Action OnFailedConnect;

            public static SerialPort Serial = new SerialPort("COM5", 9600);

            public static void EnableProbeConnect()
            {
                new Task(() =>
                {
                    while (true)
                    {
                        try
                        {
                            Serial.Open();
                            OnDisconnect?.Invoke();
                            break;
                        }
                        catch
                        {
                            OnFailedConnect?.Invoke();
                        }

                        Thread.Sleep(TimeSpan.FromSeconds(3));
                    }
                }).Start();
            }
        }


        public static class Mode1
        {
            private static int[,] colors = new int[,] 
            {  
                { 100, 0, 000  }, //Красный
                { 100, 50, 000  }, //Оранжевый
                { 100, 100, 000  }, // Желтный
                { 000, 100, 000  }, //Зеленый
                { 000, 000, 100  }, //Синий
            };

            private static Random rnd = new Random();
            private static Task active;
            private static int sleep;

            public static void Enable(int AnimationDuration)
            {
                sleep = AnimationDuration;
            }


            private static void task()
            {
                int r = 0, g = 0, b = 0;
                int color = rnd.Next(0, colors.Length);

                for (;
                    r < colors[color, 0] &&
                    g < colors[color, 1] &&
                    b < colors[color, 2]; 
                    
                    r++, g++, b++)
                {
                    Thread.Sleep(sleep);

                }
            }
        }
    }
}

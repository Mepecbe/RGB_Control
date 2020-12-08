using MetroFramework;
using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using Cyotek.Windows.Forms;
using System.Runtime.CompilerServices;

namespace RGB_Control
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        
        public Form1()
        {
            InitializeComponent();

            RGB_Control.RgbContoller.OnConnect += OnConnSuccess;
            RGB_Control.RgbContoller.OnDisconnect += OnDisconnect;
            RGB_Control.RgbContoller.OnFailedConnect += OnFailedConnect;

            RGB_Control.RgbContoller.EnableProbeConnect();
        }

        #region RGB Controller events
        public void OnConnSuccess()
        {
            /*МЕТОД ВЫЗЫВАЕТ ДРУГОЙ ПОТОК!!!!*/
            this.BeginInvoke(new Action(() =>
            {
                Label_State.Text = "ПОДКЛЮЧЕН";
                this.timer1.Enabled = true;
            }));
        }

        public void OnFailedConnect()
        {
            /*МЕТОД ВЫЗЫВАЕТ ДРУГОЙ ПОТОК!!!!*/
            this.BeginInvoke(new Action(() =>
            {
                Label_State.Text = "НЕ ПОДКЛЮЧЕН(ОШИБКА)";
                this.timer1.Enabled = false;
            }));
        }

        public void OnDisconnect()
        {

        }
        #endregion
        #region Form events

        private void SetButton_Click(object sender, EventArgs e)
        {
            RGB_Control
                .RgbContoller
                     .SetRgb(
                            Convert.ToByte(R_TextBox.Text),
                            Convert.ToByte(G_TextBox.Text),
                            Convert.ToByte(B_TextBox.Text)
                     );
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Яркость +
            this.V_TextBox.Text = (Convert.ToDouble(this.V_TextBox.Text) + 0.1d).ToString();
            Btn_HSVtoRGB_Click(null, null);
            SetButton_Click(null, null);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //Яркость -
            this.V_TextBox.Text = (Convert.ToDouble(this.V_TextBox.Text) - 0.1d).ToString();
            Btn_HSVtoRGB_Click(null, null);
            SetButton_Click(null, null);
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            RGB_Control.RgbContoller.SetRgb(0, 0, 0);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //Режим 1
            RGB_Control.Mode1.Enable(3);
        }

        private void colorWheel1_ColorChanged(object sender, EventArgs e)
        {
            this.R_TextBox.Text = colorWheel1.Color.R.ToString();
            this.G_TextBox.Text = colorWheel1.Color.G.ToString();
            this.B_TextBox.Text = colorWheel1.Color.B.ToString();

            this.H_TextBox.Text = colorWheel1.Color.GetHue().ToString();
            this.S_TextBox.Text = colorWheel1.Color.GetSaturation().ToString();
            this.V_TextBox.Text = colorWheel1.Color.GetBrightness().ToString();
        }

        private void RGBHSV_PLUS(object sender, EventArgs e)
        {
            switch (((Button)sender).Name[7])
            {
                case 'R':
                    {
                        this.R_TextBox.Text = (Convert.ToInt32(this.R_TextBox.Text) + 1).ToString();
                        colorWheel1.Color = Color.FromArgb(Convert.ToInt32(R_TextBox.Text), Convert.ToInt32(G_TextBox.Text), Convert.ToInt32(B_TextBox.Text));
                        break;
                    }

                case 'G':
                    {
                        this.G_TextBox.Text = (Convert.ToInt32(this.G_TextBox.Text) + 1).ToString();
                        colorWheel1.Color = Color.FromArgb(Convert.ToInt32(R_TextBox.Text), Convert.ToInt32(G_TextBox.Text), Convert.ToInt32(B_TextBox.Text));
                        break;
                    }

                case 'B':
                    {
                        this.B_TextBox.Text = (Convert.ToInt32(this.B_TextBox.Text) + 1).ToString();
                        colorWheel1.Color = Color.FromArgb(Convert.ToInt32(R_TextBox.Text), Convert.ToInt32(G_TextBox.Text), Convert.ToInt32(B_TextBox.Text));
                        break;
                    }

                case 'H':
                    {
                        this.H_TextBox.Text = (Convert.ToDouble(this.H_TextBox.Text) + 0.1d).ToString();
                        break;
                    }

                case 'S':
                    {
                        this.S_TextBox.Text = (Convert.ToDouble(this.S_TextBox.Text) + 0.1d).ToString();
                        break;
                    }

                case 'V':
                    {
                        this.V_TextBox.Text = (Convert.ToDouble(this.V_TextBox.Text) + 0.1d).ToString();
                        break;
                    }
            }

            
        }

        private void RGBHSV_MINUS(object sender, EventArgs e)
        {
            switch (((Button)sender).Name[7])
            {
                case 'R':
                    {
                        this.R_TextBox.Text = (Convert.ToInt32(this.R_TextBox.Text) - 1).ToString();
                        colorWheel1.Color = Color.FromArgb(Convert.ToInt32(R_TextBox.Text), Convert.ToInt32(G_TextBox.Text), Convert.ToInt32(B_TextBox.Text));
                        break;
                    }

                case 'G':
                    {
                        this.G_TextBox.Text = (Convert.ToInt32(this.G_TextBox.Text) - 1).ToString();
                        colorWheel1.Color = Color.FromArgb(Convert.ToInt32(R_TextBox.Text), Convert.ToInt32(G_TextBox.Text), Convert.ToInt32(B_TextBox.Text));
                        break;
                    }

                case 'B':
                    {
                        this.B_TextBox.Text = (Convert.ToInt32(this.B_TextBox.Text) - 1).ToString();
                        colorWheel1.Color = Color.FromArgb(Convert.ToInt32(R_TextBox.Text), Convert.ToInt32(G_TextBox.Text), Convert.ToInt32(B_TextBox.Text));
                        break;
                    }

                case 'H':
                    {
                        this.H_TextBox.Text = (Convert.ToDouble(this.H_TextBox.Text) - 0.1d).ToString();
                        break;
                    }

                case 'S':
                    {
                        this.S_TextBox.Text = (Convert.ToDouble(this.S_TextBox.Text) - 0.1d).ToString();
                        break;
                    }

                case 'V':
                    {
                        this.V_TextBox.Text = (Convert.ToDouble(this.V_TextBox.Text) - 0.1d).ToString();
                        break;
                    }
            }
        }
        #endregion


        private void UpdateState_Tick(object sender, EventArgs e)
        {
            RGB_Control.RgbContoller.GetState();
            Thread.Sleep(10);

            this.Switch1.Text = RGB_Control.RgbContoller.Switch1.ToString();
            this.Switch2.Text = RGB_Control.RgbContoller.Switch2.ToString();
            this.RezistorValue.Text = RGB_Control.RgbContoller.Fotorezistor1.ToString();
        }

        private void RGB_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("RGB to HSV");

            
        }

        private void HSV_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("HSV to rgb");

            
        }

        private void Btn_RGBtoHSV_Click(object sender, EventArgs e)
        {
            double H = 0;
            double S = 0;
            double V = 0;

            RGB_Control
                .ColorConverter
                .RgbToHSV(
                    Convert.ToByte(R_TextBox.Text),
                    Convert.ToByte(G_TextBox.Text),
                    Convert.ToByte(B_TextBox.Text),
                    out H,
                    out S,
                    out V
                );

            this.H_TextBox.Text = H.ToString();
            this.S_TextBox.Text = S.ToString();
            this.V_TextBox.Text = V.ToString();
        }

        private void Btn_HSVtoRGB_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;

            RGB_Control
                .ColorConverter
                .HsvToRgb(
                    Convert.ToDouble(H_TextBox.Text),
                    Convert.ToDouble(S_TextBox.Text),
                    Convert.ToDouble(V_TextBox.Text),
                    out r, out g, out b
                );

            this.R_TextBox.Text = r.ToString();
            this.G_TextBox.Text = g.ToString();
            this.B_TextBox.Text = b.ToString();

            this.colorWheel1.Color = Color.FromArgb(r, g, b);
        }

        private void V_TextBox_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToDouble(V_TextBox.Text) >= 1d)
            {
                V_TextBox.Text = 1d.ToString();
            }
        }
    }
}

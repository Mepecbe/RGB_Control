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
        
        public Form1()
        {
            InitializeComponent();

            RGB_Control.RgbContoller.OnConnect += OnConnSuccess;
            RGB_Control.RgbContoller.OnFailedConnect += OnFailedConnect;

            RGB_Control.RgbContoller.EnableProbeConnect();
        }

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

        private void SetButton_Click(object sender, EventArgs e)
        {
            rgb = new byte[]{
                colorWheel1.Color.R,
                colorWheel1.Color.G,
                colorWheel1.Color.B  
            };

            RGB_Control
                .RgbContoller
                     .SetRgb(
                            colorWheel1.Color.R,
                            colorWheel1.Color.G,
                            colorWheel1.Color.B
                     );
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RGB_Control.RgbContoller.AddBrightness();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            RGB_Control.RgbContoller.SubBrightness();
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
                        RGB_Control.RgbContoller.R++;
                        break;
                    }

                case 'G':
                    {
                        RGB_Control.RgbContoller.G++;
                        break;
                    }

                case 'B':
                    {
                        RGB_Control.RgbContoller.B++;
                        break;
                    }

                case 'H':
                    {
                        RGB_Control.RgbContoller.H++;
                        break;
                    }

                case 'S':
                    {
                        RGB_Control.RgbContoller.S++;
                        break;
                    }

                case 'V':
                    {
                        RGB_Control.RgbContoller.V++;
                        break;
                    }
            }

            UpdateRGBHSV_Values();
        }

        private void RGBHSV_MINUS(object sender, EventArgs e)
        {
            switch (((Button)sender).Name[7])
            {
                case 'R':
                    {
                        RGB_Control.RgbContoller.R--;
                        break;
                    }

                case 'G':
                    {
                        RGB_Control.RgbContoller.G--;
                        break;
                    }

                case 'B':
                    {
                        RGB_Control.RgbContoller.B--;
                        break;
                    }

                case 'H':
                    {
                        RGB_Control.RgbContoller.H--;
                        break;
                    }

                case 'S':
                    {
                        RGB_Control.RgbContoller.S--;
                        break;
                    }

                case 'V':
                    {
                        RGB_Control.RgbContoller.V--;
                        break;
                    }
            }

            UpdateRGBHSV_Values();
        }

        public void UpdateRGBHSV_Values()
        {
            this.R_TextBox.Text = RGB_Control.RgbContoller.R.ToString();
            this.G_TextBox.Text = RGB_Control.RgbContoller.G.ToString();
            this.B_TextBox.Text = RGB_Control.RgbContoller.B.ToString();
            this.H_TextBox.Text = RGB_Control.RgbContoller.H.ToString();
            this.S_TextBox.Text = RGB_Control.RgbContoller.S.ToString();
            this.V_TextBox.Text = RGB_Control.RgbContoller.V.ToString();
        }

        private void UpdateState_Tick(object sender, EventArgs e)
        {
            this.Switch1.Text = RGB_Control.RgbContoller.Switch1.ToString();
            this.Switch2.Text = RGB_Control.RgbContoller.Switch2.ToString();
            this.RezistorValue.Text = RGB_Control.RgbContoller.Fotorezistor1.ToString();
        }
    }
}

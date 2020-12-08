using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

using System.IO.Ports;

namespace RGB_Control
{
    /// <summary>
    /// 
    /// </summary>
    static class RGB_Control
    {
        public static class ColorConverter
        {
            public static void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
            {
                double H = h;
                while (H < 0) { H += 360; };
                while (H >= 360) { H -= 360; };
                double R, G, B;
                if (V <= 0)
                { R = G = B = 0; }
                else if (S <= 0)
                {
                    R = G = B = V;
                }
                else
                {
                    double hf = H / 60.0;
                    int i = (int)Math.Floor(hf);
                    double f = hf - i;
                    double pv = V * (1 - S);
                    double qv = V * (1 - S * f);
                    double tv = V * (1 - S * (1 - f));
                    switch (i)
                    {

                        // Red is the dominant color

                        case 0:
                            R = V;
                            G = tv;
                            B = pv;
                            break;

                        // Green is the dominant color

                        case 1:
                            R = qv;
                            G = V;
                            B = pv;
                            break;
                        case 2:
                            R = pv;
                            G = V;
                            B = tv;
                            break;

                        // Blue is the dominant color

                        case 3:
                            R = pv;
                            G = qv;
                            B = V;
                            break;
                        case 4:
                            R = tv;
                            G = pv;
                            B = V;
                            break;

                        // Red is the dominant color

                        case 5:
                            R = V;
                            G = pv;
                            B = qv;
                            break;

                        // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.

                        case 6:
                            R = V;
                            G = tv;
                            B = pv;
                            break;
                        case -1:
                            R = V;
                            G = pv;
                            B = qv;
                            break;

                        // The color is not defined, we should throw an error.

                        default:
                            //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                            R = G = B = V; // Just pretend its black/white
                            break;
                    }
                }
                r = Clamp((int)(R * 255.0));
                g = Clamp((int)(G * 255.0));
                b = Clamp((int)(B * 255.0));
            }

            /// <summary>
            /// Clamp a value to 0-255
            /// </summary>
            private static int Clamp(int i)
            {
                if (i < 0) return 0;
                if (i > 255) return 255;
                return i;
            }

            public static void RgbToHSV(byte r, byte g, byte b, out double H, out double S, out double V)
            {
                Color color = Color.FromArgb(r, b, g);
                H = color.GetHue();
                S = color.GetSaturation();
                V = color.GetBrightness();
            }

        }

        public static class RgbContoller
        {
            public static Color ActiveColor;
            public static event Action OnConnect;
            public static event Action OnDisconnect;
            public static event Action OnFailedConnect;

            public static SerialPort Serial = new SerialPort("COM5", 9600);
            
            public static byte Switch1 { get; private set; }
            public static byte Switch2 { get; private set; }
            public static byte Fotorezistor1 { get; private set; }

            /// <summary>
            /// Включить попытки подключения к RGB контроллеру через Serial порт
            /// </summary>
            public static void EnableProbeConnect()
            {
                new Task(() =>
                {
                    while (true)
                    {
                        try
                        {
                            Serial.DataReceived += OnReceive;
                            Serial.Open();
                            OnConnect?.Invoke();

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

            /// <summary>
            /// Функция события, срабатывает при приходе данных в сериал порт
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private static void OnReceive(object sender, SerialDataReceivedEventArgs e)
            {
                byte[] buff = new byte[3];
                Serial.Read(buff, 0, 3);

                Switch1 = buff[0];
                Switch2 = buff[1];
                Fotorezistor1 = buff[2];
            }

            /// <summary>
            /// Установить RGB цвет ленты.
            /// </summary>
            /// <param name="r">Красный.</param>
            /// <param name="g">Зелёный.</param>
            /// <param name="b">Синий.</param>
            /// <param name="SaveInEeprom"></param>
            public static void SetRgb(byte r, byte g, byte b, bool SaveInEeprom = false)
            {
                ActiveColor = Color.FromArgb(r, g, b);
                
                if (SaveInEeprom)
                {
                    Serial.Write(new byte[] { 1, r, g, b }, 0, 4);
                }
                else
                {
                    Serial.Write(new byte[] { 0, r, g, b }, 0, 4);
                }
            }

            /// <summary>
            /// Отправить запрос на получение состояния тумблеров и фоторезистора
            /// </summary>
            public static void GetState()
            {
                Serial.Write(new byte[] { 2 }, 0, 1);
            }
        }


        public static class Mode1
        {
            private static byte[,] colors = new byte[,]
            {
                { 254, 1, 1  }, //Красный
                //{ 100, 50, 000  }, //Оранжевый
                //{ 100, 100, 000  }, // Желтный
                { 1, 254, 1  }, //Зеленый
                { 1, 1, 255  }, //Синий
            };

            private static Random rnd = new Random();
            private static Task active;
            private static int sleep;
            private static int prevColor;

            public static void Enable(int AnimationDuration)
            {
                sleep = AnimationDuration;

                active = new Task(() => task());
                active.Start();
            }

            private static void task()
            {
                Thread.Sleep(500);

                byte r = 0, g = 0, b = 0;
                int color = rnd.Next(0, colors.GetUpperBound(0) + 1);

                while (color == prevColor)
                {
                    color = rnd.Next(0, colors.GetUpperBound(0) + 1);
                }

                prevColor = color;

                Debug.WriteLine($"Выбран цвет {color} => {colors[color, 0]}, {colors[color, 1]}, {colors[color, 2]} ");

                //Плавное "увеличение яркости"
                while (r <= colors[color, 0] || g <= colors[color, 1] || b <= colors[color, 2])
                {
                    if (r <= colors[color, 0])
                    {
                        r++;
                    }

                    if (g <= colors[color, 1])
                    {
                        g++;
                    }

                    if(b <= colors[color, 2])
                    {
                        b++;
                    }

                    Thread.Sleep(sleep);

                    RGB_Control.RgbContoller.SetRgb(r, g, b);
                    Debug.WriteLine($"[UP] Установлен цвет {r}, {g}, {b}");
                }

                Debug.WriteLine($"ENDDD ");

                Thread.Sleep(500);

                //Плавное снижение яркости
                while (r > 0 || g > 0 || b > 0)
                {
                    if (r > 0)
                    {
                        r--;
                    }

                    if (g > 0)
                    {
                        g--;
                    }

                    if (b > 0)
                    {
                        b--;
                    }

                    Thread.Sleep(sleep);

                    RGB_Control.RgbContoller.SetRgb(r, g, b);
                    Debug.WriteLine($"[DOWN] Установлен цвет {r}, {g}, {b}");
                }


                active = new Task(task);
                active.Start();
            }
        }
    }
}



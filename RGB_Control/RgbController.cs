﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

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



        }

        public static class RgbContoller
        {
            public static event Action OnConnect;
            public static event Action OnDisconnect;
            public static event Action OnFailedConnect;

            public static SerialPort Serial = new SerialPort("COM5", 9600);

            public static byte R { get; set; }
            public static byte G { get; set; }
            public static byte B { get; set; }
            public static byte H { get; set; }
            public static byte S { get; set; }
            public static byte V { get; set; }

            public static byte Switch1 { get; private set; }
            public static byte Switch2 { get; private set; }
            public static byte Fotorezistor1 { get; private set; }

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

            private static void OnReceive(object sender, SerialDataReceivedEventArgs e)
            {
                byte[] buff = new byte[3];
                Serial.Read(buff, 0, 3);

                Switch1 = buff[0];
                Switch2 = buff[1];
                Fotorezistor1 = buff[2];

                Debug.WriteLine("[Serial] OnReceive ");
            }

            public static void SetRgb(byte r, byte g, byte b, bool SaveInEeprom = false)
            {
                R = r; G = g; B = b;

                if (SaveInEeprom)
                {
                    Serial.Write(new byte[] { 1, r, g, b }, 0, 4);
                }
                else
                {
                    Serial.Write(new byte[] { 0, r, g, b }, 0, 4);
                }
            }


            public static void AddBrightness()
            {
                //ColorConverter.



                //SetRgb(++R, ++B, ++G);
            }

            public static void SubBrightness()
            {
                SetRgb(--R, --B, --G);
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


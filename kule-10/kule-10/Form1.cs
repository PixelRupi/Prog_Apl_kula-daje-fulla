using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Media;

namespace kule_10
{
    public partial class Form1 : Form
    {
        public List<Kula> kulki = new List<Kula>();

        //obiekt zegara
        private System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();
        }


        public class Kula
        {
            Random randy = new Random();

            SoundPlayer boom = new SoundPlayer();
                        

            //pozycja 
            public float x;
            public float y;
            //promien
            public float r;
            // wektory
            public int vec_x = 1;
            public int vec_y = 1;

            public string color = "red";

            Panel scena;


            // konsturktor
            public Kula(Panel scena, float radius, float poz_x = 100f, float poz_y = 100f)
            { 
                this.scena = scena;
                r = radius;
                x = poz_x;
                y = poz_y;
            }

            public Kula(Panel scena)
            {
                this.scena = scena;
                r = (float)randy.Next(5, 25);
                x = (float)randy.Next((int)r, scena.Width - (int)r);
                y = (float)randy.Next((int)r, scena.Height - (int)r);
            }

            public void przesunObiekt(List<Kula> kulases)
            {
                x += (float)vec_x;
                y += (float)vec_y;
                Console.WriteLine("kula: x: " + x + " y: " + y);

                if (x <= r)
                {
                    vec_x *= -1;
                    boom.SoundLocation = "boom.wav";
                    boom.Play();
                } else if (x >= (scena.Width - r))
                {
                    vec_x *= -1;
                    boom.SoundLocation = "boom.wav";
                    boom.Play();
                }

                if (y <= r)
                {
                    vec_y *= -1;
                    boom.SoundLocation = "boom.wav";
                    boom.Play();
                } else if (y >= (scena.Height - r))
                {
                    vec_y *= -1;
                    boom.SoundLocation = "boom.wav";
                    boom.Play();
                }


                foreach (Kula kula in kulases)
                {
                    if (kula != this)
                    {
                        if (Math.Sqrt(Math.Pow(kula.x - x, 2)+Math.Pow(kula.y - y, 2)) <= kula.r + r)
                        {
                            vec_x *= -1;
                            vec_y *= -1;
                            boom.SoundLocation = "boom.wav";
                            boom.Play();
                        }
                    }
                }

            }


            public void rysujKule()
            {
                Graphics g = scena.CreateGraphics();

                Pen pen = new Pen(Color.Black, 5);
                pen.Color = Color.FromName(color);

                g.DrawEllipse(pen, x - r, y - r, r + r, r + r);
            }

        }

        /**
        Kula kula01 = new Kula()
        {
            x = 750f,
            y = 380f,
            r = 20f,
            color = "blue"
        };
        */
        

        
        public void czyszczenieEkranu()
        {
            SolidBrush filler_brush = new SolidBrush(Color.White);
            Rectangle clearing = new Rectangle(0, 0, panel_scena.Width, panel_scena.Height);
            Graphics g = panel_scena.CreateGraphics();
            g.FillRectangle(filler_brush, clearing);
        }
        
        
        /**
        public void rysujKule()
        {
            //rysowanie pierwszej kuli:
            Graphics g = panel1.CreateGraphics();

            Pen pen = new Pen(Color.Black, 5);
            pen.Color = Color.FromName(kula01.color);

            czyszczenieEkranu();
            g.DrawEllipse(pen, kula01.x - kula01.r, kula01.y - kula01.r, kula01.r+ kula01.r, kula01.r + kula01.r);
            kula01.przesunObiekt();


            //sprawdzanie, czy nie trzeba odwrocic wektora
            if (kula01.x <= (kula01.r))
            {
                kula01.vec_x *= -1;
            } else if (kula01.x >= (panel1.Width - kula01.r))
            {
                kula01.vec_x *= -1;
            }
            
            if (kula01.y <= (kula01.r))
            {
                kula01.vec_y *= -1;
            } else if (kula01.y >= (panel1.Height - kula01.r))
            {
                kula01.vec_y *= -1;
            } 
        }
        **/


        public  void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",e.SignalTime);
            //kurwa

            czyszczenieEkranu();
            foreach (Kula k in kulki)
            {
                k.rysujKule();
                k.przesunObiekt(kulki);
            }
        }


        public void button_start_Click(object sender, EventArgs e)
        {
            SetTimer();
            //kula01.rysujKule();
            //rysujKule();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            aTimer.Stop();
        }
        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            aTimer.Stop();
            kulki.Clear();
        }

        private void button_add_kula_Click(object sender, EventArgs e)
        {
            kulki.Add(new Kula(panel_scena));
        }

        private void button_sub_kula_Click(object sender, EventArgs e)
        {
            kulki.RemoveAt(kulki.Count - 1);
        }

        private void button_CHINA_Click(object sender, EventArgs e)
        {
            SoundPlayer music = new SoundPlayer();
            music.SoundLocation = "music.wav";
            music.Play();
        }
    }
}

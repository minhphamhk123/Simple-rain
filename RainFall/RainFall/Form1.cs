using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainFall
{
    public partial class Form_rain : Form
    {
        List<Rain> PR = new List<Rain>();
        Random ran = new Random();
        Rectangle rainDrop;
        Timer timeFall = new Timer();
        Timer timeFall2 = new Timer();
        SolidBrush RainDrop = new SolidBrush(Color.DeepSkyBlue);
        Graphics draw;
        bool Check = false;

        public Form_rain()
        {
            InitializeComponent();
            CreateGraphics();
            timeFall.Interval = 10;
            timeFall.Tick += TimeFall_Tick; ;
            timeFall.Start();
            timeFall2.Interval = 15;
            timeFall2.Tick += TimeFall2_Tick; ; ;
            timeFall2.Start();
        }

        private void TimeFall2_Tick(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void Form_rain_Load(object sender, EventArgs e)
        {
            //RainDrop = ;
            
        }

        private void TimeFall_Tick(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            for (int i =0; i < PR.Count; i ++)
            {
                ////for (int i = 0; i < PR.Count; i++)
                ////{
                //    if (PR[i].xucxac == 0)
                //    {
                //        PR[i].Draw(draw);
                //    }
                //    if (PR[i].xucxac == 1)
                //    {
                //        PR[i].Draw1(draw);
                //    }
                //    if (PR[i].xucxac == 2)
                //    {
                //        PR[i].Draw2(draw);
                //    }
                //    if (PR[i].xucxac == 3)
                //    {
                //        PR[i].Draw3(draw);
                //    }
                ////}
                PR[i].Y += 5;
                if (PR[i].Y >= Height)
                {
                    PR.RemoveAt(i);
                }
            }
            Refresh();
        }

        private void Form_rain_Paint(object sender, PaintEventArgs e)
        {
            //Rain r = new Rain(ran.Next(0,Width), 0, RainDrop);
            if ((Check == true) && (PR.Count > 0))
            {
                for (int i = 0; i < PR.Count; i++)
                {
                    if (PR[i].xucxac == 0)
                    {
                        PR[i].Draw(e.Graphics);
                    }
                    if (PR[i].xucxac == 1)
                    {
                        PR[i].Draw1(e.Graphics);
                    }
                    if (PR[i].xucxac == 2)
                    {
                        PR[i].Draw2(e.Graphics);
                    }
                    if (PR[i].xucxac == 3)
                    {
                        PR[i].Draw3(e.Graphics);
                    }
                }
            }
        }

        private void Form_rain_Click(object sender, EventArgs e)
        {

        }
        private void Form_rain_Shown(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Rain r = new Rain(ran.Next(0, 822), 0, RainDrop, ran.Next(0, 4));
            draw = CreateGraphics();
            rainDrop = new Rectangle(0, 0, 1, 1);
            draw.FillRectangle(RainDrop, rainDrop);
            Check = true;
            PR.Add(r);
        }
    }
}

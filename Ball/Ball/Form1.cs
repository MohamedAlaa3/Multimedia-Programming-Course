using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball
{
    public partial class Form1 : Form
    {
        public class actor
         {
            public int x, y;
         }
        public class rectangle
        {
            public int x, y, w, h;
        }
        List<actor> lc = new List<actor>();
        List<rectangle> lt = new List<rectangle>();
        actor pnn;
        rectangle pnn2,pnn3;
        Timer tt = new Timer();
        int tttick = 0,k=0,j=0,ct=0,o=0,k2=0,o2=0,ct2=0,w=0;
        Bitmap off;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load1;
            this.KeyDown += Form1_KeyDown;
            this.Paint += Form1_Paint;
            tt.Tick += Tt_Tick;
            tt.Start();
        }

        void drawdubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            drawscene(g2);
            g.DrawImage(off, 0, 0);
        }
        private void Tt_Tick(object sender, EventArgs e)
        {
            move();
            check();
            drawdubb(CreateGraphics());
        }
       void check()
       {
           for(int i=0;i<lt.Count;i++)
           {
               if(     lc[0].x >= lt[i].x
                  &&   lc[0].x <= lt[i].x+lt[i].w
                  &&   lc[0].y >= lt[i].y
                  &&   lc[0].y <= lt[i].y + lt[i].h  )
               {
                   w = 1;
               }
           }
       }
        void move()
        {

            if (ct <= 80)
            {
                lt[0].y += 5;
                ct++;
            }
           else if (ct >= 80&& ct<=130)
            {
                lt[0].x += 5;
                ct++;
            }
            else if(ct>=130 && ct<=211)
            {
                lt[0].y -= 5;
                ct++;
            }
            else if(ct>=211&& ct<=261)
            {
                lt[0].x-= 5;
                ct++;
            }
            else if(ct>=261)
            {
                ct = 0;
            }
            //////////////////////////////////////
            if(ct2<=80)
            {
                lt[1].y -= 5;
                ct2++;
            }
            else if(ct2>=80 && ct2<=130)
            {
                lt[1].x -= 5;
                ct2++;
            }
            else if(ct2>=130 && ct2<=211)
            {
                lt[1].y += 5;
                ct2++;
            }
            else if(ct2>=211 && ct2<=261)
            {
                lt[1].x -= 5;
                ct2++;
            }
            else if(ct2>=261)
            {
                ct2 = 0;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawdubb(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics g = CreateGraphics();
            switch(e.KeyCode)
            {
                case Keys.Right:
                    lc[0].x += 15;
                    break;
                case Keys.Left:
                    lc[0].x -= 15;
                    break;
                case Keys.Up:
                    lc[0].y -= 15;
                    break;
                case Keys.Down:
                    lc[0].y += 15;
                    break;
            }
        }

    //    void blockright()
    //    {
    //        if (lc[0].x > 200
    //             && lc[0].x<1260
    //             &&lc[0].y>300
    //             &&lc[0].y<700)
    //        {
    //            lc[0].x += 15;
    //        }
    //    }
        void drawscene(Graphics g)
        {
            if (w == 0)
            {

                g.Clear(Color.Gray);
                pnn = new actor();
                pnn.x = 250;
                pnn.y = 400;
                lc.Add(pnn);
                g.FillEllipse((Brushes.Red), lc[0].x, lc[0].y, 30, 30);
                pnn2 = new rectangle();
                pnn2.x = 500;
                pnn2.y = 100;
                pnn2.w = 250;
                pnn2.h = 200;
                lt.Add(pnn2);
                pnn3 = new rectangle();
                pnn3.x = 750;
                pnn3.y = 500;
                pnn3.w = 250;
                pnn3.h = 200;
                lt.Add(pnn3);
                g.FillRectangle((Brushes.Blue), lt[0].x , lt[0].y , lt[0].w, lt[0].h);
                g.FillRectangle((Brushes.Blue), lt[1].x , lt[1].y , lt[1].w, lt[1].h);
                g.DrawLine(new Pen(Color.Black, 10), 200, 500, 500, 500);
                g.DrawLine(new Pen(Color.Black, 10), 200, 300, 500, 300);
                g.DrawLine(new Pen(Color.Black, 10), 500, 300, 500, 100);
                g.DrawLine(new Pen(Color.Black, 10), 500, 700, 500, 500);
                g.DrawLine(new Pen(Color.Black, 10), 500, 700, 1000, 700);
                g.DrawLine(new Pen(Color.Black, 10), 1000, 700, 1000, 500);
                g.DrawLine(new Pen(Color.Black, 10), 1000, 100, 1000, 300);
                g.DrawLine(new Pen(Color.Black, 10), 1300, 300, 1000, 300);
                g.DrawLine(new Pen(Color.Black, 10), 1300, 500, 1000, 500);
                g.DrawLine(new Pen(Color.Black, 10), 1300, 300, 1300, 500);
                g.DrawLine(new Pen(Color.Black, 10), 200, 300, 200, 500);
                g.DrawLine(new Pen(Color.Black, 10), 1000, 100, 500, 100);
            }
           
        }
        private void Form1_Load1(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            pnn = new actor();
            pnn.x = 250;
            pnn.y = 400;
            lc.Add(pnn);
            g.FillEllipse((Brushes.Red), lc[0].x, lc[0].y, 30, 30);
            pnn2 = new rectangle();
            pnn2.x = 502;
            pnn2.y = 102;
            pnn2.w = 250;
            pnn2.h = 200;
            lt.Add(pnn2);
            pnn3 = new rectangle();
            pnn3.x = 748;
            pnn3.y = 498;
            pnn3.w = 250;
            pnn3.h = 200;
            lt.Add(pnn3);
            g.FillRectangle((Brushes.Blue), lt[0].x , lt[0].y , lt[0].w, lt[0].h);
            g.FillRectangle((Brushes.Blue), lt[1].x , lt[1].y , lt[1].w, lt[1].h);
            g.DrawLine(new Pen(Color.Black, 10),200, 500, 500, 500);
            g.DrawLine(new Pen(Color.Black, 10), 200, 300, 500, 300);
            g.DrawLine(new Pen(Color.Black, 10), 500, 300, 500, 100);
            g.DrawLine(new Pen(Color.Black, 10), 500, 700, 500, 500);
            g.DrawLine(new Pen(Color.Black, 10), 500, 700, 1000, 700);
            g.DrawLine(new Pen(Color.Black, 10), 1000, 700, 1000, 500);
            g.DrawLine(new Pen(Color.Black, 10), 1000, 100, 1000, 300);
            g.DrawLine(new Pen(Color.Black, 10), 1300, 300, 1000, 300);
            g.DrawLine(new Pen(Color.Black, 10), 1300, 500, 1000, 500);
            g.DrawLine(new Pen(Color.Black, 10), 1300, 300, 1300, 500);
            g.DrawLine(new Pen(Color.Black, 10), 200, 300, 200, 500);
            g.DrawLine(new Pen(Color.Black, 10), 1000, 100, 500, 100);
             off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
             drawdubb(g);
            
        }

    }
}

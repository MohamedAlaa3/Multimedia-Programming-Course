using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    class node
    {
        public int id, x, y, w, h;
        public int pos;
    }
    //List<node> L = new List<node>();

    public partial class Form1 : Form
    {                //gf.FillRectangle(Brushes.Gray, 200, 200, 30, 500);//x,y,width,hight

        public Graphics gf;
        public bool isDrag = false;
        public int lx, ly, x1 = 600, y1 = 700, lastmove = 0, lastid = 200, x2 = 1000, y2 = 700, lastid2 = 50, x3 = 200, y3 = 700, pos, c1 = 0, c2 = -1, c3 = -1;
        List<node> l = new List<node>();
        int a = -1;
        List<int> m = new List<int>();
        List<int> m2 = new List<int>();
        List<int> m3 = new List<int>();



        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
            m.Add(50);
            m2.Add(50);
            m3.Add(50);
        }





        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawScene(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateActors();
            DrawScene(CreateGraphics());

        }
        void DrawScene(Graphics gf)
        {
            gf.Clear(Color.Black);
            gf.FillRectangle(Brushes.Gray, 200, 200, 30, 500);//x,y,width,hight
            gf.DrawRectangle(Pens.White, 200, 200, 30, 500);
            gf.FillRectangle(Brushes.Pink, 600, 200, 30, 500);//1
            gf.DrawRectangle(Pens.White, 600, 200, 30, 500);
            gf.FillRectangle(Brushes.Blue, 1000, 200, 30, 500);//2
            gf.DrawRectangle(Pens.White, 1000, 200, 30, 500);
            for (int i = 0; i < l.Count; i++)
            {
                gf.FillRectangle(Brushes.Green, l[i].x, l[i].y, l[i].w, l[i].h);
                gf.DrawRectangle(Pens.White, l[i].x, l[i].y, l[i].w, l[i].h);
            }
        }
        void CreateActors()
        {
            int x = 135, y = 680, w = 200, h = 30;
            for (int i = 0; i < 8; i++)
            {
                node pnn = new node();
                pnn.x = x;
                pnn.y = y;
                pnn.w = w;
                pnn.h = h;
                pnn.id = i;
                pnn.pos = 1;
                l.Add(pnn);

                w -= 25;
                y -= h;
                x += 10;
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < l.Count; i++)
                {
                    if (e.X >= l[i].x && e.X <= (l[i].x + l[i].w)
                        && e.Y >= l[i].y && e.Y <= (l[i].y + l[i].w))
                    {
                        lx = l[i].x;
                        ly = l[i].y;
                        a = i;
                        pos = l[i].pos;
                        isDrag = true;
                        int min = 999999;
                        for (int k = 0; k < 8; k++)
                        {
                            if (min > l[k].id && 1 == l[k].pos)
                            {
                                min = l[k].id;
                                c1 = k;
                            }
                        }
                       // MessageBox.Show(c1 + "");
                        min = 999999;
                        for (int k = 0; k < 8; k++)
                        {
                            if (min > l[k].id && 2 == l[k].pos)
                            {
                                min = l[k].id;
                                c2 = k;
                            }
                        }
                        min = 999999;
                        for (int k = 0; k < 8; k++)
                        {
                            if (min > l[k].id && 3 == l[k].pos)
                            {
                                min = l[k].id;
                                c3 = k;
                            }
                        }
                    }
                    // MessageBox.Show(a + "");
                }
                DrawScene(CreateGraphics());
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int p = 0;
            if (isDrag == true)
            {
                if ((l[a].x >= 200 && l[a].x <= 230) && (l[a].y >= 200 && l[a].y <= 700))//1
                {
                    l[a].x = x3;
                    l[a].y = y3;
                    y3 -= l[a].h;
                    l[a].pos = 3;
                    p = 1;

                }
                if ((l[a].x >= 600 && l[a].x <= 630) && (l[a].y >= 200 && l[a].y <= 700))//2
                {

                    l[a].x = x1;
                    l[a].y = y1;
                    y1 -= l[a].h;
                    l[a].pos = 2;
                    p = 1;

                }
                // gf.FillRectangle(Brushes.Blue, 1000, 200, 30, 500);//2

                if ((l[a].x >= 1000 && l[a].x <= 1030) && (l[a].y >= 200 && l[a].y <= 700))//3
                {
                    l[a].x = x2;
                    l[a].y = y2;
                    y2 -= l[a].h;
                    l[a].pos = 3;

                    p = 1;
                }


                //            gf.FillRectangle(Brushes.Pink, 600, 200, 30, 500);//1
                //gf.FillRectangle(Brushes.Gray, 200, 200, 30, 500);//x,y,width,hight


                if (p == 0)
                {
                    l[a].x = lx;
                    l[a].y = ly;
                }
                isDrag = false;


            }
            DrawScene(CreateGraphics());

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag == true && (c1 == a || c2 == a || c3 == a))
            {
                 MessageBox.Show(c1 + ""+a);

                l[a].x = e.X;
                l[a].y = e.Y;
                lastmove = 1;
                DrawScene(CreateGraphics());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        Bitmap off;
        int cd = 0, dx, dy, dx2, dy2;
        public Graphics gf;
        Timer tt = new Timer();
        public class lines
        {
            public int X, X2, Y2, Y;
        }
        public class actor
        {
            public int X, Y, xx, yy;
            public Bitmap img;
        }
        List<lines> li = new List<lines>();
        List<lines> li2 = new List<lines>();
        actor tom = new actor();
        actor jerry = new actor();
        int s = 0;
        public bool isDrag = false;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
            tt.Tick += Tt_Tick;
            tt.Start();
            
            
        }

      

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag == true)
            {
                dx2 = e.X;
                dy2 = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            if (isDrag == true)
            {


                int a = 0;
                for (int i = 0; i < li.Count; i++)
                {
                    //MessageBox.Show(e.Y + " " + li[i].Y);//103,100
                    if (li[i].X <= e.X && li[i].X + 6 >= e.X &&
                        li[i].Y >= e.Y && li[i].Y - 150 <= e.Y)
                    {
                        //MessageBox.Show("1");
                        lines z = new lines();
                        z.X = dx;
                        z.Y = dy;
                        a = 1;
                        z.X2 = li[i].X;
                        z.Y2 = dy;
                        if(z.X2<z.X)
                        {
                            int b = z.X;
                            z.X = z.X2;
                            z.X2 = b;
                            
                        }
                        li2.Add(z);
                        s = 1;
                    }

                }
                if (a == 1)
                {
                    isDrag = false;
                }
                else
                {
                    cd = 0;
                }

            }
            isDrag = false;
        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            if (s == 1)
            {
                move();
            }
            DrawDubb(CreateGraphics());
            if(tom.Y + tom.img.Height==jerry.Y)
            {
                s = 0;
                if(tom.X==jerry.X)
                {
                    tt.Stop();

                    MessageBox.Show("w");

                }
                else
                {
                    tt.Stop();

                    MessageBox.Show("l");



                }
                tt.Stop();
            }
            
        }
        void move()
        {
            for (int i = 0; i < li2.Count; i++)
            {
                if (li2[i].X == tom.xx && li2[i].Y == tom.Y+tom.img.Height)
                {
                    //MessageBox.Show("sh");
                    tom.X +=100;
                    tom.xx += 100;
                    break;
                }
                if (li2[i].X+100 == tom.xx && li2[i].Y == tom.Y + tom.img.Height)
                {
                    //MessageBox.Show("sh2");
                    tom.X -= 100;
                    tom.xx -= 100;
                    break;
                }
            }
            tom.Y++;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (cd == 0)
            {

                int a = 0;
                for (int i = 0; i < li.Count; i++)
                {
                    //MessageBox.Show(e.Y + " " + li[i].Y);//103,100
                    if (li[i].X <= e.X && li[i].X + 6 >= e.X &&
                        li[i].Y >= e.Y && li[i].Y - 150 <= e.Y)
                    {
                        //MessageBox.Show("1");
                        
                        a = 1;
                        dx = li[i].X;
                        dy = e.Y;
                        cd++;
                    }

                }
                if (a == 1)
                {
                    isDrag = true;
                }
            }
            else
            {


            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                li.Clear();
                li2.Clear();
                CreateActors();
            }
        
            if (e.KeyCode == Keys.W)
            {
                s = 1;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawScene(e.Graphics);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            CreateActors();
            DrawScene(CreateGraphics());
        }
        void CreateActors()
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            Random rnd = new Random();
            int b = rnd.Next(2, 8);
            int x = 100;
            lines z = new lines();
            for (int i = 0; i < b; i++)
            {
                z.Y = this.Height / 2;
                z.X = x;
                li.Add(z);
                z = new lines();
                x += 100;
            }
            for (int k = 0; k < li.Count - 1; k++)
            {
                b = rnd.Next(1, 3);
                for (int m = 0; m < b; m++)
                {
                    z.X = li[k].X;
                    z.Y = rnd.Next(this.Height / 2 - 90, (this.Height / 2 - 90) + 140);
                    z.X2 = z.X + 100;
                    z.Y2 = z.Y;
                    li2.Add(z);
                    z = new lines();

                }

            }

            Bitmap img = new Bitmap("tom.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            tom.img = img;
            b = rnd.Next(0, li.Count);
            tom.X = li[b].X - 25;
            tom.Y = li[b].Y-150;
            tom.xx = li[b].X;
            tom.yy = li[b].Y;

            img = new Bitmap("jerry.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            jerry.img = img;
            b = rnd.Next(0, li.Count);
            jerry.X = li[b].X - 25;
            jerry.Y = (li[b].Y + 50);
        }
        void DrawScene(Graphics gf)
        {
            gf.Clear(Color.White);
            Random rnd = new Random();
            for (int i = 0; i < li.Count; i++)
            {
                gf.FillRectangle(Brushes.Black, li[i].X, this.Height / 2 - 100, 6, 150);//x,y,width,hight


            }
            for (int i = 0; i < li2.Count; i++)
            {
                Pen p2 = new Pen(Color.Red, 3);// ,width
                gf.DrawLine(p2, li2[i].X, li2[i].Y, li2[i].X2, li2[i].Y2);

            }
            if (isDrag)
            {
                Pen p = new Pen(Color.Red, 3);// ,width
                gf.DrawLine(p, dx, dy, dx2, dy2);//x1,y1,x2,y2
            }
            // gf.FillRectangle(Brushes.Red, 0, this.Height / 2 - 20, this.Width / 2 - 30, 15);//x,y,width,hight
            //Pen p = new Pen(Color.Red, 3);// ,width
            //gf.DrawLine(p, 60, 60, 60, 0);//x1,y1,x2,y2

            gf.DrawImage(tom.img, tom.X, tom.Y);
            gf.DrawImage(jerry.img, jerry.X, jerry.Y);


        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}

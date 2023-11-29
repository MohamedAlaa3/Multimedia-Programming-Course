using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        Bitmap off;
        public Graphics gf;

        Timer tt = new Timer();

        public class hil
        {
            public int X, Y;
            public Bitmap img;
        }
        public class mm
        {
            public int X, Y,m;
            public Bitmap img;
        }
        public class bird
        {
            public int X, Y, m,i;
            public List<Bitmap> img = new List<Bitmap>();
        }
        List<bird> birds = new List<bird>();
        hil h = new hil();
        List<mm> mms = new List<mm>();
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.MouseDown += Form1_MouseDown;
            tt.Tick += Tt_Tick;
            tt.Start();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                h.Y-=5;
              
            }
            if (e.KeyCode == Keys.Right)
            {
                h.X ++;
            }
            if (e.KeyCode == Keys.Left)
            {
                h.X--;
            }
            if (e.KeyCode == Keys.Space)
            {
                for (int i = 0; i < birds.Count; i++)
                {
                    if (birds[i].i == 1 )
                    {
                        birds[i].m = -1;
                        birds[i].Y = h.Y + 70;
                    }
                }
            }
        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            DrawDubb(CreateGraphics());
            hmove();
            bmove();

        }
        void hmove()
        {
            h.Y += 3;
            int a = 1;
            for (int i = 0; i < mms.Count; i++)
            {

                mms[i].X += a * mms[i].m;
                if (mms[i].X == 0)
                {
                    mms[i].m = 1;
                }
                if (mms[i].X + mms[i].img.Width == this.Width)
                {
                    mms[i].m = -1;
                }
            }
            //if (mms[0].X + mms[0].img.Width == mms[1].X)
            //{
            //    MessageBox.Show("0");
            //    mms[0].m *= -1;
            //    mms[1].m *= -1;
            //}
            //if (mms[1].X + mms[1].img.Width == mms[2].X)
            //{
            //    mms[2].m *= -1;
            //    mms[1].m *= -1;
            //}
            //if (mms[2].X + mms[2].img.Width == mms[3].X)
            //{
            //    mms[2].m *= -1;
            //    mms[3].m *= -1;
            //}


        }
        void bmove()
        {
            int a = 5;

            for (int i = 0; i < birds.Count; i++)
            {
                if (birds[i].m >= 0)
                {
                    birds[i].X = mms[birds[i].m].X + 10;
                    birds[i].Y = mms[birds[i].m].Y - 40;
                }
                if (birds[i].m == -1)
                {
                    birds[i].X = h.X + a;
                    a += 20;
                    birds[i].Y = h.Y + 70;
                }

                if ((birds[i].Y - h.Y <= 150 && birds[i].X >= h.X && birds[i].X < h.X + h.img.Width)
                    || (birds[i].Y - h.Y <= 150 && birds[i].X + birds[i].img[0].Width >= h.X && birds[i].X + birds[i].img[0].Width < h.X + h.img.Width))

                {
                    birds[i].i = 1;
                }
                else
                {
                    birds[i].i = 0;

                }
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

            
            Bitmap img = new Bitmap("1.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.img=img;
            h.X = this.Width / 2;
            h.Y = 0;
            int x = 0;
            int m = 1;
            for (int i = 0; i < 4; i++)
            {
                mm pnn = new mm();
                img = new Bitmap("2.bmp");
                img.MakeTransparent(img.GetPixel(0, 0));
                pnn.img = img;
                pnn.X = x;
                pnn.Y = this.Height - 100;
                pnn.m = m;
                m *= -1;
                x += this.Width / 4;
                mms.Add(pnn);
            }
            bird pnn2;
            for (int i = 0; i< 4; i++)
            { 
                 pnn2 = new bird();
                pnn2.i = 0;
                img = new Bitmap("3.bmp");
                img.MakeTransparent(img.GetPixel(0, 0));
                pnn2.img.Add(img);
                img = new Bitmap("4.bmp");
                img.MakeTransparent(img.GetPixel(0, 0));
                pnn2.img.Add (img);

                pnn2.m = i;
                birds.Add(pnn2);
            }
        }
        void DrawScene(Graphics gf)
        {
            gf.Clear(Color.Black);
            gf.DrawImage(h.img, h.X, h.Y);

            for (int i = 0; i < mms.Count; i++)
            {
                gf.DrawImage(mms[i].img, mms[i].X, mms[i].Y);
            }
            for (int i = 0; i < 4; i++)
            {
               
                gf.DrawImage(birds[i].img[birds[i].i], birds[i].X, birds[i].Y);

            }

            //gf.FillRectangle(Brushes.Red, 0, this.Height / 2 - 20, this.Width / 2 - 30, 15);//x,y,width,hight
            //Pen p = new Pen(Color.Red, 3);// ,width
            //gf.DrawLine(p, 60, 60, 60, 0);//x1,y1,x2,y2

        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}

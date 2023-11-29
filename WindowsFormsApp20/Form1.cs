using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        Bitmap off;
        public Random rnd2 = new Random();
        public int a = 0;
        public Graphics gf;

        Timer tt = new Timer();

        public class mea
        {
            public int X, Y;
            public List<Bitmap> imglist = new List<Bitmap>();
        }
        public class mea2
        {
            public int X, Y;
            public Bitmap img;
        }
        public class ball
        {
            public int X, Y;
            public Bitmap img;
        }
        public class monkey
        {
            public int X, Y;
            public List<Bitmap> imglist = new List<Bitmap>();
            public int ic;
        }
        public class hero
        {
            public int X, Y;
            public List<Bitmap> imglist = new List<Bitmap>();
            public int ic;
        }
        public monkey monkey1 = new monkey();
        public hero hero1 = new hero();
        public List<ball> balls = new List<ball>();
        public List<mea> meas = new List<mea>();
        public mea2 meas2 = new mea2();
        int timer1 = 0;
        int jump = 0, b = 0;
        int stop = 0;


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
            if (e.KeyCode == Keys.Right)
            {
                hero1.X += 3;
                if (hero1.ic == 0)
                {
                    hero1.ic = 1;
                }
                else
                {
                    hero1.ic = 0;

                }
            }
            if (e.KeyCode == Keys.Left)
            {
                hero1.X -= 3;
                if (hero1.ic == 0)
                {
                    hero1.ic = 1;
                }
                else
                {
                    hero1.ic = 0;

                }
            }
            if (e.KeyCode == Keys.Up && hero1.Y >= 600 - hero1.imglist[0].Height * 3)
            {
                hero1.Y -= 20;

                jump = 1;
            }
        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            timer1++;
            if (stop == 0)
            {
                DrawDubb(CreateGraphics());
            }
            
            if (jump == 1)
            {
                hero1.Y += 20;
            }
            if (hero1.Y == 600 - hero1.imglist[0].Height)
            {
                jump = 0;
            }
            if (a == 0)
            {
                monkey1.X += 5;
                monkey1.ic++;
                if (meas2.img.Width * 8 < monkey1.X)
                {
                    monkey1.X = meas2.img.Width * 8;
                    a = 1;
                }
               

            }
            if (a == 1)
            {
                monkey1.X -= 5;
                monkey1.ic--;
                if (0 > monkey1.X)
                {
                    monkey1.X = 0;
                    a = 0;
                }
              



            }
            if (stop == 0)
            {


                balldown();
            }
            if (monkey1.ic == -1)
            {

                monkey1.ic = 0;
            }
            if (monkey1.ic == 4)
            {
                monkey1.ic = 3;
            }
            if (b == 0)
            {
                ball pnn3 = new ball();
                Bitmap img = new Bitmap("7.bmp");
                img.MakeTransparent(img.GetPixel(0, 0));
                pnn3.X = monkey1.X + (monkey1.imglist[monkey1.ic].Width / 2);
                pnn3.Y = 0;
                pnn3.img = img;
                balls.Add(pnn3);
            }
            Random rnd = new Random();
            b = rnd.Next(0, 10);
        }
        void balldown()
        {
            for (int k = 0; k < balls.Count; k++)
            {
                int count = 0;
                if (balls[k].Y == 200 &&
                    balls[k].X >= meas[0].X &&
                    balls[k].X <=
                   meas[0].X + (meas[0].imglist.Count * meas[0].imglist[0].Width))
                {
                    balls[k].X -= 5;
                    count++;
                }
                if (balls[k].Y == 400 &&
                    balls[k].X >= meas[1].X &&
                    balls[k].X <=
                   meas[1].X + (meas[1].imglist.Count * meas[1].imglist[0].Width))
                {
                    balls[k].X+=5;
                    count++;
                }
                if (balls[k].Y == 600&&
                    balls[k].X >= meas[2].X &&
                    balls[k].X <=
                   meas[2].X + (meas[2].imglist.Count * meas[2].imglist[0].Width))
                {
                    balls[k].X -= 5;
                    
                    count++;
                    if (balls[k].X >= hero1.X && balls[k].X <= hero1.X + hero1.imglist[0].Width )
                    {
                        if (hero1.Y == 600 - hero1.imglist[0].Height)
                        {
                            stop = 1;
                            MessageBox.Show("game over");
                        } }
                }
                if (count == 0)
                {

                    balls[k].Y += 5;
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


            Bitmap img = new Bitmap("8.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            mea pnn = new mea();
            for (int i = 0; i < 8; i++)
            {
                pnn.imglist.Add(img);
            }
            pnn.X = 100;
            pnn.Y = 200;
            meas.Add(pnn);

            pnn = new mea();
            for (int i = 0; i < 12; i++)
            {
                pnn.imglist.Add(img);
            }
            pnn.X = 0;
            pnn.Y = 400;
            meas.Add(pnn);

            pnn = new mea();
            for (int i = 0; i < 14; i++)
            {
                pnn.imglist.Add(img);
            }
            pnn.X = 50;
            pnn.Y = 600;
            meas.Add(pnn);



            img = new Bitmap("1.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            monkey1.imglist.Add(img);
            img = new Bitmap("2.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            monkey1.imglist.Add(img);
            img = new Bitmap("3.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            monkey1.imglist.Add(img);
            img = new Bitmap("4.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            Random rnd = new Random();
            b = rnd.Next(0, 100);
            monkey1.imglist.Add(img);
            monkey1.ic = 2;
            monkey1.Y = 0;
            monkey1.X = b;

            img = new Bitmap("9.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            meas2.img = img;
            meas2.Y = monkey1.imglist[2].Height;
            meas2.X = 0;

            img = new Bitmap("5.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            hero1.imglist.Add(img);
            img = new Bitmap("6.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            hero1.imglist.Add(img);
            hero1.ic = 0;
            hero1.X = 50;
            hero1.Y = 600 - hero1.imglist[0].Height;
        }
        void DrawScene(Graphics gf)
        {
            gf.Clear(Color.White);
            /* gf.FillRectangle(Brushes.Red, 0, this.Height / 2 - 20, this.Width / 2 - 30, 15);//x,y,width,hight
             Pen p = new Pen(Color.Red, 3);// ,width
             gf.DrawLine(p,  60, 60,60, 0);//x1,y1,x2,y2*/
            for (int i = 0; i < meas.Count; i++)
            {
                float x = meas[i].X, y = meas[i].Y;
                for (int k = 0; k < meas[i].imglist.Count; k++)
                {
                    gf.DrawImage(meas[i].imglist[k], x, y);
                    x += meas[i].imglist[i].Width;

                }


            }
            int m = 0;
            for (int k = 0; k < balls.Count; k++)
            {
                gf.DrawImage(balls[k].img, balls[k].X, balls[k].Y);

            }
            for (int i = 0; i < 8; i++)
            {
                gf.DrawImage(meas2.img, meas2.X + m, meas2.Y);
                m += meas2.img.Width;
            }
            gf.DrawImage(monkey1.imglist[monkey1.ic], monkey1.X, monkey1.Y);
            gf.DrawImage(hero1.imglist[hero1.ic], hero1.X, hero1.Y);

        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}

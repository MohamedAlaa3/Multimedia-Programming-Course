using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{

    public partial class Form1 : Form
    {
        Bitmap off;
        Maky m = new Maky();

        public class Maky
        {
            public int X, Y;
            public List<Bitmap> imgLst = new List<Bitmap>();
            public int iCurrFrame;
        }
        public class ball
        {
            public int X, Y;
            public Bitmap img;
        }
        public class coin
        {
            public int X, Y;
            public Bitmap img;
        }
        public Graphics gf;
        Timer tt = new Timer();
        List<ball> b = new List<ball>();
        List<ball> b2 = new List<ball>();

        List<coin> coins = new List<coin>();
        ball pnn;
        coin pnn2;
        bool bo = true;

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
            this.KeyDown += Form1_KeyDown;
            tt.Tick += Tt_Tick;
            tt.Start();
        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("dkfhlds");
            DrawDubb(CreateGraphics());


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                //MessageBox.Show(m.iCurrFrame + "");
                m.iCurrFrame = 0;
            }
            if (e.KeyCode == Keys.D)
            {
                m.iCurrFrame = 1;
            }
            if (e.KeyCode == Keys.S)
            {
                m.iCurrFrame = 2;
            }
            if (e.KeyCode == Keys.A)
            {
                m.iCurrFrame = 3;
            }
            if (e.KeyCode == Keys.Space)
            {
                b[0].X += 5;
                b[1].X += 5;
                b[2].X -= 5;
                b[3].X -= 5;
                if (b[0].X + b[0].img.Width >= m.X || b[1].X + b[1].img.Width >= m.X || b[2].X + b[2].img.Width <= m.X + m.imgLst[m.iCurrFrame].Width || b[3].X + b[3].img.Width <= m.imgLst[m.iCurrFrame].Width)
                {
                    bo = false;
                }

            }
            DrawDubb(CreateGraphics());
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(bo ==false)
            {
                for (int i = 0; i < coins.Count; i++)
                {
                    if (e.X>=coins[i].X&& e.X<=coins[i].X+coins[i].img.Width &&
                        e.Y >= coins[i].Y && e.Y <= coins[i].Y + coins[i].img.Height
                        )
                    {
                        Random rnd = new Random();

                        pnn = new ball();
                        Bitmap img = new Bitmap("e1.bmp");
                        img.MakeTransparent(img.GetPixel(0, 0));
                        pnn.img = img;
                        if(i==0)
                        {
                            pnn.Y = this.Height / 2 - 37;
                            coins[i].X = rnd.Next(this.Width / 2 + 50, this.Width - 20);

                        }
                        if (i == 1)
                        {
                            pnn.Y = this.Height / 2 - 37;
                            coins[i].X = rnd.Next(0, this.Width / 2 - 40);

                        }
                        if (i == 2)
                        {
                            pnn.Y = this.Height / 2 +5;
                            coins[i].X = rnd.Next(this.Width / 2 + 50, this.Width - 20);

                        }
                        if (i == 3)
                        {
                            pnn.Y = this.Height / 2 +5;
                            coins[i].X = rnd.Next(0, this.Width / 2 - 30);

                        }
                        pnn.X = coins[i].X;
                        b2.Add(pnn);
                    }

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
        void DrawScene(Graphics gf)
        {
            gf.Clear(Color.Black);
            gf.FillRectangle(Brushes.Red, 0, this.Height / 2 - 20, this.Width / 2 - 30, 15);//x,y,width,hight
            gf.FillRectangle(Brushes.Red, 0, this.Height / 2 + 20, this.Width / 2 - 30, 15);//x,y,width,hight
            gf.FillRectangle(Brushes.Red, this.Width / 2 + 50, this.Height / 2 - 20, this.Width / 2 - 50, 15);//x,y,width,hight
            gf.FillRectangle(Brushes.Red, this.Width / 2 + 50, this.Height / 2 + 20, this.Width / 2 - 50, 15);//x,y,width,hight
            //CreateActors();
            //MessageBox.Show(m.iCurrFrame + "");
            gf.DrawImage(m.imgLst[m.iCurrFrame], m.X, m.Y);
            if (bo)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    gf.DrawImage(b[i].img, b[i].X, b[i].Y);
                }
            }
            else
            {


                for (int i = 0; i < coins.Count; i++)
                {
                    gf.DrawImage(coins[i].img, coins[i].X, coins[i].Y);
                }
                for (int i = 0; i < b2.Count; i++)
                {
                    gf.DrawImage(b2[i].img, b2[i].X, b2[i].Y);
                }

            }
        }
        void CreateActors()
        {
            //maky
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            Bitmap img = new Bitmap("1.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            m.imgLst.Add(img);
            img = new Bitmap("2.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            m.imgLst.Add(img);
            img = new Bitmap("3.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            m.imgLst.Add(img);
            img = new Bitmap("4.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            m.imgLst.Add(img);
            /*img = new Bitmap("4.bmp");
            m.imgLst.Add(img);*/
            m.X = this.Width / 2 - 25;
            m.Y = this.Height / 2 - 20;

            //balls
            Random rnd = new Random();

            pnn = new ball();
            img = new Bitmap("e1.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            pnn.img = img;
            pnn.Y = this.Height / 2 - 37;
            pnn.X = rnd.Next(0, this.Width / 2 - 30);
            b.Add(pnn);

            pnn = new ball();
            img = new Bitmap("e2.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            pnn.img = img;
            pnn.Y = this.Height / 2 + 5;
            pnn.X = rnd.Next(0, this.Width / 2 - 30);
            b.Add(pnn);

            pnn = new ball();
            img = new Bitmap("e3.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            pnn.img = img;
            pnn.Y = this.Height / 2 + 5;
            pnn.X = rnd.Next(this.Width / 2 + 50, this.Width);
            b.Add(pnn);

            pnn = new ball();
            img = new Bitmap("e1.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            pnn.img = img;
            pnn.Y = this.Height / 2 - 37;
            pnn.X = rnd.Next(this.Width / 2 + 50, this.Width);
            b.Add(pnn);

            //coins
            pnn2 = new coin();
            img = new Bitmap("c1.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            pnn2.img = img;
            pnn2.X = rnd.Next(this.Width / 2 + 50, this.Width - 20);
            pnn2.Y = rnd.Next(0, this.Height / 2 - 37);
            coins.Add(pnn2);

            pnn2 = new coin();
            img = new Bitmap("c2.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            pnn2.img = img;
            pnn2.X = rnd.Next(0, this.Width / 2 - 40);
            pnn2.Y = rnd.Next(0, this.Height / 2 - 40);
            coins.Add(pnn2);

            pnn2 = new coin();
            img = new Bitmap("c3.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            pnn2.img = img;
            pnn2.X = rnd.Next(this.Width / 2 + 50, this.Width - 20);
            pnn2.Y = rnd.Next(this.Height / 2 + 20, this.Height - 20);
            coins.Add(pnn2);

            pnn2 = new coin();
            img = new Bitmap("c4.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            pnn2.img = img;
            pnn2.X = rnd.Next(0, this.Width / 2 - 30);
            pnn2.Y = rnd.Next(this.Height / 2 + 20, this.Height - 20);

            coins.Add(pnn2);
        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }

    }

}
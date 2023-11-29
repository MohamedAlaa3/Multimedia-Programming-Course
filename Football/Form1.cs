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

        Timer tt = new Timer();
        public class ball
        {
            public float X, Y;
            public Bitmap img;
        }
        public class hero

        {
            public float X, Y;
            public List<Bitmap> imags = new List<Bitmap>();
            public int iCurrFrame;
            public bool ba;
            public ball b;
        }
        hero h = new hero();
        List<ball> b1 = new List<ball>();
        List<ball> b2 = new List<ball>();
        ball b;

        public Graphics gf;

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown1;
            tt.Tick += Tt_Tick;
            tt.Start();


        }

        private void Form1_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                // MessageBox.Show("dd");
                h.iCurrFrame--;
                h.Y--;
            }
            if (e.KeyCode == Keys.D)
            {
                h.X++;
            }
            if (e.KeyCode == Keys.S)
            {
                h.iCurrFrame++;
                h.Y++;
            }
            if (e.KeyCode == Keys.A)
            {
                h.X--;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (h.ba == false)
                {
                    //gf.FillRectangle(Brushes.Red, this.Width / 2 - 200, 0, 400, 150);//x,y,width,hight
                    //gf.FillRectangle(Brushes.Blue, this.Width / 2 - 200, this.Height - 150, 400, 150);//x,y,width,hight
                    if ((h.X >= this.Width / 2 - 200 && h.X <= this.Width + 200 && h.Y >= this.Height - 150 && h.Y <= this.Height) ||
                        (h.X + h.imags[h.iCurrFrame].Width >= this.Width / 2 - 200 && h.X+h.imags[h.iCurrFrame].Width <= this.Width + 200 && h.Y + h.imags[h.iCurrFrame].Height >= this.Height - 150 && h.Y + h.imags[h.iCurrFrame].Height <= this.Height)
                        )
                    {
                        h.ba = true;
                        h.b = b1[b1.Count - 1];
                        b1.RemoveAt(b1.Count - 1);
                    }
                }
                if (h.ba == true)
                {
                    //gf.FillRectangle(Brushes.Red, this.Width / 2 - 200, 0, 400, 150);//x,y,width,hight
                    //gf.FillRectangle(Brushes.Blue, this.Width / 2 - 200, this.Height - 150, 400, 150);//x,y,width,hight
                    if ((h.X >= this.Width / 2 - 200 && h.X <= this.Width + 200 && h.Y >= 0 && h.Y <= 400) ||
                        (h.X + h.imags[h.iCurrFrame].Width >= this.Width / 2 - 200 && h.X + h.imags[h.iCurrFrame].Width <= this.Width + 200 && h.Y + h.imags[h.iCurrFrame].Height >= 0 && h.Y + h.imags[h.iCurrFrame].Height <= 400)
                        )
                    {
                        h.ba = false;
                        b2.Add(h.b);
                        h.b = null;

                    }
                }
            }
            if (h.iCurrFrame > 7)
            {
                h.iCurrFrame = 0;
            }
            if (h.iCurrFrame < 0)
            {
                h.iCurrFrame = 7;
            }
            if (h.X > this.Width)
            {
                h.X = this.Width;
            }
            if (h.X < this.Location.X)
            {
                h.X = 0;
            }
            if (h.X > this.Height)
            {
                h.X = this.Height;
            }
            if (h.X < this.Location.Y)
            {
                h.X = 0;
            }

        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            DrawDubb(CreateGraphics());
        }

        private void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
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

        private void DrawScene(Graphics gf)
        {
            gf.Clear(Color.Black);
            gf.FillRectangle(Brushes.Red, this.Width / 2 - 200, 0, 400, 150);//x,y,width,hight
            gf.FillRectangle(Brushes.Blue, this.Width / 2 - 200, this.Height - 150, 400, 150);//x,y,width,hight
            for (int i = 0; i < b1.Count; i++)
            {
                gf.DrawImage(b1[i].img, b1[i].X, b1[i].Y);

            }
            for (int i = 0; i < b2.Count; i++)
            {
                gf.DrawImage(b2[i].img, b2[i].X, b2[i].Y);

            }
            gf.DrawImage(h.imags[h.iCurrFrame], h.X, h.Y);
            if (h.ba)
            {
                h.b.X = h.X;
                h.b.Y = h.Y;
                gf.DrawImage(h.b.img, h.X, h.Y);

            }

        }

        void CreateActors()
        {
            //maky
            float lx = this.Width / 2 - 200 + 10, ly = this.Height - 150 + 10;
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            Bitmap img = new Bitmap("ball2.bmp");
            for (int i = 0; i < 5; i++)
            {
                b = new ball();

                img.MakeTransparent(img.GetPixel(0, 0));
                b.img = img;
                b.X = lx;
                b.Y = ly;
                lx += img.Width;
                b1.Add(b);
            }
            ly += img.Height + 10;
            lx = this.Width / 2 - 200 + 10;
            for (int i = 0; i < 3; i++)
            {
                b = new ball();

                img.MakeTransparent(img.GetPixel(0, 0));
                b.img = img;
                b.X = lx;
                b.Y = ly;
                lx += img.Width;
                b1.Add(b);


            }
            img = new Bitmap("w1.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.imags.Add(img);
            img = new Bitmap("w2.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.imags.Add(img);
            img = new Bitmap("w3.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.imags.Add(img);
            img = new Bitmap("w4.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.imags.Add(img);
            img = new Bitmap("w4.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.imags.Add(img);
            img = new Bitmap("w5.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.imags.Add(img);
            img = new Bitmap("w6.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.imags.Add(img);
            img = new Bitmap("w7.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.imags.Add(img);
            img = new Bitmap("w8.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.imags.Add(img);
            h.X = this.Width / 2;
            h.Y = this.Height / 2;
            h.ba = false;



        }
    }
}

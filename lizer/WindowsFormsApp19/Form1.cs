using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        Bitmap off;
        public class star
        {
            public int X, Y;
            public Bitmap img;
        }
        public class hero
        {
            public int X, Y, move;
            public Bitmap img;
        }
        public Graphics gf;

        List<star> stars = new List<star>();
        hero h = new hero();
        Timer tt = new Timer();
        int a = 5;
        int count = 0, count2 = 0, count3 = 0,flag=0;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            tt.Tick += Tt_Tick;
            tt.Start();
        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 20 == 0)
            {
                CreateStars();
            }
            move();
            DrawDubb(CreateGraphics());
        }
        void CreateStars()
        {
            star s = new star();
            Bitmap img = new Bitmap("1.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            s.img = img;
            s.Y = 0;
            Random rnd = new Random();
            s.X = rnd.Next(0, this.Width);
            stars.Add(s);


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                if (h.move == 1)
                {
                    a++;
                }
                else
                {
                    a = 5;
                }
                h.move = 1;
            }
            if (e.KeyCode == Keys.Enter)
            {
                flag = 1;
            }
            if (e.KeyCode == Keys.A)
            {
                if (h.move == 2)
                {
                    a++;
                }
                else
                {
                    a = 5;
                }
                    h.move = 2;
            }
        }
        public void move()
        {
            if (h.move == 1)
            {
                h.X += a;
            }
            if (h.move == 2)
            {
                h.X -= a;
            }
            if (h.X + h.img.Width > this.Width)
            {
                h.X = this.Width - h.img.Width;
            }
            if (h.X < 0)
            {
                h.X = 0;
            }
            for (int i = 0; i < stars.Count; i++)
            {
                stars[i].Y++;
                if (count2 % 6 == 0)
                {
                    //MessageBox.Show(count2 + "  "+count3 + "");
                    if (count3 % 2 == 0)
                    {
                        stars[i].X += 2;
                    }
                    else
                    {
                        stars[i].X -= 2;
                    }
                    count3++;

                }
            }
            count2++;

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          DrawScene(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            CreateActors();
            CreateStars();
        }
        void CreateActors()
        {
            Bitmap img = new Bitmap("2.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.img = img;
            h.X = this.Width / 2 - h.img.Width / 2;
            h.Y = this.Height - (h.img.Height + 40);
            h.move = 0;
            //

        }
        void DrawScene(Graphics gf)
        {
            gf.Clear(Color.Black);
            gf.DrawImage(h.img, h.X, h.Y);
            Pen p = new Pen(Color.Red,3);
            if (flag==1)
            {
                gf.DrawLine(p, h.X + (h.img.Width) / 2, h.Y, h.X + (h.img.Width) / 2, 0);
            }
           
            for (int i = 0; i < stars.Count; i++)
            {
                gf.DrawImage(stars[i].img, stars[i].X, stars[i].Y);
                if (h.X + (h.img.Width )/2>=stars[i].X&& h.X + (h.img.Width) / 2 <= stars[i].X+stars[i].img.Width&& flag == 1)
                {
                    stars.RemoveAt(i);

                }
            }
            flag = 0;
          
        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}

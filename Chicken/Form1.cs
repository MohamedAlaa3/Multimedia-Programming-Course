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
        Timer tt = new Timer();
        bool drag = false;
        Bitmap off;
        int a = -1;
        public Graphics gf;
        public class chk
        {
            public int X, Y;
            public Bitmap img;
        }
        public class bbb
        {
            public int X, Y;
            public Bitmap img;
            public List<egg> myeggs = new List<egg>();
        }
        public class egg
        {
            public int X, Y, id;
            public Bitmap img;
        }
        List<egg> eggs = new List<egg>();
        List<bbb> b = new List<bbb>();
        chk ch = new chk();
        egg E;
        Bitmap img;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            tt.Tick += Tt_Tick;
            tt.Start();
            this.MouseDown += Form1_MouseDown;

            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {

                b[a].X = e.X;
                b[a].Y = e.Y;

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            a = -1;
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    if (e.X >= b[i].X && e.X <= (b[i].X + b[i].img.Width)
                        && e.Y >= b[i].Y && e.Y <= (b[i].Y + b[i].img.Height))
                    {
                        //MessageBox.Show(i + "");
                        a = i;
                        drag = true;
                        break;
                    }
                }
            }
        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            DrawDubb(CreateGraphics());

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                ch.X -= 3;
            }
            if (e.KeyCode == Keys.D)
            {
                ch.X += 3;
            }
            if (e.KeyCode == Keys.Enter)
            {
                E = new egg();
                img = new Bitmap("3.bmp");
                img.MakeTransparent(img.GetPixel(0, 0));
                E.img = img;
                int flag = 0, f2 = 0, f3 = 0;

                for (int i = 0; i < b.Count; i++)
                {
                    if ((ch.X + ch.img.Width / 2)  <= b[i].X + b[i].img.Width && (ch.X + ch.img.Width / 2)  >= b[i].X)
                    {
                        //MessageBox.Show(  "1");
                        f3 = 1;
                        E.id = ((ch.X + ch.img.Width) / 2) % (b[i].img.Width / 5);
                        for (int k = 0; k < b[i].myeggs.Count; k++)
                        {
                            if (E.id == b[i].myeggs[k].id)
                            {
                                f2 = 1;
                            }
                        }
                        if (f2 == 0)
                        {
                            for (int l = 0; l < 5; l++)
                            {

                                int z = 0;
                                for (int K = 0; K < b[i].myeggs.Count; K++)
                                {
                                    if (b[i].myeggs[K].id == l)
                                    {
                                        z = 1;
                                        break;
                                    }
                                }
                                if (z == 0)
                                {
                                    E.id = l;
                                    break;
                                }
                            }

                        }
                        if (b[i].myeggs.Count < 5)
                        {
                            b[i].myeggs.Add(E);
                            
                        }
                        else
                        {
                            f3 = 0;
                        }
                    }
                }
                if (f3 == 0)
                {
                    E.X = ch.X;
                    E.Y = this.Height - 50;
                    eggs.Add(E);
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
            //maky
            /*
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
            m.imgLst.Add(img);*/
            /*img = new Bitmap("4.bmp");
            m.imgLst.Add(img);*/

            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            img = new Bitmap("1.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            ch.img = img;
            ch.X = this.Width / 2;
            ch.Y = 20;

            //b
            bbb b1 = new bbb();
            img = new Bitmap("2.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            b1.img = img;
            b1.X = this.Width / 2;
            b1.Y = this.Height / 2;
            b.Add(b1);

            b1 = new bbb();
            img = new Bitmap("2.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            b1.img = img;
            b1.X = this.Width / 2 + 500;
            b1.Y = this.Height / 2;
            b.Add(b1);

            b1 = new bbb();
            img = new Bitmap("2.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));
            b1.img = img;
            b1.X = this.Width / 2 - 500;
            b1.Y = this.Height / 2;
            b.Add(b1);

        }

        void DrawScene(Graphics gf)
        {
            gf.Clear(Color.Black);
            gf.DrawImage(ch.img, ch.X, ch.Y);

            for (int i = 0; i < b.Count; i++)
            {
                gf.DrawImage(b[i].img, b[i].X, b[i].Y);
                for (int K = 0; K < b[i].myeggs.Count; K++)
                {
                    gf.DrawImage(b[i].myeggs[K].img, b[i].X + b[i].myeggs[K].id * ((b[i].img.Width) / 5), b[i].Y+20 );
                }
            }
            for (int i = 0; i < eggs.Count; i++)
            {
                gf.DrawImage(eggs[i].img, eggs[i].X, eggs[i].Y);

            }
        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}

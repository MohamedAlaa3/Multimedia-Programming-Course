using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        Bitmap off;
        public Graphics gf;

        Timer tt = new Timer();
        public class CACtor
        {
            public int XD, YD;
            public Bitmap im;
            public int XS, YS;
        }

        public class hero
        {
            public int X, Y,i;
            public List<Bitmap> img = new List<Bitmap>();
        }
        public class ground
        {
            public int X, Y;
            public Bitmap img;
        }
        public class Pipe
        {
            public int X, Y;
            public Bitmap img;
        }
        public class enemy1
        {
            public int X, Y;
            public Bitmap img;
        }
        public class enemy2
        {
            public int X, Y;
            public Bitmap img;
        }
        public class block
        {
            public int X, Y;
            public Bitmap img;
        }
      
        public class eneBu
        {
            public int X, Y;
            public Bitmap img;
        }

        public class bullet
        {
            public int X, Y,i;
            public Bitmap img;
        }
        public class castel
        {
            public int X, Y, i;
            public Bitmap img;
        }
        public class coin
        {
            public int X, Y, i;
            public Bitmap img;
        }
        List<coin> coins = new List<coin>();
        int a2 = -1;
        castel csl = new castel();
        enemy2 E = new enemy2();
        List<bullet> Hbullets = new  List<bullet>();
        List<eneBu> enBt = new List<eneBu>();
        block bk = new block();
        int bkmove=-5;
        List<enemy1> enemies = new List<enemy1>();
        List<Pipe> pipes = new List<Pipe>();
        List< ground>  g=new List<ground>();
        hero h = new hero();
        int ct = 1;
        int a = 1;
        int ct2 = 0;
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
        int k = 0;
        int eneD = 1;
        int yw = 0;
        float ratio = 0.1f;
        int E1 = 1;

        List<CACtor> LActs = new List<CACtor>();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    h.Y--;
            //}
            if (e.KeyCode == Keys.Space)
            {
                int f = 0;
                for (int i = 0; i < g.Count; i++)
                {
                    if (h.Y + h.img[0].Height >= g[i].Y &&
                        h.Y + h.img[0].Height <= g[i].Y + g[i].img.Height &&
                        h.X <= g[i].X + g[i].img.Width &&
                        h.X >= g[i].X)
                    {
                        f = 1;
                        h.Y = g[i].Y - h.img[0].Height;
                    }
                }
                for (int i = 0; i < pipes.Count; i++)
                {
                    if (h.Y + h.img[0].Height >= pipes[i].Y &&
                        h.Y + h.img[0].Height <= pipes[i].Y + pipes[i].img.Height &&
                        h.X <= pipes[i].X + pipes[i].img.Width &&
                        h.X + h.img[0].Width >= pipes[i].X)
                    {
                        f = 1;
                        h.Y = pipes[i].Y - h.img[0].Height;
                    }
                }
                if (h.Y + h.img[0].Height >= bk.Y &&
                 h.Y + h.img[0].Height <= bk.Y + bk.img.Height &&
                 h.X <= bk.X + bk.img.Width &&
                 h.X >= bk.X)
            {
                f = 1;
                h.Y = bk.Y - h.img[0].Height;
            }
                
                if (f == 1)
                {
                    h.Y -= 80;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                int f2 = 0;
                for (int i = 0; i < pipes.Count; i++)
                {
                    if (h.X + h.img[0].Width+10 >= pipes[i].X &&
                        h.X + h.img[0].Width+10 <= pipes[i].X + pipes[i].img.Width &&
                        h.Y + h.img[0].Height > pipes[i].Y
                        )
                    {
                        f2 = 1;
                    }
                }
                if (f2==0)
                {

                    k = 1;
                    h.X+=10;
                    if (h.i == 0)
                    {
                        h.i = 1;
                    }
                    else if (h.i == 1)
                    {
                        h.i = 0;
                    }
                    else if (h.i == 3 || h.i == 2)
                    {
                        h.i = 0;
                    }
                    LActs[0].XS += 1;
                    
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                k = 2;
                int f2 = 0;
                for (int i = 0; i < pipes.Count; i++)
                {
                    if (h.X - 10 >= pipes[i].X &&
                        h.X - 10 <= pipes[i].X + pipes[i].img.Width &&
                        h.Y + h.img[0].Height > pipes[i].Y
                        )
                    {
                        f2 = 1;
                    }
                }
                if (f2 == 0)
                {
                    if (h.X - 10 > 0)
                    {
                        h.X -= 10;
                    }
                    else
                    {
                        h.X = 0;
                    }

                    if (h.i == 0||h.i==1)
                    {
                        h.i = 2;
                    }
                    else if (h.i == 2)
                    {
                        h.i = 3;
                    }
                    else if ( h.i ==3 )
                    {
                        h.i = 2;
                    }
                    LActs[0].XS -= 1;

                }

            }
            if (e.KeyCode == Keys.Z)
            {
                Bitmap img = new Bitmap("7.bmp");
                img.MakeTransparent(img.GetPixel(0, 0));
                bullet b = new bullet();
                b.img = img;
                if(h.i==1||h.i==0)
                {
                    b.i = 0;
                    b.X = h.X + h.img[0].Width + 5;

                }
                else
                {
                    b.i = 1;
                    b.X = h.X - 5;

                }
                b.Y = h.Y + 10;

                Hbullets.Add(b);
            }
        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            DrawDubb(CreateGraphics());
            Hdown();
            eneMove();
            bkMove();
            eneeBu();
            HBullet();
            enemyy2();

        }
        void enemyy2()
        {
            if(E.X==pipes[1].X)
            {
                a2 *= -1;
            }
            if(E.X==pipes[0].X+pipes[0].img.Width)
            {
                a2 *= -1;
            }
            if (   E.X >= h.X &&
                   E.X <= h.X + h.img[0].Width &&
                   E.Y >= h.Y &&
                   E.Y <= h.Y + h.img[0].Height&&
                   E1 == 1)
            {
                tt.Stop();
                MessageBox.Show("you are loser2");

            }
            E.X += a2;
        }
        void HBullet()
        {
            
            for (int i = 0; i < Hbullets.Count; i++)
            {
                if(Hbullets[i].X>=enemies[0].X&&
                   Hbullets[i].X <= enemies[0].X+enemies[0].img.Width &&
                    Hbullets[i].Y>=enemies[0].Y &&
                    Hbullets[i].Y <= enemies[0].Y+enemies[0].img.Height)
                {
                    eneD = 0;
                }
                for (int k = 0; k < enBt.Count; k++)
                {
                    if (Hbullets[i].X >= enBt[k].X &&
                   Hbullets[i].X <=  enBt[k].X + enBt[k].img.Width &&
                    Hbullets[i].Y >= enBt[k].Y &&
                    Hbullets[i].Y <= enBt[k].Y + enBt[k].img.Height)
                    {
                        enBt.RemoveAt(k);
                    }
                }
                if (Hbullets[i].X >= E.X &&
                  Hbullets[i].X <= E.X + enemies[0].img.Width &&
                   Hbullets[i].Y >= E.Y &&
                   Hbullets[i].Y <=E.Y + E.img.Height)
                { 
                    E1 = 0;
                }
                if (Hbullets[i].i==0)
                {
                    Hbullets[i].X += 5;
                }
                else
                {
                    Hbullets[i].X -= 5;

                }
            }
        }
        void eneeBu()
        {
            if (ct2 % 100 == 0&&eneD==1)
            {
                eneBu bt = new eneBu();
                Bitmap img = new Bitmap("f.png");
                img.MakeTransparent(img.GetPixel(0, 0));
                bt.img = img;
                bt.X = enemies[0].X + enemies[0].img.Width;
                bt.Y = enemies[0].Y+35;
                enBt.Add(bt);
            }
            for (int i = 0; i < enBt.Count; i++)
            {
                if (enBt[i].X >= h.X &&
                    enBt[i].X <= h.X + h.img[0].Width &&
                    enBt[i].Y >= h.Y &&
                    enBt[i].Y <= h.Y + h.img[0].Height)
                {
                    tt.Stop();
                    MessageBox.Show("you are loser3");

                }
                enBt[i].X+=5;
            }

            ct2++;
        }
        void bkMove()
        {
            if(bk.Y<g[15].Y)
            {
                bkmove *= -1;
            }
            if (bk.Y == g[0].Y-bk.img.Height)
            {
                bkmove *= -1;
            }
            bk.Y -= bkmove;
        }
        void eneMove()
        {
            if (ct % 20 == 0)
            {
                a *= -1;
            }
            if (   enemies[0].X >= h.X &&
                   enemies[0].X <= h.X + h.img[0].Width &&
                   enemies[0].Y >= h.Y &&
                   enemies[0].Y <= h.Y + h.img[0].Height)
            {
                //tt.Stop();
                //MessageBox.Show("you are loser4");

            }
            enemies[0].X += a;
            ct++;
        }
        void Hdown()
        {
            int f = 0;
            for (int i = 0; i < g.Count; i++)
            {
                if (h.Y + h.img[0].Height >= g[i].Y &&
                    h.Y + h.img[0].Height <= g[i].Y+g[i].img.Height&&
                    h.X <= g[i].X + g[i].img.Width &&
                    h.X >= g[i].X)
                {
                    f = 1;
                    h.Y = g[i].Y - h.img[0].Height;
                }
            }
            for (int i = 0; i < pipes.Count; i++)
            {
                if (h.Y + h.img[0].Height >= pipes[i].Y &&
                    h.Y + h.img[0].Height <= pipes[i].Y + pipes[i].img.Height &&
                    h.X <= pipes[i].X + pipes[i].img.Width &&
                    h.X+h.img[0].Width >= pipes[i].X)
                {
                    f = 1;
                    if (i == 2)
                    {
                        h.Y -= 250;
                    }
                }
            }
            if (h.Y + h.img[0].Height >= bk.Y &&
                 h.Y + h.img[0].Height <= bk.Y + bk.img.Height &&
                 h.X <= bk.X + bk.img.Width &&
                 h.X >= bk.X)
            {
                f = 1;
                h.Y = bk.Y - h.img[0].Height;
            }
            if (f==0)
            {
                h.Y+=5;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawScene(e.Graphics);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            CACtor pnn = new CACtor();
            pnn.XD = 0;
            pnn.YD = 0;
            pnn.XS = 0;
            pnn.YS = 0;
            pnn.im = new Bitmap("background.png");
            LActs.Add(pnn);
            CreateActors();
            DrawScene(CreateGraphics());

        }
        void CreateActors()
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            
            

            //ground
            Bitmap  img = new Bitmap("u1.png");
            ground pnn=new ground();
            img.MakeTransparent(img.GetPixel(0, 0));
            int x= 0;
            for (int i = 0; i < 11; i++)
            {
                pnn.X = x;
                pnn.img = img;
                pnn.Y = this.Height - pnn.img.Height-40;
                g.Add(pnn);
                x += pnn.img.Width;
                pnn = new ground();
            }
            x = 00;
            img = new Bitmap("8.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));

            for (int i = 0; i < 20; i++)
            {
                if(i!=10&&i!=11)
                { 
                  pnn.X = x;
                    pnn.img = img;
                     pnn.Y = this.Height/2+50;
                  g.Add(pnn);

                }
                x += g[11].img.Width;
                pnn = new ground();

            }
            //hero
            img = new Bitmap("hr1.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.img.Add (img);
            img = new Bitmap("hr2.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.img.Add(img);
            img = new Bitmap("hl1.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.img.Add(img);
            img = new Bitmap("hl2.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            h.img.Add(img);
            h.X = 0;
            h.i = 0;
            h.Y = g[0].Y-h.img[0].Height;

            //pipes
            Pipe pi = new Pipe();
            img = new Bitmap("bluePipe.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            pi.img = img;
            pi.X = this.Width / 4;
            pi.Y = this.Height - g[0].img.Height - pi.img.Height-40;
            pipes.Add(pi);

            pi = new Pipe();
            pi.img = img;
            pi.X = this.Width / 2;
            pi.Y = this.Height - g[0].img.Height- pi.img.Height-40;
            pipes.Add(pi);

         


            //enemies
            enemy1 ene = new enemy1();
            img = new Bitmap("g.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            ene.img = img;
            ene.X = 0;
            ene.Y = g[11].Y - ene.img.Height;
            enemies.Add(ene);

            pi = new Pipe();
            img = new Bitmap("Y.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            pi.img = img;
            pi.X = 0;
            pi.Y = g[11].Y - pi.img.Height;
            pipes.Add(pi);

            //bk
            img = new Bitmap("b.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            bk.img = img;
            bk.X = this.Width / 2+100;
            bk.Y = g[0].Y -bk.img.Height;


            //
            x = 0;
            img = new Bitmap("8.bmp");
            img.MakeTransparent(img.GetPixel(0, 0));

            for (int i = 0; i < 20; i++)
            {
                if (i != 0 && i != 1)
                {
                    pnn.X = x;
                    pnn.img = img;
                    pnn.Y = g[11].Y-200;
                    g.Add(pnn);

                }
                x += g[11].img.Width;
                pnn = new ground();

            }

            //lad
            img = new Bitmap("ew.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            E.img = img;
            E.X =pipes[0].X+pipes[0].img.Width;
            E.Y = this.Height - g[0].img.Height -E.img.Height-22;

            //castel
            img = new Bitmap("castle.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            csl.img = img;
            csl.X = this.Width - csl.img.Width -20;
            csl.Y = g[11].Y - 200 - csl.img.Height;

            //coin
            img = new Bitmap("coin.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            coin pnn2 = new coin();
            int x5 = this.Width / 2;
            for (int i = 0; i < 5; i++)
            {
                pnn2 = new coin();
                pnn2.img = img;
                pnn2.X = x5;
                x5+=pnn2.img.Width+10;
                pnn2.Y = csl.Y+10;
                coins.Add(pnn2);
            }


            img = new Bitmap("coin.png");
            img.MakeTransparent(img.GetPixel(0, 0));
             pnn2 = new coin();
             x5 = this.Width -500;
            for (int i = 0; i < 5; i++)
            {
                pnn2 = new coin();
                pnn2.img = img;
                pnn2.X = x5;
                x5 += pnn2.img.Width + 10;
                pnn2.Y = g[0].Y-pnn2.img.Height;
                coins.Add(pnn2);
            }



            img = new Bitmap("coin.png");
            img.MakeTransparent(img.GetPixel(0, 0));
            pnn2 = new coin();
            x5 = 400;
            for (int i = 0; i < 5; i++)
            {
                pnn2 = new coin();
                pnn2.img = img;
                pnn2.X = x5;
                x5 += pnn2.img.Width + 10;
                pnn2.Y = g[13].Y - pnn2.img.Height;
                coins.Add(pnn2);
            }
        }
        void DrawScene(Graphics gf)
        {
            gf.Clear(Color.Black);
            for (int i = 0; i < LActs.Count; i++)
            {
                Rectangle rcDest = new Rectangle(LActs[i].XD, LActs[i].YD,
                                                    //(int)(LActs[i].im.Width*ratio) , 
                                                    //(int)(LActs[i].im.Height* ratio));
                                                    this.Width,
                                                    this.Height);

                Rectangle rcSrc = new Rectangle(LActs[i].XS, LActs[i].YS,
                                                LActs[i].im.Width / 2, LActs[i].im.Height);
                //LActs[i].im.Width, LActs[i].im.Height);
                gf.DrawImage(LActs[i].im,
                            rcDest, rcSrc,
                            GraphicsUnit.Pixel
                            );
            }
            if (E1 == 1)
            {
                if (k == 1)
                {
                    E.X--;
                }
                if (k == 2)
                {
                    E.X++;
                }
                gf.DrawImage(E.img, E.X, E.Y);

            }
            for (int i = 0; i < coins.Count; i++)
            {
                if (k == 1)
                {
                    coins[i].X--;
                }
                if (k == 2)
                {
                    coins[i].X++;
                }
                gf.DrawImage(coins[i].img, coins[i].X, coins[i].Y);
                if (h.X >= coins[i].X &&
                    h.X <= coins[i].X + coins[i].img.Width &&
                    h.Y+20 >= coins[i].Y &&
                    h.Y+20 <= coins[i].Y + coins[i].img.Height)
                {
                    coins.RemoveAt(i);
                }

            }
            gf.DrawImage(h.img[h.i], h.X, h.Y);
            gf.DrawImage(csl.img, csl.X, csl.Y);
            if (k == 1)
            {
                h.X--;
            }
            if (k == 2)
            {
                h.X++;
            }


            for (int i = 0; i < g.Count; i++)
            {
                if (k == 1)
                {
                    g[i].X--;
                }
                if (k == 2)
                {
                    g[i].X++;
                }
                gf.DrawImage(g[i].img, g[i].X, g[i].Y);
            }
            for (int i = 0; i < pipes.Count; i++)
            {
                if (k == 1)
                {
                    pipes[i].X--;
                }
                if (k == 2)
                {
                    pipes[i].X++;
                }
                gf.DrawImage(pipes[i].img, pipes[i].X, pipes[i].Y);
            }
            for (int i = 0; i < enemies.Count; i++)
            {
                if(eneD==1)
                { 

                   gf.DrawImage(enemies[i].img, enemies[i].X, enemies[i].Y);
                }
                if (k == 1)
                {
                    enemies[i].X--;
                }
                if (k == 2)
                {
                    enemies[i].X++;
                }
            }
            for (int i = 0; i < enBt.Count; i++)
            {
                if (k == 1)
                {
                    enBt[i].X--;
                }
                if (k == 2)
                {
                    enBt[i].X++;
                }
                gf.DrawImage(enBt[i].img, enBt[i].X, enBt[i].Y);
            }
            for (int i = 0; i < Hbullets.Count; i++)
            {
                gf.DrawImage(Hbullets[i].img, Hbullets[i].X, Hbullets[i].Y);
            }
            if (   h.X >= csl.X &&
                   h.X <= csl.X + csl.img.Width &&
                   h.Y + 20 >= csl.Y &&
                   h.Y + 20 <= csl.Y + csl.img.Height)
            {
                tt.Stop();
                                MessageBox.Show("you are winner1");


            }
            gf.DrawImage(bk.img, bk.X, bk.Y);
            //gf.DrawImage(lr.img, lr.X, lr.Y);
            //gf.FillRectangle(Brushes.Red, 0, this.Height / 2 - 20, this.Width / 2 - 30, 15);//x,y,width,hight
            //Pen p = new Pen(Color.Red, 3);// ,width
            //gf.DrawLine(p, 60, 60, 60, 0);//x1,y1,x2,y2
            k = 0;
        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}

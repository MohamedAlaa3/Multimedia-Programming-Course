using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public class CActor
    {
        public int X, Y;
        public int W, H;
        public Color clr;
        public int iConnect;
    }

    public partial class Form1 : Form
    {
        int N = 4;
        int ctMouseClick = 0;
        int old_i = -1;
        List<CActor> LActs = new List<CActor>();
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.KeyDown += Form1_KeyDown;
            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < LActs.Count; i++)
            {
                if (e.X >= LActs[i].X
                    && e.X <= LActs[i].X + LActs[i].W
                    && e.Y >= LActs[i].Y
                    && e.Y <= LActs[i].Y + LActs[i].H
                    )
                {

                    ctMouseClick++;
                    if (ctMouseClick == 1)
                    {
                        old_i = i;
                    }
                    if (ctMouseClick == 2)
                    {
                        LActs[i].iConnect = old_i;
                        ctMouseClick = 0;
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            DrawScene();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CreateMyActs();
            DrawScene();
        }

        void CreateMyActs()
        {
            Random RR = new Random();
            int tx = 20;
            int ty = 40;
            Color[] c = { Color.Red , Color.Yellow,
                            Color.Blue, Color.Green
                        };
            int[] isOk = { 0, 0, 0, 0 };
            int v;
            for (int i = 0; i < N; i++)
            {
                CActor pnn = new CActor();
                pnn.X = tx;
                pnn.Y = ty;
                pnn.W = 50;
                pnn.H = 50;
                pnn.iConnect = -1;
                pnn.clr = c[i];
                LActs.Add(pnn);


                pnn = new CActor();
                pnn.X = tx + 200;
                pnn.Y = ty;
                pnn.W = 50;
                pnn.H = 50;
                pnn.iConnect = -1;

                for (; ; )
                {
                    v = RR.Next(4);
                    if (isOk[v] == 0)
                    {
                        isOk[v] = 1;
                        break;
                    }
                }
                pnn.clr = c[v];
                ty += pnn.H + 10;

                LActs.Add(pnn);

            }

            //MessageBox.Show(LActs[0].X+ " , " + LActs[0].Y );

        }

        void DrawScene()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            ///// loop over each actor & draw it
            for (int i = 0; i < LActs.Count; i++)
            {
                //LActs[i]
                SolidBrush b = new SolidBrush(LActs[i].clr);
                g.FillEllipse(b,
                                LActs[i].X, LActs[i].Y,
                                LActs[i].W, LActs[i].H);
                g.DrawEllipse(Pens.Black,
                                LActs[i].X, LActs[i].Y,
                                LActs[i].W, LActs[i].H);

                if (LActs[i].iConnect != -1)
                {

                }
            }
        }


    }
}

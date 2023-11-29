using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public class CActor
    {
        public int X, Y;
        public int type;        // 1 --> rect , 2 --> Ellipse
        public int W;
    }
    public partial class Form1 : Form
    {
        List<CActor> LActs = new List<CActor>();
        int N = 10;

        public Form1()
        {
            this.Paint += Form1_Paint;
            this.Load += Form1_Load1;
            this.KeyDown += Form1_KeyDown;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    for (int i=0; i < LActs.Count; i++)
                    {
                        if (LActs[i].type == 1)
                        {
                            LActs[i].X += 5;
                        }
                    }
                    break;
                case Keys.Left:
                    for (int i = 0; i < LActs.Count; i++)
                    {
                        if (LActs[i].type == 1)
                        {
                            LActs[i].X -= 5;
                        }
                    }
                    break;

                case Keys.Down:
                    for (int i = 0; i < LActs.Count; i++)
                    {
                        if (LActs[i].type == 1)
                        {
                            LActs[i].Y += 5;
                        }
                    }
                    break;
                case Keys.Up:
                    for (int i = 0; i < LActs.Count; i++)
                    {
                        if (LActs[i].type == 1)
                        {
                            LActs[i].Y -= 5;
                        }
                    }
                    break;
            }
            DrawScene(CreateGraphics());
        }

        private void Form1_Load1(object sender, EventArgs e)
        {
           
            Random RR = new Random();
            for (int i=0; i < N; i++)
            {
                CActor pnn = new CActor();
                pnn.X = RR.Next(0, ClientSize.Width);
                pnn.Y = RR.Next(0, ClientSize.Height );
                pnn.W = 30;
                pnn.type = RR.Next(0, 2)+1;
                LActs.Add(pnn);

            }
            DrawScene(CreateGraphics());
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawScene(e.Graphics);
        }

        void DrawScene ( Graphics g)
        {
            
            g.Clear(Color.Black);
            for (int i=0; i < LActs.Count; i++)
            {
                if (LActs[i].type == 1)
                {
                    g.FillRectangle(Brushes.Red, LActs[i].X, LActs[i].Y, LActs[i].W, LActs[i].W);
                }
                if (LActs[i].type == 2)
                {
                    g.FillEllipse(Brushes.Yellow, LActs[i].X, LActs[i].Y, LActs[i].W, LActs[i].W);
                }
            }
        }
    }
}

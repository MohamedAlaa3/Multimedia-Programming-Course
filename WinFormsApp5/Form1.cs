using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    class rect
    {
        public int n, x, y, w, h;
    }
    public partial class Form1 : Form
    {
        List<rect> rects = new List<rect>();
        List<rect> rects1 = new List<rect>();
        List<rect> rects2 = new List<rect>();
        int rectno;
        int whichrect;
        int lastrectin2;
        int lastrectin3;
        int lastrectin1;
        bool isdrag = false;
        public Form1()
        {
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.WindowState = FormWindowState.Maximized;
            this.MouseUp += Form1_MouseUp;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isdrag == true)
            {
                if (whichrect == 0)
                {
                    rects[rectno].x = e.X;
                    rects[rectno].y = e.Y;
                }
                else if(whichrect == 1)
                {
                    rects1[rectno].x = e.X;
                    rects1[rectno].y = e.Y;
                }
                else if (whichrect == 2)
                {
                    rects2[rectno].x = e.X;
                    rects2[rectno].y = e.Y;
                }


                drawscene(CreateGraphics());
            }

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(isdrag == true)
            {
                if(whichrect == 0)
                {
                    if (rects[rectno].x >= ((ClientSize.Width / 4 * 2) - 100) && rects[rectno].x <= ((ClientSize.Width / 4 * 2) + 120))
                    {
                        rect pnn = new rect();
                        if (rects1.Count == 0)
                        {
                            pnn.y = 625;
                        }
                        else
                        {
                            pnn.y = rects1[rects1.Count - 1].y - 60;
                        }

                        pnn.x = (ClientSize.Width / 4 * 2) - (rects[rectno].w / 2 - 11);

                        pnn.w = rects[rectno].w;
                        pnn.h = rects[rectno].h;
                        if (rects1.Count == 0)
                        {
                            pnn.n = 0;
                        }
                        else
                        {
                            pnn.n = rects1[rects1.Count - 1].n + 1;
                        }
                        rects1.Add(pnn);
                        rects.RemoveAt(rectno);
                    }else if (rects[rectno].x >= ((ClientSize.Width / 4 * 3) - 100) && rects[rectno].x <= ((ClientSize.Width / 4 * 3) + 120))
                    {
                        rect pnn = new rect();
                        pnn.x = (ClientSize.Width / 4 * 3) - (rects[rectno].w / 2 - 11);
                        if (rects2.Count == 0)
                        {
                            pnn.y = 625;
                        }
                        else
                        {
                            pnn.y = rects2[rects2.Count - 1].y - 60;
                        }
                        pnn.w = rects[rectno].w;
                        pnn.h = rects[rectno].h;
                        if (rects2.Count == 0)
                        {
                            pnn.n = 0;
                        }
                        else
                        {
                            pnn.n = rects2[rects2.Count - 1].n + 1;
                        }
                        rects2.Add(pnn);
                        rects.RemoveAt(rectno);
                    }
                }
                if(whichrect == 1)
                {
                    if (rects1[rectno].x >= ((ClientSize.Width / 4) - 100) && rects1[rectno].x <= ((ClientSize.Width / 4) + 120))
                    {
                        rect pnn = new rect();
                        pnn.x = (ClientSize.Width / 4) - (rects1[rectno].w / 2 - 11);
                        if (rects.Count == 0)
                        {
                            pnn.y = 625;
                        }
                        else
                        {
                            pnn.y = rects[rects.Count - 1].y - 60;
                        }
                        pnn.w = rects1[rectno].w;
                        pnn.h = rects1[rectno].h;
                        if (rects.Count == 0)
                        {
                            pnn.n = 0;
                        }
                        else
                        {
                            pnn.n = rects[rects.Count - 1].n + 1;
                        }
                        rects.Add(pnn);
                        rects1.RemoveAt(rectno);
                    } else if (rects1[rectno].x >= ((ClientSize.Width / 4 * 3) -100) && rects1[rectno].x <= ((ClientSize.Width / 4 * 3) + 120))
                    {
                        rect pnn = new rect();
                        pnn.x = (ClientSize.Width / 4 * 3) - (rects1[rectno].w / 2 - 11);
                        if (rects1.Count == 0)
                        {
                            pnn.y = 625;
                        }
                        else
                        {
                            pnn.y = rects1[rects1.Count - 1].y - 60;
                        }
                        pnn.w = rects1[rectno].w;
                        pnn.h = rects1[rectno].h;
                        if (rects2.Count == 0)
                        {
                            pnn.n = 0;
                        }
                        else
                        {
                            pnn.n = rects2[rects2.Count - 1].n + 1;
                        }
                        rects2.Add(pnn);
                        rects1.RemoveAt(rectno);
                    }
                }
                if (whichrect == 2)
                {
                    if (rects2[rectno].x >= ((ClientSize.Width / 4) -100) && rects2[rectno].x <= ((ClientSize.Width / 4) + 120))
                    {
                        rect pnn = new rect();
                        pnn.x = (ClientSize.Width / 4) - (rects2[rectno].w / 2 - 11);
                        if (rects.Count == 0)
                        {
                            pnn.y = 625;
                        }
                        else
                        {
                            pnn.y = rects[rects.Count - 1].y - 60;
                        }
                        pnn.w = rects2[rectno].w;
                        pnn.h = rects2[rectno].h;
                        if (rects.Count == 0)
                        {
                            pnn.n = 0;
                        }
                        else
                        {
                            pnn.n = rects[rects.Count - 1].n + 1;
                        }
                        rects.Add(pnn);
                        rects2.RemoveAt(rectno);
                    }else  if (rects2[rectno].x >= ((ClientSize.Width / 4 * 2) - 100) && rects2[rectno].x <= ((ClientSize.Width / 4 * 2) + 120))
                    {
                        rect pnn = new rect();
                        pnn.x = (ClientSize.Width / 4 * 2) - (rects2[rectno].w / 2 - 11);
                        if (rects1.Count == 0)
                        {
                            pnn.y = 625;
                        }
                        else
                        {
                            pnn.y = rects1[rects1.Count - 1].y - 60;
                        }
                        pnn.w = rects2[rectno].w;
                        pnn.h = rects2[rectno].h;
                        if (rects1.Count == 0)
                        {
                            pnn.n = 0;
                        }
                        else
                        {
                            pnn.n = rects1[rects1.Count - 1].n + 1;
                        }
                        rects1.Add(pnn);
                        rects2.RemoveAt(rectno);
                    }
                }
                isdrag = false;
            }
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Y >= rects[rects.Count - 1].y && e.Y <= rects[rects.Count - 1].y + 50)
                {
                    for (int i = 0; i < rects.Count; i++)
                    {
                        if (e.X >= rects[i].x && e.X <= (rects[i].x + rects[i].w) && e.Y >= rects[i].y && e.Y <= (rects[i].y + rects[i].h))
                        {
                            whichrect = 0;
                            rectno = i;
                            isdrag = true;
                        }
                    }

                } else if (rects1.Count == 0 && rects2.Count == 0)
                {
                    MessageBox.Show("please move the top piece first!!!");
                } else if (e.Y >= rects1[rects1.Count - 1].y && e.Y <= rects1[rects1.Count - 1].y + 50)
                {
                    for (int i = 0; i < rects1.Count; i++)
                    {
                        if (e.X >= rects1[i].x && e.X <= (rects1[i].x + rects1[i].w) && e.Y >= rects1[i].y && e.Y <= (rects1[i].y + rects1[i].h))
                        {
                            whichrect = 1;
                            rectno = i;
                            isdrag = true;
                        }
                    }

                }else if(rects2.Count == 0)
                {
                    MessageBox.Show("please move a piece from the first two columns first!!!");
                }
                else if (e.Y >= rects2[rects.Count - 1].y && e.Y <= rects2[rects.Count - 1].y + 50)
                {
                    for (int i = 0; i < rects2.Count; i++)
                    {
                        if (e.X >= rects2[i].x && e.X <= (rects2[i].x + rects2[i].w) && e.Y >= rects2[i].y && e.Y <= (rects2[i].y + rects2[i].h))
                        {
                            whichrect = 2;
                            rectno = i;
                            isdrag = true;
                        }
                    }

                }
            }
            drawscene(CreateGraphics());
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawscene(CreateGraphics());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = ClientSize.Width / 4, y = 625, w = 135, h = 50;
            for (int i = 0; i < 10; i++)
            {
                rect pnn = new rect();
               if(w > 25)
               {
                    pnn.x = (ClientSize.Width / 4) - (w / 2 - 11);
               }
                else
                {
                    pnn.x = ClientSize.Width / 4;
                
                }
                pnn.n = i;
                pnn.y = y;
                pnn.w = w;
                pnn.h = h;
                rects.Add(pnn);
                w -= 10;
                y -= 60;
                
            }
            drawscene(CreateGraphics());
        }
        void drawscene(Graphics g)
        {
            g.Clear(Color.Aqua);
            g.FillRectangle(Brushes.Black, ClientSize.Width / 4, 100, 25, 600);
            g.FillRectangle(Brushes.Black, ClientSize.Width / 4 * 2, 100, 25, 600);
            g.FillRectangle(Brushes.Black, ClientSize.Width / 4 * 3, 100, 25, 600);
            for(int i = 0; i < rects.Count; i++)
            {
                g.FillRectangle(Brushes.Yellow, rects[i].x, rects[i].y, rects[i].w, rects[i].h);
            }
            for (int i = 0; i < rects1.Count; i++)
            {
                g.FillRectangle(Brushes.Yellow, rects1[i].x, rects1[i].y, rects1[i].w, rects1[i].h);
            }
            for (int i = 0; i < rects2.Count; i++)
            {
                g.FillRectangle(Brushes.Yellow, rects2[i].x, rects2[i].y, rects2[i].w, rects2[i].h);
            }

        }
    }
}

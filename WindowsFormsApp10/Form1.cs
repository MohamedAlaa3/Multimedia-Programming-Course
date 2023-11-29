//2
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        List<Form1> lr = new List<Form1>();
        List<Form1> ll = new List<Form1>();
        int ct;
        int sy;
        bool drag;
        public Form1()
        {
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Form1 pnn;
                int dy = e.Y - sy;
                if (ct >= 2)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        pnn = lr[i];
                        int oldx = pnn.Location.X;
                        int oldy = pnn.Location.Y;
                        pnn.Location = new Point(oldx, oldy + dy);

                    }
                    for (int i = 0; i < 4; i++)
                    {
                        pnn = ll[i];
                        int oldx = pnn.Location.X;
                        int oldy = pnn.Location.Y;
                        pnn.Location = new Point(oldx, oldy + dy);

                    }
                }
                sy = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (ct == 0)
                {
                    int yy = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        Form1 pnn = new Form1();
                        pnn.Width = this.Width / 4;
                        pnn.Height = this.Height / 4;
                        pnn.Show();
                        int a = this.Location.X + this.Width;
                        int v = this.Location.Y + yy;
                        pnn.Location = new Point(a, v);
                        pnn.BackColor = Color.Red;
                        yy += pnn.Height;
                        lr.Add(pnn);
                    }
                }
                if (ct == 1)
                {
                    int yy = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        Form1 pnn = new Form1();
                        pnn.Width = this.Width / 4;
                        pnn.Height = this.Height / 4;
                        pnn.Show();
                        int a = this.Location.X - pnn.Width;
                        int v = this.Location.Y + yy;
                        pnn.Location = new Point(a, v);
                        pnn.BackColor = Color.Blue;
                        yy += pnn.Height;
                        ll.Add(pnn);
                    }
                }
                ct++;

            }
            else
            {
                drag = true;
                sy = e.Y;
            }
        }
    }
}

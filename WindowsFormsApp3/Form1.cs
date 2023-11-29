//4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace assignment
{
    class MyWnd : Form
    {
        List<MyWnd> L = new List<MyWnd>();
        int ct;

        public MyWnd()
        {
            this.MouseDown += MyWnd_MouseDown;

        }
        private void MyWnd_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MyWnd pnn = new MyWnd();
                if (ct == 0)
                {
                    pnn.Show();
                    pnn.Location = new Point(0, 0);
                    pnn.BackColor = Color.Red;

                }
                if (ct == 1)
                {
                    pnn.Show();
                    pnn.Location = new Point(0, 500);
                    pnn.BackColor = Color.Yellow;
                }
                if (ct == 2)
                {
                    pnn.Show();
                    pnn.Location = new Point(500, 0);
                    pnn.BackColor = Color.Green;


                }
                if (ct == 3)
                {
                    pnn.Show();
                    pnn.Location = new Point(500, 500);
                    pnn.BackColor = Color.Blue;
                }
                L.Add(pnn);
                ct++;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    MyWnd pt = L[i];
                    int oldx = pt.Location.X;
                    int oldy = pt.Location.Y;

                    if (pt.Location.X < 500 && pt.Location.Y == 500)
                    {
                        pt.Location = new Point(oldx + 10, oldy);
                    }
                    else if (pt.Location.Y < 500 && pt.Location.X == 0)
                    {
                        pt.Location = new Point(oldx, oldy + 10);

                    }
                    else if (pt.Location.Y == 0 && pt.Location.X > 0)
                    {
                        pt.Location = new Point(oldx - 10, oldy);

                    }
                    else if (pt.Location.X == 500 && pt.Location.Y > 0)
                    {
                        pt.Location = new Point(oldx, oldy - 10);
                    }
                }
            }
        }

        static void Main()
        {
            MyWnd x = new MyWnd();

            Application.Run(x);
        }
    }
}

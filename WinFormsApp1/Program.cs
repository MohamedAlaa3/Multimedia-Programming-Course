using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1
{
    class MyWnd : Form
    {
        int v = 0;
        public MyWnd()
        {
            Text = "100% Course Work yaaaaaa MOataz ";
            Color x = Color.FromArgb(255, 0, 0);
            this.BackColor = x;
            this.ClientSize = new Size(100, 500);
            //this.Opacity = 0.2;
            this.WindowState = FormWindowState.Maximized;
            this.MouseDown += new MouseEventHandler(MyWnd_MouseDown);
        }

        void MyWnd_MouseDown(object sender, MouseEventArgs e)
        {
            //Text = v + "% Course Work yaaaaaa MOataz ";
            //MessageBox.Show(v + "% Course Work yaaaaaa MOataz " );
            //v++;
            MessageBox.Show(e.X + " : " + e.Y);
        }

        static void Main()
        {
            MyWnd x = new MyWnd();
            Application.Run(x);
        }
    }
}

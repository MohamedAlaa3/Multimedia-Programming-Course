using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _14_04_2021_MM
{
    class CMyForm : Form
    {
        int ct = 0;
        CMyForm()
        {

            this.MouseDown += CMyForm_MouseDown;
        }

        void CMyForm_MouseDown(object sender, MouseEventArgs e)
        {
            ct++;
            if (ct % 2 == 0)
                BackColor = Color.FromArgb(255, 0, 0);
            else
                BackColor = Color.Yellow;

            Opacity = 0.5f;
            MessageBox.Show("Click # " + ct + " >> " + e.X + " | " + e.Y);
        }

        static void Main()
        {
            CMyForm obj;
            obj = new CMyForm();
            Application.Run(obj);
        }
    }
}

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

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int ct1;
        public Form1()
        {
            MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(ct1>=0 && ct1<10)
            {
                this.Opacity -= 0.1;
                ct1++;
            }
            if(ct1>=10)
            {
                this.Opacity += 0.1;
            }
        }
    }
}

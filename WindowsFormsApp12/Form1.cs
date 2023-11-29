using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
class pcc
{
    public int r, g, b;
}

namespace WindowsFormsApp12
{

    public partial class Form1 : Form
    {
        List<pcc> cc = new List<pcc>();
        pcc p;
        int count, i;
        public Form1()
        {
            this.MouseDown += Form1_MouseDown;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.BackColor = Color.FromArgb(cc[i].r, cc[i].g, cc[i].b);

                i++;

                if (i == cc.Count)
                {
                    i = 0;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                this.BackColor = Color.FromArgb(cc[i].r, cc[i].g, cc[i].b);

                i--;
                if (i == -1)
                {
                    i = cc.Count - 1;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            count++;

            if (count == 1)
            {

                 p = new pcc();
                if (e.X > 255)
                {
                    p.r = 255;

                }
                else
                {
                    p.r = e.X;
                }

            }
            if (count == 2)
            {
                if (e.X > 255)
                {
                    p.g = 255;

                }
                else
                {
                    p.g = e.X;

                }
            }
            if (count == 3)
            {
                if (e.X > 255)
                {

                    p.r = 255;

                }
                else
                {
                    p.r = e.X;

                }
                cc.Add(p);
                count = -1;
            }
        }
    }
}

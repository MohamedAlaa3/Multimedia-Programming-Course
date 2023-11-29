using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        float total;
        float v, v2;
        string x, x2;
        int ct;
        char y;
        Button a;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "\n";
        }
        private void button_Click(object sender, EventArgs e)
        {
            a = (Button)sender;
            richTextBox1.Text += a.Text;
            x += a.Text;
            v = float.Parse(x);
            if (ct == 0)
            {
                total = v;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ct != 0)
            {
                if (y == '+')
                {
                    total += v;
                }
                if (y == '/')
                {
                    total /= v;
                }
                if (y == '*')
                {
                    total *= v;
                }
                if (y == '-')
                {
                    total -= v;
                }
                v2 = v;

            }
            Button b = (Button)sender;
            y = b.Text[0];
            richTextBox1.Text = total.ToString();
            richTextBox1.Text += y;
            richTextBox1.Text += "\n";

            x = "";
            ct++;
        }

        private void button18_Click(object sender, EventArgs e)//C
        {
            richTextBox1.Text = "";
            total = 0;
            v = 0;
            y = ' ';
            x = "";
            ct = 0;
        }

        private void button19_Click(object sender, EventArgs e)//CE
        {
            richTextBox1.Text = total.ToString();
            richTextBox1.Text += y;
            richTextBox1.Text += "\n";
            x = "";
            v = 0;
        }

        private void button14_Click(object sender, EventArgs e)//=-
        {

            richTextBox1.Text = total.ToString();
            richTextBox1.Text += y;
            richTextBox1.Text += "\n";
            v *= -1;
            richTextBox1.Text += v.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (x.Length >= 1)
            {
                richTextBox1.Text = total.ToString();
                richTextBox1.Text += y;
                richTextBox1.Text += "\n";

                x = x.Remove(x.Length - 1, 1);
                richTextBox1.Text += x;

                v = float.Parse(x);
            }
        }

        private void button2_Click(object sender, EventArgs e)//=
        {
            if (ct != 0)
            {
                if (y == '+')
                {
                    total += v;
                }
                if (y == '/')
                {
                    total /= v;
                }
                if (y == '*')
                {
                    total *= v;
                }
                if (y == '-')
                {
                    total -= v;
                }
            }
            richTextBox1.Text = "\n";
            richTextBox1.Text = total.ToString();
            y = ' ';

            x = richTextBox1.Text;
        }

    }
}

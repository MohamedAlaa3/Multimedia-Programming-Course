using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //curr
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new
            Form2 f1 = new Form2();
            f1.Show();
        }
    }
}

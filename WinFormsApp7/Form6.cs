using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //name
            textBox1.Text = Form2.L[Form5.p].username;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //major
            textBox2.Text = Form2.L[Form5.p].major;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //CR hour
            textBox3.Text = Form2.L[Form5.p].totH;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //corses name
            //richTextBox1.Text = Form2.L[Form5.p].;
            richTextBox1.Text = Form2.L[Form5.p].courses;
        }
    }
        
    
}

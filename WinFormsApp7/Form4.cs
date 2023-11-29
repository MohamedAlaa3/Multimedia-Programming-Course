using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void CS1_CheckedChanged(object sender, EventArgs e)
        {
           // totalH += 2;
            StreamWriter SW = new StreamWriter(@"C:\Users\Mohamed Alaa\Desktop\k.txt", true);
            SW.WriteLine("," + CS1.Text);
            SW.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // totalH += 2;
            StreamWriter SW = new StreamWriter(@"C:\Users\Mohamed Alaa\Desktop\k.txt", true);
            SW.WriteLine("," + checkBox2.Text);
            SW.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // totalH += 2;
            StreamWriter SW = new StreamWriter(@"C:\Users\Mohamed Alaa\Desktop\k.txt", true);
            SW.WriteLine("," + checkBox3.Text);
            SW.Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // totalH += 2;
            StreamWriter SW = new StreamWriter(@"C:\Users\Mohamed Alaa\Desktop\k.txt", true);
            SW.WriteLine("," + checkBox4.Text);
            SW.Close();
        }
    }
}

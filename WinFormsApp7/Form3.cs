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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Load += Form3_Load1;
        }

        private void Form3_Load1(object sender, EventArgs e)
        {
            totalH = 0;
        }

        public static int totalH;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            totalH += 3;
            StreamWriter SW = new StreamWriter(@"C:\Users\Mohamed Alaa\Desktop\k.txt", true);
            SW.WriteLine("," + checkBox3.Text);
            int pos = -1;
            for (int i = 0; i < Form2.L.Count; i++)
            {
                if (Form2.L[i].id == Form2.p)
                {
                    pos = i;
                }
            }
            Form2.L[pos].courses +=  checkBox3.Text + " ";
            SW.Close();
        }

        private void CS1_CheckedChanged(object sender, EventArgs e)
        {
            totalH += 3;
            int pos=-1;

            StreamWriter SW = new StreamWriter(@"C:\Users\Mohamed Alaa\Desktop\k.txt", true);
            SW.WriteLine( "," +CS1.Text);
            for (int i = 0; i < Form2.L.Count; i++)
            {
                if (Form2.L[i].id == Form2.p)
                {
                    pos = i;
                }
            }
            Form2.L[pos].courses += CS1.Text + " ";
            SW.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pos=-1;
            for (int i = 0; i < Form2.L.Count; i++)
            {
                if(Form2.L[i].id==Form2.p)
                {
                    pos = i;
                }
            }
            Form2.L[pos].totH = Convert.ToString( totalH);
            this.Close();

        }

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            totalH += 3;

            StreamWriter SW = new StreamWriter(@"C:\Users\Mohamed Alaa\Desktop\k.txt", true);
            SW.WriteLine("," + checkBox2.Text);
            SW.Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            totalH += 3;

            StreamWriter SW = new StreamWriter(@"C:\Users\Mohamed Alaa\Desktop\k.txt", true);
            SW.WriteLine("," + checkBox4.Text);
            int pos = -1;
            for (int i = 0; i < Form2.L.Count; i++)
            {
                if (Form2.L[i].id == Form2.p)
                {
                    pos = i;
                }
            }
            Form2.L[pos].courses += checkBox4.Text + " ";
            SW.Close();
        }
    }
}

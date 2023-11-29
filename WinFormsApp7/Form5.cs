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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static string p;
        private int i;

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            StreamReader sr = new StreamReader(@"C:\Users\Administrator\Desktop\k.txt");
            while (!sr.EndOfStream)
            {
                string l = sr.ReadLine();
                string[] temp = l.Split(',');
                if (temp[0] == textBox1.Text && temp[1] == textBox2.Text)
                {
                    p = temp[1];
                    flag = 1;
                    Form6 f6 = new Form6();
                    f6.Show();
                }

            }
            if (flag == 0)
            {
                MessageBox.Show("wrong");
            }
        }

                /* int Flag = 0;
             for (int i = 0; i < Form2.L.Count; i++)
             {
                if(textBox1.Text==Form2.L[i].id&&textBox2.Text==Form2.L[i].username)
                 {
                     p = i;
                     Flag = 1;
                     Form6 f6 = new Form6();
                     f6.Show();
                 }
             }
             if(Flag==0)
             {
                 MessageBox.Show("Wrong");
             }*/
        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //id
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


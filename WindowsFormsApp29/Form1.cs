﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           // InitializeComponent();
            this.Load += Form1_Load1;
        }

        private void Form1_Load1(object sender, EventArgs e)
        {
            Button dynamicButton = new Button();

            dynamicButton.Height = 40;

            dynamicButton.Width = 300;

            dynamicButton.BackColor = Color.Red;

            dynamicButton.ForeColor = Color.Blue;

            dynamicButton.Location = new Point(20, 150);

            dynamicButton.Text = "I am Dynamic Button";

            dynamicButton.Name = "DynamicButton";

            dynamicButton.Font = new Font("Georgia", 16);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button dynamicButton = new Button();

            dynamicButton.Height = 40;

            dynamicButton.Width = 300;

            dynamicButton.BackColor = Color.Red;

            dynamicButton.ForeColor = Color.Blue;

            dynamicButton.Location = new Point(20, 150);

            dynamicButton.Text = "I am Dynamic Button";

            dynamicButton.Name = "DynamicButton";

            dynamicButton.Font = new Font("Georgia", 16);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

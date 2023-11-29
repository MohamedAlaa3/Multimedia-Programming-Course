﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = " ";
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text += e.KeyCode;
            if (e.KeyCode == Keys.Enter)
            {
                this.Text = " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

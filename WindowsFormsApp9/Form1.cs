using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    //x every 3 clicks

    public partial class Form1 : Form
    {
        Form1 pnn;
        List<Form1> a = new List<Form1>();
        List<Form1> b = new List<Form1>();
        int l = 1;
        int l2 = 1;
        int p = 0;
        public Form1()
        {
            KeyDown += Form1_KeyDown;
            this.Width = this.Height;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.NumPad1)
            {
                p = 1;
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                p = 2;
            }



            if (e.KeyCode == Keys.Enter)
            {
                pnn = new Form1();
                pnn.Show();
                pnn.Height = this.Height / 2;
                pnn.Width = this.Width / 2;
                pnn.Location = new Point(this.Location.X - pnn.Width, this.Location.Y);
                pnn.BackColor = Color.Red;
                pnn.Opacity = .5;
                a.Add(pnn);//0

                pnn = new Form1();
                pnn.Show();
                pnn.Height = this.Height / 2;
                pnn.Width = this.Width / 2;
                pnn.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                pnn.BackColor = Color.Yellow;
                pnn.Opacity = .5;
                a.Add(pnn);//1



                pnn = new Form1();
                pnn.Show();
                pnn.Height = this.Height / 2;
                pnn.Width = this.Width / 2;
                pnn.Location = new Point(this.Location.X - pnn.Width * 2, this.Location.Y + pnn.Width);
                pnn.BackColor = Color.Green;
                pnn.Opacity = .5;
                a.Add(pnn);//2

                pnn = new Form1();
                pnn.Show();
                pnn.Height = this.Height / 2;
                pnn.Width = this.Width / 2;
                pnn.Location = new Point(this.Location.X + pnn.Width * 3, this.Location.Y + pnn.Width);
                pnn.BackColor = Color.Pink;
                pnn.Opacity = .5;//3
                a.Add(pnn);//3


                pnn = new Form1();
                pnn.Show();
                pnn.Height = this.Height / 2;
                pnn.Width = this.Width / 2;
                pnn.Location = new Point(this.Location.X, this.Location.Y - pnn.Height);
                pnn.BackColor = Color.Red;
                pnn.Opacity = .5;
                a.Add(pnn);//4



                pnn = new Form1();
                pnn.Show();
                pnn.Height = this.Height / 2;
                pnn.Width = this.Width / 2;
                pnn.Location = new Point(this.Location.X, this.Location.Y + pnn.Height * 2);
                pnn.BackColor = Color.Yellow;
                pnn.Opacity = .5;
                a.Add(pnn);




                pnn = new Form1();
                pnn.Show();
                pnn.Height = this.Height / 2;
                pnn.Width = this.Width / 2;
                pnn.Location = new Point(this.Location.X + pnn.Width, this.Location.Y + pnn.Height * 2);
                pnn.BackColor = Color.Pink;
                pnn.Opacity = .5;
                a.Add(pnn);



                pnn = new Form1();
                pnn.Show();
                pnn.Height = this.Height / 2;
                pnn.Width = this.Width / 2;
                pnn.Location = new Point(this.Location.X + pnn.Width, this.Location.Y - pnn.Height);
                pnn.BackColor = Color.Green;
                pnn.Opacity = .5;
                a.Add(pnn);












            }
            if (e.KeyCode == Keys.A)
            {
                if (p == 1)
                {
                    a[0].Location = new Point(a[0].Location.X - l, a[0].Location.Y + l);
                    a[2].Location = new Point(a[2].Location.X + l, a[2].Location.Y - l);
                    a[1].Location = new Point(a[1].Location.X + l, a[1].Location.Y + l);
                    a[3].Location = new Point(a[3].Location.X - l, a[3].Location.Y - l);
                    if (a[0].Location.X == (this.Location.X - this.Width))
                    {
                        l *= -1;
                    }
                    if (a[0].Location.X == (this.Location.X - pnn.Width))
                    {
                        l *= -1;
                    }
                }
                if (p == 2)
                {
                    a[4].Location = new Point(a[4].Location.X + l2, a[4].Location.Y);
                    a[5].Location = new Point(a[5].Location.X + l2, a[5].Location.Y);
                    a[6].Location = new Point(a[6].Location.X - l2, a[5].Location.Y);
                    a[7].Location = new Point(a[7].Location.X - l2, a[7].Location.Y);
                    if (a[4].Location.X == (this.Location.X + this.Width/2))
                    {
                        l2 *= -1;
                    }
                    if (a[4].Location.X == this.Location.X)
                    {
                        l2 *= -1;
                    }
                }



              

            }

        }
    }
}

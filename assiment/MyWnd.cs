//3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace WindowsFormsApp2
{
    class Program : Form
    {
        int count, p;
        List<int> x1 = new List<int>();
        List<int> y1 = new List<int>();
        List<int> x2 = new List<int>();
        List<int> y2 = new List<int>();
        char a;
        public Program()
        {
            MouseDown += Program_MouseDown;
        }

        private void Program_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
               


                if (count == 0)
                {
                    p = e.Y;
                }
                if(count!=0)
                {
                    if (e.Y < p)
                    {
                        if (count == 1||a=='d')//up
                        {
                            x1.Add(e.X);
                            y1.Add(e.Y);
                            a = 'u';//up
                        }
                        else
                        {
                            MessageBox.Show(" Error");
                        }

                    }
                    else
                    {
                        if (count == 1 || a == 'u')//down
                        {
                            x1.Add(e.X);
                            y1.Add(e.Y);
                            a = 'd';//down
                        }
                        else
                        {
                            MessageBox.Show(" Error");
                        }
                    }
                }
                count++;
            }
            else
            {
                for (int i = 0; i < x1.Count; i++)
                {
                    MessageBox.Show(x1[i] + "  " + y1[i]);

                }
                for (int i = 0; i < x2.Count; i++)
                {
                    MessageBox.Show(x2[i] + "  " + y2[i]);

                }
            }
        }

        static void Main()
        {
            Program x = new Program();

            Application.Run(x);
        }
    }
}

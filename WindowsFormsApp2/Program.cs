using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public class cnode
{
    public int X, Y;
}

namespace WindowsFormsApp2
{
    class Program : Form
    {
        int ct, pos;
        List<cnode> lTop = new List<cnode>();
        List<cnode> lDown = new List<cnode>();
        public Program()
        {
            MouseDown += Program_MouseDown;
        }

        private void Program_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                cnode pnn = new cnode();
                pnn.X = e.X;
                pnn.Y = e.Y;


                if (ct == 0)
                {
                    pos = e.Y;
                }
                else
                {
                    if (e.Y < pos)
                    {
                        lTop.Add(pnn);
                    }
                    else
                    {
                        lDown.Add(pnn);
                    }
                }
                ct++;
            }
            else
            {
                for (int i = 0; i < lTop.Count; i++)
                {
                    MessageBox.Show(lTop[i].X +"  "+lTop[i].Y);

                }
                for (int i = 0; i < lTop.Count; i++)
                {
                    MessageBox.Show(lDown[i].X + "  " + lDown[i].Y);

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class cactor
{
    public int X, Y;
    public int W, H;
    public Color clr;
    public int iConnect;
}
namespace WindowsFormsApp15
{

    public partial class Form1 : Form
    {
        int ct, pos, last = 0;
        List<cactor> lTop = new List<cactor>();
        List<cactor> lDown = new List<cactor>();
        public int tx, ty;


        Form1()
        {
            this.Load += Form1_Load;
            this.WindowState = FormWindowState.Maximized;
            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMyActs();
            DrawScene();
            MessageBox.Show(" Error");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            DrawScene();
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                tx = e.X;
                ty = e.Y;
                cactor pnn = new cactor();
                pnn.X = e.X;
                pnn.Y = e.Y;
                pnn.W = 50;
                pnn.H = 50;
                pnn.clr = Color.Red;


                if (ct == 0)
                {
                    pos = e.Y;
                }
                else
                {
                    if (e.Y < pos)
                    {
                        if (last == 0)
                        {
                            lTop.Add(pnn);
                            last = 1;
                        }
                        else
                        {
                            MessageBox.Show(" Error");
                        }

                    }
                    else
                    {
                        if (last == 1)
                        {
                            lDown.Add(pnn);
                            last = 0;
                        }
                        else
                        {
                            MessageBox.Show(" Error");

                        }
                    }
                }
                ct++;
            }
            else
            {
                for (int i = 0; i < lTop.Count; i++)
                {
                    MessageBox.Show(lTop[i].X + "  " + lTop[i].Y);

                }
                for (int i = 0; i < lDown.Count; i++)
                {
                    MessageBox.Show(lDown[i].X + "  " + lDown[i].Y);

                }
            }
            DrawScene();
        }

        void CreateMyActs()
        {
            cactor pnn = new cactor();
            pnn.X = tx;
            pnn.Y = ty;
            pnn.W = 50;
            pnn.H = 50;
            pnn.iConnect = -1;
        }
        void DrawScene()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            for (int i = 0; i < lTop.Count; i++)
            {
                //LActs[i]
                SolidBrush b = new SolidBrush(lTop[i].clr);
                g.FillEllipse(b,
                                lTop[i].X, lTop[i].Y,
                                lTop[i].W, lTop[i].H);
                g.DrawEllipse(Pens.Black,
                                lTop[i].X, lTop[i].Y,
                                lTop[i].W, lTop[i].H);

                if (lTop[i].iConnect != -1)
                {

                }
            }
        }



    }
}

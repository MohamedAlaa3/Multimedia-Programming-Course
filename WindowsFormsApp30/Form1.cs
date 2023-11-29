using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        Bitmap off;
        public Graphics gf;
            
        public Form1()
        {
            //InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Label t = new Label();
            t.Location = new Point(10, 20);
            t.Text = "Number of Instanst";
            Controls.Add(t);
        }
    }
}

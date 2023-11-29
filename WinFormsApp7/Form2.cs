using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
class a
{
    public string id, username, major, path, totH, courses;
};
namespace WinFormsApp7
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string path;
        private static readonly List<a> @as = new List<a>();
        private static List<a> l = @as;
        int major;
        public static string p;
        private string totalH;

        internal static List<a> L { get => l; set => l = value; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //name
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //id
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //photo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add photo
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                pictureBox1.Image = Image.FromFile(path);
                MessageBox.Show(path);
            }
        }

        private void CS_Click(object sender, EventArgs e)
        {
            //cs
            int flag = 0;
            string username = textBox1.Text;
            string id = textBox2.Text;

            for (int i = 0; i < L.Count; i++)
            {

                if (id == L[i].id)
                {
                    flag = 1;
                    MessageBox.Show("id is taken");
                }
            }
            if (flag == 0)
            {
                StreamWriter SW = new StreamWriter(@"C:\Users\Mohamed Alaa\Desktop\k.txt", true);

                SW.WriteLine(username + "," + id + "," + "CS" + "," + path + ",", totalH + ",");
                a pnn = new a();
                pnn.id = id;
                pnn.major = "CS";
                pnn.path = path;
                pnn.username = username;
                pnn.totH = totalH;
                L.Add(pnn);
                p = id;
                SW.Close();
            }

            Form3 f3 = new Form3();
            f3.Show();
        }


    }
}

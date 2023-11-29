using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider= OraOLEDB.Oracle ;TNS_ADMIN=C: \ Users\ Mohamed Alaa\Oracle\network\admin;USER ID=SYSTEM;Password = 1234;DATA SOURCE=DESKTOP-NGTJ8TA:1521/XE");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from Case55", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Case55 VAlUES('" + textBox1.Text + "','" + textBox2.Text + "','omar',8)", con);
            cmd.ExecuteNonQuery();
            con.Close();
            button1_Click(null, null);

        }
    }
}

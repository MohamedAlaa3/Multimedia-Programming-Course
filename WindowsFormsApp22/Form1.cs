using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()

        {

            try

            {

                string ConString = "Data Source=XE;User Id=sys;Password=1234;DBA Privilege = SYSDBA;";



                using (OracleConnection con = new OracleConnection(ConString))

                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand(" * FROM Case55", con);
                    MessageBox.Show("hello2");
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);

                    DataSet ds = new DataSet();

                    oda.Fill(ds);

                    if (ds.Tables.Count > 0)

                    {

                        dataGridView1.DataSource = ds.Tables[0].DefaultView;

                        con.Close();

                    }

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.ToString());

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("hello");

        }

  
    }

}

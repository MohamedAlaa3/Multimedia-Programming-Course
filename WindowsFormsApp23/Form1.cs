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
namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider= OraOLEDB.Oracle ;TNS_ADMIN=C:\Users\Mohamed Alaa\Oracle\network\admin;USER ID=SYSTEM;Password = 1234;DATA SOURCE=DESKTOP-NGTJ8TA:1521/XE");

        public Form1()
        {
            InitializeComponent();
        }
    }
}

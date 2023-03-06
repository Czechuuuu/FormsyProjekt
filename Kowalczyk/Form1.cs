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

namespace userlogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection db_conn;
            OleDbCommand db_comm;
            db_conn = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=C:/userinfo.accdb");
            db_conn.Open();
            string que = "SELECT COUNT (*) FROM userinfo WHERE user_id=@uid and user_pass=@upa";
            db_comm = new OleDbCommand(que, db_conn);
            db_comm.Parameters.Add("@uid", OleDbType.VarChar).Value = textBox1.Text;
            db_comm.Parameters.Add("@upa", OleDbType.VarChar).Value = textBox2.Text;
            int count = (int)db_comm.ExecuteScalar();
            db_conn.Close();
            db_conn = null;
            if (count <= 0)
            {
                MessageBox.Show("User not exists");
            }
            else
            {
                MessageBox.Show("User exists and you can logon");
            }
        }
    }
}

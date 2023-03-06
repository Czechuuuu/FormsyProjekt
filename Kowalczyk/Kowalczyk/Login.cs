using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kowalczyk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mrora\Desktop\git\FormsyProjekt\Kowalczyk\Kowalczyk\Database7.accdb;User ID=admin");
        OleDbCommand cmd = new OleDbCommand("select id, username, password");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            OleDbConnection db_conn;
            OleDbCommand db_comm;
            db_conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\mrora\\Desktop\\git\\FormsyProjekt\\Kowalczyk\\Kowalczyk\\Database7.accdb;User ID=admin");
            db_conn.Open();
            string que = "SELECT COUNT (*) FROM userinfo WHERE user_id=@uid and user_pass=@upa";
            db_comm = new OleDbCommand(que, db_conn);
            db_comm.Parameters.Add("@uid", OleDbType.VarChar).Value = txt_username.Text;
            db_comm.Parameters.Add("@upa", OleDbType.VarChar).Value = txt_password.Text;
            int count = (int)db_comm.ExecuteScalar();
            db_conn.Close();
            db_conn = null;
            if (count <= 0)
            {
                MessageBox.Show("Użytkownik nie istnieje");
            }
            else
            {
                MessageBox.Show("Zalogowano");
            }
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using System.Threading;

namespace Kowalczyk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void button_login_Click(object sender, EventArgs e)
        {
            if(user.Text.Trim() == "" && pass.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error");
            }
            else
            {
                string query = "SELECT * from Login WHERE username = @user and password = @pass";
                SQLiteConnection conn = new SQLiteConnection("Data Source=Database1.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user.Text);
                cmd.Parameters.AddWithValue("@pass", pass.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count> 0)
                {
                    MessageBox.Show("Zalogowano", "Zalogowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stronaGlowna();
                }
                else
                {
                    MessageBox.Show("Sprawdz swoje haslo lub login","Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void stronaGlowna()
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}

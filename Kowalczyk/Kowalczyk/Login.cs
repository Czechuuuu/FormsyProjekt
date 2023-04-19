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
using System.Runtime.CompilerServices;
using System.Media;

namespace Kowalczyk
{
    public partial class Login : Form
    {
        public static String L, H;
        public Login()
        {
            InitializeComponent();
        }

        public void button_login_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Database1.db; Pooling=false");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Login", conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            bool flag = false;
            while (reader.Read())
            {
                
                String login = reader.GetString(1);
                String password = reader.GetString(2);
                if (user.Text == login && pass.Text == password)
                {
                    L = login; H = password;
                    MessageBox.Show("Zalogowano");
                    stronaGlownaZalogowana zalogowano = new stronaGlownaZalogowana();
                    this.Hide();
                    zalogowano.ShowDialog();
                    this.Dispose();
                }
            }
            flag = true;
            if (flag == true)
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nie udalo sie zalogowa");
                flag = false;
            }
            reader.Close();
            conn.Close();
            

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            stronaGlowna.powrot();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

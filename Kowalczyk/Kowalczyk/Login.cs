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
using System.IO;

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
            StreamReader sr = new StreamReader("uzytkownicy.txt");
            bool flag = true;
            while (sr.Peek() >= 0)
            {
                string a = sr.ReadLine();
                string[] x = a.Split(' ');
                if (x[1] == user.Text && x[2] == pass.Text)
                {
                    flag = false;
                    L = x[1]; H = x[2];
                    MessageBox.Show("Zalogowano");
                }
            }
            if (flag == true)
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nie udalo sie zalogować");
                flag = false;
                sr.Close();
            }
            else
            {
                sr.Close();
                stronaGlownaZalogowana zalogowano = new stronaGlownaZalogowana();
                this.Hide();
                zalogowano.ShowDialog();
                this.Dispose();

            }
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

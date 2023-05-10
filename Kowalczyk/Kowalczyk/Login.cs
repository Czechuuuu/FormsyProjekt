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
using System.Diagnostics.Eventing.Reader;

namespace Kowalczyk
{
    public partial class Login : Form
    {
        public static String L, H, ID;
        public static bool czyAdmin = false;
        public Login()
        {
            InitializeComponent();
            passHide.Hide();
        }

        public void button_login_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("uzytkownicy.txt");
            bool flag = true;
            czyAdmin = false;
            while (sr.Peek() >= 0)
            {
                string a = sr.ReadLine();
                string[] x = a.Split(' ');
                if (x[1] == user.Text && x[2] == pass.Text)
                {
                    flag = false;
                    if (x[0] == "1") // Admin to zawsze uzytkownik z ID 1
                        Login.czyAdmin = true;
                    L = x[1]; H = x[2]; ID = x[0];  
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
                if (czyAdmin == false)
                {
                    sr.Close();
                    stronaGlownaZalogowana zalogowano = new stronaGlownaZalogowana();
                    this.Hide();
                    zalogowano.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    sr.Close();
                    stronaGlownaZalogowanaA zalogowano = new stronaGlownaZalogowanaA();
                    this.Hide();
                    zalogowano.ShowDialog();
                    this.Dispose();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            passHide.Text = pass.Text;
        }

        private void btnPassHide_MouseDown(object sender, MouseEventArgs e)
        {
            passHide.Show();
            pass.Hide();
        }

        private void btnPassHide_MouseUp(object sender, MouseEventArgs e)
        {
            passHide.Hide();
            pass.Show();   

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            stronaGlowna x = new stronaGlowna();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

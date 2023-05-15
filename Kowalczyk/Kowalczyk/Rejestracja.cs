using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kowalczyk
{
    public partial class Rej : Form
    {
        public Rej()
        {
            InitializeComponent();
            passHide.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Zatwierdz_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            stronaGlowna x = new stronaGlowna();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            stronaGlowna x = new stronaGlowna();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void Zatwierdz_Click_1(object sender, EventArgs e)
        {
            bool flag = false;
            var lines = File.ReadAllLines("uzytkownicy.txt");
            if ((login.Text == "" || haslo.Text == "" || Phaslo.Text == "") && flag == false)
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nie wypełniono danych");
                flag = true;
            }
            if ((haslo.Text != Phaslo.Text) && flag == false) 
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Hasła nie są takie same");
                flag = true;
            }
            if (flag == false)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    var word = lines[i].Split(' ');
                    if (word[1] == login.Text)
                    {
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Zajęta nazwa użytkownika");
                        flag = true;
                        break;
                    }
                }
            }
            if (flag == false)
            {
                String[] newUzytkownicy = new string[lines.Length + 1];
                for (int i = 0; i < newUzytkownicy.Length; i++)
                {

                    if (i == (newUzytkownicy.Length - 1))
                    {
                        var word = lines[i - 1].Split(' ');
                        int ID = int.Parse(word[0]);
                        int newID = ID + 1;
                        String newID2 = newID.ToString();
                        newUzytkownicy[i] = $"{newID2} {login.Text} {haslo.Text}";
                    }
                    else
                    {
                        newUzytkownicy[i] = lines[i];
                    }
                }
                File.WriteAllLines("uzytkownicy.txt", newUzytkownicy);
                MessageBox.Show("Rejestracja zakończona pomyślnie");

                login.Text = "";
                haslo.Text = "";
                Phaslo.Text = "";

                stronaGlowna sgz = new stronaGlowna();
                this.Hide();
                sgz.ShowDialog();
                this.Close();
            }
        }

        private void btnHide_MouseUp(object sender, MouseEventArgs e)
        {
            passHide.Hide();
            haslo.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            passHide.Text = haslo.Text;
        }

        private void btnHide_MouseDown(object sender, MouseEventArgs e)
        {
            passHide.Show();
            haslo.Hide();
        }
    }
}

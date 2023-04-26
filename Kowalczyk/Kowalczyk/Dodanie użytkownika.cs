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
    public partial class DU : Form
    {
        public DU()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            ZU x = new ZU();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void asd_Click(object sender, EventArgs e)
        {
            bool flag = false;
            var lines = File.ReadAllLines("uzytkownicy.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                var word = lines[i].Split(' ');
                if (word[1] == login.Text)
                {
                    MessageBox.Show("Zajęta nazwa użytkownika");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                String[] newUzytkownicy = new string[lines.Length+1];
                for (int i = 0; i < newUzytkownicy.Length; i++)
                {
                    
                    if (i == (newUzytkownicy.Length-1))
                    {
                        var word = lines[i-1].Split(' ');
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

                ZU sgz = new ZU();
                this.Hide();
                sgz.ShowDialog();
                this.Close();

            }
            
            /*
            if (curpass.Text == Login.H && (curpass.Text != newpass.Text))
            {
                var lines = File.ReadAllLines("uzytkownicy.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    var word = lines[i].Split(' ');
                    if (word[2] == Login.H)
                    {
                        if (word[0] == "1")
                            Login.czyAdmin = true;
                        lines[i] = $"{word[0]} {word[1]} {newpass.Text}";
                        break;
                    }
                }
                File.WriteAllLines("uzytkownicy.txt", lines);
                MessageBox.Show("Zmieniono hasło");
                if (Login.czyAdmin == false)
                {
                    stronaGlownaZalogowana sgz = new stronaGlownaZalogowana();
                    this.Hide();
                    sgz.ShowDialog();
                    this.Close();
                }
                else
                {
                    stronaGlownaZalogowanaA sgz = new stronaGlownaZalogowanaA();
                    this.Hide();
                    sgz.ShowDialog();
                    this.Close();
                }

            }
            else if (curpass.Text == newpass.Text)
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Podano to samo hasło");
            }
            else if (curpass.Text == "" || newpass.Text == "")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nie wypełniono danych");
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Niepoprawne obecne hasło");
            }
            */
        }

        

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

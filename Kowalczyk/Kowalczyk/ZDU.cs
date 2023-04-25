using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kowalczyk
{
    public partial class ZDU : Form
    {
        public ZDU()
        {
            InitializeComponent();
        }

        private void asd_Click(object sender, EventArgs e)
        {
            if (curpass.Text == Login.H && (curpass.Text != newpass.Text))
            {
                var lines = File.ReadAllLines("uzytkownicy.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    var word = lines[i].Split(' ');
                    if (word[2] == Login.H)
                    {
                        lines[i] = $"{word[0]} {word[1]} {newpass.Text}";
                        break;
                    }
                }
                File.WriteAllLines("uzytkownicy.txt", lines);
                MessageBox.Show("Zmieniono hasło");
                stronaGlownaZalogowana sgz = new stronaGlownaZalogowana();
                this.Hide();
                sgz.ShowDialog();
                this.Close();

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
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            stronaGlownaZalogowana sgz = new stronaGlownaZalogowana();
            this.Hide();
            sgz.ShowDialog();
            this.Close();
        }

        private void curpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

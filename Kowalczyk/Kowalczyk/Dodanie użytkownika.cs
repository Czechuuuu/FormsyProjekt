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

                ListaU.Items.Clear();
                File.WriteAllLines("uzytkownicy.txt", newUzytkownicy);
                for (int j = 1; j < newUzytkownicy.Length; j++)
                {
                    var word4 = newUzytkownicy[j].Split(' ');
                    ListaU.Items.Add($"ID: {word4[0]}   Login: {word4[1]}   Hasło: {word4[2]}");
                }
                login.Text = "";
                haslo.Text = "";
                


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

        private void DU_Load(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("uzytkownicy.txt");
            String[] lista = new String[lines.Length];
            for (int i = 1; i < lines.Length; i++)
            {
                var word = lines[i].Split(' ');
                lista[i] = $"ID: {word[0]}   Login: {word[1]}   Hasło: {word[2]}";
            }
            for (int i = 1; i < lista.Length; i++)
            {
                ListaU.Items.Add(lista[i]);
            }
        }
    }
}

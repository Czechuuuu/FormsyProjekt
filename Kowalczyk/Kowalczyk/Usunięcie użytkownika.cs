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
    public partial class UU : Form
    {
        public UU()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            
            ZU x = new ZU();
            this.Hide();
            x.ShowDialog();
            this.Close();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UU_Load(object sender, EventArgs e)
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

        private void asd_Click(object sender, EventArgs e)
        {
            
            if (kogousunac.Text == "1")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nie można usunąć użytkownika z ID 1");   
            }
            else
            {
                bool flag = false;
                var lines = File.ReadAllLines("uzytkownicy.txt");
                for (int i = 1; i < lines.Length; i++)
                {
                    var word = lines[i].Split(' ');
                    if (word[0] == kogousunac.Text)
                    {
                        flag = true;
                        int ktoreID = int.Parse(word[0]);
                        String[] newUzytkownicy = new String[lines.Length - 1];
                        for (int j = 0; j < newUzytkownicy.Length; j++)
                        {
                            if (j >= (ktoreID-1))
                            {
                                var word2 = lines[j + 1].Split(' ');
                                var word3 = lines[j].Split(' ');
                                newUzytkownicy[j] = $"{word3[0]} {word2[1]} {word2[2]}";
                            }
                            else
                            {
                                newUzytkownicy[j] = lines[j];
                            }
                        }
                        ListaU.Items.Clear();
                        File.WriteAllLines("uzytkownicy.txt", newUzytkownicy);
                        for (int j = 1; j < newUzytkownicy.Length; j++)
                        {
                            var word4 = newUzytkownicy[j].Split(' ');
                            ListaU.Items.Add($"ID: {word4[0]}   Login: {word4[1]}   Hasło: {word4[2]}");
                        }
                        break;
                    }
                }
                if (flag == false)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Nie ma użytkownika z takim ID");
                }
                kogousunac.Text = "";
            }
        }
    }
}

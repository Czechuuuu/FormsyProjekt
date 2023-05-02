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
    public partial class ZDU2 : Form
    {
        public ZDU2()
        {
            InitializeComponent();
        }

        private void ListaU_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void asd_Click(object sender, EventArgs e)
        {

            if (komuzmienicdane.Text == "1")
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
                    if (word[0] == komuzmienicdane.Text)
                    {
                        flag = true;
                        lines[i] = $"{word[0]} {newlogin.Text} {newpass.Text}";
                        ListaU.Items.Clear();
                        File.WriteAllLines("uzytkownicy.txt", lines);
                        for (int j = 1; j < lines.Length; j++)
                        {
                            var word4 = lines[j].Split(' ');
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
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            ZU x = new ZU();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void ZDU2_Load(object sender, EventArgs e)
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

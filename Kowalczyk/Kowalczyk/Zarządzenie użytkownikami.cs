using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kowalczyk
{
    public partial class ZU : Form
    {
        public ZU()
        {
            InitializeComponent();
        }

        private void DU_Click(object sender, EventArgs e)
        {
            DU x = new DU();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            stronaGlownaZalogowanaA x = new stronaGlownaZalogowanaA();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void UU_Click(object sender, EventArgs e)
        {
            

            UU x = new UU();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZDU2 x = new ZDU2();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void ZU_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            PoglądZamówień x = new PoglądZamówień();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void ListaU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

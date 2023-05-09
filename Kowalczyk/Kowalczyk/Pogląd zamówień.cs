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
    public partial class PoglądZamówień : Form
    {
        public PoglądZamówień()
        {
            InitializeComponent();
        }

        private void PoglądZamówień_Load(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("koszyk.txt");
            String[] lista = new String[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                var word = lines[i].Split(' ');
                listazam.Items.Add($"ID zamówienia: {word[0]}");
                listazam.Items.Add($"ID użytkownika zamawiającego: {word[1]}");
                listazam.Items.Add($"Herbata mrożona: {word[3]}");
                listazam.Items.Add($"Hot dog: {word[4]}");
                listazam.Items.Add($"Coca-Cola: {word[5]}");
                listazam.Items.Add($"Sałatka Cezar: {word[6]}");
                listazam.Items.Add($"Nuggetsy z kurczaka: {word[7]}");
                listazam.Items.Add($"Podwójny cheeseburger: {word[8]}");
                listazam.Items.Add($"Cheeseburger: {word[9]}");
                listazam.Items.Add($"Skrzydełka kurczaka: {word[10]}");
                listazam.Items.Add($"Kawa: {word[11]}");
                listazam.Items.Add($"Lemoniada: {word[12]}");
                listazam.Items.Add($"Frytki: {word[13]}");
                listazam.Items.Add($"Hamburger: {word[14]}");
                listazam.Items.Add($"Suma zakupu: {word[2]}");
                listazam.Items.Add($"=================================");
            }
        }

        private void ListaU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            ZU x = new ZU();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
    }
}

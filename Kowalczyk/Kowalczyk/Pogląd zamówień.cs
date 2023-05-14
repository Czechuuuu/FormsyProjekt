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
                listazam.Items.Add($"Suma zakupu: {word[2]} zł");
                listazam.Items.Add($"=================================");
            }
            var lines2 = File.ReadAllLines("dane_przy_zamawianiu.txt");
            for (int i = 0; i < lines2.Length; i++)
            {
                var word = lines2[i].Split(' ');
                IOZ.Items.Add($"ID użytkownika zamawiającego: {word[0]}");
                IOZ.Items.Add($"Imię: {word[1]}");
                IOZ.Items.Add($"Nazwisko: {word[2]}");
                IOZ.Items.Add($"Ulica: {word[3]}");
                IOZ.Items.Add($"Numer domu/mieszkania: {word[4]}");
                IOZ.Items.Add($"Kod pocztowy: {word[5]}");
                IOZ.Items.Add($"Miasto/miejscowość: {word[6]}");
                IOZ.Items.Add($"Adres poczty elektronicznej: {word[7]}");
                IOZ.Items.Add($"Numer telefonu: {word[8]}");
                IOZ.Items.Add($"=================================");
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

        private void IOZ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Zamówienie : Form
    {
        static public bool czyDokonanoZamowienia = false;
        public Zamówienie()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("dane_przy_zamawianiu.txt");
            StreamReader sr = new StreamReader("dane_przy_zamawianiu.txt");
            String line;
            bool niemadanych = false;
            bool czyjest = false;
            while ((line = sr.ReadLine()) != null)
            {
                czyjest = true;
            }
            sr.Close();

            if (imie.Text == "" || nazwisko.Text == "" || ulica.Text == "" || nrdomiesz.Text == "" || kodpocz.Text == "" || miasmie.Text == "" || adrpoele.Text == "" || nrtele.Text == "")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nie wypełniono danych");
                niemadanych = true;
                
            }

            if ((czyjest == false) && niemadanych == false) 
            {
                String[] linia = new String[1] { $"{Login.ID} {imie.Text} {nazwisko.Text} {ulica.Text} {nrdomiesz.Text} {kodpocz.Text} {miasmie.Text} {adrpoele.Text} {nrtele.Text}" };
                File.WriteAllLines("dane_przy_zamawianiu.txt", linia);
                imie.Text = "";
                nazwisko.Text = "";
                ulica.Text = "";
                nrdomiesz.Text = "";
                kodpocz.Text = "";
                kodpocz.Text = "";
                miasmie.Text = "";
                adrpoele.Text = "";
                nrtele.Text = "";
                MessageBox.Show("Dokonano zamówienia");
                czyDokonanoZamowienia = true;
                this.Hide();
                this.Close();
            }
            else if ((czyjest == true) && niemadanych == false) 
            {
                var lines2 = File.ReadAllLines("dane_przy_zamawianiu.txt");
                String[] newlines = new string[lines.Length + 1];
                for (int i = 0; i < newlines.Length; i++)
                {

                    if (i == (newlines.Length - 1))
                    {
                        var word = lines[i - 1].Split(' ');
                        newlines[i] = $"{Login.ID} {imie.Text} {nazwisko.Text} {ulica.Text} {nrdomiesz.Text} {kodpocz.Text} {miasmie.Text} {adrpoele.Text} {nrtele.Text}";
                    }
                    else
                    {
                        newlines[i] = lines[i];
                    }
                }
                
                File.WriteAllLines("dane_przy_zamawianiu.txt", newlines);
                imie.Text = "";
                nazwisko.Text = "";
                ulica.Text = "";
                nrdomiesz.Text = "";
                kodpocz.Text = "";
                kodpocz.Text = "";
                miasmie.Text = "";
                adrpoele.Text = "";
                nrtele.Text = "";
                MessageBox.Show("Dokonano zamówienia");
                czyDokonanoZamowienia = true;
                this.Hide();
                this.Close();
            }



            

        }

        private void Zamówienie_Load(object sender, EventArgs e)
        {
            czyDokonanoZamowienia = false;
        }
    }
}

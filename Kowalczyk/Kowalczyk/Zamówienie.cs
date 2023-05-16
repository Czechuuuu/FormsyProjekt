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
            bool czyjestblad = false;
            int ilejestbledow = 0;
            while ((line = sr.ReadLine()) != null)
            {
                czyjest = true;
            }
            sr.Close();

            if (imie.Text == "" || nazwisko.Text == "" || ulica.Text == "" || nrdomiesz.Text == "" || kodpocz.Text == "" || miasmie.Text == "" || adrpoele.Text == "" || nrtele.Text == "" || nrkarty.Text == "" || datawaz.Text == "" || kodzabez.Text == "")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nie wypełniono danych");
                niemadanych = true;
                czyjestblad = true;
                goto niewypelniono;
            }

            if (nrtele.Text.Length == 9)
            {
                for (int i = 0; i < nrtele.Text.Length; i++)
                {
                    if (Char.IsDigit(nrtele.Text[i]) == false)
                    {
                        niemadanych = true;
                        ilejestbledow = ilejestbledow + 1;
                        if (ilejestbledow == 2)
                        {
                            goto duzobledow;
                        }
                        break;
                    }
                }
            }
            else if (nrtele.Text.Length != 11)
            {
                niemadanych = true;
                ilejestbledow = ilejestbledow + 1;
                if (ilejestbledow == 2)
                {
                    goto duzobledow;
                }
            }

            if (kodpocz.Text.Length == 5)
            {
                for (int i = 0; i < kodpocz.Text.Length; i++)
                {
                    if (Char.IsDigit(kodpocz.Text[i]) == false)
                    {
                        niemadanych = true;
                        ilejestbledow = ilejestbledow + 1;
                        if (ilejestbledow == 2)
                        {
                            goto duzobledow;
                        }
                        break;
                    }
                }

            }
            else if (kodpocz.Text.Length !=6)
            {
                niemadanych = true;
                ilejestbledow = ilejestbledow + 1;
                if (ilejestbledow == 2)
                {
                    goto duzobledow;
                }
            }

            if (nrkarty.Text.Length == 16)
            {
                for (int i = 0; i < nrkarty.Text.Length; i++)
                {
                    if (Char.IsDigit(nrkarty.Text[i]) == false)
                    {
                        niemadanych = true;
                        ilejestbledow = ilejestbledow + 1;
                        if (ilejestbledow == 2)
                        {
                            goto duzobledow;
                        }
                        break;
                    }
                }

            }
            else if (nrkarty.Text.Length != 19)
            {
                niemadanych = true;
                ilejestbledow = ilejestbledow + 1;
                if (ilejestbledow == 2)
                {
                    goto duzobledow;
                }
            }

            if (datawaz.Text.Length == 6)
            {
                for (int i = 0; i < datawaz.Text.Length; i++)
                {
                    if (Char.IsDigit(datawaz.Text[i]) == false)
                    {
                        niemadanych = true;
                        ilejestbledow = ilejestbledow + 1;
                        if (ilejestbledow == 2)
                        {
                            goto duzobledow;
                        }
                        break;
                    }
                }

            }
            else if (datawaz.Text.Length != 7)
            {
                niemadanych = true;
                ilejestbledow = ilejestbledow + 1;
                if (ilejestbledow == 2)
                {
                    goto duzobledow;
                }
            }

            if (kodzabez.Text.Length == 3)
            {
                for (int i = 0; i < kodzabez.Text.Length; i++)
                {
                    if (Char.IsDigit(kodzabez.Text[i]) == false)
                    {
                        niemadanych = true;
                        ilejestbledow = ilejestbledow + 1;
                        if (ilejestbledow == 2)
                        {
                            goto duzobledow;
                        }
                        break;
                    }
                }

            }
            else if (kodzabez.Text.Length != 3)
            {
                niemadanych = true;
                ilejestbledow = ilejestbledow + 1;
                if (ilejestbledow == 2)
                {
                    goto duzobledow;
                }
            }




            if ((nrtele.Text.Length == 9) && czyjestblad == false)
            {
                for (int i = 0; i < nrtele.Text.Length; i++)
                {
                    if (Char.IsDigit(nrtele.Text[i]) == false)
                    {
                        czyjestblad = true;
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Nieprawidłowy numer telefonu");
                        break;
                    }
                }
            }
            else if ((nrtele.Text.Length != 11) && czyjestblad == false)
            {
                czyjestblad = true;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nieprawidłowy numer telefonu");
            }

            if ((nrkarty.Text.Length == 16) && czyjestblad == false)
            {
                for (int i = 0; i < nrkarty.Text.Length; i++)
                {
                    if (Char.IsDigit(nrkarty.Text[i]) == false)
                    {
                        czyjestblad = true;
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Nieprawidłowy numer karty");
                        break;
                    }
                }
            }
            else if ((nrkarty.Text.Length != 19) && czyjestblad == false)
            {
                czyjestblad = true;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nieprawidłowy numer karty");
            }

            if ((datawaz.Text.Length == 6) && czyjestblad == false)
            {
                for (int i = 0; i < datawaz.Text.Length; i++)
                {
                    if (Char.IsDigit(datawaz.Text[i]) == false)
                    {
                        czyjestblad = true;
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Nieprawidłowa data ważnosci");
                        break;
                    }
                }
            }
            else if ((datawaz.Text.Length != 7) && czyjestblad == false)
            {
                czyjestblad = true;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nieprawidłowa data ważności");
            }

            if ((kodzabez.Text.Length == 3) && czyjestblad == false)
            {
                for (int i = 0; i < kodzabez.Text.Length; i++)
                {
                    if (Char.IsDigit(kodzabez.Text[i]) == false)
                    {
                        czyjestblad = true;
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Nieprawidłowy kod zabezpieczający");
                        break;
                    }
                }
            }
            else if ((kodzabez.Text.Length != 3) && czyjestblad == false)
            {
                czyjestblad = true;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nieprawidłowy kod zabezpieczający");
            }

            if ((kodpocz.Text.Length == 5) && czyjestblad == false)
            {
                for (int i = 0; i < kodpocz.Text.Length; i++)
                {
                    if (Char.IsDigit(kodpocz.Text[i]) == false)
                    {
                        czyjestblad = true;
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Nieprawidłowy kod pocztowy");
                    }
                }

            }
            else if ((kodpocz.Text.Length != 6) && czyjestblad == false)
            {
                czyjestblad = true;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nieprawidłowy kod pocztowy");
            }


        duzobledow:
            if (ilejestbledow == 2)
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nieprawidłowo wprowadzone dane");
                niemadanych = true;
                czyjestblad = true;
            }
        niewypelniono:
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

        private void nrtele_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

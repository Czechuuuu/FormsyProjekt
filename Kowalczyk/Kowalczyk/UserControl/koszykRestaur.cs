using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kowalczyk
{
    public partial class koszykRestaur : UserControl
    {
        static public int suma = 0;
        static public String[] Produkty = new string[12] {"Herbata mrożona", "Hot dog", "Coca-Cola", "Sałatka Cezar", "Nuggetsy z kurczaka", "Podwójny cheeseburger", "Cheeseburger", "Skrzydełka kurczaka", "Kawa", "Lemoniada", "Frytki", "Hamburger" };
        static public int[] Ceny = new int[12] { 6, 7, 7, 10, 8, 13, 8, 10, 6, 6, 7, 8 };
        static public int[] ilosc = new int[12] {0, 0, 0, 0, 0, 0, 0, 0 , 0 , 0, 0, 0 };
        static public int[] czyjuzjest = new int[4] { 0, 0, 0, 0 };



        public koszykRestaur()
        {
            InitializeComponent();
        }

        private void koszykRestaur_Load(object sender, EventArgs e)
        {
            ilosc = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            czyjuzjest = new int[4] { 0, 0, 0, 0 };
            suma = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[0]} - {Ceny[0]} zł");
            suma = suma + Ceny[0];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[0] == 0 )
            {
                lista.Items.Add($"{Produkty[0]} - {ilosc[0]+1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[0]} - {ilosc[0]}")
                    {

                        lista.Items[i] = $"{Produkty[0]} - {ilosc[0]+1}";
                        break;
                    }
                }
            }
            ilosc[0] = ilosc[0] + 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "stronaGlownaZalogowana")
                {
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {

                int ID;
                var lines = File.ReadAllLines("koszyk.txt");
                StreamReader sr = new StreamReader("koszyk.txt");
                String line;
                bool czyjest = false;
                while ((line = sr.ReadLine()) != null)
                {
                    czyjest = true;
                }
                sr.Close();

                bool czycosjest = false;

                for (int i = 0; i < ilosc.Length; i++)
                {
                    if (ilosc[i] != 0)
                    {
                        czycosjest = true;
                        break;
                    }
                }

                for (int i = 0; i < czyjuzjest.Length; i++)
                {
                    if (czyjuzjest[i] != 0)
                    {
                        czycosjest = true;
                        break;
                    }
                }

                if (czycosjest == false)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("W koszyku nic nie ma");
                }

                if ((czyjest == false) && (czycosjest == true))
                {

                    Zamówienie sgz = new Zamówienie();
                    sgz.ShowDialog();

                    if (Zamówienie.czyDokonanoZamowienia == true)
                    {

                        ID = 1;
                        String[] linia = new string[1] { $"{ID} {Login.ID} {suma} {ilosc[0]} {ilosc[1]} {ilosc[2]} {ilosc[3]} {ilosc[4]} {ilosc[5]} {ilosc[6]} {ilosc[7]} {ilosc[8]} {ilosc[9]} {ilosc[10]} {ilosc[11]} {czyjuzjest[0]} {czyjuzjest[1]} {czyjuzjest[2]} {czyjuzjest[3]}" };
                        File.WriteAllLines("koszyk.txt", linia);

                        kosz.Items.Clear();
                        lista.Items.Clear();
                        ilosc = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        czyjuzjest = new int[4] { 0, 0, 0, 0 };
                        suma = 0;
                        sumapro.Text = $"{suma.ToString()}";
                    }
 
                }
                else if ((czyjest == true) && (czycosjest == true))
                {

                    Zamówienie sgz = new Zamówienie();
                    sgz.ShowDialog();

                    if (Zamówienie.czyDokonanoZamowienia == true)
                    {


                        String[] newlines = new string[lines.Length + 1];
                        for (int i = 0; i < newlines.Length; i++)
                        {

                            if (i == (newlines.Length - 1))
                            {
                                var word = lines[i - 1].Split(' ');
                                ID = int.Parse(word[0]);
                                int newID = ID + 1;
                                String newID2 = newID.ToString();
                                newlines[i] = $"{newID2} {Login.ID} {suma} {ilosc[0]} {ilosc[1]} {ilosc[2]} {ilosc[3]} {ilosc[4]} {ilosc[5]} {ilosc[6]} {ilosc[7]} {ilosc[8]} {ilosc[9]} {ilosc[10]} {ilosc[11]} {czyjuzjest[0]} {czyjuzjest[1]} {czyjuzjest[2]} {czyjuzjest[3]}";
                            }
                            else
                            {
                                newlines[i] = lines[i];
                            }
                        }
                        File.WriteAllLines("koszyk.txt", newlines);

                        kosz.Items.Clear();
                        lista.Items.Clear();
                        ilosc = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        czyjuzjest = new int[4] { 0, 0, 0, 0 };
                        suma = 0;
                        sumapro.Text = $"{suma.ToString()}";
                    }
                }
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Aby dokonać zamówienia, należy być zalogowany");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[9]} - {Ceny[9]} zł");
            suma = suma + Ceny[9];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[9] == 0)
            {
                lista.Items.Add($"{Produkty[9]} - {ilosc[9] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[9]} - {ilosc[9]}")
                    {

                        lista.Items[i] = $"{Produkty[9]} - {ilosc[9] + 1}";
                        break;
                    }
                }
            }
            ilosc[9] = ilosc[9] + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[1]} - {Ceny[1]} zł");
            suma = suma + Ceny[1];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[1] == 0)
            {
                lista.Items.Add($"{Produkty[1]} - {ilosc[1] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[1]} - {ilosc[1]}")
                    {

                        lista.Items[i] = $"{Produkty[1]} - {ilosc[1] + 1}";
                        break;
                    }
                }
            }
            ilosc[1] = ilosc[1] + 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[2]} - {Ceny[2]} zł");
            suma = suma + Ceny[2];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[2] == 0)
            {
                lista.Items.Add($"{Produkty[2]} - {ilosc[2] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[2]} - {ilosc[2]}")
                    {

                        lista.Items[i] = $"{Produkty[2]} - {ilosc[2] + 1}";
                        break;
                    }
                }
            }
            ilosc[2] = ilosc[2] + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[3]} - {Ceny[3]} zł");
            suma = suma + Ceny[3];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[3] == 0)
            {
                lista.Items.Add($"{Produkty[3]} - {ilosc[3] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[3]} - {ilosc[3]}")
                    {

                        lista.Items[i] = $"{Produkty[3]} - {ilosc[3] + 1}";
                        break;
                    }
                }
            }
            ilosc[3] = ilosc[3] + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[4]} - {Ceny[4]} zł");
            suma = suma + Ceny[4];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[4] == 0)
            {
                lista.Items.Add($"{Produkty[4]} - {ilosc[4] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[4]} - {ilosc[4]}")
                    {

                        lista.Items[i] = $"{Produkty[4]} - {ilosc[4] + 1}";
                        break;
                    }
                }
            }
            ilosc[4] = ilosc[4] + 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[5]} - {Ceny[5]} zł");
            suma = suma + Ceny[5];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[5] == 0)
            {
                lista.Items.Add($"{Produkty[5]} - {ilosc[5] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[5]} - {ilosc[5]}")
                    {

                        lista.Items[i] = $"{Produkty[5]} - {ilosc[5] + 1}";
                        break;
                    }
                }
            }
            ilosc[5] = ilosc[5] + 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[6]} - {Ceny[6]} zł");
            suma = suma + Ceny[6];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[6] == 0)
            {
                lista.Items.Add($"{Produkty[6]} - {ilosc[6] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[6]} - {ilosc[6]}")
                    {

                        lista.Items[i] = $"{Produkty[6]} - {ilosc[6] + 1}";
                        break;
                    }
                }
            }
            ilosc[6] = ilosc[6] + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[7]} - {Ceny[7]} zł");
            suma = suma + Ceny[7];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[7] == 0)
            {
                lista.Items.Add($"{Produkty[7]} - {ilosc[7] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[7]} - {ilosc[7]}")
                    {

                        lista.Items[i] = $"{Produkty[7]} - {ilosc[7] + 1}";
                        break;
                    }
                }
            }
            ilosc[7] = ilosc[7] + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[8]} - {Ceny[8]} zł");
            suma = suma + Ceny[8];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[8] == 0)
            {
                lista.Items.Add($"{Produkty[8]} - {ilosc[8] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[8]} - {ilosc[8]}")
                    {

                        lista.Items[i] = $"{Produkty[8]} - {ilosc[8] + 1}";
                        break;
                    }
                }
            }
            ilosc[8] = ilosc[8] + 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[10]} - {Ceny[10]} zł");
            suma = suma + Ceny[10];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[10] == 0)
            {
                lista.Items.Add($"{Produkty[10]} - {ilosc[10] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[10]} - {ilosc[10]}")
                    {

                        lista.Items[i] = $"{Produkty[10]} - {ilosc[10] + 1}";
                        break;
                    }
                }
            }
            ilosc[10] = ilosc[10] + 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[11]} - {Ceny[11]} zł");
            suma = suma + Ceny[11];
            sumapro.Text = $"{suma.ToString()} zł";
            if (ilosc[11] == 0)
            {
                lista.Items.Add($"{Produkty[11]} - {ilosc[11] + 1}");
            }
            else
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (lista.Items[i].ToString() == $"{Produkty[11]} - {ilosc[11]}")
                    {

                        lista.Items[i] = $"{Produkty[11]} - {ilosc[11] + 1}";
                        break;
                    }
                }
            }
            ilosc[11] = ilosc[11] + 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String to = "";
            int ktory = 0;
            int flag = 0;
            String ktoryzestaw = "";
            int odktoregoID = 0;
            if (kosz.SelectedItem == null) 
            {
                flag = 1;
            }

            bool dolnyzakres = false;
            bool gornyzakres = false;
            String pomoc;

            if (flag == 0)
            {
                int ktory2 = kosz.SelectedIndex;

                for (int i = kosz.SelectedIndex; i < kosz.SelectedIndex+5; i++)
                {
                    if ((dolnyzakres == false))
                    {
                        if (i < kosz.Items.Count)
                        {
                            if (kosz.Items[i].ToString() == "----------------------------")
                            {
                                dolnyzakres = true;
                            }
                        }
                    }
                    if ((gornyzakres == false))
                    {
                        if (ktory2 >= 0)
                        {
                            pomoc = kosz.Items[ktory2].ToString();
                            var word = pomoc.Split(' ');
                            if (word.Length > 1)
                            {
                                if (word[1][0] == 's' && word[0][0] == '-')
                                {
                                    gornyzakres = true;
                                    ktoryzestaw = "s";
                                    odktoregoID = ktory2;
                                }
                                if (word[1][0] == 'h' && word[0][0] == '-')
                                {
                                    gornyzakres = true;
                                    ktoryzestaw = "h";
                                    odktoregoID = ktory2;
                                }
                                if (word[1][0] == 'p' && word[0][0] == '-')
                                {
                                    gornyzakres = true;
                                    ktoryzestaw = "p";
                                    odktoregoID = ktory2;
                                }
                                if (word[1][0] == 'n' && word[0][0] == '-')
                                {
                                    gornyzakres = true;
                                    ktoryzestaw = "n";
                                    odktoregoID = ktory2;
                                }
                            }
                        }
                    }
                    ktory2 = ktory2 - 1;
                }

                if (dolnyzakres == true && gornyzakres == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        kosz.Items.RemoveAt(odktoregoID);
                    }

                    if (ktoryzestaw == "n")
                    {
                        suma = suma - 15;
                        sumapro.Text = $"{suma.ToString()} zł";
                        czyjuzjest[3] = 0;
                        for (int i = 0; i < lista.Items.Count; i++)
                        {
                            if (lista.Items[i].ToString() == "--Zestaw nuggets--")
                            {
                                lista.Items.RemoveAt(i);
                            }
                        }
                    }
                    if (ktoryzestaw == "s")
                    {
                        suma = suma - 17;
                        sumapro.Text = $"{suma.ToString()} zł";
                        czyjuzjest[2] = 0;
                        for (int i = 0; i < lista.Items.Count; i++)
                        {
                            if (lista.Items[i].ToString() == "--Zestaw skrzydełka--")
                            {
                                lista.Items.RemoveAt(i);
                            }
                        }
                    }
                    if (ktoryzestaw == "p")
                    {
                        suma = suma - 22;
                        sumapro.Text = $"{suma.ToString()} zł";
                        czyjuzjest[1] = 0;
                        for (int i = 0; i < lista.Items.Count; i++)
                        {
                            if (lista.Items[i].ToString() == "--Zestaw podwójny cheeseburger--")
                            {
                                lista.Items.RemoveAt(i);
                            }
                        }
                    }
                    if (ktoryzestaw == "h")
                    {
                        suma = suma - 16;
                        sumapro.Text = $"{suma.ToString()} zł";
                        czyjuzjest[0] = 0;
                        for (int i = 0; i < lista.Items.Count; i++)
                        {
                            if (lista.Items[i].ToString() == "--Zestaw hamburger--")
                            {
                                lista.Items.RemoveAt(i);
                            }
                        }
                    }
                    flag = 1;
                }

            }


            if (flag == 0)
            {
                String cos = kosz.SelectedItem.ToString();
                var word = cos.Split(' ');
                



                kosz.Items.Remove(kosz.SelectedItem.ToString());
                for (int i = 0; i < word.Length; i++)
                {
                    if (Char.IsNumber(word[i], 0) == false)
                    {
                        continue;
                    }
                    else
                    {
                        suma = suma - int.Parse(word[i]);
                        sumapro.Text = $"{suma.ToString()} zł";
                        break;
                    }
                }
                for (int i = 0; i < lista.Items.Count; i++) 
                {
                    var wiersz = lista.Items[i].ToString();
                    var wyraz = wiersz.Split(' ');
                    if (word[0] == wyraz[0])
                    {
                        for (int j = 0; j < Produkty.Length; j++)
                        {
                            var word3 = Produkty[j].Split();
                            if (wyraz[0] == word3[0])
                            {
                                to = Produkty[j];
                                ktory = j;
                                break;
                            }
                        }
                        int ile = int.Parse(wyraz[wyraz.Length-1]);
                        lista.Items[i] = $"{to} - {(ile-1).ToString()}";
                        if ((ilosc[ktory] - 1) <= 0)
                        {
                            ilosc[ktory] = ilosc[ktory] - 1;
                            lista.Items.RemoveAt(i);
                        }
                        else
                        {
                            ilosc[ktory] = ilosc[ktory] - 1;
                        }
                        break;
                    }
                }
            }

            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //dodawanie do koszyka całych kuponów rabatowych
                //Kupon 1 Hamburger

            bool flag1 = false;

            if (promokod.Text == "7YvgAz")
            {
                flag1 = true;
            }
            else if (promokod.Text == "oMfUkk")
            {
                flag1 = true;
            }
            else if (promokod.Text == "ndrueB")
            {
                flag1 = true;
            }
            else if (promokod.Text == "wjL95V")
            {
                flag1 = true;
            }


            if (flag1 == true)
            {
                if ((promokod.Text == "7YvgAz") && czyjuzjest[0] == 0)
                {
                    kosz.Items.Add("--Zestaw hamburger--");
                    kosz.Items.Add($"{Produkty[10]} - {Ceny[10]} zł");
                    kosz.Items.Add($"{Produkty[9]} - {Ceny[9]} zł");
                    kosz.Items.Add($"{Produkty[11]} - {Ceny[11]} zł");
                    kosz.Items.Add("----------------------------");
                    suma = suma + 16;
                    sumapro.Text = $"{suma.ToString()} zł";
                    czyjuzjest[0] = czyjuzjest[0] + 1;
                    lista.Items.Add("--Zestaw hamburger--");

                }
                else if ((promokod.Text == "7YvgAz") && czyjuzjest[0] != 0)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Można wykorzystać kupon tylko raz");
                }
                //kupon 2 Cheeseburger
                if ((promokod.Text == "oMfUkk") && czyjuzjest[1] == 0)
                {
                    kosz.Items.Add("--Zestaw podwójny cheeseburger--");
                    kosz.Items.Add($"{Produkty[3]} - {Ceny[3]} zł");
                    kosz.Items.Add($"{Produkty[5]} - {Ceny[5]} zł");
                    kosz.Items.Add($"{Produkty[0]} - {Ceny[0]} zł");
                    kosz.Items.Add("----------------------------");
                    suma = suma + 22;
                    sumapro.Text = $"{suma.ToString()} zł";
                    czyjuzjest[1] = czyjuzjest[1] + 1;
                    lista.Items.Add("--Zestaw podwójny cheeseburger--");
                }
                else if ((promokod.Text == "oMfUkk") && czyjuzjest[1] != 0)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Można wykorzystać kupon tylko raz");
                }
                //kupon3 skrzydałka
                if ((promokod.Text == "ndrueB") && czyjuzjest[2] == 0)
                {
                    kosz.Items.Add("--Zestaw skrzydełka--");
                    kosz.Items.Add($"{Produkty[7]} - {Ceny[7]} zł");
                    kosz.Items.Add($"{Produkty[8]} - {Ceny[8]} zł");
                    kosz.Items.Add($"{Produkty[10]} - {Ceny[10]} zł");
                    kosz.Items.Add("----------------------------");
                    suma = suma + 17;
                    sumapro.Text = $"{suma.ToString()} zł";
                    czyjuzjest[2] = czyjuzjest[2] + 1;
                    lista.Items.Add("--Zestaw skrzydełka--");
                }
                else if ((promokod.Text == "ndrueB") && czyjuzjest[2] != 0)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Można wykorzystać kupon tylko raz");
                }
                //kupon4 Nuggets
                if ((promokod.Text == "wjL95V") && czyjuzjest[3] == 0)
                {
                    kosz.Items.Add("--Zestaw nuggets--");
                    kosz.Items.Add($"{Produkty[4]} - {Ceny[4]} zł");
                    kosz.Items.Add($"{Produkty[2]} - {Ceny[2]} zł");
                    kosz.Items.Add($"{Produkty[11]} - {Ceny[10]} zł");
                    kosz.Items.Add("----------------------------");
                    suma = suma + 15;
                    sumapro.Text = $"{suma.ToString()} zł";
                    czyjuzjest[3] = czyjuzjest[3] + 1;
                    lista.Items.Add("--Zestaw nuggets--");
                }
                else if ((promokod.Text == "wjL95V") && czyjuzjest[3] != 0)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Można wykorzystać kupon tylko raz");
                }
                promokod.Text = "";
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Podano nieprawidłowy kod");
            }

        }
    }
}

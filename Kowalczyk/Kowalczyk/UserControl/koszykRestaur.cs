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
        static public String[] koszyk = new string[100];
        static public String[] Produkty = new string[12] {"Herbata mrożona", "Hot dog", "Coca-Cola", "Sałatka Cezar", "Nuggetsy z kurczaka", "Podwójny cheeseburger", "Cheeseburger", "Skrzydełka kurczaka", "Kawa", "Lemoniada", "Frytki", "Hamburger" };
        static public int[] Ceny = new int[12] { 6, 7, 7, 10, 8, 13, 8, 10, 6, 6, 7, 8 };



        public koszykRestaur()
        {
            InitializeComponent();
        }

        private void koszykRestaur_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[0]} - {Ceny[0]} zł");
            suma = suma + Ceny[0];
            sumapro.Text = $"{suma.ToString()} zł";
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
                var lines = File.ReadAllLines("koszyk.txt");
                String[] newlines= new string[lines.Length + 1];
                for (int i = 0; i < newlines.Length; i++)
                {

                    if (i == (newlines.Length - 1))
                    {
                        var word = lines[i - 1].Split(' ');
                        int ID = int.Parse(word[0]);
                        int newID = ID + 1;
                        String newID2 = newID.ToString();
                        newlines[i] = $"{newID2} {Login.ID} {suma}";
                    }
                    else
                    {
                        newlines[i] = lines[i];
                    }
                }
                File.WriteAllLines("koszyk.txt", newlines);
                MessageBox.Show("Dokonano zamówienia");
            }
            else
            {
                MessageBox.Show("Aby dokonać zamówienia, należy być zalogowany");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[9]} - {Ceny[9]} zł");
            suma = suma + Ceny[9];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[1]} - {Ceny[1]} zł");
            suma = suma + Ceny[1];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[2]} - {Ceny[2]} zł");
            suma = suma + Ceny[2];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[3]} - {Ceny[3]} zł");
            suma = suma + Ceny[3];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[4]} - {Ceny[4]} zł");
            suma = suma + Ceny[4];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[5]} - {Ceny[5]} zł");
            suma = suma + Ceny[5];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[6]} - {Ceny[6]} zł");
            suma = suma + Ceny[6];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[7]} - {Ceny[7]} zł");
            suma = suma + Ceny[7];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[8]} - {Ceny[8]} zł");
            suma = suma + Ceny[8];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[10]} - {Ceny[10]} zł");
            suma = suma + Ceny[10];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kosz.Items.Add($"{Produkty[11]} - {Ceny[11]} zł");
            suma = suma + Ceny[11];
            sumapro.Text = $"{suma.ToString()} zł";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (kosz.SelectedItem == null) 
            {
                flag = 1;
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
            }

            
        }
    }
}

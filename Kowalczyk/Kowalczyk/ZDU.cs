﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
    public partial class ZDU : Form
    {
        public ZDU()
        {
            InitializeComponent();
            passHide.Hide();
        }

        private void asd_Click(object sender, EventArgs e)
        {
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
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
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

        private void curpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            passHide.Text = newpass.Text;
        }

        private void btnHide_MouseDown(object sender, MouseEventArgs e)
        {
            passHide.Show();
            newpass.Hide();

        }

        private void btnHide_MouseUp(object sender, MouseEventArgs e)
        {
            passHide.Hide();
            newpass.Show();
        }
    }
}

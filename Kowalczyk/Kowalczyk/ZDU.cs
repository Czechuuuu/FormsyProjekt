using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Media;
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
        }

        private void asd_Click(object sender, EventArgs e)
        {
            if (curpass.Text == Login.H)
            {
                
                String nowehaslo = curpass.Text;
                SQLiteConnection conn2 = new SQLiteConnection("Data Source=Database1.db; Pooling=false");
                conn2.Open();
               
                SQLiteCommand cmd = new SQLiteCommand($"UPDATE Login SET password = '{nowehaslo}' WHERE password = '{Login.H}'", conn2);        
                cmd.ExecuteNonQuery();
                
                SystemSounds.Beep.Play();
                MessageBox.Show("Zmieniono hasło");
                
                conn2.Close();


            }
            else if (curpass.Text == newpass.Text && (curpass.Text != "" || newpass.Text != ""))   
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
            stronaGlownaZalogowana sgz = new stronaGlownaZalogowana();
            this.Hide();
            sgz.ShowDialog();
            this.Close();
        }

        private void curpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

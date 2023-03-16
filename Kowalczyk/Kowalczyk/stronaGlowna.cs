using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kowalczyk
{
    public partial class stronaGlowna : Form
    {
        public stronaGlowna()
        {
            InitializeComponent();
        }
        public static void powrot()
        {
            stronaGlowna sg = new stronaGlowna();
            sg.Show();
        }
        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            btnZaloguj.Text = "Wyloguj";
            this.Show();
        }
    }
}

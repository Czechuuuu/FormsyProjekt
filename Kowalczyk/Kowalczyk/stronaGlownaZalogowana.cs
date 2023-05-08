using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kowalczyk
{
    public partial class stronaGlownaZalogowana : Form
    {
        public stronaGlownaZalogowana()
        {
            InitializeComponent();
        }

        private void ZDU_Click(object sender, EventArgs e)
        {
            ZDU sgz = new ZDU();
            this.Hide();
            sgz.ShowDialog();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            stronaGlowna x = new stronaGlowna();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
    }
}

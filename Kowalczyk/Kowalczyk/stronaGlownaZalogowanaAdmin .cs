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
    public partial class stronaGlownaZalogowanaA : Form
    {
        public stronaGlownaZalogowanaA()
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

        private void button1_Click(object sender, EventArgs e)
        {
            ZU sgz = new ZU();
            this.Hide();
            sgz.ShowDialog();
            this.Close();
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            stronaGlowna sgz = new stronaGlowna();
            this.Hide();
            sgz.ShowDialog();
            this.Close();
        }
    }
}

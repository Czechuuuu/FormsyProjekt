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

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainerSG.Controls.Clear();
            panelContainerSG.Controls.Add(userControl);
            userControl.BringToFront();
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

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            stronaGlowna sgz = new stronaGlowna();
            this.Hide();
            sgz.ShowDialog();
            this.Close();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            menuRestaur menuR = new menuRestaur();
            AddUserControl(menuR);
        }

        private void buttonKupony_Click(object sender, EventArgs e)
        {
            kuponyRestaur kupoR = new kuponyRestaur();
            AddUserControl(kupoR);
        }

        private void buttonKoszyk_Click(object sender, EventArgs e)
        {
            koszykRestaur koszR = new koszykRestaur();
            AddUserControl(koszR);
        }

        private void buttonRestauracje_Click(object sender, EventArgs e)
        {
            restauracjeRestaur restR = new restauracjeRestaur();
            AddUserControl(restR);
        }

        private void buttonKontakt_Click(object sender, EventArgs e)
        {
            kontaktRestaur kontR = new kontaktRestaur();
            AddUserControl(kontR);
        }
    }
}

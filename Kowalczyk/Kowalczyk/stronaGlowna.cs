using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
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

        private void AddUserControl(UserControl userControl) 
        {
            userControl.Dock = DockStyle.Fill;
            panelContainerSG.Controls.Clear();
            panelContainerSG.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public static void powrot()
        {   
            stronaGlowna sg = new stronaGlowna();
            sg.Show();
        }
        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            menuRestaur menuR = new menuRestaur();
            AddUserControl(menuR);
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

        private void buttonLogo_Click(object sender, EventArgs e)
        {
            stronaglownaRestaur sgloR = new stronaglownaRestaur();
            AddUserControl(sgloR);
        }

        private void stronaglownaRestaur1_Load(object sender, EventArgs e)
        {

        }

        private void stronaGlowna_Load(object sender, EventArgs e)
        {

        }
    }
}

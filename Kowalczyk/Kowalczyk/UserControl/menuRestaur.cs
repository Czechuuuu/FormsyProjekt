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
    public partial class menuRestaur : UserControl
    {
        public menuRestaur()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainerMenu.Controls.Clear();
            panelContainerMenu.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void kan_butt_Click(object sender, EventArgs e)
        {
            skrz_img.Show();
            ham_img.Show();
            pchee_img.Show();
            chee_img.Show();
            lem_img.Hide();
            kaw_img.Hide();
            ice_img.Hide();
            co_img.Hide();
            cez_img.Hide();
            nugg_img.Hide();
            hot_img.Hide();
            fry_img.Hide();

            skrz_lab.Show();
            ham_lab.Show();
            pchee_lab.Show();
            chee_lab.Show();
            lem_lab.Hide();
            Kaw_lab.Hide();
            ice_lab.Hide();
            co_lab.Hide();
            cez_lab.Hide();
            nug_lab.Hide();
            hot_lab.Hide();
            fry_lab.Hide();
        }

        private void dod_butt_Click(object sender, EventArgs e)
        {
            skrz_img.Hide();
            ham_img.Hide();
            pchee_img.Hide();
            chee_img.Hide();
            lem_img.Hide();
            kaw_img.Hide();
            ice_img.Hide();
            co_img.Hide();
            cez_img.Show();
            nugg_img.Show();
            hot_img.Show();
            fry_img.Show();

            skrz_lab.Hide();
            ham_lab.Hide();
            pchee_lab.Hide();
            chee_lab.Hide();
            lem_lab.Hide();
            Kaw_lab.Hide();
            ice_lab.Hide();
            co_lab.Hide();
            cez_lab.Show();
            nug_lab.Show();
            hot_lab.Show();
            fry_lab.Show();

        }

        private void nap_butt_Click(object sender, EventArgs e)
        {
            skrz_img.Hide();
            ham_img.Hide();
            pchee_img.Hide();
            chee_img.Hide();
            lem_img.Show();
            kaw_img.Show();
            ice_img.Show();
            co_img.Show();
            cez_img.Hide();
            nugg_img.Hide();
            hot_img.Hide();
            fry_img.Hide();

            skrz_lab.Hide();
            ham_lab.Hide();
            pchee_lab.Hide();
            chee_lab.Hide();
            lem_lab.Show();
            Kaw_lab.Show();
            ice_lab.Show();
            co_lab.Show();
            cez_lab.Hide();
            nug_lab.Hide();
            hot_lab.Hide();
            fry_lab.Hide();
        }
    }
}

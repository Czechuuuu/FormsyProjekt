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
    public partial class ZU : Form
    {
        public ZU()
        {
            InitializeComponent();
        }

        private void DU_Click(object sender, EventArgs e)
        {
            DU x = new DU();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            stronaGlownaZalogowanaA x = new stronaGlownaZalogowanaA();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

        private void UU_Click(object sender, EventArgs e)
        {
            

            UU x = new UU();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
    }
}

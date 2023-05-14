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
    public partial class kuponyRestaur : UserControl
    {
        public kuponyRestaur()
        {
            InitializeComponent();
        }

        private void btnCopy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("7YvgAz");
            MessageBox.Show("Skopiowano do schowka");
        }

        private void btnCopy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("oMfUkk");
            MessageBox.Show("Skopiowano do schowka");

        }

        private void btnCopy3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("ndrueB");
            MessageBox.Show("Skopiowano do schowka");

        }

        private void btnCopy4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("wjL95V");
            MessageBox.Show("Skopiowano do schowka");

        }
    }
}

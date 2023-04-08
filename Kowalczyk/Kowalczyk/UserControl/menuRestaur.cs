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
    }
}

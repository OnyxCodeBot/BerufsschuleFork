using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adressbuch
{
    public partial class AdressForm : Form
    {
        public AdressForm()
        {
            InitializeComponent();
        }

        private void neuerDatensatzToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}

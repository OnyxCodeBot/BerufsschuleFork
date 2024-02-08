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
        private IPersonDAO pers = new PersonDAO();

        public AdressForm()
        {
            InitializeComponent();
            neuToolStripMenuItem.PerformClick();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void RefreshBinding()
        {
            personBindingSource.DataSource = pers.PList;
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pers.NewData();
            RefreshBinding();

            personBindingSource.AddNew();
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pers.LoadData();
            RefreshBinding();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personBindingSource.EndEdit();
            pers.SaveData();
        }

        private void AdressForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Wollen Sie speichern?", "Programmende", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pers.SaveData();
            }
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            speichernToolStripMenuItem.PerformClick();
        }

        private void neuerDatensatzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personBindingSource.AddNew();
        }

        private void datensatzLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personBindingSource.RemoveCurrent();
        }
    }
}

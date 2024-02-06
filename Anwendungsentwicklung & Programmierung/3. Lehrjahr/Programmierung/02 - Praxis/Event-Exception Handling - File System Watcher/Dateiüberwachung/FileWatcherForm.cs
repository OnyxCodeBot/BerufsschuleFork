using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dateiüberwachung
{
    public partial class FileWatcherForm : Form
    {
        public FileWatcherForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            fsWatcher.EnableRaisingEvents = false;
            MessageBox.Show("Applikation wird geschlossen.");
            this.Close();
        }

        //Startet die Überwachung des Ordners
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txtPfad.Text == "")
                {
                    throw new Exception("Kein Pfad zur Überwachung angegeben.");
                }
                //Überwachung starten
                fsWatcher.Path = this.txtPfad.Text;
                fsWatcher.EnableRaisingEvents = true;

                //Start/Stoppbutton aktivieren/deaktivieren
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPfad.SelectAll();
                txtPfad.Focus();
            }
        }

        //Stoppt die Überwachung des Ordners
        private void btnStop_Click(object sender, EventArgs e)
        {
            //Überwachung stoppen
            fsWatcher.EnableRaisingEvents = false;

            //Start/Stoppbutton aktivieren/deaktivieren
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        //Abfangen der verschiedenen Änderungs-
        //möglichkeiten im gewählten Verzeichnis
        private void fsWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            lstFiles.Items.Add("Geändert: " + e.FullPath);
        }

        private void fsWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            lstFiles.Items.Add("Erstellt: " + e.FullPath);
        }

        private void fsWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            lstFiles.Items.Add("Gelöscht: " + e.FullPath);
        }

        private void fsWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            lstFiles.Items.Add("Umbenannt: " + e.FullPath);
        }

        private void chkSubFolder_Click(object sender, EventArgs e)
        {
            try
            {
                fsWatcher.IncludeSubdirectories = chkSubFolder.Checked;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK , MessageBoxIcon.Error);
                txtPfad.SelectAll();
                txtPfad.Focus();
            }
        }

        private void btn_fbDialog_Click(object sender, EventArgs e)
        {
            fbDialog.SelectedPath = "K:\\";
            if(fbDialog.ShowDialog() == DialogResult.OK)
            {
                txtPfad.Text = fbDialog.SelectedPath;
            }
        }
    }
}

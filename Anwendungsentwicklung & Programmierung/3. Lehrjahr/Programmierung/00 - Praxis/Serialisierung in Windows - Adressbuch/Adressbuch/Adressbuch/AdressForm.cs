using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adressbuch
{
    public partial class AdressForm : Form
    {
        private IPersonDAO pers = new PersonDAO();
        private PageSettings pageSet = new PageSettings();

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

        private void seiteEinrichtenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Seitenränder setzen
            pageSet.Margins.Left = 100;
            pageSet.Margins.Right = 100;
            pageSet.Margins.Top = 100;
            pageSet.Margins.Bottom = 100;

            // Umrechnung in mm
            psDialog.EnableMetric = true;
            printDocument.DefaultPageSettings = pageSet;
            psDialog.PageSettings = pageSet;
            psDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Daten
            Person p = (Person)personBindingSource.Current;
            int number = personBindingSource.Position + 1;
            int count = personBindingSource.Count;
            string header = "Adressdatensatz " + number + " von " + count;

            //Grafikelemente
            Graphics g = e.Graphics;

            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            Brush headerBrush = Brushes.Blue;

            Font textFont = new Font("Arial", 14, FontStyle.Regular);
            Brush textBrush = Brushes.Black;

            //Zeilenabstand und Ränder
            float headerWidth = g.MeasureString(header, headerFont).Width;
            float headerHeight = g.MeasureString(header, headerFont).Height;

            float row = e.MarginBounds.Height / headerHeight;

            float column1 = e.MarginBounds.Left;
            float column2 = e.MarginBounds.Left + e.MarginBounds.Width / 3.0f;

            //Überschrift drucken
            g.DrawString(header, headerFont, headerBrush, 
                e.MarginBounds.Left + (e.MarginBounds.Width - headerWidth) / 2, 
                e.MarginBounds.Top);

            //Daten drucken
            int line = 3;
            g.DrawString("Name:", textFont, textBrush, column1, 
                line * row + e.MarginBounds.Top);
            g.DrawString(p.Name, textFont, textBrush, column2,
                line++ * row + e.MarginBounds.Top);

            g.DrawString("Vorname:", textFont, textBrush, column1,
                line * row + e.MarginBounds.Top);
            g.DrawString(p.Vorname, textFont, textBrush, column2,
                line++ * row + e.MarginBounds.Top);

            g.DrawString("Straße:", textFont, textBrush, column1,
                line * row + e.MarginBounds.Top);
            g.DrawString(p.Strasse, textFont, textBrush, column2,
                line++ * row + e.MarginBounds.Top);

            g.DrawString("Hausnummer:", textFont, textBrush, column1,
                line * row + e.MarginBounds.Top);
            g.DrawString(p.Hausnummer, textFont, textBrush, column2,
                line++ * row + e.MarginBounds.Top);

            g.DrawString("Postleitzahl:", textFont, textBrush, column1,
                line * row + e.MarginBounds.Top);
            g.DrawString(p.Plz, textFont, textBrush, column2,
                line++ * row + e.MarginBounds.Top);

            g.DrawString("Ort:", textFont, textBrush, column1,
                line * row + e.MarginBounds.Top);
            g.DrawString(p.Ort, textFont, textBrush, column2,
                line++ * row + e.MarginBounds.Top);

            g.DrawString("Telefon:", textFont, textBrush, column1,
                line * row + e.MarginBounds.Top);
            g.DrawString(p.Telefon, textFont, textBrush, column2,
                line++ * row + e.MarginBounds.Top);

            g.DrawString("E-Mail:", textFont, textBrush, column1,
                line * row + e.MarginBounds.Top);
            g.DrawString(p.Email, textFont, textBrush, column2,
                line++ * row + e.MarginBounds.Top);

            //Nach dem Ausdrucken eines Datensatzes
            personBindingSource.MoveNext();

            if (number < count)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void druckvorschauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ppDialog.Document = printDocument;
            personBindingSource.MoveFirst();

            //Dialog anzeigen
            ppDialog.ShowDialog();
        }

        private void druckenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dialog anzeigen, wenn der Benuzer OK klickt
            if(pDialog.ShowDialog() == DialogResult.OK)
            {
                //Auf ersten Datensatz springen
                personBindingSource.MoveFirst();

                //PrinterSettings setzen
                printDocument.PrinterSettings = pDialog.PrinterSettings;

                //Druck starten
                printDocument.Print();
            }
        }
    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ManageBuchungenApp
{
	/// <summary>
	/// Klasse UC 01.6, Buchungen an den Veranstalter melden
	/// </summary>
	/// <remarks>
	/// Aktuelle Events werden angezeigt, um die Benachrichtigug an den Eventveranstalter
	/// ueber gebuchte Plaetze automatisiert erstellen zu lassen
	///</remarks>
	public class VeranstalterBenachrichtigungsForm : System.Windows.Forms.Form
	{
		// Steuerelemente des Forms
		private System.Windows.Forms.ListBox lstVeranstalterBenachrichtigungen;
		private System.Windows.Forms.Button btnBenachrichtigen;
		/// <summary>
		/// Array mit aktuellen Events zur Benachrichtigung der Eventveranstalter
		/// </summary>
		private ManageBuchungen.IVeranstalterBenachrichtigung[] aBenachrichtigungen;
		private System.Windows.Forms.GroupBox gpVeranstalter;
		private System.Windows.Forms.MainMenu veranstalterMenue;
		private System.Windows.Forms.HelpProvider hpVeranstalter;
		private System.Windows.Forms.ToolTip veranstalterToolTip;
		private System.Windows.Forms.MenuItem mnuVeranstalterBenachrichtigungen;
		private System.Windows.Forms.MenuItem mnuBenachrichtigen;
		private System.Windows.Forms.MenuItem mnuSeperator1;
		private System.Windows.Forms.MenuItem mnuSeperator2;
		private System.Windows.Forms.MenuItem mnuAktualisieren;
		private System.Windows.Forms.Button btnAktualisieren;
		private System.Windows.Forms.Button btnSchliessen;
		private System.Windows.Forms.MenuItem mnuSchliessen;
		private System.ComponentModel.IContainer components;

		/// <summary>
		/// Konstruktor mit Initialisierungen
		/// </summary>
		public VeranstalterBenachrichtigungsForm()
		{
			// Erforderlich für die Windows Form-Designerunterstützung
			InitializeComponent();

			// Array mit Veranstalterbenachrichtigungen aus der Datenbank lesen
			this.FillVeranstalterBenachrichtigungen();
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeranstalterBenachrichtigungsForm));
            this.lstVeranstalterBenachrichtigungen = new System.Windows.Forms.ListBox();
            this.btnBenachrichtigen = new System.Windows.Forms.Button();
            this.gpVeranstalter = new System.Windows.Forms.GroupBox();
            this.btnAktualisieren = new System.Windows.Forms.Button();
            this.veranstalterMenue = new System.Windows.Forms.MainMenu(this.components);
            this.mnuVeranstalterBenachrichtigungen = new System.Windows.Forms.MenuItem();
            this.mnuBenachrichtigen = new System.Windows.Forms.MenuItem();
            this.mnuSeperator1 = new System.Windows.Forms.MenuItem();
            this.mnuAktualisieren = new System.Windows.Forms.MenuItem();
            this.mnuSeperator2 = new System.Windows.Forms.MenuItem();
            this.mnuSchliessen = new System.Windows.Forms.MenuItem();
            this.hpVeranstalter = new System.Windows.Forms.HelpProvider();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.veranstalterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gpVeranstalter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVeranstalterBenachrichtigungen
            // 
            this.lstVeranstalterBenachrichtigungen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hpVeranstalter.SetHelpString(this.lstVeranstalterBenachrichtigungen, "Listet die aktuellen Veranstalterbenachrichtigungen auf.");
            this.lstVeranstalterBenachrichtigungen.Location = new System.Drawing.Point(16, 24);
            this.lstVeranstalterBenachrichtigungen.Name = "lstVeranstalterBenachrichtigungen";
            this.lstVeranstalterBenachrichtigungen.ScrollAlwaysVisible = true;
            this.hpVeranstalter.SetShowHelp(this.lstVeranstalterBenachrichtigungen, true);
            this.lstVeranstalterBenachrichtigungen.Size = new System.Drawing.Size(624, 329);
            this.lstVeranstalterBenachrichtigungen.TabIndex = 0;
            this.veranstalterToolTip.SetToolTip(this.lstVeranstalterBenachrichtigungen, "Liste der Veranstalterbenachrichtigungen");
            // 
            // btnBenachrichtigen
            // 
            this.btnBenachrichtigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hpVeranstalter.SetHelpString(this.btnBenachrichtigen, "Die Veranstalterbenachrichtigungen werden generiert.");
            this.btnBenachrichtigen.Location = new System.Drawing.Point(136, 376);
            this.btnBenachrichtigen.Name = "btnBenachrichtigen";
            this.hpVeranstalter.SetShowHelp(this.btnBenachrichtigen, true);
            this.btnBenachrichtigen.Size = new System.Drawing.Size(184, 23);
            this.btnBenachrichtigen.TabIndex = 2;
            this.btnBenachrichtigen.Text = "Veranstalter be&nachrichtigen";
            this.veranstalterToolTip.SetToolTip(this.btnBenachrichtigen, "generiert die Veranstalterbenachrichtigungen");
            this.btnBenachrichtigen.Click += new System.EventHandler(this.btnBenachrichtigen_Click);
            // 
            // gpVeranstalter
            // 
            this.gpVeranstalter.Controls.Add(this.btnAktualisieren);
            this.gpVeranstalter.Controls.Add(this.lstVeranstalterBenachrichtigungen);
            this.gpVeranstalter.Controls.Add(this.btnBenachrichtigen);
            this.gpVeranstalter.Location = new System.Drawing.Point(8, 8);
            this.gpVeranstalter.Name = "gpVeranstalter";
            this.gpVeranstalter.Size = new System.Drawing.Size(656, 416);
            this.gpVeranstalter.TabIndex = 3;
            this.gpVeranstalter.TabStop = false;
            this.gpVeranstalter.Text = "Folgende Veranstalter müssen über die Buchungen Informiert werden:";
            // 
            // btnAktualisieren
            // 
            this.hpVeranstalter.SetHelpString(this.btnAktualisieren, "Die Anzeige der Veranstalterbenachrichtigungen wird aktualisiert.");
            this.btnAktualisieren.Location = new System.Drawing.Point(336, 376);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.hpVeranstalter.SetShowHelp(this.btnAktualisieren, true);
            this.btnAktualisieren.Size = new System.Drawing.Size(184, 23);
            this.btnAktualisieren.TabIndex = 3;
            this.btnAktualisieren.Text = "Benachrichtigungen &aktualisieren";
            this.veranstalterToolTip.SetToolTip(this.btnAktualisieren, "aktualisiert Anzeige der Benachrichtigungen");
            this.btnAktualisieren.Click += new System.EventHandler(this.mnuAktualisieren_Click);
            // 
            // veranstalterMenue
            // 
            this.veranstalterMenue.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuVeranstalterBenachrichtigungen});
            // 
            // mnuVeranstalterBenachrichtigungen
            // 
            this.mnuVeranstalterBenachrichtigungen.Index = 0;
            this.mnuVeranstalterBenachrichtigungen.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuBenachrichtigen,
            this.mnuSeperator1,
            this.mnuAktualisieren,
            this.mnuSeperator2,
            this.mnuSchliessen});
            this.mnuVeranstalterBenachrichtigungen.Text = "&Veranstalterbenachrichtigungen";
            // 
            // mnuBenachrichtigen
            // 
            this.mnuBenachrichtigen.Index = 0;
            this.mnuBenachrichtigen.Text = "Veranstalter be&nachrichtigen";
            this.mnuBenachrichtigen.Click += new System.EventHandler(this.btnBenachrichtigen_Click);
            // 
            // mnuSeperator1
            // 
            this.mnuSeperator1.Index = 1;
            this.mnuSeperator1.Text = "-";
            // 
            // mnuAktualisieren
            // 
            this.mnuAktualisieren.Index = 2;
            this.mnuAktualisieren.Text = "Benachrichtigungen &aktualisieren";
            this.mnuAktualisieren.Click += new System.EventHandler(this.mnuAktualisieren_Click);
            // 
            // mnuSeperator2
            // 
            this.mnuSeperator2.Index = 3;
            this.mnuSeperator2.Text = "-";
            // 
            // mnuSchliessen
            // 
            this.mnuSchliessen.Index = 4;
            this.mnuSchliessen.Text = "S&chließen";
            this.mnuSchliessen.Click += new System.EventHandler(this.mnuSchließen_Click);
            // 
            // btnSchliessen
            // 
            this.hpVeranstalter.SetHelpString(this.btnSchliessen, "Das Fenster Veranstalterbenachrichtigungen wird geschlossen.");
            this.btnSchliessen.Location = new System.Drawing.Point(217, 440);
            this.btnSchliessen.Name = "btnSchliessen";
            this.hpVeranstalter.SetShowHelp(this.btnSchliessen, true);
            this.btnSchliessen.Size = new System.Drawing.Size(240, 23);
            this.btnSchliessen.TabIndex = 4;
            this.btnSchliessen.Text = "S&chließen";
            this.veranstalterToolTip.SetToolTip(this.btnSchliessen, "Fenster schließen");
            this.btnSchliessen.Click += new System.EventHandler(this.mnuSchließen_Click);
            // 
            // VeranstalterBenachrichtigungsForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(674, 475);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.gpVeranstalter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.veranstalterMenue;
            this.MinimizeBox = false;
            this.Name = "VeranstalterBenachrichtigungsForm";
            this.Text = "Benachrichtigung der Veranstalter";
            this.Closed += new System.EventHandler(this.VeranstalterBenachrichtigungsForm_Closed);
            this.gpVeranstalter.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Listbox mit Veranstalterbenachrichtigungen fuellen
		/// </summary>
		private void FillVeranstalterBenachrichtigungen()
		{
			// Listbox und Array zuruecksetzen
			aBenachrichtigungen = null;
			this.lstVeranstalterBenachrichtigungen.Items.Clear();

			try
			{
				// Aktuelle Benachrichtigungen laden
				ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
				aBenachrichtigungen = dtm.SucheVeranstalterBenachrichtigungen();

				// Sind aktuelle Benachrichtigungen vorhanden?
				if(aBenachrichtigungen != null)
				{
					// alle Benachrichtigungen in Listbox eintragen
					for(int i = 0; i < aBenachrichtigungen.Length; i++)
						this.lstVeranstalterBenachrichtigungen.Items.Add(aBenachrichtigungen[i].Firma +"   "+aBenachrichtigungen[i].EventBezeichnung+"  "+aBenachrichtigungen[i].Beginn.ToLongDateString()+" Teilnehmerzahl: "+aBenachrichtigungen[i].Teilnehmer.ToString());
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// UC 01.6 Benachrichtigungen fuer die Veranstalter erstellen
		/// </summary>
		/// <remarks>
		/// Aktuelle Benachrichtigungen werden ueber Automatisierung mit MS Word 2000 erstellt
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBenachrichtigen_Click(object sender, System.EventArgs e)
		{
			// Variable fuer die DokumentManagement Klasse
			ManageDocuments.DokumentManagement dm = null;

			try
			{
				// aktuelle Benachrichtigungen vorhanden?
				if(this.aBenachrichtigungen != null)
				{
					// DokumentManagement Klasse initialisieren
					dm = new ManageDocuments.DokumentManagement();

					// Word oeffnen
					dm.OpenWordGenerator();

					// Alle Benachrichtigungen erstellen
					for(int i = 0; i < this.aBenachrichtigungen.Length; i++)
					{
						// Benachrichtigung erstellen
						dm.ErstelleBenachrichtigung(this.aBenachrichtigungen[i]);
						// Erstellung der Benachrichtigung in der Datenbank bestaetigen
						this.aBenachrichtigungen[i].BestaetigeBenachrichtigung();
					}
					// Refresh der Anzeige
					this.FillVeranstalterBenachrichtigungen();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				// Word schliessen
				if(dm != null)
				{
					dm.CloseWordGenerator();
					dm = null;
				}
			}
		}

		/// <summary>
		/// Aendert das Hauptmenue zum erstellen des Forms
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void VeranstalterBenachrichtigungsForm_Closed(object sender, System.EventArgs e)
		{
			// Menue zum Erstellen einer neuen Benachrichtigung freigeben
			((MainForm) this.MdiParent).SetMnuAnzeige(this.Text, true);
		}

		/// <summary>
		/// Aktualisiert die Anzeige der Veranstalterbenachrichtigungen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuAktualisieren_Click(object sender, System.EventArgs e)
		{
			this.FillVeranstalterBenachrichtigungen();
		}

		/// <summary>
		/// Schließt das Veranstalterbenachrichtigungsfenster
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuSchließen_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}

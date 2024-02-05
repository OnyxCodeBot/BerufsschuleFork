using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ManageBuchungenApp
{
	/// <summary>
	/// Klasse zu den UCs 1.4, 1.4.1 Rechnungen erstellen sowie UC 01.7 Zahlungseingang pruefen
	/// </summary>
	/// <remarks>
	/// In zwei Listboxen werdn zu erstellende Rechnungen sowie offene Rechnungen zur
	/// Bearbeitung angezeigt
	/// </remarks>
	public class ZahlungsForm : System.Windows.Forms.Form
	{
		// Steuerelemente des Forms
		private System.Windows.Forms.Button btnBezahlt;
		private System.Windows.Forms.ListBox lstOffeneRechnungen;
		private System.Windows.Forms.GroupBox grpOffeneRechnungen;
		private System.Windows.Forms.GroupBox grpAktRechnungen;
		private System.Windows.Forms.Button btnAktRechnungen;
		private System.Windows.Forms.ListBox lstAktuelleRechnungen;
		private System.ComponentModel.IContainer components;

		/// <summary>
		/// Array mit den offenen Rechnungen
		/// </summary>
		private ManageBuchungen.IRechnung[] aOffeneRechnungen;
		private System.Windows.Forms.MainMenu rechnungsMenue;
		private System.Windows.Forms.MenuItem mnuRechnung;
		private System.Windows.Forms.Button btnARladen;
		private System.Windows.Forms.Button btnORladen;
		private System.Windows.Forms.Button btnSchliessen;
		private System.Windows.Forms.MenuItem mnuRechnungsverwaltung;
		private System.Windows.Forms.MenuItem mnZahlungseingang;
		private System.Windows.Forms.MenuItem mnARladen;
		private System.Windows.Forms.MenuItem mnORladen;
		private System.Windows.Forms.MenuItem mnuSchliessen;
		private System.Windows.Forms.HelpProvider hpRechnungen;
		private System.Windows.Forms.ToolTip rechnungenToolTip;
		private System.Windows.Forms.MenuItem mnuSeperator1;
		private System.Windows.Forms.MenuItem mnuSeperator2;

		/// <summary>
		/// Array mit den aktuellen, noch nicht erstellten Rechnungen
		///</summary>
		private ManageBuchungen.IRechnung[] aAktuelleRechnungen;

		/// <summary>
		/// Konstruktor mit Initialisierungen
		/// </summary>
		public ZahlungsForm()
		{
			// Erforderlich für die Windows Form-Designerunterstützung
			InitializeComponent();

			// Offene Rechnungen laden
			this.FillOffeneRechnungen();

			// Aktuelle Rechnungen laden
			this.FillAktuelleRechnungen();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZahlungsForm));
            this.lstOffeneRechnungen = new System.Windows.Forms.ListBox();
            this.btnBezahlt = new System.Windows.Forms.Button();
            this.lstAktuelleRechnungen = new System.Windows.Forms.ListBox();
            this.grpOffeneRechnungen = new System.Windows.Forms.GroupBox();
            this.btnORladen = new System.Windows.Forms.Button();
            this.grpAktRechnungen = new System.Windows.Forms.GroupBox();
            this.btnARladen = new System.Windows.Forms.Button();
            this.btnAktRechnungen = new System.Windows.Forms.Button();
            this.rechnungsMenue = new System.Windows.Forms.MainMenu(this.components);
            this.mnuRechnungsverwaltung = new System.Windows.Forms.MenuItem();
            this.mnuRechnung = new System.Windows.Forms.MenuItem();
            this.mnZahlungseingang = new System.Windows.Forms.MenuItem();
            this.mnuSeperator1 = new System.Windows.Forms.MenuItem();
            this.mnARladen = new System.Windows.Forms.MenuItem();
            this.mnORladen = new System.Windows.Forms.MenuItem();
            this.mnuSeperator2 = new System.Windows.Forms.MenuItem();
            this.mnuSchliessen = new System.Windows.Forms.MenuItem();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.hpRechnungen = new System.Windows.Forms.HelpProvider();
            this.rechnungenToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpOffeneRechnungen.SuspendLayout();
            this.grpAktRechnungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOffeneRechnungen
            // 
            this.hpRechnungen.SetHelpKeyword(this.lstOffeneRechnungen, "");
            this.hpRechnungen.SetHelpString(this.lstOffeneRechnungen, "Listet alle derzeit offenen Rechnungen auf.");
            this.lstOffeneRechnungen.Location = new System.Drawing.Point(16, 24);
            this.lstOffeneRechnungen.Name = "lstOffeneRechnungen";
            this.lstOffeneRechnungen.ScrollAlwaysVisible = true;
            this.lstOffeneRechnungen.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.hpRechnungen.SetShowHelp(this.lstOffeneRechnungen, true);
            this.lstOffeneRechnungen.Size = new System.Drawing.Size(720, 186);
            this.lstOffeneRechnungen.TabIndex = 0;
            this.rechnungenToolTip.SetToolTip(this.lstOffeneRechnungen, "listet offene Rechnungen auf");
            // 
            // btnBezahlt
            // 
            this.hpRechnungen.SetHelpKeyword(this.btnBezahlt, "");
            this.hpRechnungen.SetHelpString(this.btnBezahlt, "Bestätigt den Zahlungseingang der gewählten Rechnung.");
            this.btnBezahlt.Location = new System.Drawing.Point(192, 224);
            this.btnBezahlt.Name = "btnBezahlt";
            this.hpRechnungen.SetShowHelp(this.btnBezahlt, true);
            this.btnBezahlt.Size = new System.Drawing.Size(176, 23);
            this.btnBezahlt.TabIndex = 1;
            this.btnBezahlt.Text = "&Zahlungseingang erfolgt";
            this.rechnungenToolTip.SetToolTip(this.btnBezahlt, "bestätigt Zahlungseingang");
            this.btnBezahlt.Click += new System.EventHandler(this.btnBezahlt_Click);
            // 
            // lstAktuelleRechnungen
            // 
            this.hpRechnungen.SetHelpString(this.lstAktuelleRechnungen, "Listet alle aktuell zu erstellenden Rechnungen auf.");
            this.lstAktuelleRechnungen.Location = new System.Drawing.Point(16, 24);
            this.lstAktuelleRechnungen.Name = "lstAktuelleRechnungen";
            this.lstAktuelleRechnungen.ScrollAlwaysVisible = true;
            this.lstAktuelleRechnungen.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.hpRechnungen.SetShowHelp(this.lstAktuelleRechnungen, true);
            this.lstAktuelleRechnungen.Size = new System.Drawing.Size(720, 186);
            this.lstAktuelleRechnungen.TabIndex = 3;
            this.rechnungenToolTip.SetToolTip(this.lstAktuelleRechnungen, "listet aktuell zu erstellende Rechnungen auf");
            // 
            // grpOffeneRechnungen
            // 
            this.grpOffeneRechnungen.Controls.Add(this.btnORladen);
            this.grpOffeneRechnungen.Controls.Add(this.lstOffeneRechnungen);
            this.grpOffeneRechnungen.Controls.Add(this.btnBezahlt);
            this.grpOffeneRechnungen.Location = new System.Drawing.Point(15, 288);
            this.grpOffeneRechnungen.Name = "grpOffeneRechnungen";
            this.grpOffeneRechnungen.Size = new System.Drawing.Size(752, 264);
            this.grpOffeneRechnungen.TabIndex = 4;
            this.grpOffeneRechnungen.TabStop = false;
            this.grpOffeneRechnungen.Text = "offene Rechnungen";
            // 
            // btnORladen
            // 
            this.hpRechnungen.SetHelpKeyword(this.btnORladen, "");
            this.hpRechnungen.SetHelpString(this.btnORladen, "Aktualisiert die Anzeige der offenen Rechnungen.");
            this.btnORladen.Location = new System.Drawing.Point(384, 224);
            this.btnORladen.Name = "btnORladen";
            this.hpRechnungen.SetShowHelp(this.btnORladen, true);
            this.btnORladen.Size = new System.Drawing.Size(176, 23);
            this.btnORladen.TabIndex = 2;
            this.btnORladen.Text = "&offene Rechnungen laden";
            this.rechnungenToolTip.SetToolTip(this.btnORladen, "aktualisiert offene Rechnungen");
            this.btnORladen.Click += new System.EventHandler(this.mnuORladen_Click);
            // 
            // grpAktRechnungen
            // 
            this.grpAktRechnungen.Controls.Add(this.btnARladen);
            this.grpAktRechnungen.Controls.Add(this.btnAktRechnungen);
            this.grpAktRechnungen.Controls.Add(this.lstAktuelleRechnungen);
            this.grpAktRechnungen.Location = new System.Drawing.Point(15, 8);
            this.grpAktRechnungen.Name = "grpAktRechnungen";
            this.grpAktRechnungen.Size = new System.Drawing.Size(752, 264);
            this.grpAktRechnungen.TabIndex = 5;
            this.grpAktRechnungen.TabStop = false;
            this.grpAktRechnungen.Text = "aktuell zu erstellende Rechnungen";
            // 
            // btnARladen
            // 
            this.hpRechnungen.SetHelpString(this.btnARladen, "Die Anzeige der aktuell zu erstellenden Rechnungen wird aktualisiert.");
            this.btnARladen.Location = new System.Drawing.Point(384, 224);
            this.btnARladen.Name = "btnARladen";
            this.hpRechnungen.SetShowHelp(this.btnARladen, true);
            this.btnARladen.Size = new System.Drawing.Size(176, 23);
            this.btnARladen.TabIndex = 5;
            this.btnARladen.Text = "&aktuelle Rechnungen laden";
            this.rechnungenToolTip.SetToolTip(this.btnARladen, "aktualisiert die aktuell zu erstellenden Rechnungen");
            this.btnARladen.Click += new System.EventHandler(this.mnuARladen_Click);
            // 
            // btnAktRechnungen
            // 
            this.hpRechnungen.SetHelpString(this.btnAktRechnungen, "Ausgewählte Rechnungen werden generiert.");
            this.btnAktRechnungen.Location = new System.Drawing.Point(192, 224);
            this.btnAktRechnungen.Name = "btnAktRechnungen";
            this.hpRechnungen.SetShowHelp(this.btnAktRechnungen, true);
            this.btnAktRechnungen.Size = new System.Drawing.Size(176, 23);
            this.btnAktRechnungen.TabIndex = 4;
            this.btnAktRechnungen.Text = "Rechnung &erstellen";
            this.rechnungenToolTip.SetToolTip(this.btnAktRechnungen, "erstellt die ausgewählten Rechnungen");
            this.btnAktRechnungen.Click += new System.EventHandler(this.btnAktRechnungen_Click);
            // 
            // rechnungsMenue
            // 
            this.rechnungsMenue.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuRechnungsverwaltung});
            // 
            // mnuRechnungsverwaltung
            // 
            this.mnuRechnungsverwaltung.Index = 0;
            this.mnuRechnungsverwaltung.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuRechnung,
            this.mnZahlungseingang,
            this.mnuSeperator1,
            this.mnARladen,
            this.mnORladen,
            this.mnuSeperator2,
            this.mnuSchliessen});
            this.mnuRechnungsverwaltung.Text = "&Rechnungen";
            // 
            // mnuRechnung
            // 
            this.mnuRechnung.Index = 0;
            this.mnuRechnung.Text = "Rechnung &erstellen";
            this.mnuRechnung.Click += new System.EventHandler(this.btnAktRechnungen_Click);
            // 
            // mnZahlungseingang
            // 
            this.mnZahlungseingang.Index = 1;
            this.mnZahlungseingang.Text = "&Zahlungseingang erfolgt";
            this.mnZahlungseingang.Click += new System.EventHandler(this.btnBezahlt_Click);
            // 
            // mnuSeperator1
            // 
            this.mnuSeperator1.Index = 2;
            this.mnuSeperator1.Text = "-";
            // 
            // mnARladen
            // 
            this.mnARladen.Index = 3;
            this.mnARladen.Text = "&aktuelle Rechnungen neu laden";
            this.mnARladen.Click += new System.EventHandler(this.mnuARladen_Click);
            // 
            // mnORladen
            // 
            this.mnORladen.Index = 4;
            this.mnORladen.Text = "&offene Rechnungen neu laden";
            this.mnORladen.Click += new System.EventHandler(this.mnuORladen_Click);
            // 
            // mnuSeperator2
            // 
            this.mnuSeperator2.Index = 5;
            this.mnuSeperator2.Text = "-";
            // 
            // mnuSchliessen
            // 
            this.mnuSchliessen.Index = 6;
            this.mnuSchliessen.Text = "S&chließen";
            this.mnuSchliessen.Click += new System.EventHandler(this.mnuSchliessen_Click);
            // 
            // btnSchliessen
            // 
            this.hpRechnungen.SetHelpKeyword(this.btnSchliessen, "");
            this.hpRechnungen.SetHelpString(this.btnSchliessen, "Schließt das Rechnungsfenster.");
            this.btnSchliessen.Location = new System.Drawing.Point(247, 568);
            this.btnSchliessen.Name = "btnSchliessen";
            this.hpRechnungen.SetShowHelp(this.btnSchliessen, true);
            this.btnSchliessen.Size = new System.Drawing.Size(288, 23);
            this.btnSchliessen.TabIndex = 6;
            this.btnSchliessen.Text = "S&chließen";
            this.rechnungenToolTip.SetToolTip(this.btnSchliessen, "Fenster schließen");
            this.btnSchliessen.Click += new System.EventHandler(this.mnuSchliessen_Click);
            // 
            // ZahlungsForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.grpAktRechnungen);
            this.Controls.Add(this.grpOffeneRechnungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Menu = this.rechnungsMenue;
            this.MinimizeBox = false;
            this.Name = "ZahlungsForm";
            this.hpRechnungen.SetShowHelp(this, true);
            this.Text = "Rechnungsverwaltung";
            this.Closed += new System.EventHandler(this.ZahlungsForm_Closed);
            this.grpOffeneRechnungen.ResumeLayout(false);
            this.grpAktRechnungen.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// UC 01.7 Zahlungseingang pruefen.
		/// </summary>
		/// <remarks>
		/// Listbox wird mit den offenen Rechnungen gefuellt.
		/// </remarks>
		private void FillOffeneRechnungen()
		{
			// Listbox und Array zuruecksetzen
			aOffeneRechnungen = null;
			this.lstOffeneRechnungen.Items.Clear();

			try
			{
				// Offene Rechnungen laden
				ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
				aOffeneRechnungen = dtm.SucheOffeneRechnungen();

				// Sind offene Rechnungen vorhanden?
				if(aOffeneRechnungen != null)
				{
					// alle Rechnungen in Listbox eintragen
					for(int i = 0; i < aOffeneRechnungen.Length; i++)
						this.lstOffeneRechnungen.Items.Add(aOffeneRechnungen[i].RechnungsNr.ToString() +"   "+aOffeneRechnungen[i].RechnungsBuchung.EventBezeichnung+"  "+aOffeneRechnungen[i].RechnungsKunde.Name + "  Summe: "+ aOffeneRechnungen[i].GesamtPreis.ToString("c") +",  zahlbar bis: "+aOffeneRechnungen[i].Zahlbar.ToLongDateString());
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// UC 01.4, 01.4.1 Rechnungen/ Stornorechnungen erstellen. Listbox wird mit den aktuellen Rechnungen gefuellt
		/// </summary>
		/// <remarks>
		/// Listbox wird mit den aktuellen Rechnungen gefuellt
		///</remarks>
		private void FillAktuelleRechnungen()
		{
			// Listbox und Array zuruecksetzen
			aAktuelleRechnungen = null;
			this.lstAktuelleRechnungen.Items.Clear();

			try
			{
				// Offene Rechnungen laden
				ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
				aAktuelleRechnungen = dtm.SucheAktuelleRechnungen();

				// Sind offene Rechnungen vorhanden?
				if(aAktuelleRechnungen != null)
				{
					// alle Rechnungen in Listbox eintragen
					for(int i = 0; i < aAktuelleRechnungen.Length; i++)
						this.lstAktuelleRechnungen.Items.Add(aAktuelleRechnungen[i].RechnungsNr.ToString() +"   "+aAktuelleRechnungen[i].RechnungsBuchung.EventBezeichnung+"  "+aAktuelleRechnungen[i].RechnungsKunde.Name + "  Summe: "+ aAktuelleRechnungen[i].GesamtPreis.ToString("c") +",  zahlbar bis: "+aAktuelleRechnungen[i].Zahlbar.ToLongDateString());
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// UC 01.7 Zahlungsseingaenge fuer offene Rechnungen werden bestaetigt
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBezahlt_Click(object sender, System.EventArgs e)
		{
			// sind offene Rechnungen vorhanden?
			if(aOffeneRechnungen != null)
			{
				for(int i = 0; i < aOffeneRechnungen.Length; i++)
				{
					// Zahlungseingang fuer alle ausgewaehlten Rechnungen bestaetigen
					if(this.lstOffeneRechnungen.GetSelected(i)== true)
					{
						// Zahlung bestaetigen
						aOffeneRechnungen[i].ZahlungEingegangen();
					}
				}
				// Anzeige aktualisieren
				this.FillOffeneRechnungen();
			}
		}

		/// <summary>
		/// UC 01.4 aktuell faellige Rechnungen erstellen
		/// </summary>
		/// <remarks>
		/// Aktuelle Rechnungen werden ueber Automatisierung mit MS Word 2000 erstellt
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAktRechnungen_Click(object sender, System.EventArgs e)
		{
			// Word Automatisierung
			ManageDocuments.DokumentManagement dm = null;
			try
			{
				// sind aktuelle Rechnungen zu erstellen?
				if(aAktuelleRechnungen != null)
				{
					dm = new ManageDocuments.DokumentManagement();

					// Word starten
					dm.OpenWordGenerator();
					
					for(int i = 0; i < aAktuelleRechnungen.Length; i++)
					{
						// Rechnungen fuer alle ausgewaehlten Rechnungen erstellen
						if(this.lstAktuelleRechnungen.GetSelected(i)== true)
						{
							// Rechnung erstellen
							dm.ErstelleRechnung(aAktuelleRechnungen[i]);
							// Rechnungserstellung in Datenbank bestaetigen
							aAktuelleRechnungen[i].BestaetigeRechnung();
						}
					}
					// Anzeige aktualisieren
					this.FillAktuelleRechnungen();
					this.FillOffeneRechnungen();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				// Wordgenerator schliessen
				if(dm != null)
				{
					dm.CloseWordGenerator();
					dm = null;
				}
			}
		}

		/// <summary>
		/// Aendert das Hauptmenue zum Erstellen des Forms
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ZahlungsForm_Closed(object sender, System.EventArgs e)
		{
			// Menue zum Erstellen einer neuen Rechnungsbearbeitung freigeben
			((MainForm) this.MdiParent).SetMnuAnzeige(this.Text, true);
		}

		/// <summary>
		/// Refresh der aktuell zu erstellenden Rechnungen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuARladen_Click(object sender, System.EventArgs e)
		{
			this.FillAktuelleRechnungen();
		}

		/// <summary>
		/// Refresh der offenen Rechnungen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuORladen_Click(object sender, System.EventArgs e)
		{
			this.FillOffeneRechnungen();
		}

		/// <summary>
		/// Schliessen des Forms
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuSchliessen_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}	
	}
}

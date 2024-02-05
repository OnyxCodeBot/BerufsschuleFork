using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ManageBuchungenApp
{
	/// <summary>
	/// Klassne zu UC 03.1 Kundendaten zu Statistikzwecken auswaehlen
	/// </summary>
	/// <remarks>
	/// Anhand einer Eventkategorie koennen Kunden, welche Events dieser
	/// Kategorie gewaehlt haben ermittelt werden
	/// </remarks>
	public class KundenAnalyseForm : System.Windows.Forms.Form
	{
		// Steuerelemente des Forms
		private System.Windows.Forms.ListBox lstKundendaten;
		private System.Windows.Forms.Button btnAdressenSpeichern;
		private System.Windows.Forms.ComboBox cboKategorien;
		private System.Windows.Forms.Button btnSchliessen;
		private System.Windows.Forms.MainMenu kundenAnalyseMenu;
		private System.Windows.Forms.HelpProvider hpKundenAnalyse;
		private System.Windows.Forms.ToolTip kundenAnalyseToolTip;
		private System.Windows.Forms.MenuItem mnuKundenAnalyse;
		private System.Windows.Forms.MenuItem mnuAdressenSpeichern;
		private System.Windows.Forms.MenuItem mnuSeperator;
		private System.Windows.Forms.MenuItem mnuSchliessen;
		private System.Windows.Forms.GroupBox grpKundenanalyse;
		private System.ComponentModel.IContainer components;

		/// <summary>
		/// Array mit Bezeichnungen der Kategorien
		/// </summary>
		private string [] aKategorien;
		/// <summary>
		/// Array mit Kunden, die ein Event einer bestimmten Kategorie gebucht haben
		/// </summary>
		private ManageBuchungen.IKunde [] aKunden;
		/// <summary>
		/// Datei Speichern Dialog zum Speichern der Analyseergebnisse
		/// </summary>
		private System.Windows.Forms.SaveFileDialog saveFileDlg;

		/// <summary>
		/// Konstruktor mit Initialisierungen
		/// </summary>
		public KundenAnalyseForm()
		{
			// Erforderlich für die Windows Form-Designerunterstützung
			InitializeComponent();

			// Kategorien laden und in ComboBox anzeigen
			ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
			aKategorien = dtm.LadeEventKategorien();
			this.cboKategorien.DataSource = aKategorien;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundenAnalyseForm));
            this.lstKundendaten = new System.Windows.Forms.ListBox();
            this.btnAdressenSpeichern = new System.Windows.Forms.Button();
            this.cboKategorien = new System.Windows.Forms.ComboBox();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.grpKundenanalyse = new System.Windows.Forms.GroupBox();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.kundenAnalyseMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mnuKundenAnalyse = new System.Windows.Forms.MenuItem();
            this.mnuAdressenSpeichern = new System.Windows.Forms.MenuItem();
            this.mnuSeperator = new System.Windows.Forms.MenuItem();
            this.mnuSchliessen = new System.Windows.Forms.MenuItem();
            this.hpKundenAnalyse = new System.Windows.Forms.HelpProvider();
            this.kundenAnalyseToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpKundenanalyse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKundendaten
            // 
            this.lstKundendaten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKundendaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpKundenAnalyse.SetHelpString(this.lstKundendaten, "Die Kunden einer Eventkategorie werden aufgelistet.");
            this.lstKundendaten.Location = new System.Drawing.Point(8, 56);
            this.lstKundendaten.Name = "lstKundendaten";
            this.lstKundendaten.ScrollAlwaysVisible = true;
            this.lstKundendaten.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.hpKundenAnalyse.SetShowHelp(this.lstKundendaten, true);
            this.lstKundendaten.Size = new System.Drawing.Size(480, 407);
            this.lstKundendaten.TabIndex = 0;
            this.kundenAnalyseToolTip.SetToolTip(this.lstKundendaten, "Listet alle Kunden einer Eventkategorie auf");
            // 
            // btnAdressenSpeichern
            // 
            this.btnAdressenSpeichern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hpKundenAnalyse.SetHelpString(this.btnAdressenSpeichern, "Die Kundenadressen der Kundenanalyse werden gespeichert.");
            this.btnAdressenSpeichern.Location = new System.Drawing.Point(168, 472);
            this.btnAdressenSpeichern.Name = "btnAdressenSpeichern";
            this.hpKundenAnalyse.SetShowHelp(this.btnAdressenSpeichern, true);
            this.btnAdressenSpeichern.Size = new System.Drawing.Size(160, 23);
            this.btnAdressenSpeichern.TabIndex = 1;
            this.btnAdressenSpeichern.Text = "&Kundendaten speichern";
            this.kundenAnalyseToolTip.SetToolTip(this.btnAdressenSpeichern, "Speichert die aktuelle Kundenanalyse");
            this.btnAdressenSpeichern.Click += new System.EventHandler(this.btnAdressenSpeichern_Click);
            // 
            // cboKategorien
            // 
            this.cboKategorien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hpKundenAnalyse.SetHelpString(this.cboKategorien, "Die aktuellen Eventkategorien werden zur Auswahl angezeigt.");
            this.cboKategorien.Location = new System.Drawing.Point(8, 24);
            this.cboKategorien.Name = "cboKategorien";
            this.hpKundenAnalyse.SetShowHelp(this.cboKategorien, true);
            this.cboKategorien.Size = new System.Drawing.Size(240, 21);
            this.cboKategorien.TabIndex = 2;
            this.kundenAnalyseToolTip.SetToolTip(this.cboKategorien, "Listet Eventkategorien zur Auswahl auf");
            this.cboKategorien.SelectedIndexChanged += new System.EventHandler(this.cboKategorien_SelectedIndexChanged);
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.FileName = "doc1";
            // 
            // grpKundenanalyse
            // 
            this.grpKundenanalyse.Controls.Add(this.btnAdressenSpeichern);
            this.grpKundenanalyse.Controls.Add(this.cboKategorien);
            this.grpKundenanalyse.Controls.Add(this.lstKundendaten);
            this.grpKundenanalyse.Location = new System.Drawing.Point(9, 16);
            this.grpKundenanalyse.Name = "grpKundenanalyse";
            this.grpKundenanalyse.Size = new System.Drawing.Size(496, 504);
            this.grpKundenanalyse.TabIndex = 4;
            this.grpKundenanalyse.TabStop = false;
            this.grpKundenanalyse.Text = "Bitte wählen Sie eine Kategorie zur Analyse aus!";
            // 
            // btnSchliessen
            // 
            this.hpKundenAnalyse.SetHelpString(this.btnSchliessen, "Der Kundenanalyseform wird geschlossen.");
            this.btnSchliessen.Location = new System.Drawing.Point(177, 536);
            this.btnSchliessen.Name = "btnSchliessen";
            this.hpKundenAnalyse.SetShowHelp(this.btnSchliessen, true);
            this.btnSchliessen.Size = new System.Drawing.Size(160, 23);
            this.btnSchliessen.TabIndex = 5;
            this.btnSchliessen.Text = "S&chließen";
            this.kundenAnalyseToolTip.SetToolTip(this.btnSchliessen, "Schließt den Kundenanalyseform");
            this.btnSchliessen.Click += new System.EventHandler(this.mnuSchliessen_Click);
            // 
            // kundenAnalyseMenu
            // 
            this.kundenAnalyseMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuKundenAnalyse});
            // 
            // mnuKundenAnalyse
            // 
            this.mnuKundenAnalyse.Index = 0;
            this.mnuKundenAnalyse.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAdressenSpeichern,
            this.mnuSeperator,
            this.mnuSchliessen});
            this.mnuKundenAnalyse.Text = "Kundenana&lyse";
            // 
            // mnuAdressenSpeichern
            // 
            this.mnuAdressenSpeichern.Index = 0;
            this.mnuAdressenSpeichern.Text = "&Kundendaten speichern";
            this.mnuAdressenSpeichern.Click += new System.EventHandler(this.btnAdressenSpeichern_Click);
            // 
            // mnuSeperator
            // 
            this.mnuSeperator.Index = 1;
            this.mnuSeperator.Text = "-";
            // 
            // mnuSchliessen
            // 
            this.mnuSchliessen.Index = 2;
            this.mnuSchliessen.Text = "S&chließen";
            this.mnuSchliessen.Click += new System.EventHandler(this.mnuSchliessen_Click);
            // 
            // KundenAnalyseForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(514, 567);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.grpKundenanalyse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Menu = this.kundenAnalyseMenu;
            this.MinimizeBox = false;
            this.Name = "KundenAnalyseForm";
            this.Text = "Analyse der Kundendaten";
            this.Closed += new System.EventHandler(this.KundenAnalyseForm_Closed);
            this.grpKundenanalyse.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// UC 03.1 Analyse der Kundendaten. Eine Eventkategorie wird ausgewaehlt
		/// </summary>
		/// <remarks>
		/// Nach der Auswahl einer Kategorie werden die zugehoerigen Kunden angezeigt
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cboKategorien_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Anzeige zuruecksetzen
			this.lstKundendaten.Items.Clear();

			// Kundenarray loeschen
			aKunden = null;

			// Speichern sperren
			this.btnAdressenSpeichern.Enabled = false;
			this.mnuAdressenSpeichern.Enabled = false;

			try
			{
				// Daten laden
				ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
				aKunden = dtm.SucheKatKunde(this.cboKategorien.Text);

				// Wurden Kunden gefunden?
				if(aKunden != null)
				{
					// Speichern freigeben
					this.btnAdressenSpeichern.Enabled = true;
					this.mnuAdressenSpeichern.Enabled = true;

					// Listbox fuellen
					for(int i = 0; i <aKunden.Length; i++)
					{
						this.lstKundendaten.Items.Add(aKunden[i].Name +", "+aKunden[i].Vorname+", "+aKunden[i].Strasse+", "+aKunden[i].HNummer+", "+aKunden[i].PLZ+", "+aKunden[i].Ort);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// UC 03.1 Kundendaten werden nach der Analyse in einer Datei abgespeichert
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdressenSpeichern_Click(object sender, System.EventArgs e)
		{
			// Save File Dialog einstellen
			this.saveFileDlg.AddExtension = true;
			this.saveFileDlg.DefaultExt = "txt";
			this.saveFileDlg.Filter = "Text (*.txt)|*.txt|CSV (Trennzeichen getrennt) (*.csv)|*.csv";
			this.saveFileDlg.FileName = "Kundenanalyse1";
			
			// Speicherndialog verwenden, Daten abspeichern
			if(this.saveFileDlg.ShowDialog()==DialogResult.OK)
			{
				// gewahlten Pfad ermitteln
				string path = saveFileDlg.FileName;

				// Daten ueber einen StreamWriter speichern
				DateTime dt = DateTime.Today;
				System.IO.StreamWriter sw = new System.IO.StreamWriter(path);
				
				// Kopfzeile
				sw.WriteLine("*** Folgende Kunden haben Events der Kategorie " + this.cboKategorien.Text + " gewählt: ***");
				sw.WriteLine("");
				
				// Daten der Listbox
				for(int i = 0; i < this.lstKundendaten.Items.Count; i++)
				{
					// Zeilenweise speichern
					sw.WriteLine(this.lstKundendaten.Items[i].ToString());
				}

				// Fusszeile
				sw.WriteLine("");
				sw.WriteLine("*** Kundenalysedatei erstellt am: " + dt.Date.ToLongDateString()+" ***");

				// StreamWriter schliessen
				sw.Close();
			}
		}

		/// <summary>
		/// Aendert das Hauptmenue zum Erstellen des Forms
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KundenAnalyseForm_Closed(object sender, System.EventArgs e)
		{
			// Menue zum Erstellen einer neuen Analyse freigeben
			((MainForm) this.MdiParent).SetMnuAnzeige(this.Text, true);
		}

		/// <summary>
		/// Schließt den Kundenanalyseform
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuSchliessen_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}

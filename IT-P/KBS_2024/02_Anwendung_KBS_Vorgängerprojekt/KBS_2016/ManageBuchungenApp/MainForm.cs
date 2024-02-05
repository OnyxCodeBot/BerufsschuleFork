using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ManageBuchungenApp
{
	/// <summary>
	/// Rahmenfenster des KBS KundenBuchungsSystems
	/// </summary>
	/// <remarks>
	/// Steuert die Unterdialoge zur Kunden-, Buchungs- und Rechnungsverwaltung
	/// sowie zur Kundenanalyse
	/// </remarks>
	public class MainForm : System.Windows.Forms.Form
	{
		// Steuerelemente des Forms
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem mnuDatei;
		private System.Windows.Forms.MenuItem mnuSeperator1;
		private System.Windows.Forms.MenuItem mnuBeenden;
		private System.Windows.Forms.MenuItem mnuFenster;
		private System.Windows.Forms.MenuItem mnuNeu;
		private System.Windows.Forms.MenuItem mnuKundenAnalyse;
		private System.Windows.Forms.MenuItem mnuRechnungsVerwaltung;
		private System.Windows.Forms.MenuItem mnuVeranstalterInfo;
		private System.Windows.Forms.MenuItem mnuBuchungsVerwaltung;
        private IContainer components;

        /// <summary>
        /// Konstruktor mit Initialisierungen
        /// </summary>
        public MainForm()
		{
			// Erforderlich für die Windows Form-Designerunterstützung
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mnuDatei = new System.Windows.Forms.MenuItem();
            this.mnuNeu = new System.Windows.Forms.MenuItem();
            this.mnuKundenAnalyse = new System.Windows.Forms.MenuItem();
            this.mnuRechnungsVerwaltung = new System.Windows.Forms.MenuItem();
            this.mnuVeranstalterInfo = new System.Windows.Forms.MenuItem();
            this.mnuBuchungsVerwaltung = new System.Windows.Forms.MenuItem();
            this.mnuSeperator1 = new System.Windows.Forms.MenuItem();
            this.mnuBeenden = new System.Windows.Forms.MenuItem();
            this.mnuFenster = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuDatei,
            this.mnuFenster});
            // 
            // mnuDatei
            // 
            this.mnuDatei.Index = 0;
            this.mnuDatei.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNeu,
            this.mnuSeperator1,
            this.mnuBeenden});
            this.mnuDatei.Text = "&Datei";
            // 
            // mnuNeu
            // 
            this.mnuNeu.Index = 0;
            this.mnuNeu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuKundenAnalyse,
            this.mnuRechnungsVerwaltung,
            this.mnuVeranstalterInfo,
            this.mnuBuchungsVerwaltung});
            this.mnuNeu.Text = "&neu";
            // 
            // mnuKundenAnalyse
            // 
            this.mnuKundenAnalyse.Index = 0;
            this.mnuKundenAnalyse.Text = "&Kundenanalyse";
            this.mnuKundenAnalyse.Click += new System.EventHandler(this.mnuKundenAnalyse_Click);
            // 
            // mnuRechnungsVerwaltung
            // 
            this.mnuRechnungsVerwaltung.Index = 1;
            this.mnuRechnungsVerwaltung.Text = "&Rechnungsverwaltung";
            this.mnuRechnungsVerwaltung.Click += new System.EventHandler(this.mnuRechnungsVerwaltung_Click);
            // 
            // mnuVeranstalterInfo
            // 
            this.mnuVeranstalterInfo.Index = 2;
            this.mnuVeranstalterInfo.Text = "&Veranstalter Info";
            this.mnuVeranstalterInfo.Click += new System.EventHandler(this.mnuVeranstalterInfo_Click);
            // 
            // mnuBuchungsVerwaltung
            // 
            this.mnuBuchungsVerwaltung.Index = 3;
            this.mnuBuchungsVerwaltung.Text = "&Buchungsverwaltung";
            this.mnuBuchungsVerwaltung.Click += new System.EventHandler(this.mnuBuchungsVerwaltung_Click);
            // 
            // mnuSeperator1
            // 
            this.mnuSeperator1.Index = 1;
            this.mnuSeperator1.Text = "-";
            // 
            // mnuBeenden
            // 
            this.mnuBeenden.Index = 2;
            this.mnuBeenden.Text = "&Beenden";
            this.mnuBeenden.Click += new System.EventHandler(this.mnuBeenden_Click);
            // 
            // mnuFenster
            // 
            this.mnuFenster.Index = 1;
            this.mnuFenster.MdiList = true;
            this.mnuFenster.MergeOrder = 1;
            this.mnuFenster.Text = "&Fenster";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(968, 421);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "KBS Kundenbuchungssystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

		}
		#endregion
		
		

		/// <summary>
		/// Beendet das Kundenbuchungssystem
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuBeenden_Click(object sender, System.EventArgs e)
		{
			// Form schliessen
			this.Close();
		}
	
		/// <summary>
		/// UC 03.1 Analyse der Kundendaten
		/// </summary>
		/// <remarks>
		/// Startet den Kundenanalyse - Form
		/// Der Menuepunkt mnuKundenAnalyse wird deaktiviert, damit nur eine Instanz
		/// des Forms gestartet werden kann.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuKundenAnalyse_Click(object sender, System.EventArgs e)
		{
			// Kundenanalyseform erstellen und anzeigen
			KundenAnalyseForm kaf = new KundenAnalyseForm();
			kaf.MdiParent = this;
			kaf.Show();

			// Der Menuepunkt wird deaktiviert, damit nur eine Instanz des Forms gestartet werden kann
			this.mnuKundenAnalyse.Enabled = false;
		}

		/// <summary>
		/// UC 01.4, UC 01.4.1, UC 01.7 Verwaltung der Rechnungen,
		/// Pruefen der eingegangenen Zahlungen nach der Rechnungserstellung
		/// </summary>
		/// <remarks>
		/// Startet den Zahlungs - Form
		/// Der Menuepunkt mnuRechnungsVerwaltung wird deaktiviert, damit nur eine Instanz
		/// des Forms gestartet werden kann.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuRechnungsVerwaltung_Click(object sender, System.EventArgs e)
		{
			// Zahlungsform erstellen und anzeigen
			ZahlungsForm zf = new ZahlungsForm();
			zf.MdiParent = this;
			zf.Show();

			// Der Menuepunkt wird deaktiviert, damit nur eine Instanz des Forms gestartet werden kann
			this.mnuRechnungsVerwaltung.Enabled = false;
		}

		/// <summary>
		/// UC 01.6 Buchungen an den Veranstalter melden
		/// </summary>
		/// <remarks>
		/// Startet den VeranstalterBenachrichtigungs - Form
		/// Der Menuepunkt mnuVeranstalterInfo wird deaktiviert, damit nur eine Instanz
		/// des Forms gestartet werden kann.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuVeranstalterInfo_Click(object sender, System.EventArgs e)
		{
			// VeranstalterBenachrichtigungsForm erstellen und anzeigen
			VeranstalterBenachrichtigungsForm vbf = new VeranstalterBenachrichtigungsForm();
			vbf.MdiParent = this;
			vbf.Show();

			// Der Menuepunkt wird deaktiviert, damit nur eine Instanz des Forms gestartet werden kann
			this.mnuVeranstalterInfo.Enabled = false;
		}

		/// <summary>
		/// UC 01.1, 01.1.1, 01.5, 02.1, 02.1.1, 02.1.2, Form zur Kunden und Buchungsverwaltung
		/// </summary>
		/// <remarks>
		/// Startet den KundenBuchungs - Form
		/// Der Menuepunkt mnuBuchungsVerwaltung wird deaktiviert, damit nur eine Instanz
		/// des Forms gestartet werden kann.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuBuchungsVerwaltung_Click(object sender, System.EventArgs e)
		{
			// KundenBuchungsForm erstellen und anzeigen
			KundenBuchungsForm kbf = new KundenBuchungsForm();
			kbf.MdiParent = this;
			kbf.Show();

			// Der Menuepunkt wird deaktiviert, damit nur eine Instanz des Forms gestartet werden kann
			this.mnuBuchungsVerwaltung.Enabled = false;
		}

		/// <summary>
		/// Sperrt oder schaltet uebergebene Menuepunkte zur Erzeugung der Forms ein
		/// </summary>
		/// <param name="en">true = Enabled, false = gesperrt</param>
		public void SetMnuAnzeige(string formBezeichnung, bool en)
		{
			// Menuepunkt ermitteln und Wert fuer Enabled setzen
			switch(formBezeichnung)
			{
				case "Kunden Buchungen":
					this.mnuBuchungsVerwaltung.Enabled = en;
					break;
				case "Rechnungsverwaltung":
					this.mnuRechnungsVerwaltung.Enabled = en;
					break;
				case "Analyse der Kundendaten":
					this.mnuKundenAnalyse.Enabled = en;
					break;
				case "Benachrichtigung der Veranstalter":
					this.mnuVeranstalterInfo.Enabled = en;
					break;
			}
		}

		/// <summary>
		/// Startet den KundenBuchungsForm automatisch bei Programmstart
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			this.mnuBuchungsVerwaltung_Click(sender, e);
		}
	}
}

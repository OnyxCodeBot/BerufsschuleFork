using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ManageBuchungenApp
{
	/// <summary>
	/// Klasse zu den UCs 01.1, 01.1.1, 01.2, 01.3, 01.5 Kundenbuchungen und Stornierungen
	/// sowie 02.1, 02.1.1, 02.1.2, Verwaltung der Kundendaten.
	/// </summary>
	/// <remarks>
	/// Daten zu Buchungen, Stornierungen, Events und Kunden werden zur Bearbeitung angezeigt.
	///</remarks>
	public class KundenBuchungsForm : System.Windows.Forms.Form
	{
		// Steuerelemente des Forms
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblVorname;
		private System.Windows.Forms.Label lblHNummer;
		private System.Windows.Forms.Label lblStrasse;
		private System.Windows.Forms.Label lblPLZ;
		private System.Windows.Forms.Label lblOrt;
		private System.Windows.Forms.Label lblTelefon;
		private System.Windows.Forms.Label lblEMail;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtVorname;
		private System.Windows.Forms.TextBox txtStrasse;
		private System.Windows.Forms.TextBox txtHnummer;
		private System.Windows.Forms.TextBox txtPLZ;
		private System.Windows.Forms.TextBox txtOrt;
		private System.Windows.Forms.TextBox txtTelefon;
		private System.Windows.Forms.TextBox txtEMail;
		private System.Windows.Forms.TextBox txtSuchname;
		private System.Windows.Forms.Label lblSuchname;
		private System.Windows.Forms.Button btnSucheKunde;
		private System.Windows.Forms.GroupBox grpKundenDaten;
		private System.Windows.Forms.ComboBox cboName;
		private System.Windows.Forms.Button btnUpdtKunde;
		private System.Windows.Forms.Button btnNeuerKunde;
		private System.Windows.Forms.Label lblGebuchteEvents;
		private System.Windows.Forms.Label lblAuswahlName;
		private System.Windows.Forms.ComboBox cboEvents;
		private System.Windows.Forms.GroupBox grpKunde;
		private System.Windows.Forms.TreeView trvKundenEvents;
		private System.Windows.Forms.Button btnStorniereEvent;
		private System.Windows.Forms.GroupBox grpEventAuswahl;
		private System.Windows.Forms.Label lblEventAuswahl;
		private System.Windows.Forms.ComboBox cboDatum;
		private System.Windows.Forms.TextBox txtEnde;
		private System.Windows.Forms.TextBox txtStartOrt;
		private System.Windows.Forms.TextBox txtZielOrt;
		private System.Windows.Forms.TextBox txtBeschreibung;
		private System.Windows.Forms.TextBox txtKategorie;
		private System.Windows.Forms.TextBox txtVeranstalter;
		private System.Windows.Forms.Label lblZielOrt;
		private System.Windows.Forms.Label lblEvTermin;
		private System.Windows.Forms.Label lblEndeTermin;
		private System.Windows.Forms.Label lblVeranstalter;
		private System.Windows.Forms.Label lblKategorie;
		private System.Windows.Forms.Button btnBucheEvent;
		private System.Windows.Forms.TextBox txtAktTeilnehmer;
		private System.Windows.Forms.TextBox txtMaxTeilnehmer;
		private System.Windows.Forms.Label lblAktTeilnehmer;
		private System.Windows.Forms.Label lblMaxTeilnehmer;
		private System.Windows.Forms.GroupBox grpEventDaten;
		private System.Windows.Forms.Label lblPreis;
		private System.Windows.Forms.TextBox txtPreis;
		private System.Windows.Forms.TextBox txtEventBezeichnung;
		private System.Windows.Forms.Label lblEventBezeichnung;
		private System.Windows.Forms.MenuItem mnuEvent;
		private System.Windows.Forms.MenuItem mnuAnsicht;
		private System.Windows.Forms.MenuItem mnuEventdetails;
		private System.Windows.Forms.Label lblStarttermin;
		private System.Windows.Forms.TextBox txtStarttermin;
		private System.Windows.Forms.MainMenu buchungsMenu;
		private System.Windows.Forms.MenuItem mnuBuchen;
		private System.Windows.Forms.MenuItem mnuStorno;
		private System.Windows.Forms.MenuItem mnuKunde;
		private System.Windows.Forms.MenuItem mnuKundenSuchen;
		private System.Windows.Forms.MenuItem mnuNeuerKunde;
		private System.Windows.Forms.MenuItem mnuAenderungenSpeichern;
		private System.Windows.Forms.MenuItem mnuRefreshEvents;

		/// <summary>
		/// CurrencyManager fuer das Kundenarray
		/// </summary>
		private CurrencyManager cmKunden;
		/// <summary>
		/// CurrencyManager fuer die Eventdaten ArrayList
		/// </summary>
		private CurrencyManager cmEventDaten;
		/// <summary>
		/// CurrencyManager fuer das Eventbezeichnungsarray
		/// </summary>
		private CurrencyManager cmEvents;
		/// <summary>
		/// KundenArray der gewaehlten Kunden
		/// </summary>
		private ManageBuchungen.IKunde [] aKunden;
		/// <summary>
		/// ArrayList der Kundenbuchungen
		/// </summary>
		private System.Collections.ArrayList alBuchungen;
		/// <summary>
		/// ArrayList der Eventdaten
		/// </summary>
		private System.Collections.ArrayList alEventDaten;
		/// <summary>
		/// der aktuell ausgewaehlte Event
		/// </summary>
		private ManageBuchungen.IEvent selectedEvent;
		/// <summary>
		/// Die aktuell zur Buchung gewaehlten Plaetze
		/// </summary>
		private int m_buchungsPlaetze;
		/// <summary>
		/// Array mit den aktuellen Eventbezeichnungen
		/// </summary>
		private string [] aEvBezeichnungen;
		private System.Windows.Forms.ToolTip buchungenToolTip;
		private System.Windows.Forms.HelpProvider hpBuchungen;
		private System.Windows.Forms.Label lblStartOrt;
		private System.ComponentModel.IContainer components;

		public KundenBuchungsForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundenBuchungsForm));
            this.grpKundenDaten = new System.Windows.Forms.GroupBox();
            this.btnStorniereEvent = new System.Windows.Forms.Button();
            this.trvKundenEvents = new System.Windows.Forms.TreeView();
            this.lblAuswahlName = new System.Windows.Forms.Label();
            this.lblGebuchteEvents = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.txtPLZ = new System.Windows.Forms.TextBox();
            this.txtHnummer = new System.Windows.Forms.TextBox();
            this.txtStrasse = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblOrt = new System.Windows.Forms.Label();
            this.lblPLZ = new System.Windows.Forms.Label();
            this.lblStrasse = new System.Windows.Forms.Label();
            this.lblHNummer = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdtKunde = new System.Windows.Forms.Button();
            this.btnNeuerKunde = new System.Windows.Forms.Button();
            this.txtSuchname = new System.Windows.Forms.TextBox();
            this.lblSuchname = new System.Windows.Forms.Label();
            this.btnSucheKunde = new System.Windows.Forms.Button();
            this.cboEvents = new System.Windows.Forms.ComboBox();
            this.buchungsMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mnuKunde = new System.Windows.Forms.MenuItem();
            this.mnuKundenSuchen = new System.Windows.Forms.MenuItem();
            this.mnuNeuerKunde = new System.Windows.Forms.MenuItem();
            this.mnuAenderungenSpeichern = new System.Windows.Forms.MenuItem();
            this.mnuEvent = new System.Windows.Forms.MenuItem();
            this.mnuBuchen = new System.Windows.Forms.MenuItem();
            this.mnuStorno = new System.Windows.Forms.MenuItem();
            this.mnuRefreshEvents = new System.Windows.Forms.MenuItem();
            this.mnuAnsicht = new System.Windows.Forms.MenuItem();
            this.mnuEventdetails = new System.Windows.Forms.MenuItem();
            this.grpKunde = new System.Windows.Forms.GroupBox();
            this.grpEventAuswahl = new System.Windows.Forms.GroupBox();
            this.lblStarttermin = new System.Windows.Forms.Label();
            this.lblVeranstalter = new System.Windows.Forms.Label();
            this.txtKategorie = new System.Windows.Forms.TextBox();
            this.lblEventAuswahl = new System.Windows.Forms.Label();
            this.lblKategorie = new System.Windows.Forms.Label();
            this.txtVeranstalter = new System.Windows.Forms.TextBox();
            this.btnBucheEvent = new System.Windows.Forms.Button();
            this.cboDatum = new System.Windows.Forms.ComboBox();
            this.txtMaxTeilnehmer = new System.Windows.Forms.TextBox();
            this.txtAktTeilnehmer = new System.Windows.Forms.TextBox();
            this.lblEndeTermin = new System.Windows.Forms.Label();
            this.lblEvTermin = new System.Windows.Forms.Label();
            this.lblStartOrt = new System.Windows.Forms.Label();
            this.txtBeschreibung = new System.Windows.Forms.TextBox();
            this.txtZielOrt = new System.Windows.Forms.TextBox();
            this.txtStartOrt = new System.Windows.Forms.TextBox();
            this.txtEnde = new System.Windows.Forms.TextBox();
            this.lblZielOrt = new System.Windows.Forms.Label();
            this.lblAktTeilnehmer = new System.Windows.Forms.Label();
            this.lblMaxTeilnehmer = new System.Windows.Forms.Label();
            this.grpEventDaten = new System.Windows.Forms.GroupBox();
            this.txtStarttermin = new System.Windows.Forms.TextBox();
            this.lblEventBezeichnung = new System.Windows.Forms.Label();
            this.txtEventBezeichnung = new System.Windows.Forms.TextBox();
            this.txtPreis = new System.Windows.Forms.TextBox();
            this.lblPreis = new System.Windows.Forms.Label();
            this.buchungenToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.hpBuchungen = new System.Windows.Forms.HelpProvider();
            this.grpKundenDaten.SuspendLayout();
            this.grpKunde.SuspendLayout();
            this.grpEventAuswahl.SuspendLayout();
            this.grpEventDaten.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKundenDaten
            // 
            this.grpKundenDaten.Controls.Add(this.btnStorniereEvent);
            this.grpKundenDaten.Controls.Add(this.trvKundenEvents);
            this.grpKundenDaten.Controls.Add(this.lblAuswahlName);
            this.grpKundenDaten.Controls.Add(this.lblGebuchteEvents);
            this.grpKundenDaten.Controls.Add(this.cboName);
            this.grpKundenDaten.Controls.Add(this.txtEMail);
            this.grpKundenDaten.Controls.Add(this.txtTelefon);
            this.grpKundenDaten.Controls.Add(this.txtOrt);
            this.grpKundenDaten.Controls.Add(this.txtPLZ);
            this.grpKundenDaten.Controls.Add(this.txtHnummer);
            this.grpKundenDaten.Controls.Add(this.txtStrasse);
            this.grpKundenDaten.Controls.Add(this.txtVorname);
            this.grpKundenDaten.Controls.Add(this.txtName);
            this.grpKundenDaten.Controls.Add(this.lblEMail);
            this.grpKundenDaten.Controls.Add(this.lblTelefon);
            this.grpKundenDaten.Controls.Add(this.lblOrt);
            this.grpKundenDaten.Controls.Add(this.lblPLZ);
            this.grpKundenDaten.Controls.Add(this.lblStrasse);
            this.grpKundenDaten.Controls.Add(this.lblHNummer);
            this.grpKundenDaten.Controls.Add(this.lblVorname);
            this.grpKundenDaten.Controls.Add(this.lblName);
            this.grpKundenDaten.Location = new System.Drawing.Point(8, 216);
            this.grpKundenDaten.Name = "grpKundenDaten";
            this.grpKundenDaten.Size = new System.Drawing.Size(760, 256);
            this.grpKundenDaten.TabIndex = 1;
            this.grpKundenDaten.TabStop = false;
            this.grpKundenDaten.Text = "Kundendaten";
            // 
            // btnStorniereEvent
            // 
            this.hpBuchungen.SetHelpString(this.btnStorniereEvent, "Storniert das aktuell ausgewählte Kundenevent.");
            this.btnStorniereEvent.Location = new System.Drawing.Point(472, 224);
            this.btnStorniereEvent.Name = "btnStorniereEvent";
            this.hpBuchungen.SetShowHelp(this.btnStorniereEvent, true);
            this.btnStorniereEvent.Size = new System.Drawing.Size(272, 23);
            this.btnStorniereEvent.TabIndex = 20;
            this.btnStorniereEvent.Text = "ausgewähltes Kundenevent &stornieren";
            this.buchungenToolTip.SetToolTip(this.btnStorniereEvent, "storniert das gewählte Kundenevent ");
            this.btnStorniereEvent.Click += new System.EventHandler(this.btnStorniereEvent_Click);
            // 
            // trvKundenEvents
            // 
            this.hpBuchungen.SetHelpString(this.trvKundenEvents, "Listet alle Buchungen des Kunden auf.");
            this.trvKundenEvents.Location = new System.Drawing.Point(472, 48);
            this.trvKundenEvents.Name = "trvKundenEvents";
            this.hpBuchungen.SetShowHelp(this.trvKundenEvents, true);
            this.trvKundenEvents.Size = new System.Drawing.Size(272, 160);
            this.trvKundenEvents.TabIndex = 19;
            this.buchungenToolTip.SetToolTip(this.trvKundenEvents, "Anzeige der Kundenevents");
            // 
            // lblAuswahlName
            // 
            this.lblAuswahlName.Location = new System.Drawing.Point(16, 24);
            this.lblAuswahlName.Name = "lblAuswahlName";
            this.lblAuswahlName.Size = new System.Drawing.Size(264, 16);
            this.lblAuswahlName.TabIndex = 0;
            this.lblAuswahlName.Text = "Bitte wählen Sie den Kunden aus!";
            // 
            // lblGebuchteEvents
            // 
            this.lblGebuchteEvents.Location = new System.Drawing.Point(472, 24);
            this.lblGebuchteEvents.Name = "lblGebuchteEvents";
            this.lblGebuchteEvents.Size = new System.Drawing.Size(224, 16);
            this.lblGebuchteEvents.TabIndex = 18;
            this.lblGebuchteEvents.Text = "gebuchte Events des Kunden";
            // 
            // cboName
            // 
            this.hpBuchungen.SetHelpString(this.cboName, "Wählen Sie den aktuellen Kunden anhand des Vornamens aus.");
            this.cboName.Location = new System.Drawing.Point(16, 48);
            this.cboName.Name = "cboName";
            this.hpBuchungen.SetShowHelp(this.cboName, true);
            this.cboName.Size = new System.Drawing.Size(264, 21);
            this.cboName.TabIndex = 1;
            this.buchungenToolTip.SetToolTip(this.cboName, "Vornamen wählen");
            // 
            // txtEMail
            // 
            this.hpBuchungen.SetHelpString(this.txtEMail, "Eingabe/ Ändern der EMail - Adresse");
            this.txtEMail.Location = new System.Drawing.Point(192, 224);
            this.txtEMail.Name = "txtEMail";
            this.hpBuchungen.SetShowHelp(this.txtEMail, true);
            this.txtEMail.Size = new System.Drawing.Size(256, 20);
            this.txtEMail.TabIndex = 17;
            this.buchungenToolTip.SetToolTip(this.txtEMail, "EMail Adresse eingeben/ ändern");
            // 
            // txtTelefon
            // 
            this.hpBuchungen.SetHelpString(this.txtTelefon, "Eingabe/ Ändern der Telefonnummer");
            this.txtTelefon.Location = new System.Drawing.Point(16, 224);
            this.txtTelefon.Name = "txtTelefon";
            this.hpBuchungen.SetShowHelp(this.txtTelefon, true);
            this.txtTelefon.Size = new System.Drawing.Size(160, 20);
            this.txtTelefon.TabIndex = 15;
            this.buchungenToolTip.SetToolTip(this.txtTelefon, "Telefonnummer eingeben/ ändern");
            // 
            // txtOrt
            // 
            this.hpBuchungen.SetHelpString(this.txtOrt, "Eingabe/ Ändern des Ortes");
            this.txtOrt.Location = new System.Drawing.Point(152, 184);
            this.txtOrt.Name = "txtOrt";
            this.hpBuchungen.SetShowHelp(this.txtOrt, true);
            this.txtOrt.Size = new System.Drawing.Size(296, 20);
            this.txtOrt.TabIndex = 13;
            this.buchungenToolTip.SetToolTip(this.txtOrt, "Ort eingeben/ ändern");
            // 
            // txtPLZ
            // 
            this.hpBuchungen.SetHelpString(this.txtPLZ, "Eingabe/ Ändern der Postleitzahl");
            this.txtPLZ.Location = new System.Drawing.Point(16, 184);
            this.txtPLZ.Name = "txtPLZ";
            this.hpBuchungen.SetShowHelp(this.txtPLZ, true);
            this.txtPLZ.Size = new System.Drawing.Size(120, 20);
            this.txtPLZ.TabIndex = 11;
            this.buchungenToolTip.SetToolTip(this.txtPLZ, "PLZ eingeben/ ändern");
            // 
            // txtHnummer
            // 
            this.hpBuchungen.SetHelpString(this.txtHnummer, "Eingabe/ Ändern der Hausnummer");
            this.txtHnummer.Location = new System.Drawing.Point(336, 144);
            this.txtHnummer.Name = "txtHnummer";
            this.hpBuchungen.SetShowHelp(this.txtHnummer, true);
            this.txtHnummer.Size = new System.Drawing.Size(112, 20);
            this.txtHnummer.TabIndex = 9;
            this.buchungenToolTip.SetToolTip(this.txtHnummer, "Hausnummer eingeben/ ändern");
            // 
            // txtStrasse
            // 
            this.hpBuchungen.SetHelpString(this.txtStrasse, "Eingabe/ Ändern der Straße");
            this.txtStrasse.Location = new System.Drawing.Point(16, 144);
            this.txtStrasse.Name = "txtStrasse";
            this.hpBuchungen.SetShowHelp(this.txtStrasse, true);
            this.txtStrasse.Size = new System.Drawing.Size(304, 20);
            this.txtStrasse.TabIndex = 7;
            this.buchungenToolTip.SetToolTip(this.txtStrasse, "Straße eingeben/ ändern");
            // 
            // txtVorname
            // 
            this.hpBuchungen.SetHelpString(this.txtVorname, "Eingabe/ Ändern des Vornamens");
            this.txtVorname.Location = new System.Drawing.Point(296, 104);
            this.txtVorname.Name = "txtVorname";
            this.hpBuchungen.SetShowHelp(this.txtVorname, true);
            this.txtVorname.Size = new System.Drawing.Size(152, 20);
            this.txtVorname.TabIndex = 5;
            this.buchungenToolTip.SetToolTip(this.txtVorname, "Vornamen eingeben/ ändern");
            // 
            // txtName
            // 
            this.hpBuchungen.SetHelpString(this.txtName, "Eingabe/ Ändern des Vornamens");
            this.txtName.Location = new System.Drawing.Point(16, 104);
            this.txtName.Name = "txtName";
            this.hpBuchungen.SetShowHelp(this.txtName, true);
            this.txtName.Size = new System.Drawing.Size(264, 20);
            this.txtName.TabIndex = 3;
            this.buchungenToolTip.SetToolTip(this.txtName, "Namen eingeben/ ändern");
            // 
            // lblEMail
            // 
            this.lblEMail.Location = new System.Drawing.Point(192, 208);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(100, 16);
            this.lblEMail.TabIndex = 16;
            this.lblEMail.Text = "eMail";
            // 
            // lblTelefon
            // 
            this.lblTelefon.Location = new System.Drawing.Point(16, 208);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(100, 16);
            this.lblTelefon.TabIndex = 14;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblOrt
            // 
            this.lblOrt.Location = new System.Drawing.Point(152, 168);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(72, 16);
            this.lblOrt.TabIndex = 12;
            this.lblOrt.Text = "Ort";
            // 
            // lblPLZ
            // 
            this.lblPLZ.Location = new System.Drawing.Point(16, 168);
            this.lblPLZ.Name = "lblPLZ";
            this.lblPLZ.Size = new System.Drawing.Size(100, 16);
            this.lblPLZ.TabIndex = 10;
            this.lblPLZ.Text = "PLZ";
            // 
            // lblStrasse
            // 
            this.lblStrasse.Location = new System.Drawing.Point(16, 128);
            this.lblStrasse.Name = "lblStrasse";
            this.lblStrasse.Size = new System.Drawing.Size(100, 16);
            this.lblStrasse.TabIndex = 6;
            this.lblStrasse.Text = "Straße";
            // 
            // lblHNummer
            // 
            this.lblHNummer.Location = new System.Drawing.Point(336, 128);
            this.lblHNummer.Name = "lblHNummer";
            this.lblHNummer.Size = new System.Drawing.Size(100, 16);
            this.lblHNummer.TabIndex = 8;
            this.lblHNummer.Text = "Hausnummer";
            // 
            // lblVorname
            // 
            this.lblVorname.Location = new System.Drawing.Point(296, 88);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(100, 16);
            this.lblVorname.TabIndex = 4;
            this.lblVorname.Text = "Vorname";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(16, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // btnUpdtKunde
            // 
            this.hpBuchungen.SetHelpString(this.btnUpdtKunde, "Daten eines neuen Kunden bzw. geänderte Kundendaten werden gespeichert.");
            this.btnUpdtKunde.Location = new System.Drawing.Point(16, 152);
            this.btnUpdtKunde.Name = "btnUpdtKunde";
            this.hpBuchungen.SetShowHelp(this.btnUpdtKunde, true);
            this.btnUpdtKunde.Size = new System.Drawing.Size(312, 23);
            this.btnUpdtKunde.TabIndex = 4;
            this.btnUpdtKunde.Text = "&Änderungen speichern";
            this.buchungenToolTip.SetToolTip(this.btnUpdtKunde, "speichert Änderungen an den Kundendaten");
            this.btnUpdtKunde.Click += new System.EventHandler(this.btnUpdtKunde_Click);
            // 
            // btnNeuerKunde
            // 
            this.hpBuchungen.SetHelpString(this.btnNeuerKunde, "Ein neuer Kunde kann angelegt werden.");
            this.btnNeuerKunde.Location = new System.Drawing.Point(16, 120);
            this.btnNeuerKunde.Name = "btnNeuerKunde";
            this.hpBuchungen.SetShowHelp(this.btnNeuerKunde, true);
            this.btnNeuerKunde.Size = new System.Drawing.Size(312, 23);
            this.btnNeuerKunde.TabIndex = 3;
            this.btnNeuerKunde.Text = "&neuer Kunde";
            this.buchungenToolTip.SetToolTip(this.btnNeuerKunde, "neuen Kunden anlegen");
            this.btnNeuerKunde.Click += new System.EventHandler(this.btnNeuerKunde_Click);
            // 
            // txtSuchname
            // 
            this.hpBuchungen.SetHelpString(this.txtSuchname, "Bitte geben Sie den Nachnamen des Gesuchten Kunden ein!");
            this.txtSuchname.Location = new System.Drawing.Point(16, 48);
            this.txtSuchname.Name = "txtSuchname";
            this.hpBuchungen.SetShowHelp(this.txtSuchname, true);
            this.txtSuchname.Size = new System.Drawing.Size(312, 20);
            this.txtSuchname.TabIndex = 1;
            this.buchungenToolTip.SetToolTip(this.txtSuchname, "Eingabe des Nachnamens des gesuchten Kunden ");
            // 
            // lblSuchname
            // 
            this.lblSuchname.Location = new System.Drawing.Point(16, 24);
            this.lblSuchname.Name = "lblSuchname";
            this.lblSuchname.Size = new System.Drawing.Size(312, 16);
            this.lblSuchname.TabIndex = 0;
            this.lblSuchname.Text = "Bitte geben Sie den Nachnamen des gesuchten Kunden ein!";
            // 
            // btnSucheKunde
            // 
            this.hpBuchungen.SetHelpString(this.btnSucheKunde, "Sucht nach dem eingegebenen Kunden in der Datenbank.");
            this.btnSucheKunde.Location = new System.Drawing.Point(16, 88);
            this.btnSucheKunde.Name = "btnSucheKunde";
            this.hpBuchungen.SetShowHelp(this.btnSucheKunde, true);
            this.btnSucheKunde.Size = new System.Drawing.Size(312, 23);
            this.btnSucheKunde.TabIndex = 2;
            this.btnSucheKunde.Text = "Kunden s&uchen";
            this.buchungenToolTip.SetToolTip(this.btnSucheKunde, "eingegebener Kunde wird gesucht");
            this.btnSucheKunde.Click += new System.EventHandler(this.btnSucheKunde_Click);
            // 
            // cboEvents
            // 
            this.cboEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hpBuchungen.SetHelpString(this.cboEvents, "Ein Event kann zur Buchung ausgewählt werden.");
            this.cboEvents.Location = new System.Drawing.Point(8, 48);
            this.cboEvents.Name = "cboEvents";
            this.hpBuchungen.SetShowHelp(this.cboEvents, true);
            this.cboEvents.Size = new System.Drawing.Size(384, 21);
            this.cboEvents.TabIndex = 1;
            this.buchungenToolTip.SetToolTip(this.cboEvents, "Auswahl des zu buchenden Events");
            // 
            // buchungsMenu
            // 
            this.buchungsMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuKunde,
            this.mnuEvent,
            this.mnuAnsicht});
            // 
            // mnuKunde
            // 
            this.mnuKunde.Index = 0;
            this.mnuKunde.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuKundenSuchen,
            this.mnuNeuerKunde,
            this.mnuAenderungenSpeichern});
            this.mnuKunde.Text = "&Kunde";
            // 
            // mnuKundenSuchen
            // 
            this.mnuKundenSuchen.Index = 0;
            this.mnuKundenSuchen.Text = "Kunden s&uchen";
            this.mnuKundenSuchen.Click += new System.EventHandler(this.btnSucheKunde_Click);
            // 
            // mnuNeuerKunde
            // 
            this.mnuNeuerKunde.Index = 1;
            this.mnuNeuerKunde.Text = "&neuer Kunde";
            this.mnuNeuerKunde.Click += new System.EventHandler(this.btnNeuerKunde_Click);
            // 
            // mnuAenderungenSpeichern
            // 
            this.mnuAenderungenSpeichern.Index = 2;
            this.mnuAenderungenSpeichern.Text = "&Änderungen speichern";
            this.mnuAenderungenSpeichern.Click += new System.EventHandler(this.btnUpdtKunde_Click);
            // 
            // mnuEvent
            // 
            this.mnuEvent.Index = 1;
            this.mnuEvent.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuBuchen,
            this.mnuStorno,
            this.mnuRefreshEvents});
            this.mnuEvent.Text = "&Event";
            // 
            // mnuBuchen
            // 
            this.mnuBuchen.Index = 0;
            this.mnuBuchen.Text = "ausgeähltes Event &buchen";
            this.mnuBuchen.Click += new System.EventHandler(this.btnBucheEvent_Click);
            // 
            // mnuStorno
            // 
            this.mnuStorno.Index = 1;
            this.mnuStorno.Text = "ausgewähltes Kundenevent &stornieren";
            this.mnuStorno.Click += new System.EventHandler(this.btnStorniereEvent_Click);
            // 
            // mnuRefreshEvents
            // 
            this.mnuRefreshEvents.Index = 2;
            this.mnuRefreshEvents.Text = "Eventauswahl aktualisie&ren";
            this.mnuRefreshEvents.Click += new System.EventHandler(this.mnuRefreshEvents_Click);
            // 
            // mnuAnsicht
            // 
            this.mnuAnsicht.Index = 2;
            this.mnuAnsicht.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEventdetails});
            this.mnuAnsicht.Text = "&Ansicht";
            // 
            // mnuEventdetails
            // 
            this.mnuEventdetails.Checked = true;
            this.mnuEventdetails.Index = 0;
            this.mnuEventdetails.Text = "Event&details";
            this.mnuEventdetails.Click += new System.EventHandler(this.mnuEventdetails_Click);
            // 
            // grpKunde
            // 
            this.grpKunde.Controls.Add(this.btnNeuerKunde);
            this.grpKunde.Controls.Add(this.lblSuchname);
            this.grpKunde.Controls.Add(this.btnUpdtKunde);
            this.grpKunde.Controls.Add(this.btnSucheKunde);
            this.grpKunde.Controls.Add(this.txtSuchname);
            this.grpKunde.Location = new System.Drawing.Point(8, 8);
            this.grpKunde.Name = "grpKunde";
            this.grpKunde.Size = new System.Drawing.Size(344, 200);
            this.grpKunde.TabIndex = 0;
            this.grpKunde.TabStop = false;
            this.grpKunde.Text = "Kundenverwaltung";
            // 
            // grpEventAuswahl
            // 
            this.grpEventAuswahl.Controls.Add(this.lblStarttermin);
            this.grpEventAuswahl.Controls.Add(this.lblVeranstalter);
            this.grpEventAuswahl.Controls.Add(this.txtKategorie);
            this.grpEventAuswahl.Controls.Add(this.lblEventAuswahl);
            this.grpEventAuswahl.Controls.Add(this.cboEvents);
            this.grpEventAuswahl.Controls.Add(this.lblKategorie);
            this.grpEventAuswahl.Controls.Add(this.txtVeranstalter);
            this.grpEventAuswahl.Controls.Add(this.btnBucheEvent);
            this.grpEventAuswahl.Controls.Add(this.cboDatum);
            this.grpEventAuswahl.Location = new System.Drawing.Point(368, 8);
            this.grpEventAuswahl.Name = "grpEventAuswahl";
            this.grpEventAuswahl.Size = new System.Drawing.Size(400, 200);
            this.grpEventAuswahl.TabIndex = 2;
            this.grpEventAuswahl.TabStop = false;
            this.grpEventAuswahl.Text = "Eventauswahl";
            // 
            // lblStarttermin
            // 
            this.lblStarttermin.Location = new System.Drawing.Point(8, 88);
            this.lblStarttermin.Name = "lblStarttermin";
            this.lblStarttermin.Size = new System.Drawing.Size(72, 16);
            this.lblStarttermin.TabIndex = 2;
            this.lblStarttermin.Text = "Starttermin";
            // 
            // lblVeranstalter
            // 
            this.lblVeranstalter.Location = new System.Drawing.Point(136, 120);
            this.lblVeranstalter.Name = "lblVeranstalter";
            this.lblVeranstalter.Size = new System.Drawing.Size(100, 16);
            this.lblVeranstalter.TabIndex = 6;
            this.lblVeranstalter.Text = "Eventveranstalter";
            // 
            // txtKategorie
            // 
            this.txtKategorie.Location = new System.Drawing.Point(8, 136);
            this.txtKategorie.Name = "txtKategorie";
            this.txtKategorie.ReadOnly = true;
            this.txtKategorie.Size = new System.Drawing.Size(104, 20);
            this.txtKategorie.TabIndex = 5;
            this.txtKategorie.TabStop = false;
            // 
            // lblEventAuswahl
            // 
            this.lblEventAuswahl.Location = new System.Drawing.Point(8, 24);
            this.lblEventAuswahl.Name = "lblEventAuswahl";
            this.lblEventAuswahl.Size = new System.Drawing.Size(328, 16);
            this.lblEventAuswahl.TabIndex = 0;
            this.lblEventAuswahl.Text = "Bitte wählen Sie ein Event zur Buchung aus!";
            // 
            // lblKategorie
            // 
            this.lblKategorie.Location = new System.Drawing.Point(8, 120);
            this.lblKategorie.Name = "lblKategorie";
            this.lblKategorie.Size = new System.Drawing.Size(100, 16);
            this.lblKategorie.TabIndex = 4;
            this.lblKategorie.Text = "Eventkategorie";
            // 
            // txtVeranstalter
            // 
            this.txtVeranstalter.Location = new System.Drawing.Point(136, 136);
            this.txtVeranstalter.Name = "txtVeranstalter";
            this.txtVeranstalter.ReadOnly = true;
            this.txtVeranstalter.Size = new System.Drawing.Size(256, 20);
            this.txtVeranstalter.TabIndex = 7;
            this.txtVeranstalter.TabStop = false;
            // 
            // btnBucheEvent
            // 
            this.hpBuchungen.SetHelpString(this.btnBucheEvent, "Das ausgewählte Event wird für den gewählten Kunden gebucht.");
            this.btnBucheEvent.Location = new System.Drawing.Point(128, 168);
            this.btnBucheEvent.Name = "btnBucheEvent";
            this.hpBuchungen.SetShowHelp(this.btnBucheEvent, true);
            this.btnBucheEvent.Size = new System.Drawing.Size(160, 23);
            this.btnBucheEvent.TabIndex = 8;
            this.btnBucheEvent.Text = "ausgewähltes Event &buchen";
            this.buchungenToolTip.SetToolTip(this.btnBucheEvent, "Buchen des Events");
            this.btnBucheEvent.Click += new System.EventHandler(this.btnBucheEvent_Click);
            // 
            // cboDatum
            // 
            this.cboDatum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hpBuchungen.SetHelpString(this.cboDatum, "Der Starttermin des Events kann gewählt werden.");
            this.cboDatum.Location = new System.Drawing.Point(88, 85);
            this.cboDatum.Name = "cboDatum";
            this.hpBuchungen.SetShowHelp(this.cboDatum, true);
            this.cboDatum.Size = new System.Drawing.Size(304, 21);
            this.cboDatum.TabIndex = 3;
            this.buchungenToolTip.SetToolTip(this.cboDatum, "Auswahl des Starttermins des Events");
            // 
            // txtMaxTeilnehmer
            // 
            this.txtMaxTeilnehmer.Location = new System.Drawing.Point(160, 208);
            this.txtMaxTeilnehmer.Name = "txtMaxTeilnehmer";
            this.txtMaxTeilnehmer.ReadOnly = true;
            this.txtMaxTeilnehmer.Size = new System.Drawing.Size(96, 20);
            this.txtMaxTeilnehmer.TabIndex = 11;
            this.txtMaxTeilnehmer.TabStop = false;
            this.txtMaxTeilnehmer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAktTeilnehmer
            // 
            this.txtAktTeilnehmer.Location = new System.Drawing.Point(8, 208);
            this.txtAktTeilnehmer.Name = "txtAktTeilnehmer";
            this.txtAktTeilnehmer.ReadOnly = true;
            this.txtAktTeilnehmer.Size = new System.Drawing.Size(96, 20);
            this.txtAktTeilnehmer.TabIndex = 9;
            this.txtAktTeilnehmer.TabStop = false;
            this.txtAktTeilnehmer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEndeTermin
            // 
            this.lblEndeTermin.Location = new System.Drawing.Point(8, 120);
            this.lblEndeTermin.Name = "lblEndeTermin";
            this.lblEndeTermin.Size = new System.Drawing.Size(100, 16);
            this.lblEndeTermin.TabIndex = 4;
            this.lblEndeTermin.Text = "Ende";
            // 
            // lblEvTermin
            // 
            this.lblEvTermin.Location = new System.Drawing.Point(8, 80);
            this.lblEvTermin.Name = "lblEvTermin";
            this.lblEvTermin.Size = new System.Drawing.Size(152, 16);
            this.lblEvTermin.TabIndex = 2;
            this.lblEvTermin.Text = "Beginn";
            // 
            // lblStartOrt
            // 
            this.lblStartOrt.Location = new System.Drawing.Point(8, 232);
            this.lblStartOrt.Name = "lblStartOrt";
            this.lblStartOrt.Size = new System.Drawing.Size(56, 16);
            this.lblStartOrt.TabIndex = 12;
            this.lblStartOrt.Text = "Startort";
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Location = new System.Drawing.Point(8, 320);
            this.txtBeschreibung.Multiline = true;
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.ReadOnly = true;
            this.txtBeschreibung.Size = new System.Drawing.Size(248, 128);
            this.txtBeschreibung.TabIndex = 16;
            this.txtBeschreibung.TabStop = false;
            // 
            // txtZielOrt
            // 
            this.txtZielOrt.Location = new System.Drawing.Point(8, 288);
            this.txtZielOrt.Name = "txtZielOrt";
            this.txtZielOrt.ReadOnly = true;
            this.txtZielOrt.Size = new System.Drawing.Size(248, 20);
            this.txtZielOrt.TabIndex = 15;
            this.txtZielOrt.TabStop = false;
            // 
            // txtStartOrt
            // 
            this.txtStartOrt.Location = new System.Drawing.Point(8, 248);
            this.txtStartOrt.Name = "txtStartOrt";
            this.txtStartOrt.ReadOnly = true;
            this.txtStartOrt.Size = new System.Drawing.Size(248, 20);
            this.txtStartOrt.TabIndex = 13;
            this.txtStartOrt.TabStop = false;
            // 
            // txtEnde
            // 
            this.txtEnde.Location = new System.Drawing.Point(8, 136);
            this.txtEnde.Name = "txtEnde";
            this.txtEnde.ReadOnly = true;
            this.txtEnde.Size = new System.Drawing.Size(248, 20);
            this.txtEnde.TabIndex = 5;
            this.txtEnde.TabStop = false;
            // 
            // lblZielOrt
            // 
            this.lblZielOrt.Location = new System.Drawing.Point(8, 272);
            this.lblZielOrt.Name = "lblZielOrt";
            this.lblZielOrt.Size = new System.Drawing.Size(48, 16);
            this.lblZielOrt.TabIndex = 14;
            this.lblZielOrt.Text = "Zielort";
            // 
            // lblAktTeilnehmer
            // 
            this.lblAktTeilnehmer.Location = new System.Drawing.Point(8, 192);
            this.lblAktTeilnehmer.Name = "lblAktTeilnehmer";
            this.lblAktTeilnehmer.Size = new System.Drawing.Size(112, 16);
            this.lblAktTeilnehmer.TabIndex = 8;
            this.lblAktTeilnehmer.Text = "aktuelle Teilnehmer";
            // 
            // lblMaxTeilnehmer
            // 
            this.lblMaxTeilnehmer.Location = new System.Drawing.Point(160, 192);
            this.lblMaxTeilnehmer.Name = "lblMaxTeilnehmer";
            this.lblMaxTeilnehmer.Size = new System.Drawing.Size(96, 16);
            this.lblMaxTeilnehmer.TabIndex = 10;
            this.lblMaxTeilnehmer.Text = "max. Teilnehmer";
            // 
            // grpEventDaten
            // 
            this.grpEventDaten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEventDaten.Controls.Add(this.txtStarttermin);
            this.grpEventDaten.Controls.Add(this.lblEventBezeichnung);
            this.grpEventDaten.Controls.Add(this.txtEventBezeichnung);
            this.grpEventDaten.Controls.Add(this.txtPreis);
            this.grpEventDaten.Controls.Add(this.lblPreis);
            this.grpEventDaten.Controls.Add(this.txtBeschreibung);
            this.grpEventDaten.Controls.Add(this.txtZielOrt);
            this.grpEventDaten.Controls.Add(this.lblZielOrt);
            this.grpEventDaten.Controls.Add(this.txtStartOrt);
            this.grpEventDaten.Controls.Add(this.lblStartOrt);
            this.grpEventDaten.Controls.Add(this.txtAktTeilnehmer);
            this.grpEventDaten.Controls.Add(this.lblAktTeilnehmer);
            this.grpEventDaten.Controls.Add(this.lblMaxTeilnehmer);
            this.grpEventDaten.Controls.Add(this.txtMaxTeilnehmer);
            this.grpEventDaten.Controls.Add(this.lblEndeTermin);
            this.grpEventDaten.Controls.Add(this.lblEvTermin);
            this.grpEventDaten.Controls.Add(this.txtEnde);
            this.grpEventDaten.Location = new System.Drawing.Point(784, 8);
            this.grpEventDaten.Name = "grpEventDaten";
            this.grpEventDaten.Size = new System.Drawing.Size(264, 462);
            this.grpEventDaten.TabIndex = 3;
            this.grpEventDaten.TabStop = false;
            this.grpEventDaten.Text = "Eventdetails";
            // 
            // txtStarttermin
            // 
            this.txtStarttermin.Location = new System.Drawing.Point(8, 96);
            this.txtStarttermin.Name = "txtStarttermin";
            this.txtStarttermin.ReadOnly = true;
            this.txtStarttermin.Size = new System.Drawing.Size(248, 20);
            this.txtStarttermin.TabIndex = 3;
            this.txtStarttermin.TabStop = false;
            // 
            // lblEventBezeichnung
            // 
            this.lblEventBezeichnung.Location = new System.Drawing.Point(8, 24);
            this.lblEventBezeichnung.Name = "lblEventBezeichnung";
            this.lblEventBezeichnung.Size = new System.Drawing.Size(100, 16);
            this.lblEventBezeichnung.TabIndex = 0;
            this.lblEventBezeichnung.Text = "Eventbezeichnung";
            // 
            // txtEventBezeichnung
            // 
            this.txtEventBezeichnung.Location = new System.Drawing.Point(8, 48);
            this.txtEventBezeichnung.Name = "txtEventBezeichnung";
            this.txtEventBezeichnung.ReadOnly = true;
            this.txtEventBezeichnung.Size = new System.Drawing.Size(248, 20);
            this.txtEventBezeichnung.TabIndex = 1;
            this.txtEventBezeichnung.TabStop = false;
            // 
            // txtPreis
            // 
            this.txtPreis.Location = new System.Drawing.Point(160, 168);
            this.txtPreis.Name = "txtPreis";
            this.txtPreis.ReadOnly = true;
            this.txtPreis.Size = new System.Drawing.Size(96, 20);
            this.txtPreis.TabIndex = 7;
            this.txtPreis.TabStop = false;
            // 
            // lblPreis
            // 
            this.lblPreis.Location = new System.Drawing.Point(40, 168);
            this.lblPreis.Name = "lblPreis";
            this.lblPreis.Size = new System.Drawing.Size(112, 16);
            this.lblPreis.TabIndex = 6;
            this.lblPreis.Text = "Preis pro Teilnehmer";
            // 
            // KundenBuchungsForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1056, 479);
            this.Controls.Add(this.grpEventDaten);
            this.Controls.Add(this.grpEventAuswahl);
            this.Controls.Add(this.grpKunde);
            this.Controls.Add(this.grpKundenDaten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.buchungsMenu;
            this.MinimizeBox = false;
            this.Name = "KundenBuchungsForm";
            this.hpBuchungen.SetShowHelp(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kunden Buchungen";
            this.TopMost = true;
            this.Closed += new System.EventHandler(this.KundenBuchungsForm_Closed);
            this.Load += new System.EventHandler(this.KundenBuchungsForm_Load);
            this.grpKundenDaten.ResumeLayout(false);
            this.grpKundenDaten.PerformLayout();
            this.grpKunde.ResumeLayout(false);
            this.grpKunde.PerformLayout();
            this.grpEventAuswahl.ResumeLayout(false);
            this.grpEventAuswahl.PerformLayout();
            this.grpEventDaten.ResumeLayout(false);
            this.grpEventDaten.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// UC 01.1 Anzeige der Buchbaren Events.
		/// </summary>
		/// <remarks>
		/// Refresh der Eventliste wird durchgefuehrt
		///</remarks>
		private void RefreshEventBezeichnungen()
		{
			try
			{
				// Daten laden
				ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
				this.aEvBezeichnungen = dtm.LadeEventBezeichnungen();
				// ComboBox fuellen
				this.cboEvents.DataSource = this.aEvBezeichnungen;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// UC 01.1, 01.5 Refresh der DataBindings an das geaenderte Kundenbuchungsarray.
		/// </summary>
		/// <remarks>
		/// Die Treeview wird aufgebaut
		///</remarks>
		private void RefreshBuchungen()
		{
			// Aktuelle Buchungen des Kunden zuruecksetzen
			this.alBuchungen = null;
			// Treeview zuruecksetzen
			this.trvKundenEvents.Nodes.Clear();

			// Kunde gefunden?
			if(this.aKunden != null)
			{
				// Buchung des aktuellen Kunden holen
				this.alBuchungen = this.aKunden[this.cmKunden.Position].Buchungen;

				// sind Buchungen vorhanden?
				if(alBuchungen.Count != 0)
				{
					// solange noch Buchungen vorhanden sind
					for(int i = 0; i< alBuchungen.Count; i++)
					{
						// Buchungsknoten erzeugen
						TreeNode [] aNodes = new TreeNode[4];

						// Child-Knoten aufbauen
						aNodes[0] = new TreeNode("Startort: " + ((ManageBuchungen.IBuchung) alBuchungen[i]).StartOrt);
						aNodes[1] = new TreeNode("Starttermin: " + ((ManageBuchungen.IBuchung) alBuchungen[i]).StartTermin.ToShortDateString());
						aNodes[2] = new TreeNode("Preis: " + (((ManageBuchungen.IBuchung) alBuchungen[i]).GebuchtePlaetze * ((ManageBuchungen.IBuchung) alBuchungen[i]).Preis).ToString("c"));
						aNodes[3] = new TreeNode("gebuchte Plätze: " + ((ManageBuchungen.IBuchung) alBuchungen[i]).GebuchtePlaetze.ToString());

						// Ist Event storniert?
						string s = "";
						if(((ManageBuchungen.IBuchung)alBuchungen[i]).Storniert == true)
							s = "Storniert: ";
					
						// Treeview zusammensetzen
						TreeNode nEvent = new TreeNode(s + ((ManageBuchungen.IBuchung)alBuchungen[i]).EventBezeichnung, aNodes);
						if(s != "")
							nEvent.ForeColor = Color.Red;
					
						// Tag auf die Buchung setzen
						nEvent.Tag = alBuchungen[i];

						// Node zur TreeView hinzufuegen
						this.trvKundenEvents.Nodes.Add(nEvent);
					}
				}
			}
		}

		/// <summary>
		/// UC 02.1, 02.1.1, 02.1.2 Kundendaten verwalten
		/// </summary>
		/// <remarks>
		/// Refresh der DataBindings an das geaenderte Kundenobjektarray
		///</remarks>
		private void RefreshKunde()
		{
			// Alle DataBindings zuruecksetzen
			this.cboName.DataBindings.Clear();
			this.txtEMail.DataBindings.Clear();
			this.txtHnummer.DataBindings.Clear();
			this.txtName.DataBindings.Clear();
			this.txtOrt.DataBindings.Clear();
			this.txtPLZ.DataBindings.Clear();
			this.txtStrasse.DataBindings.Clear();
			this.txtTelefon.DataBindings.Clear();
			this.txtVorname.DataBindings.Clear();

			// Textboxen leeren
			this.cboName.Text = "";
			this.txtEMail.Clear();
			this.txtHnummer.Clear();
			this.txtName.Clear();
			this.txtOrt.Clear();
			this.txtPLZ.Clear();
			this.txtStrasse.Clear();
			this.txtTelefon.Clear();
			this.txtVorname.Clear();

			// Ist ein Kunde gewaehlt?
			if(this.aKunden != null)
			{
				// DataBindings neu erzeugen
				this.cboName.DataSource = this.aKunden;
				this.cboName.DisplayMember = "Vorname";
				this.txtEMail.DataBindings.Add("Text", this.aKunden, "EMail");
				this.txtHnummer.DataBindings.Add("Text", this.aKunden, "HNummer");
				this.txtName.DataBindings.Add("Text", this.aKunden, "Name");
				this.txtOrt.DataBindings.Add("Text", this.aKunden, "Ort");
				this.txtPLZ.DataBindings.Add("Text", this.aKunden, "PLZ");
				this.txtStrasse.DataBindings.Add("Text", this.aKunden, "Strasse");
				this.txtTelefon.DataBindings.Add("Text", this.aKunden, "Telefon");
				this.txtVorname.DataBindings.Add("Text", this.aKunden, "Vorname");

				// CurrencyManager neu erstellen
				this.cmKunden = null;
				this.cmKunden = (CurrencyManager) this.BindingContext[aKunden];
				this.cmKunden.PositionChanged += new System.EventHandler(this.cmKunden_PositionChanged);
			}
		}

		/// <summary>
		/// automatischer Refresh der Anzeige der Kundenbuchungen, wenn neuer Kunde gewaehlt wird
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmKunden_PositionChanged(object sender, System.EventArgs e)
		{
			this.RefreshBuchungen();
		}

		/// <summary>
		/// UC 01.1, 01.2, 01.5, 02.1, 02.1.1, 02.1.2, 
		/// Sucht nach Kunden mit bestimmten Namen und zeigt diesen zur Bearbeitung an.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSucheKunde_Click(object sender, System.EventArgs e)
		{
			// ManageBuchungenObjekt erzeugen und Kunden abfragen
			ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
			
			try
			{
				// Kundenarray abfragen
				aKunden = dtm.SucheKunde(this.txtSuchname.Text);
				
				// Kein Kunde gefunden
				if(aKunden == null)
				{	
					MessageBox.Show("Es wurde kein Kunde mit entsprechendem Namen gefunden!"+
						"\nLegen Sie den Kunden gegebenenfalls neu an.", "Kein Kunde gefunden!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}

				// DataBindings setzen
				this.RefreshKunde();
				this.RefreshBuchungen();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		/// <summary>
		/// UC 02.1, 02.1.2 Kundendaten aendern und aktualisieren
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUpdtKunde_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Kundendaten aendern lassen
				if(aKunden[cmKunden.Position].AktualisiereDaten()== false)
				{
					// Daten sind unvollstaendig
					MessageBox.Show("Bitte geben Sie Namen und Adresse des Kunden ein!", "Fehlende Daten!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					this.txtName.Focus();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// UC 02.1.1 Neuer Kunde wird im System erfasst
		/// </summary>
		/// <remarks>
		/// Die Handlermethode fuer Aenderungen speichern wird geaendert.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnNeuerKunde_Click(object sender, System.EventArgs e)
		{
			// Anzeige zuruecksetzen
			this.txtSuchname.Text = "";
			this.trvKundenEvents.Nodes.Clear();

			// Neues Kundenobjekt erzeugen
			ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
			ManageBuchungen.IKunde k = dtm.CreateKunde();
			
			// Kunde im Array ablegen
			aKunden = null;
			aKunden = new ManageBuchungen.IKunde[1];
			aKunden[0] = k;
			this.RefreshKunde();

			// Handlermethode auf Insert eines Kunden setzen
			this.btnUpdtKunde.Click -= new System.EventHandler(this.btnUpdtKunde_Click);
			this.btnUpdtKunde.Click += new System.EventHandler(this.NeuenKundenSpeichern);

			// Steuerelemente deaktivieren bis Kunde in Datenbank gespeichert ist
			this.btnSucheKunde.Enabled = false;
			this.btnNeuerKunde.Enabled = false;
			this.mnuKundenSuchen.Enabled = false;
			this.mnuNeuerKunde.Enabled = false;
			this.btnBucheEvent.Enabled = false;
			this.btnStorniereEvent.Enabled = false;
			this.mnuStorno.Enabled = false;
			this.mnuBuchen.Enabled = false;
			this.cboName.Enabled = false;
			this.txtSuchname.Enabled = false;

			this.txtName.Focus();
		}

		/// <summary>
		/// UC 02.1.1 Neuer Kunde wird im System erfasst und in die Datenbank geschrieben
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NeuenKundenSpeichern(object sender, System.EventArgs e)
		{
			// Aktuelle Position des Kunden im Array
			int pos = cmKunden.Position;
			try
			{
				// ManageBuchungenObjekt erzeugen und Kunden in Datenbank anlegen
				ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();

				if(dtm.NeuerKunde(aKunden[cmKunden.Position]))
				{
					// Neuen Kunden anzeigen
					this.txtSuchname.Text = (aKunden[cmKunden.Position]).Name;
					this.RefreshKunde();
					this.cmKunden.Position = pos;

					// Handlermethode auf Update eines Kunden zuruecksetzen
					this.btnUpdtKunde.Click -= new System.EventHandler(this.NeuenKundenSpeichern);
					this.btnUpdtKunde.Click += new System.EventHandler(this.btnUpdtKunde_Click);
				
					// Steuerelemente aktivieren da Kunde in Datenbank gespeichert ist
					this.btnSucheKunde.Enabled = true;
					this.btnNeuerKunde.Enabled = true;
					this.mnuKundenSuchen.Enabled = true;
					this.mnuNeuerKunde.Enabled = true;
					this.btnBucheEvent.Enabled = true;
					this.btnStorniereEvent.Enabled = true;
					this.mnuStorno.Enabled = true;
					this.mnuBuchen.Enabled = true;
					this.cboName.Enabled = true;
					this.txtSuchname.Enabled = true;
				}
				else
				{
					// Daten sind unvollstaendig
					MessageBox.Show("Bitte geben Sie Namen und Adresse des Kunden ein!", "Fehlende Daten!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					this.txtName.Focus();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		/// <summary>
		/// UC 01.1 Kunde bucht ein Event.
		/// </summary>
		/// <remarks>
		/// Mitarbeiter sucht ein Event zur Buchung aus
		/// Vorbedingung: 
		/// Event ist zur Buchung freigegeben
		/// Veranstalter wurde noch nicht ueber die Teilnehmerzahl benachrichtigt.
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmEvents_PositionChanged(object sender, System.EventArgs e)
		{
			// Die Eventdaten werden geladen
			ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
			this.selectedEvent = dtm.LadeEvent(this.cboEvents.Text);
			
			// Es wurde ein freigegebener Event gefunden
			if(selectedEvent != null)
			{
				// Databindings zuruecksetzen
				this.txtStarttermin.DataBindings.Clear();
				this.txtStartOrt.DataBindings.Clear();
				this.txtZielOrt.DataBindings.Clear();
				this.txtEnde.DataBindings.Clear();
				this.txtAktTeilnehmer.DataBindings.Clear();
				this.txtMaxTeilnehmer.DataBindings.Clear();
				this.txtPreis.DataBindings.Clear();	

				// Eventtextfelder setzen
				this.txtBeschreibung.Text = selectedEvent.Beschreibung;
				this.txtKategorie.Text = selectedEvent.Kategorie;
				this.txtVeranstalter.Text = selectedEvent.Veranstalter;
				this.txtEventBezeichnung.Text = selectedEvent.Bezeichnung;

				// neue Eventdaten setzen
				this.alEventDaten = selectedEvent.EventData;
					
				// Databindings setzen
				this.cboDatum.DataSource = alEventDaten;
				this.cboDatum.DisplayMember = "Beginn";
				this.txtEnde.DataBindings.Add("Text", alEventDaten, "Ende");
				this.txtStartOrt.DataBindings.Add("Text",alEventDaten, "Startort");
				this.txtZielOrt.DataBindings.Add("Text", alEventDaten,"Zielort");
				this.txtAktTeilnehmer.DataBindings.Add("Text", alEventDaten, "AktTeilnehmer");
				this.txtMaxTeilnehmer.DataBindings.Add("Text", alEventDaten, "MaxTeilnehmer");
				this.txtPreis.DataBindings.Add("Text",alEventDaten, "Preis");
				this.txtStarttermin.DataBindings.Add("Text", alEventDaten, "Beginn");

				// Formatierung des Preises
				this.txtPreis.DataBindings["Text"].Format += new ConvertEventHandler(FormatPreis);

				// CurrencyManager fuer die Eventdaten setzen
				this.cmEventDaten = this.BindingContext[this.alEventDaten] as CurrencyManager;
					
				// EventDaten neu auffuellen lassen
				this.cmEventDaten.Refresh();
			}
			else
			{
				// Event kann nicht mehr gebucht werden
				this.mnuRefreshEvents_Click(sender,e);
			}
		}
		/// <summary>
		/// UC 01.5 Ein Kunde storniert eine Buchung, 
		/// 01.4.1 Rechnung ueber Stornogebuehr wird erstellt.
		/// </summary>
		/// <remarks>
		/// Die folgenden Einschränkungen sind diesem Element zugeordnet:
		/// (Vorbedingung) :
		/// Der Kunde kann nur bis 14 Tage vor dem Eventbeginn ein Event stornieren.
		/// Der Eventveranstalter darf dabei noch keine Benachrichtigung ueber die Teilnehmer-
		/// zahl erhalten haben
		/// </remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnStorniereEvent_Click(object sender, System.EventArgs e)
		{	
			// Statusflag
			bool stornoErfolgreich = false;
			ManageDocuments.DokumentManagement dm = null;

			// gewaehlten Knoten ermitteln
			TreeNode evNode = this.trvKundenEvents.SelectedNode;

			// Knoten ausgewaehlt?
			if(evNode != null)
			{
				// ist es ein Unterknoten?
				if(evNode.GetNodeCount(true) == 0)
				{
					// Elternknoten ermitteln
					evNode = evNode.Parent;	
				}
				try
				{
					// Ist Event noch nicht storniert
					if(((ManageBuchungen.IBuchung) evNode.Tag).Storniert == false && MessageBox.Show(((ManageBuchungen.IBuchung) evNode.Tag).EventBezeichnung + "\nStartdatum: "+
						((ManageBuchungen.IBuchung) evNode.Tag).StartTermin, "Wollen Sie den Event wirklich stornieren?",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
					{
						// Storno abschicken
						stornoErfolgreich = this.aKunden[this.cmKunden.Position].StorniereBuchung((ManageBuchungen.IBuchung) evNode.Tag);

						// UC 01.4.1 Rechnung ueber Stornogebuehr erstellen
						if(stornoErfolgreich)
						{
							// Rechnung ueber Stornogebuehr erstellen
							((ManageBuchungen.IBuchung)evNode.Tag).Storniert = true;
							ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
							ManageBuchungen.IRechnung rechnung = dtm.CreateRechnung(this.aKunden[this.cmKunden.Position], (ManageBuchungen.IBuchung)evNode.Tag);
							
							
							// Wordgenerator oeffnen
							dm = new ManageDocuments.DokumentManagement();
							dm.OpenWordGenerator();
							// Rechnung erstellen
							dm.ErstelleRechnung(rechnung);
							
							// Rechnungserstellung bestaetigen
							rechnung.BestaetigeRechnung();

							// Refresh der Anzeige
							// Merker fuer Refresh der Anzeige
							int kpos = this.cmKunden.Position;
							int edpos = this.cmEventDaten.Position;
							this.btnSucheKunde_Click(sender, e);
							this.cmEvents_PositionChanged(sender, e);
							this.cmKunden.Position = kpos;
							this.cmEventDaten.Position = edpos;
						}
						else
						{
							MessageBox.Show("Storno kann nicht duechgeführt werden!","Warnung!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
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
			else
				MessageBox.Show("Bitte wählen Sie ein Kundenevent zum Stornieren aus!","Fehlende Auswahl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// UC 01.1 Kunde bucht ein Event, UC 01.3 Buchungsbestaetigung drucken
		/// </summary>
		/// <remarks>
		/// Die folgenden Einschränkungen sind diesem Element zugeordnet:
		/// (Vorbedingung) :
		/// Im aktuellen Event muessen noch Plaetze frei sein
		/// Der Veranstalter darf noch nicht benachrichtigt sein
		/// Im aktuellen Event muessen noch Plaetze frei sein
		/// Der Veranstalter darf noch nicht benachrichtigt sein
		///</remarks>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBucheEvent_Click(object sender, System.EventArgs e)
		{
			// Variable zur Automatisierung von MS-Word
			ManageDocuments.DokumentManagement dm = null;
			// Abfrage der Anzahl der Buchungsplaetze
			EventBuchungsForm f = new EventBuchungsForm();
			if(this.cmKunden != null && this.aKunden[this.cmKunden.Position] != null && this.selectedEvent != null)
			{	
				// Dialogfeldanzeige aufbauen
				f.BuchungsDaten = "Kunde: " + this.aKunden[this.cmKunden.Position].Name + " " +this.aKunden[this.cmKunden.Position].Vorname
					+ "\nEvent: " + this.selectedEvent.Bezeichnung
					+ "\nStarttermin: " + ((ManageBuchungen.IEventDaten) this.alEventDaten[this.cmEventDaten.Position]).Beginn;
				
				// Hat Mitarbeiter die Buchung bestaetigt?
				f.Owner = this;
				DialogResult dr = f.ShowDialog();
				if(dr == DialogResult.OK)
				{
					try
					{
						// hat alles geklappt?
						if(this.aKunden[this.cmKunden.Position].BucheEvent(this.selectedEvent, (ManageBuchungen.IEventDaten)this.alEventDaten[this.cmEventDaten.Position], this.m_buchungsPlaetze))
						{
							/// Refresh der Anzeige
							// Merker fuer Refresh der Anzeige
							int kpos = this.cmKunden.Position;
							int edpos = this.cmEventDaten.Position;
							this.btnSucheKunde_Click(sender, e);
							this.cmEvents_PositionChanged(sender, e);
							this.cmKunden.Position = kpos;
							this.cmEventDaten.Position = edpos;

							//UC 01.3 Buchungsbestaetigung erstellen
							ManageBuchungen.IBuchung b = (this.trvKundenEvents.Nodes[this.trvKundenEvents.Nodes.Count - 1].Tag) as ManageBuchungen.IBuchung;
							dm = new ManageDocuments.DokumentManagement();
							dm.OpenWordGenerator();
							dm.ErstelleBestaetigung(b, this.aKunden[this.cmKunden.Position]);
						}
						else
						{
							// UC 01.1.1 Buchung wird abgelehnt
							MessageBox.Show("Der Event konnte nicht gebucht werden!\nEventuell wurde die Teilnehmerzahl\n"+
								"oder das letztmögliche Buchungsdatum  überschritten.", "Keine Buchung!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					
						}
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					finally
					{
						if(dm != null)
						{
							dm.CloseWordGenerator();
							dm = null;
						}
					}
				}
			}
			else
				MessageBox.Show("Bitte wählen Sie zuerst einen Kunden und ein Event aus!", "Fehlende Auswahl!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// Aendert die Anzeige der Eventdetails des Forms
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuEventdetails_Click(object sender, System.EventArgs e)
		{
			this.mnuEventdetails.Checked = !this.mnuEventdetails.Checked;
			
			this.SuspendLayout();

			this.grpEventDaten.Visible = !this.grpEventDaten.Visible;

			if(this.grpEventDaten.Visible == true)
				this.Width = 1066;
			else
				this.Width = 785;
			
			this.ResumeLayout();
		}

		/// <summary>
		/// Schliessen der Buchungsverwaltung
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KundenBuchungsForm_Closed(object sender, System.EventArgs e)
		{
			// Menue zum Erstellen einer neuen Kundenbuchung freigeben
			((MainForm) this.MdiParent).SetMnuAnzeige(this.Text, true);
		}

		/// <summary>
		/// Refresh der Eventanzeige wird erzwungen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuRefreshEvents_Click(object sender, System.EventArgs e)
		{
			this.RefreshEventBezeichnungen();

			// CurrencyManager fuer Eventliste erstellen
			this.cmEvents = this.BindingContext[this.aEvBezeichnungen] as CurrencyManager;

			// PositionChanged Event abfangen
			this.cmEvents.PositionChanged += new System.EventHandler(this.cmEvents_PositionChanged);
			cmEvents_PositionChanged(sender, e);
		}

		/// <summary>
		/// UC 01.2 Reservierung von Plaetzen,
		/// Liefert die Daten einer Buchung an den EventBuchungsForm
		/// </summary>
		public int BuchungsPlaetze
		{
			set
			{
				m_buchungsPlaetze = value;
			}
		}

		/// <summary>
		/// Formatieren der Ausgabe des Eventpreises
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormatPreis(object sender, ConvertEventArgs e)
		{
			e.Value = Convert.ToDecimal(e.Value).ToString("c");
		}

		/// <summary>
		/// Laden der Events beim Start der Applikation
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void KundenBuchungsForm_Load(object sender, System.EventArgs e)
		{
			// Erstellen der Eventliste
			this.mnuRefreshEvents_Click(sender, e);
		}
	}
}

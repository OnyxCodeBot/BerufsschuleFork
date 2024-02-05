// zu den UCs 01, 02 und 03, Kunden-, Buchungsverwaltung sowie Kundenanalyse
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

// Hinzufuegen
using System.Data;
using System.Data.SqlClient;


namespace ManageBuchungen
{
	///<summary>
	/// Klasse zu den UCs 01, 02 und 03, Kunden-, Buchungsverwaltung sowie Kundenanalyse
	///</summary>
	///<remarks>
	///Hauptmodul der Mittelschicht zur Kundenverwaltung
	///Logische Datenzugriffsschicht zur Datenbank
	///</remarks>
	public class DataTransferModule : System.ComponentModel.Component
	{
		/// <summary>
		/// Connection zur Datenbank
		/// </summary>
		private System.Data.SqlClient.SqlConnection cnBuchungen;

		/// <summary>
		/// Sucht einen Kunden anhand des Namens
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdSucheKunde;

		/// <summary>
		/// Faehrt einen Update der Kundendaten in der Datenbank
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdUpdtKunde;

		/// <summary>
		/// Erstellt einen neuen Kunden in der Datenbank
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdInsKunde;

		/// <summary>
		/// Laedt die Eventdaten anhand der Eventbezeichnung
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdLoadEventDaten;

		/// <summary>
		/// Bucht einen Event in der Datenbank
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdBucheEvent;

		/// <summary>
		/// Aktualisiert die Teilnehmerzahl eines Events in der Datenbank nach einer Stornierung
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdUpdtTeilnehmer;

		/// <summary>
		/// Erhoeht die Teilnehmerzahl eines Events in der Datenbank
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdAddTeilnehmer;

		/// <summary>
		/// Laedt die Bezeichnungen der Kategorien
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdLoadKatBezeichnung;

		/// <summary>
		/// Laedt alle Kunden einer Kategorie zur Analyse
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdLoadAnalyseKunden;

		/// <summary>
		/// Zahlungseingang einer Buchung wird bestaetigt
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdBestaetigeZahlungseingang;

		/// <summary>
		/// Alle offenen Rechnungen, die bereits erstellt sind werden gesucht
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdSucheOffeneRechnungen;

		/// <summary>
		/// Alle aktuellen noch nicht erstellten Rechnungen werden gesucht
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdSucheAktuelleRechnungen;

		/// <summary>
		/// Die Rechnung wird als erstellt in der Datenbank eingetragen
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdUpdtRechnung;

		/// <summary>
		/// Alle aktuellen Veranstalterbenachrichtigungen werden gesucht 
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdSucheVeranstalterBenachrichtigungen;

		/// <summary>
		/// Die aktuelle Teilnehmerzahl eines Events wird ermittelt
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdSelectAktTeilnehmer;

		/// <summary>
		/// Fraegt ab, ob der Veranstalter bereits ueber die Teilnehmerzahlen benachrichtigt wurde
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdSelectBenachrichtigt;

		/// <summary>
		/// Setzt einen Event als an den Veranstalter gemeldet
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdUpdtBenachrichtigung;

		/// <summary>
		/// Laedt alle freigegebenen Bezeichnungen von Events
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdLoadEvBezeichnung;
		private System.Data.SqlClient.SqlCommand cmdStorniereBuchung;

		/// <summary>
		/// Laedt alle Buchungen eines Kunden
		/// </summary>
		private System.Data.SqlClient.SqlCommand cmdSelectKundenBuchungen;

		/// <summary>
		/// Konstruktor mit Initialisierungen
		/// </summary>
		public DataTransferModule()
		{
			/// <summary>
			/// Erforderlich für die Unterstützung von Windows.Forms Class Composition Designer
			/// </summary>
			InitializeComponent();
		}

		#region Component Designer generated code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.cnBuchungen = new System.Data.SqlClient.SqlConnection();
            this.cmdSucheKunde = new System.Data.SqlClient.SqlCommand();
            this.cmdUpdtKunde = new System.Data.SqlClient.SqlCommand();
            this.cmdInsKunde = new System.Data.SqlClient.SqlCommand();
            this.cmdLoadEvBezeichnung = new System.Data.SqlClient.SqlCommand();
            this.cmdSelectKundenBuchungen = new System.Data.SqlClient.SqlCommand();
            this.cmdLoadEventDaten = new System.Data.SqlClient.SqlCommand();
            this.cmdStorniereBuchung = new System.Data.SqlClient.SqlCommand();
            this.cmdBucheEvent = new System.Data.SqlClient.SqlCommand();
            this.cmdUpdtTeilnehmer = new System.Data.SqlClient.SqlCommand();
            this.cmdAddTeilnehmer = new System.Data.SqlClient.SqlCommand();
            this.cmdLoadKatBezeichnung = new System.Data.SqlClient.SqlCommand();
            this.cmdLoadAnalyseKunden = new System.Data.SqlClient.SqlCommand();
            this.cmdSucheOffeneRechnungen = new System.Data.SqlClient.SqlCommand();
            this.cmdBestaetigeZahlungseingang = new System.Data.SqlClient.SqlCommand();
            this.cmdSucheAktuelleRechnungen = new System.Data.SqlClient.SqlCommand();
            this.cmdUpdtRechnung = new System.Data.SqlClient.SqlCommand();
            this.cmdSucheVeranstalterBenachrichtigungen = new System.Data.SqlClient.SqlCommand();
            this.cmdSelectAktTeilnehmer = new System.Data.SqlClient.SqlCommand();
            this.cmdSelectBenachrichtigt = new System.Data.SqlClient.SqlCommand();
            this.cmdUpdtBenachrichtigung = new System.Data.SqlClient.SqlCommand();
            // 
            // cnBuchungen
            // 
            this.cnBuchungen.ConnectionString = ((string)(configurationAppSettings.GetValue("cnBuchungen.ConnectionString", typeof(string))));
            this.cnBuchungen.FireInfoMessageEventOnUserErrors = false;
            // 
            // cmdSucheKunde
            // 
            this.cmdSucheKunde.CommandText = "[spSucheKunde]";
            this.cmdSucheKunde.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdSucheKunde.Connection = this.cnBuchungen;
            this.cmdSucheKunde.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@kd_Name", System.Data.SqlDbType.NVarChar, 50)});
            // 
            // cmdUpdtKunde
            // 
            this.cmdUpdtKunde.CommandText = "[spUpdtKunde]";
            this.cmdUpdtKunde.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdUpdtKunde.Connection = this.cnBuchungen;
            this.cmdUpdtKunde.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@kd_Name", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@kd_Vorname", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@kd_Strasse", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@kd_HNummer", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@kd_PLZ", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@kd_Ort", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@kd_Telefon", System.Data.SqlDbType.NVarChar, 25),
            new System.Data.SqlClient.SqlParameter("@kd_EMail", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@kd_KundenID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdInsKunde
            // 
            this.cmdInsKunde.CommandText = "[spInsKunde]";
            this.cmdInsKunde.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdInsKunde.Connection = this.cnBuchungen;
            this.cmdInsKunde.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@kd_Name", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@kd_Vorname", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@kd_Strasse", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@kd_HNummer", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@kd_PLZ", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@kd_Ort", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@kd_Telefon", System.Data.SqlDbType.NVarChar, 25),
            new System.Data.SqlClient.SqlParameter("@kd_EMail", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@kd_KundenID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Output, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdLoadEvBezeichnung
            // 
            this.cmdLoadEvBezeichnung.CommandText = "[spLoadEvBezeichnung]";
            this.cmdLoadEvBezeichnung.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdLoadEvBezeichnung.Connection = this.cnBuchungen;
            this.cmdLoadEvBezeichnung.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdSelectKundenBuchungen
            // 
            this.cmdSelectKundenBuchungen.CommandText = "[spSelectKundenBuchungen]";
            this.cmdSelectKundenBuchungen.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdSelectKundenBuchungen.Connection = this.cnBuchungen;
            this.cmdSelectKundenBuchungen.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@kd_KundenID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdLoadEventDaten
            // 
            this.cmdLoadEventDaten.CommandText = "[spLoadEventDaten]";
            this.cmdLoadEventDaten.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdLoadEventDaten.Connection = this.cnBuchungen;
            this.cmdLoadEventDaten.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@et_Bezeichnung", System.Data.SqlDbType.NVarChar, 50)});
            // 
            // cmdStorniereBuchung
            // 
            this.cmdStorniereBuchung.CommandText = "[spStorniereBuchung]";
            this.cmdStorniereBuchung.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdStorniereBuchung.Connection = this.cnBuchungen;
            this.cmdStorniereBuchung.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@bu_BuchungsID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdBucheEvent
            // 
            this.cmdBucheEvent.CommandText = "[spBucheEvent]";
            this.cmdBucheEvent.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdBucheEvent.Connection = this.cnBuchungen;
            this.cmdBucheEvent.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@kd_KundenID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ed_EvDatenID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@bu_GebuchtePlaetze", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdUpdtTeilnehmer
            // 
            this.cmdUpdtTeilnehmer.CommandText = "[spUpdtTeilnehmer]";
            this.cmdUpdtTeilnehmer.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdUpdtTeilnehmer.Connection = this.cnBuchungen;
            this.cmdUpdtTeilnehmer.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ed_AktTeilnehmer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@bu_BuchungsID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdAddTeilnehmer
            // 
            this.cmdAddTeilnehmer.CommandText = "[spAddTeilnehmer]";
            this.cmdAddTeilnehmer.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdAddTeilnehmer.Connection = this.cnBuchungen;
            this.cmdAddTeilnehmer.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ed_EvDatenID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ed_AktTeilnehmer", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdLoadKatBezeichnung
            // 
            this.cmdLoadKatBezeichnung.CommandText = "[spLoadKatBezeichnung]";
            this.cmdLoadKatBezeichnung.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdLoadKatBezeichnung.Connection = this.cnBuchungen;
            this.cmdLoadKatBezeichnung.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdLoadAnalyseKunden
            // 
            this.cmdLoadAnalyseKunden.CommandText = "[spLoadAnalyseKunden]";
            this.cmdLoadAnalyseKunden.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdLoadAnalyseKunden.Connection = this.cnBuchungen;
            this.cmdLoadAnalyseKunden.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ek_KatBezeichnung", System.Data.SqlDbType.NVarChar, 15)});
            // 
            // cmdSucheOffeneRechnungen
            // 
            this.cmdSucheOffeneRechnungen.CommandText = "[spSucheOffeneRechnungen]";
            this.cmdSucheOffeneRechnungen.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdSucheOffeneRechnungen.Connection = this.cnBuchungen;
            this.cmdSucheOffeneRechnungen.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdBestaetigeZahlungseingang
            // 
            this.cmdBestaetigeZahlungseingang.CommandText = "[spBestaetigeZahlungseingang]";
            this.cmdBestaetigeZahlungseingang.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdBestaetigeZahlungseingang.Connection = this.cnBuchungen;
            this.cmdBestaetigeZahlungseingang.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@bu_BuchungsID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdSucheAktuelleRechnungen
            // 
            this.cmdSucheAktuelleRechnungen.CommandText = "[spSucheAktuelleRechnungen]";
            this.cmdSucheAktuelleRechnungen.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdSucheAktuelleRechnungen.Connection = this.cnBuchungen;
            this.cmdSucheAktuelleRechnungen.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdUpdtRechnung
            // 
            this.cmdUpdtRechnung.CommandText = "[spUpdtRechnung]";
            this.cmdUpdtRechnung.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdUpdtRechnung.Connection = this.cnBuchungen;
            this.cmdUpdtRechnung.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@bu_BuchungsID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdSucheVeranstalterBenachrichtigungen
            // 
            this.cmdSucheVeranstalterBenachrichtigungen.CommandText = "[spSucheVeranstalterBenachrichtigungen]";
            this.cmdSucheVeranstalterBenachrichtigungen.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdSucheVeranstalterBenachrichtigungen.Connection = this.cnBuchungen;
            this.cmdSucheVeranstalterBenachrichtigungen.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdSelectAktTeilnehmer
            // 
            this.cmdSelectAktTeilnehmer.CommandText = "[spSelectAktTeilnehmer]";
            this.cmdSelectAktTeilnehmer.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdSelectAktTeilnehmer.Connection = this.cnBuchungen;
            this.cmdSelectAktTeilnehmer.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ed_EvDatenID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdSelectBenachrichtigt
            // 
            this.cmdSelectBenachrichtigt.CommandText = "[spSelectBenachrichtigt]";
            this.cmdSelectBenachrichtigt.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdSelectBenachrichtigt.Connection = this.cnBuchungen;
            this.cmdSelectBenachrichtigt.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ed_EvDatenID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cmdUpdtBenachrichtigung
            // 
            this.cmdUpdtBenachrichtigung.CommandText = "[spUpdtBenachrichtigung]";
            this.cmdUpdtBenachrichtigung.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmdUpdtBenachrichtigung.Connection = this.cnBuchungen;
            this.cmdUpdtBenachrichtigung.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ed_EvdatenID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});

		}
		#endregion

		
		/// <summary>
		/// UC 01.2 Reservierung fuer Event ausfuehren.
		/// </summary>
		/// <remarks>
		/// Die folgenden Einschränkungen sind diesem Element zugeordnet:
		/// (Vorbedingung) : KundenID gueltig
		/// (Vorbedingung) : EventDatenID gueltig
		/// (Vorbedingung) : Das Event ist zur Buchung freigegeben
		///</remarks>
		/// <param name="buchung">die neue Kundenbuchung</param>
		/// <param name="kdID">die KundenID</param>
		/// <param name="evdaID">die EvDatenID</param>
		internal void BucheEvent(IBuchung buchung, int kdID, int evdaID)
		{
			// Transaktion erzeugen
			this.cnBuchungen.Open();
			SqlTransaction trans = cnBuchungen.BeginTransaction(IsolationLevel.Serializable);
			this.cmdBucheEvent.Transaction = trans;
			this.cmdAddTeilnehmer.Transaction = trans;
			
			try
			{
				// Neue Buchung in Datenbank eintragen
				// Parameter setzen
				this.cmdBucheEvent.Parameters["@kd_KundenID"].Value = kdID;
				this.cmdBucheEvent.Parameters["@ed_EvDatenID"].Value = evdaID;
				this.cmdBucheEvent.Parameters["@bu_GebuchtePlaetze"].Value = buchung.GebuchtePlaetze;
				this.cmdBucheEvent.ExecuteNonQuery();

				// aktuelle Teilnehmerzahl anpassen
				this.cmdAddTeilnehmer.Parameters["@ed_EvDatenID"].Value = evdaID;
				this.cmdAddTeilnehmer.Parameters["@ed_AktTeilnehmer"].Value = buchung.GebuchtePlaetze;
				this.cmdAddTeilnehmer.ExecuteNonQuery();

				// Transaktion bestaetigen
				trans.Commit();
			}
			catch(Exception ex)
			{
				// Rollback der Transaktion, da Fehler aufgetreten
				trans.Rollback();
				throw ex;
			}
			finally
			{
				this.cnBuchungen.Close();
			}
			// Die neu vergebene ID der Buchung aus der Datenbank wird gesetzt
			buchung.BuchungsID = (int) this.cmdBucheEvent.Parameters["@RETURN_VALUE"].Value;
		}

		/// <summary>
		/// UC 01.1, 02.1, 01.5, 02.1.2  Sucht nach Kunden mit bestimmten Namen
		/// </summary>
		/// <param name="name">Name des gesuchten Kunden</param>
		/// <returns>Kundenarray mit allen gefundenen Kunden</returns>
		public IKunde[] SucheKunde(string name)
		{
			// Array fuer Kundenobjekte
			Kunde [] aKunden = null;

			try
			{
				// Eingabeparameter setzen
				this.cmdSucheKunde.Parameters["@kd_Name"].Value = name;

				// Anzahl der zurueckgegebenen Records
				int records;
			
				// Datenbank oeffnen
				this.cnBuchungen.Open();

				// Suche in Datenbank ausfuehren
				SqlDataReader dr = this.cmdSucheKunde.ExecuteReader();
			
				// Records vorhanden?
				if(dr.Read())
					records = dr.GetInt32(0);
				else
					records = 0;

				// Es wurden Kunden mit dem Namen gefunden
				if(records > 0)
				{
					// Kundenarray erstellen
					aKunden = new Kunde[records];

					//Zahler fuer while-Schleife
					int i = 0;
					// Zaehler fuer Spalten des zurueckgelieferten Datensatzes
					int j = 0;

					// Auf naechste Abfrage schalten
					dr.NextResult();

					// solange Records in DB sind
					while(dr.Read())
					{
						// neuen Kunden erzeugen und im Array hinzufuegen
						Kunde k = new Kunde();
						aKunden[i] = k;

						// Kundenattribute setzen
						aKunden[i].KundenID = dr.GetInt32(j++);
						aKunden[i].Name = dr.GetString(j++);
						aKunden[i].Vorname= dr.GetString(j++);
						aKunden[i].Strasse= dr.GetString(j++);
						aKunden[i].HNummer= dr.GetString(j++);
						aKunden[i].PLZ= dr.GetString(j++);
						aKunden[i].Ort= dr.GetString(j++);
						// Telefonnummer vorhanden?
						if(dr.IsDBNull(j) == false)
							aKunden[i].Telefon= dr.GetString(j++);
						// Emailadresse vorhanden?
						if(dr.IsDBNull(j) == false)
							aKunden[i].EMail= dr.GetString(j++);

						// Zaehler setzen
						j = 0;
						i++;
					}
					// DataReader schliessen
					dr.Close();
					
					// Buchungen erstellen
					for(int k = 0; k<aKunden.Length; k++)
					{
						// KundenID setzen
						this.cmdSelectKundenBuchungen.Parameters["@kd_KundenID"].Value = aKunden[k].KundenID;
						
						// Datenbankabfrage starten
						dr = this.cmdSelectKundenBuchungen.ExecuteReader();
						
						// Alle Buchungen des Kunden auslesen
						while(dr.Read())
						{
							Buchung bu = new Buchung();
							bu.BuchungsID = dr.GetInt32(0);
							bu.GebuchtePlaetze = dr.GetInt32(1);
							bu.Bezahlt = dr.GetBoolean(2);
							bu.Storniert = dr.GetBoolean(3);
							bu.StartTermin = dr.GetDateTime(4);
							bu.StartOrt = dr.GetString(5);
							bu.Preis = dr.GetDecimal(6);
							bu.EventBezeichnung = dr.GetString(7);

							// Buchung beim Kunden einfuegen
							aKunden[k].Buchungen.Add(bu);
							bu = null;
						}
						// Datareader schliessen
						dr.Close();
					}
				}
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Datenbank schliessen
				this.cnBuchungen.Close();
			}
			// Kunden oder null zurückgeben
			return aKunden;
		}
		
		/// <summary>
		/// UC 02.1.2, Uebertraegt geaenderte Kundendaten in die Datenbank.
		/// </summary>
		/// <param name="kunde">der zu aendernde Kunde</param>
		internal void AktualisiereKunde(IKunde kunde)
		{
			// Parameter fuer Update eines Kunden setzen
			this.cmdUpdtKunde.Parameters["@kd_KundenID"].Value = kunde.KundenID;
			this.cmdUpdtKunde.Parameters["@kd_Name"].Value = kunde.Name;
			this.cmdUpdtKunde.Parameters["@kd_Vorname"].Value = kunde.Vorname;
			this.cmdUpdtKunde.Parameters["@kd_Strasse"].Value = kunde.Strasse;
			this.cmdUpdtKunde.Parameters["@kd_HNummer"].Value = kunde.HNummer;
			this.cmdUpdtKunde.Parameters["@kd_PLZ"].Value = kunde.PLZ;
			this.cmdUpdtKunde.Parameters["@kd_Ort"].Value = kunde.Ort;
			this.cmdUpdtKunde.Parameters["@kd_Telefon"].Value = kunde.Telefon;
			this.cmdUpdtKunde.Parameters["@kd_EMail"].Value = kunde.EMail;
			try
			{
				// Datenbank oeffnen
				this.cnBuchungen.Open();

				// Stored Procedure ausfuehren
				this.cmdUpdtKunde.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Datenbank schliessen
				cnBuchungen.Close();
			}
		}

		/// <summary>
		/// UC 02.1.1 Neuer Kunde wird erfasst und in die Datenbank geschrieben
		/// </summary>
		/// <param name="kunde">das neue Kundenobjekt</param>
		/// <returns>true wenn Insert des Kunden erfolgreich</returns>
		public bool NeuerKunde(IKunde kunde)
		{
			// Statusflag
			bool erfolgreich = false;
			
			// Sind die Kundendaten vollstaendig?
			if(kunde.Name != "" && kunde.Vorname != "" && kunde.Strasse !="" && kunde.HNummer!=""&&kunde.PLZ !=""&&kunde.Ort!="")
			{
				// Parameter fuer Insert eines Kunden setzen
				this.cmdInsKunde.Parameters["@kd_KundenID"].Value = kunde.KundenID;
				this.cmdInsKunde.Parameters["@kd_Name"].Value = kunde.Name;
				this.cmdInsKunde.Parameters["@kd_Vorname"].Value = kunde.Vorname;
				this.cmdInsKunde.Parameters["@kd_Strasse"].Value = kunde.Strasse;
				this.cmdInsKunde.Parameters["@kd_HNummer"].Value = kunde.HNummer;
				this.cmdInsKunde.Parameters["@kd_PLZ"].Value = kunde.PLZ;
				this.cmdInsKunde.Parameters["@kd_Ort"].Value = kunde.Ort;
				this.cmdInsKunde.Parameters["@kd_Telefon"].Value = kunde.Telefon;
				this.cmdInsKunde.Parameters["@kd_EMail"].Value = kunde.EMail;
			
				try
				{
					// Datenbank oeffnen
					this.cnBuchungen.Open();

					// Stored Procedure ausfuehren
					this.cmdInsKunde.ExecuteNonQuery();

					// Neu vergebene ID von Datenbank holen und setzen
					kunde.KundenID = (int) this.cmdInsKunde.Parameters["@kd_KundenID"].Value;
					erfolgreich = true;
				}
				catch(Exception ex)
				{
					throw ex;
				}
				finally
				{
					// Datenbank schliessen
					cnBuchungen.Close();
				}
			}
			// Status des Inserts zurueckgeben
			return erfolgreich;
		}

		/// <summary>
		/// UC 01.5, Buchungen werden storniert.
		/// </summary>
		/// <remarks>
		/// Die folgenden Einschränkungen sind diesem Element zugeordnet:
		/// Frist : Die Buchung darf nur bis 14 Tage vor dem Eventbeginn storniert werden.
		/// </remarks>
		/// <param name="bu_id">ID der zu stornierenden Buchung</param>
		/// <param name="teilnehmer">Teilnehmerzahl am stornierten Event</param>
		/// <returns>true falls erfolgreich storniert</returns>
		internal bool StorniereBuchung(int bu_id, int teilnehmer)
		{
			// Flag fuer den Status
			bool erfolgreich = false;

			// Transaktion erstellen
			this.cnBuchungen.Open();
			SqlTransaction trans = cnBuchungen.BeginTransaction(IsolationLevel.Serializable);
			this.cmdStorniereBuchung.Transaction = trans;
			this.cmdUpdtTeilnehmer.Transaction = trans;

			try
			{
				// Buchung stornieren
				this.cmdStorniereBuchung.Parameters["@bu_BuchungsID"].Value = bu_id;
				this.cmdStorniereBuchung.ExecuteNonQuery();

				// GebuchtePlaetze updaten
				this.cmdUpdtTeilnehmer.Parameters["@bu_BuchungsID"].Value = bu_id;
				this.cmdUpdtTeilnehmer.Parameters["@ed_AktTeilnehmer"].Value = teilnehmer;
				this.cmdUpdtTeilnehmer.ExecuteNonQuery();
				
				// Transaktion bestaetigen
				trans.Commit();
				erfolgreich = true;
				
			}
			catch(Exception ex)
			{
				// Rollback der Transaktion bei Fehler
				trans.Rollback();
				throw ex;
			}
			finally
			{
				// Datenbankverbindung schliessen
				this.cnBuchungen.Close();
			}
			// Status zurueckgeben
			return erfolgreich;
		}

		/// <summary>
		/// UC 01.1 Laedt die Beschreibungen aller Events zur Auswahl fuer eine Buchung
		/// </summary>
		/// <returns>Stringarray mit allen Events der Agentur</returns>
		public string [] LadeEventBezeichnungen()
		{
			// Array fuer die Bezeichnungen
			string [] aBezeichnungen = null;
			try
			{
				// Datenbank oeffnen
				this.cnBuchungen.Open();

				// Kommando ausfuehren
				SqlDataReader dr = this.cmdLoadEvBezeichnung.ExecuteReader();
				
				// Anzahl der Events ermiteln 
				dr.Read(); 
				int anzahl = dr.GetInt32(0);

				// Auf naechstes Rueckgabeset springen
				dr.NextResult();

				// Array initialisieren
				aBezeichnungen = new string[anzahl];

				// Daten in Array schreiben
				for(int i = 0; dr.Read(); i++)
					aBezeichnungen[i] = dr.GetString(0);

				// Datareader schliessen
				dr.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Datenbankverbindung schliessen
				this.cnBuchungen.Close();
			}
			// Array zurueckgeben
			return aBezeichnungen;
		}

		/// <summary>
		/// UC 01.1 Gibt die Daten eines Events zur Ansicht zurueck
		/// </summary>
		/// <param name="evBezeichnung">Bezeichnungen eines Events aus der Datenbank</param>
		/// <returns>Interface auf ein Event</returns>
		public IEvent LadeEvent(string evBezeichnung)
		{
			// Das gewaehlte Event
			Event gewaehlterEvent = null;

			try
			{
				// Eingabeparameter setzen
				this.cmdLoadEventDaten.Parameters["@et_Bezeichnung"].Value = evBezeichnung;
			
				// Datenbank oeffnen
				this.cnBuchungen.Open();

				// Suche in Datenbank ausfuehren
				SqlDataReader dr = this.cmdLoadEventDaten.ExecuteReader();

				int i = 0;
				// solange Records in Datenbank sind
				while(dr.Read())
				{
					if(i == 0)
					{
						// Eventproperties setzen
						gewaehlterEvent = new Event();
						gewaehlterEvent.EventID = dr.GetInt32(9);
						gewaehlterEvent.Bezeichnung = dr.GetString(10);
						gewaehlterEvent.Beschreibung = dr.GetString(11);
						gewaehlterEvent.Veranstalter = dr.GetString(12);
						gewaehlterEvent.Kategorie = dr.GetString(13);
					}
					i = 0;
					EventDaten evDaten = new EventDaten();

					// Eventdaten setzen
					evDaten.EventDatenID = dr.GetInt32(i++);
					evDaten.Preis = dr.GetDecimal(i++);
					evDaten.Beginn = dr.GetDateTime(i++);
					evDaten.Ende = dr.GetDateTime(i++);
					evDaten.StartOrt = dr.GetString(i++);
					if(dr.IsDBNull(i))
						evDaten.ZielOrt = "";
					else
						evDaten.ZielOrt = dr.GetString(i);
						i++;
					evDaten.MaxTeilnehmer = dr.GetInt32(i++);
					evDaten.AktTeilnehmer = dr.GetInt32(i++);
					evDaten.VeranstalterBenachrichtigt = dr.GetBoolean(i++);

					// Dem Event die Daten hinzufuegen
					gewaehlterEvent.EventData.Add(evDaten);
				}
				// DataReader schliessen
				dr.Close();
			}
			catch(Exception noEventsException)
			{
				throw noEventsException;
			}
			finally
			{
				// Datenbank schliessen
				this.cnBuchungen.Close();
			}
			// Kunden oder null zurückgeben
			return gewaehlterEvent;
		}

		/// <summary>
		/// UC 02.1.1 Liefert ein neues Kundenobjekt zurueck
		/// </summary>
		/// <returns>neues Kundenobjekt als Interface</returns>
		public IKunde CreateKunde()
		{
			// Kunde erzeugen
			Kunde k = new Kunde();
			return k;
		}

		/// <summary>
		/// UC 03.1 Kundenadressen zu Statistikzwecken auswaehlen
		/// </summary>
		/// <returns>Array der Eventkategoriebezeichnungen</returns>
		public string [] LadeEventKategorien()
		{
			int anzahl = 0;
			string [] aKatBezeichnung = null;
			try
			{
				// Datenbankverbindung oeffnen
				this.cnBuchungen.Open();

				// DataReader dr initialisieren
				SqlDataReader dr = this.cmdLoadKatBezeichnung.ExecuteReader();

				// Ermitteln der Anzahl der Kategorien
				while(dr.Read())
					anzahl = dr.GetInt32(0);

				aKatBezeichnung = new string[anzahl];
				int i = 0;

				// Weiterschalten auf das naechste Resultset
				dr.NextResult();

				// Lesen der Kategorien
				while(dr.Read())
				{
					aKatBezeichnung[i] = dr.GetString(0);
					i++;
				}
				// DataReader schliessen
				dr.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Datenbankverbindung schliessen
				this.cnBuchungen.Close();
			}
			return aKatBezeichnung;
		}

		/// <summary>
		/// UC 03.1 Kunden werden zur Analyse entsprechend der Kategorie zurueckgeliefert
		/// </summary>
		/// <param name="kat">Name der Kategorie</param>
		/// <returns>Array mit den gefundenen Kunden</returns>
		public IKunde [] SucheKatKunde(string kat)
		{
			// Array fuer Kundenobjekte
			Kunde [] aKunden = null;

			try
			{
				// Eingabeparameter setzen
				this.cmdLoadAnalyseKunden.Parameters["@ek_KatBezeichnung"].Value = kat;

				// Anzahl der zurueckgegebenen Records
				int records = 0;
			
				// Datenbank oeffnen
				this.cnBuchungen.Open();

				// Suche in Datenbank ausfuehren
				SqlDataReader dr = this.cmdLoadAnalyseKunden.ExecuteReader();
			
				// Records vorhanden?
				if(dr.Read())
					records = dr.GetInt32(0);

				// Es wurden Kunden mit der Kategorie gefunden
				if(records > 0)
				{
					// Kundenarray erstellen
					aKunden = new Kunde[records];

					//Zahler fuer while-Schleife
					int j = 0;
					int i = 0;

					// Auf naechste Abfrage schalten
					dr.NextResult();

					// solange Records in DB sind
					while(dr.Read())
					{
						// neuen Kunden erzeugen und im Array hinzufuegen
						Kunde k = new Kunde();
						aKunden[i] = k;

						// Kundenproperties setzen
						aKunden[i].KundenID = dr.GetInt32(j++);
						aKunden[i].Name = dr.GetString(j++);
						aKunden[i].Vorname= dr.GetString(j++);
						aKunden[i].Strasse= dr.GetString(j++);
						aKunden[i].HNummer= dr.GetString(j++);
						aKunden[i].PLZ= dr.GetString(j++);
						aKunden[i].Ort= dr.GetString(j++);
						
						j = 0;
						i++;
					}
					
				}
				// DataReader schliessen
				dr.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Datenbank schliessen
				this.cnBuchungen.Close();
			}
			// Kunden oder null zurückgeben
			return aKunden;
		}


		/// <summary>
		/// UC 01.4, UC 01.4.1 Eine Rechnung wird zusammengesetzt
		/// </summary>
		/// <param name="kunde">Kunde der Rechnung</param>
		/// <param name="buchung">Buchung der Rechnung</param>
		/// <returns>die Rechnung</returns>
		public IRechnung CreateRechnung(IKunde kunde, IBuchung buchung)
		{
			// Rechnung generieren
			Rechnung r = new Rechnung();
			r.RechnungsBuchung = buchung;
			r.RechnungsKunde = kunde;

			// Rechnung zurueckgeben
			return r;
		}

		/// <summary>
		/// UC 01.7 offene Rechnungen zur Pruefung des Zahlungseingangs suchen
		/// </summary>
		/// <returns>Array mit allen offenen Rechnungen</returns>
		public IRechnung[] SucheOffeneRechnungen()
		{
			Rechnung [] aRechnungen = null;
			int anzahl;
			try
			{
				// Datenbank oeffnen
				this.cnBuchungen.Open();

				// Daten Laden
				SqlDataReader dr = this.cmdSucheOffeneRechnungen.ExecuteReader();
				if(dr.Read())
				{
					// Anzahl ermitteln
					anzahl = dr.GetInt32(0);
					if(anzahl > 0)
					{
						int j = 0;

						//Rechnungsarray erstellen
						aRechnungen = new Rechnung[anzahl];

						// Auf naechstes Resultset schalten
						dr.NextResult();

						for(int i = 0; dr.Read(); i++)
						{
							// Rechnung erstellen
							aRechnungen[i] = new Rechnung();
							aRechnungen[i].RechnungsBuchung = new Buchung();
							aRechnungen[i].RechnungsKunde = new Kunde();

							// Kundendaten setzen
							aRechnungen[i].RechnungsKunde.KundenID = dr.GetInt32(j++);
							aRechnungen[i].RechnungsKunde.Name = dr.GetString(j++);
							aRechnungen[i].RechnungsKunde.Vorname = dr.GetString(j++);
							aRechnungen[i].RechnungsKunde.Strasse = dr.GetString(j++);
							aRechnungen[i].RechnungsKunde.HNummer = dr.GetString(j++);
							aRechnungen[i].RechnungsKunde.PLZ = dr.GetString(j++);
							aRechnungen[i].RechnungsKunde.Ort = dr.GetString(j++);

							// Buchungsdaten setzen
							aRechnungen[i].RechnungsBuchung.BuchungsID = dr.GetInt32(j++);
							aRechnungen[i].RechnungsBuchung.GebuchtePlaetze = dr.GetInt32(j++);
							aRechnungen[i].RechnungsBuchung.Bezahlt = dr.GetBoolean(j++);
							aRechnungen[i].RechnungsBuchung.Storniert = dr.GetBoolean(j++);
							aRechnungen[i].RechnungsBuchung.StartTermin = dr.GetDateTime(j++);
							aRechnungen[i].RechnungsBuchung.StartOrt = dr.GetString(j++);
							aRechnungen[i].RechnungsBuchung.Preis = dr.GetDecimal(j++);
							aRechnungen[i].RechnungsBuchung.EventBezeichnung = dr.GetString(j++);

							j = 0;
						}
					}
				}
				// DataReader schliessen
				dr.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Datenbankverbindung schliessen
				this.cnBuchungen.Close();
			}
			// Rechnungsarray zurueckgeben
			return aRechnungen;
		}

		/// <summary>
		/// UC 01.7 Zahlungseingang in der Datenbank bestaetigen
		/// </summary>
		/// <param name="bu_id">ID der bezahlten Buchung</param>
		internal void BestaetigeZahlung(int bu_id)
		{
			try
			{
				// Zahlungseingang in Datenbank speichern
				this.cmdBestaetigeZahlungseingang.Parameters["@bu_BuchungsID"].Value = bu_id;
				this.cnBuchungen.Open();
				this.cmdBestaetigeZahlungseingang.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Datenbankverbindung schliessen
				this.cnBuchungen.Close();
			}
		}

		/// <summary>
		/// UC 01.4 Aktuelle Rechnungen werden zur Erstellung gesucht
		/// </summary>
		/// <returns>Array mit den aktuellen Rechnungen</returns>
		public IRechnung[] SucheAktuelleRechnungen()
		{
			Rechnung [] aRechnungen = null;
			int anzahl;
			try
			{
				// Aktuelle Rechnungen werden aus der Datenbank ausgelesen
				this.cnBuchungen.Open();
				SqlDataReader dr = this.cmdSucheAktuelleRechnungen.ExecuteReader();

				// Sind Rechnungen vorhanden?
				if(dr.Read())
				{
					// Anzahl ermitteln
					anzahl = dr.GetInt32(0);
					if(anzahl > 0)
					{
						int j = 0;

						// Rechnung erstellen
						aRechnungen = new Rechnung[anzahl];
						dr.NextResult();

						// Die Rechnungen zusammenbauen
						for(int i = 0; dr.Read(); i++)
						{
							// Rechnungsdaten
							aRechnungen[i] = new Rechnung();
							aRechnungen[i].RechnungsBuchung = new Buchung();
							aRechnungen[i].RechnungsKunde = new Kunde();

							// Kundendaten setzen
							aRechnungen[i].RechnungsKunde.KundenID = dr.GetInt32(j++);
							aRechnungen[i].RechnungsKunde.Name = dr.GetString(j++);
							aRechnungen[i].RechnungsKunde.Vorname = dr.GetString(j++);
							aRechnungen[i].RechnungsKunde.Strasse = dr.GetString(j++);
							aRechnungen[i].RechnungsKunde.HNummer = dr.GetString(j++);
							aRechnungen[i].RechnungsKunde.PLZ = dr.GetString(j++);
							aRechnungen[i].RechnungsKunde.Ort = dr.GetString(j++);

							// Buchungsdaten setzen
							aRechnungen[i].RechnungsBuchung.BuchungsID = dr.GetInt32(j++);
							aRechnungen[i].RechnungsBuchung.GebuchtePlaetze = dr.GetInt32(j++);
							aRechnungen[i].RechnungsBuchung.Bezahlt = dr.GetBoolean(j++);
							aRechnungen[i].RechnungsBuchung.Storniert = dr.GetBoolean(j++);
							aRechnungen[i].RechnungsBuchung.StartTermin = dr.GetDateTime(j++);
							aRechnungen[i].RechnungsBuchung.StartOrt = dr.GetString(j++);
							aRechnungen[i].RechnungsBuchung.Preis = dr.GetDecimal(j++);
							aRechnungen[i].RechnungsBuchung.EventBezeichnung = dr.GetString(j++);

							j = 0;
						}
					}
				}
				// DataReader schliessen
				dr.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Datenbankverbindung schliessen
				this.cnBuchungen.Close();
			}
			return aRechnungen;
		}

		/// <summary>
		/// UC 01.4, UC 01.4.1 Die Rechnungserstellung wird in der Datenbank festgehalten
		/// </summary>
		/// <param name="bu_id">ID der Buchung, fuer die eine Rechnung erstellt wurde</param>
		internal void BestaetigeRechnung(int bu_id)
		{
			try
			{
				// Parameter setzen
				this.cmdUpdtRechnung.Parameters["@bu_BuchungsID"].Value = bu_id;
				// Connection oeffnen
				this.cnBuchungen.Open();
				// Datenbank updaten
				this.cmdUpdtRechnung.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Datenbankverbindung schliessen
				this.cnBuchungen.Close();
			}
		}

		/// <summary>
		/// UC 01.6 aktuell zu erstellende Benachrichtigungen der Eventveranstalter werden gesucht
		/// </summary>
		/// <returns>Array mit Benachrichtigungen</returns>
		public IVeranstalterBenachrichtigung[] SucheVeranstalterBenachrichtigungen()
		{
			// Array fuer Benachrichtigungen
			VeranstalterBenachrichtigung [] aVB = null;
			int anzahl = 0;

			try
			{
				// Datenbank oeffnen
				this.cnBuchungen.Open();
				SqlDataReader dr = this.cmdSucheVeranstalterBenachrichtigungen.ExecuteReader();

				// Sind Benachrichtigungen zu erstellen?
				if(dr.Read())
				{
					// Anzahl ermitteln
					anzahl = dr.GetInt32(0);

					// Sind benachrichtigungen zu erstellen?
					if(anzahl > 0)
					{
						int j = 0;
						// Benachrichtigung erstellen
						aVB = new VeranstalterBenachrichtigung[anzahl];

						dr.NextResult();

						// Die Benachrichtigungen zusammenbauen
						for(int i = 0; dr.Read(); i++)
						{
							VeranstalterBenachrichtigung vb = new VeranstalterBenachrichtigung();
							aVB[i] = vb;
							aVB[i].Firma = dr.GetString(j++);
							aVB[i].Strasse = dr.GetString(j++);
							aVB[i].HNummer = dr.GetString(j++);
							aVB[i].PLZ = dr.GetString(j++);
							aVB[i].Ort = dr.GetString(j++);
							aVB[i].EventBezeichnung = dr.GetString(j++);
							aVB[i].EvDatenID = dr.GetInt32(j++);
							aVB[i].Beginn = dr.GetDateTime(j++);
							aVB[i].Startort = dr.GetString(j++);
							aVB[i].Teilnehmer = dr.GetInt32(j++);

							j = 0;
						}
					}
				}
				// DataReader schliessen
				dr.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Verbindung zur Datenbank schliessen
				this.cnBuchungen.Close();
			}
			// Array mit Benachrichtigungen zurueckgeben
			return aVB;
		}

		/// <summary>
		/// UC 01.2, UC 01.5, Abfrage zum Buchen und Stornieren
		/// </summary>
		/// <remarks>
		/// Vorbedingung: Buchungen/ Stornierungen duerfen nur ausgefuehrt werden,
		/// wenn der Veranstalter noch nicht benachrichtigt ist
		/// </remarks>
		/// <param name="ed_id">Die ID des Events</param>
		/// <returns>true wenn Veranstalter bereits benachrichtigt ist</returns>
		internal bool IstVeranstalterBenachrichtigt(int ed_id)
		{
			bool benachrichtigt;
			try
			{
				// Parameter setzen
				this.cmdSelectBenachrichtigt.Parameters["@ed_EvDatenID"].Value = ed_id;
				// Datenbank oeffnen
				this.cnBuchungen.Open();
				// Benachrichtigung ermitteln
				this.cmdSelectBenachrichtigt.ExecuteNonQuery();
				// Datenbank schliessen
				this.cnBuchungen.Close();
				// Status der Benachrichtigung zurueckgeben
				if((int) this.cmdSelectBenachrichtigt.Parameters["@RETURN_VALUE"].Value == 0)
					benachrichtigt = false;
				else
					benachrichtigt = true;
				return benachrichtigt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// UC 01.2 Abfrage zu den Buchungen
		/// </summary>
		/// <remarks>
		/// Vorbedingung: Buchungen duerfen nur ausgefuehrt werden,
		/// wenn freie Plaetze vorhanden sind
		/// </remarks>
		/// <param name="ed_id">Die ID des Events</param>
		/// <returns>Anzahl der aktuell gebuchten Plaetze</returns>
		internal int ErmittleAktTeilnehmer(int ed_id)
		{
			int anzahl;
			try
			{
				// Parameter setzen
				this.cmdSelectAktTeilnehmer.Parameters["@ed_EvDatenID"].Value = ed_id;
				// Datenbank oeffnen
				this.cnBuchungen.Open();
				// Teilnehmer ermitteln
				this.cmdSelectAktTeilnehmer.ExecuteNonQuery();
				// Datenbank schliessen
				this.cnBuchungen.Close();
				// Anzahl ermitteln und zurueckgeben
				anzahl = (int) this.cmdSelectAktTeilnehmer.Parameters["@RETURN_VALUE"].Value;
				return anzahl;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// UC 01.6 Benachrichtigung an den Veranstalter senden
		/// </summary>
		/// <remarks>
		/// Die Erstellung der Veranstalterbenachrichtigung wird
		/// in der Datenbank eingetragen.
		/// </remarks>
		/// <param name="ed_ID">ID der Veranstaltung</param>
		internal void BestaetigeBenachrichtigung(int ed_id)
		{
			try
			{
				// Parameter setzen
				this.cmdUpdtBenachrichtigung.Parameters["@ed_EvDatenID"].Value = ed_id;
				// Connection oeffnen
				this.cnBuchungen.Open();
				// Datenbank updaten
				this.cmdUpdtBenachrichtigung.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				// Datenbankverbindung schliessen
				this.cnBuchungen.Close();
			}
		}
	}
}

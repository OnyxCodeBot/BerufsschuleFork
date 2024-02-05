// Mittelschicht zur Kundenverwaltung
using System;
using System.Data.SqlTypes;
namespace ManageBuchungen
{
	///<summary>
	///internal Klasse zu den UCs 01.4 und 01.4.1 Rechnung erstellen, 
	///Rechnung ueber Stornogebuehr erstellen sowie 01.7 Zahlungseingang pruefen.
	///</summary>
	/// <remarks>
	/// Die Daten zur Rechnungserstellung und Zahlungseingangspruefung
	/// inclusive Storno werden verwaltet.
	/// </remarks>
	internal class Rechnung : IRechnung
	{

		/// <summary>
		/// Der Kunde der Rechnung
		/// </summary>
		private ManageBuchungen.IKunde m_RechnungsKunde;

		/// <summary>
		/// Die zugehoerige Buchung
		/// </summary>
		private ManageBuchungen.IBuchung m_RechnungsBuchung;

		/// <summary>
		/// Konstruktor mit Initialisierungen
		/// </summary>
		public Rechnung()
		{
		}

		/// <summary>
		/// Die Rechnungsnummer der Rechnung
		/// </summary>
		/// <remarks>
		/// Die RechnungsNr setzt sich aus BuchungsID und dem Praefix RE zusammen
		/// </remarks>
		public string RechnungsNr
		{
			get
			{
				return "RE-" + this.m_RechnungsBuchung.BuchungsID.ToString();
			}
		}

		/// <summary>
		/// Zahltag der Rechnung
		/// </summary>
		/// <remarks>
		/// Zahlbar ist die Rechnung bis zum Starttermin des Events
		/// </remarks>
		public DateTime Zahlbar
		{
			get
			{
				return this.m_RechnungsBuchung.StartTermin;
			}
		}
		
		/// <summary>
		/// Der Gesamtpreis der Rechnung
		/// </summary>
		/// <remarks>
		/// Preis = gebuchte Plaetze * Einzelpreis
		/// </remarks>
		public decimal GesamtPreis
		{
			get
			{
				// Gesammtpreis berechnen
				decimal preis;
				preis = (this.m_RechnungsBuchung.Preis * this.m_RechnungsBuchung.GebuchtePlaetze);

				return preis;
			}
		}
		 
		/// <summary>
		/// UC 01.5 Eine Buchung wurde storniert
		/// </summary>
		public bool Storniert
		{
			get
			{
				return this.m_RechnungsBuchung.Storniert;
			}
		}
		
		/// <summary>
		/// Property zu m_RechnungsKunde
		/// </summary>
		public IKunde RechnungsKunde
		{
			get
			{
				return this.m_RechnungsKunde;
			}
			set
			{
				this.m_RechnungsKunde = value;
			}
		}
		 
		/// <summary>
		/// Property zu m_RechnungsBuchung
		/// </summary>
		public IBuchung RechnungsBuchung
		{
			get
			{
				return this.m_RechnungsBuchung;
			}
			set
			{
				this.m_RechnungsBuchung = value;
			}
		}

		/// <summary>
		/// UC 01.7 Zahlungseingang einer Rechnung wird geprueft und bestaetigt
		/// </summary>
		public void ZahlungEingegangen()
		{
			try
			{
				// Zahlungsbestaetigung in Datenbank eintragen
				DataTransferModule dtm = new DataTransferModule();
				dtm.BestaetigeZahlung(this.RechnungsBuchung.BuchungsID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// UC 01.4, UC 01.4.1 Die Rechnungserstellung wird in der Datenbank festgehalten
		/// </summary>
		public void BestaetigeRechnung()
		{
			try
			{
				ManageBuchungen.DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
							
				// Rechnungserstellung in Datenbank bestaetigen
				dtm.BestaetigeRechnung(this.RechnungsBuchung.BuchungsID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
	}
}

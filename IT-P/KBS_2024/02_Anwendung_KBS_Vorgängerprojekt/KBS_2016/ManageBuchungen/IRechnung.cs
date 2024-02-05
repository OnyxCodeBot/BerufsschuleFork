// Zu den UCs 01.4 und 01.4.1 Rechnung erstellen, Rechnung ueber Stornogebuehr erstellen 
// sowie 01.7 Zahlungseingang pruefen
using System;
using System.Data.SqlTypes;


namespace ManageBuchungen
{
	///<summary>
	///Interface zu den UCs 01.4 und 01.4.1 Rechnung erstellen, 
	///Rechnung ueber Stornogebuehr erstellen sowie 01.7 Zahlungseingang pruefen.
	///</summary>
	/// <remarks>
	/// Die Daten zur Rechnungserstellung und Zahlungseingangspruefung
	/// inclusive Storno werden verwaltet.
	/// </remarks>
	public interface IRechnung
	{
		/// <summary>
		/// Die Rechnungsnummer der Rechnung
		/// </summary>
		 string RechnungsNr
		{
			get;
		}

		/// <summary>
		/// Zahltag der Rechnung
		/// </summary>
		 DateTime Zahlbar
		{
			get;
		}

		/// <summary>
		/// Der Gesamtpreis der Rechnung
		/// </summary>
		 decimal GesamtPreis
		{
			get;
		}

		/// <summary>
		/// Der Rechnungskunde
		/// </summary>
		 IKunde RechnungsKunde
		{
			get;
			set;
		}

		/// <summary>
		/// Die Buchung zur Rechnung
		/// </summary>
		IBuchung RechnungsBuchung
		{
			 get;
			 set;
		}

		/// <summary>
		/// UC 01.5 Eine Buchung wurde storniert
		/// </summary>
		 bool Storniert
		{
			get;
		}

		/// <summary>
		/// UC 01.7 Zahlungseingang einer Rechnung wird geprueft und bestaetigt
		/// </summary>
		void ZahlungEingegangen();

		/// <summary>
		/// UC 01.4, UC 01.4.1 Die Rechnungserstellung wird in der Datenbank festgehalten
		/// </summary>
		void BestaetigeRechnung();
	}
}

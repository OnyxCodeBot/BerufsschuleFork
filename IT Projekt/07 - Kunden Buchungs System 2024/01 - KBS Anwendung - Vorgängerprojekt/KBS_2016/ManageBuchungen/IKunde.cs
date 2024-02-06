// Zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen, 02.1, 02.1.1, 02.1.2 Kunden verwalten 
using System.Collections;

namespace ManageBuchungen
{
	///<summary>
	/// Interface zu den UseCases 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen, 02.1, 02.1.1, 02.1.2 Kunden verwalten 
	///</summary>
	/// <remarks>
	/// Die Buchungsdaten sowie die Kundendaten werden verwaltet
	/// </remarks>
	public interface IKunde
	{
		/// <summary>
		/// ID des Kunden in der Datenbank
		/// </summary>
		 int KundenID
		{
			get;
			set;
		}

		/// <summary>
		/// Name des Kunden in der Datenbank
		/// </summary>
		 string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Vorname des Kunden in der Datenbank
		/// </summary>
		 string Vorname
		{
			get;
			set;
		}

		/// <summary>
		/// Adresse des Kunden in der Datenbank
		/// </summary>
		 string Strasse
		{
			get;
			set;
		}

		/// <summary>
		/// Adresse des Kunden in der Datenbank
		/// </summary>
		 string HNummer
		{
			get;
			set;
		}

		/// <summary>
		/// Adresse des Kunden in der Datenbank
		/// </summary>
		 string PLZ
		{
			get;
			set;
		}

		/// <summary>
		/// Adresse des Kunden in der Datenbank
		/// </summary>
		 string Ort
		{
			get;
			set;
		}

		/// <summary>
		/// Telefon des Kunden in der Datenbank
		/// </summary>
		 string Telefon
		{
			get;
			set;
		}

		/// <summary>
		/// EMailadresse des Kunden in der Datenbank
		/// </summary>
		 string EMail
		{
			get;
			set;
		}

		/// <summary>
		/// UC 01.1 Kunde bucht ein bestimmtes Event
		/// </summary>
		/// <param name="selEvent">das zu buchende Event</param>
		/// <param name="selEvDaten">die Eventdaten des konkreten Events</param>
		/// <param name="plaetze">Anzahl der zu buchenden Plaetze</param>
		/// <returns>true wenn Buchung erfolgreich</returns>
		 bool BucheEvent(IEvent selEvent, IEventDaten selEvDaten, int plaetze);

		/// <summary>
		/// UC 01.5 Kunde storniert ein Event
		/// </summary>
		/// <param name="selBuchung">die zu stornierende Buchung</param>
		/// <returns>true falls erfolgreiche Stornierung</returns>
		 bool StorniereBuchung(IBuchung selBuchung);

		/// <summary>
		/// UC 02.1.2, Uebertraegt geaenderte Kundendaten in die Datenbank.
		/// </summary>
		/// <returns>true, wenn Update in Datenbank erfolgreich verlaeuft</returns>
		 bool AktualisiereDaten();

		/// <summary>
		/// Gibt die aktuellen Buchungen des Kunden als ArrayList zurueck
		/// </summary>
		ArrayList Buchungen
		{
			get;
		}
	}
}
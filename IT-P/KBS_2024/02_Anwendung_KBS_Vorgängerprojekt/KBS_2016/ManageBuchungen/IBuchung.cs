// Zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen
using System;
using System.Data.SqlTypes;

namespace ManageBuchungen
{
	/// <summary>
	/// Interface zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen
	/// </summary>
	/// <remarks>
	/// Die Buchungsdaten eines Kunden werden verwaltet
	/// </remarks>
	public interface IBuchung
	{
		/// <summary>
		/// ID der Buchung in der Datenbank
		/// </summary>
		 int BuchungsID
		{
			get;
			set;
		}

		/// <summary>
		/// Anzahl der gebuchten Plaetze der Buchung
		/// </summary>
		 int GebuchtePlaetze
		{
			get;
			set;
		}

		/// <summary>
		/// Bezeichnung des gebuchten Events
		/// </summary>
		 string EventBezeichnung
		{
			get;
			set;
		}

		/// <summary>
		/// Starttermin des gebuchten Events
		/// </summary>
		 DateTime StartTermin
		{
			get;
			set;
		}

		/// <summary>
		/// Startort des gebuchten Events
		/// </summary>
		 string StartOrt
		{
			get;
			set;
		}

		/// <summary>
		/// Einzelpreis des gebuchten Events
		/// </summary>
		 decimal Preis
		{
			get;
			set;
		}

		/// <summary>
		/// Flag, ob die Rechnung bereits bezahlt wurde
		/// </summary>
		 bool Bezahlt
		{
			get;
			set;
		}

		/// <summary>
		/// Flag, ob die Buchung storniert wurde
		/// </summary>
		 bool Storniert
		{
			get;
			set;
		}
	}
}

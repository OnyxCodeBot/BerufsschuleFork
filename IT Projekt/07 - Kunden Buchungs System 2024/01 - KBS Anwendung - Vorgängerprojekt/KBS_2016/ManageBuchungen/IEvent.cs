// Zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen
using System.Collections;

namespace ManageBuchungen
{
	/// <summary>
	/// Interface zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen
	/// </summary>
	/// <remarks>
	/// Die Daten des Events werden zur Anzeige und zum Buchen verwaltet
	/// </remarks>
	public interface IEvent
	{
		/// <summary>
		/// ID des Events in der Datenbank
		/// </summary>
		 int EventID
		{
			get;
			set;
		}

		/// <summary>
		/// Bezeichnung des Events
		/// </summary>
		 string Bezeichnung
		{
			get;
			set;
		}

		/// <summary>
		/// Beschreibung des Events
		/// </summary>
		 string Beschreibung
		{
			get;
			set;
		}

		/// <summary>
		/// Firmenname des Veranstalters des Events
		/// </summary>
		 string Veranstalter
		{
			get;
			set;
		}

		/// <summary>
		/// Bezeichnung der Kategorie des Events
		/// </summary>
		 string Kategorie
		{
			get;
			set;
		}

		/// <summary>
		/// Die zugehoerigen Eventdaten des Events als ArrayList
		/// </summary>
		ArrayList EventData
		{
			get;
		}
	}
} 

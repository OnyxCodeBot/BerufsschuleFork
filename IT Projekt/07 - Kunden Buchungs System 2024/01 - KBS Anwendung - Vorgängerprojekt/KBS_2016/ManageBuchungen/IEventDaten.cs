// Zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen
using System;
using System.Data.SqlTypes;

namespace ManageBuchungen
{
	///<summary>
	/// Interface zu den UseCases 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen 
	///</summary>
	/// <remarks>
	/// Die Daten eines Events werden verwaltet
	/// </remarks>
	public interface IEventDaten
	{
		/// <summary>
		/// ID der Eventdaten in der Datenbank
		/// </summary>
		 int EventDatenID
		{
			get;
			set;
		}

		/// <summary>
		/// Der Preis des Events in der Datenbank
		/// </summary>
		 decimal Preis
		{
			get;
			set;
		}

		/// <summary>
		/// Das Startdatum des Events in der Datenbank
		/// </summary>
		 DateTime Beginn
		{
			get;
			set;
		}

		/// <summary>
		/// Das Ende des Events in der Datenbank
		/// </summary>
		 DateTime Ende
		{
			get;
			set;
		}

		/// <summary>
		/// Der Startort des Events in der Datenbank
		/// </summary>
		 string StartOrt
		{
			get;
			set;
		}

		/// <summary>
		/// Der Zielort des Events in der Datenbank
		/// </summary>
		 string ZielOrt
		{
			get;
			set;
		}

		/// <summary>
		/// Die maximale Anzahl der Teilnehmer des Events in der Datenbank
		/// </summary>
		 int MaxTeilnehmer
		{
			get;
			set;
		}

		/// <summary>
		/// Die aktuelle Anzahl der gebuchten Plaetze des Events in der Datenbank
		/// </summary>
		 int AktTeilnehmer
		{
			get;
			set;
		}

		/// <summary>
		/// Flag, ob der Veranstalter bereits ueber die Teilnehmerzahl benachrichtigt wurde
		/// </summary>
		bool VeranstalterBenachrichtigt
		{
			get;
			set;
		}
	}
}

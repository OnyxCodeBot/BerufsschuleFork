// Zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen
using System.Collections;


namespace ManageBuchungen
{
	/// <summary>
	/// Klasse zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen
	/// </summary>
	/// <remarks>
	/// Die Daten des Events werden zur Anzeige und zum Buchen verwaltet
	/// </remarks>
	internal class Event : IEvent
	{
		/// <summary>
		/// ID des Events in der Datenbank
		/// </summary>
		private int m_eventID = 0;

		/// <summary>
		/// Bezeichnung des Events
		/// </summary>
		private string m_bezeichnung = "";
		
		/// <summary>
		/// Beschreibung des Events
		/// </summary>
		private string m_beschreibung = "";

		/// <summary>
		/// Firmenname des Veranstalters des Events
		/// </summary>
		private string m_veranstalter = "";

		/// <summary>
		/// Bezeichnung der Kategorie des Events
		/// </summary>
		private string m_kategorie = "";

		/// <summary>
		/// Die zugehoerigen Eventdaten des Events als ArrayList
		/// </summary>
		private ArrayList m_aEventDaten;

		///<summary>
		///Konstruktor mit Initialisierungen
		///</summary> 
		public Event()
		{
			m_aEventDaten = new ArrayList(0);
		}

		/// <summary>
		/// Property zu m_eventID
		/// </summary>
		public int EventID
		{
			get
			{
				return this.m_eventID;
			}
			set
			{
				this.m_eventID = value;
			}
		}
		
		/// <summary>
		/// Property zu m_bezeichnung
		/// </summary>
		public string Bezeichnung
		{
			get
			{
				return this.m_bezeichnung;
			}
			set
			{
				this.m_bezeichnung = value;
			}
		}

		/// <summary>
		///  Property zu m_beschreibung
		/// </summary>
		public string Beschreibung
		{
			get
			{
				return this.m_beschreibung;
			}
			set
			{
				this.m_beschreibung = value;
			}
		}

		/// <summary>
		/// Property zu m_veranstalter
		/// </summary>
		public string Veranstalter
		{
			get
			{
				return this.m_veranstalter;
			}
			set
			{
				this.m_veranstalter = value;
			}
		}

		/// <summary>
		/// Property zu m_kategorie
		/// </summary>
		public string Kategorie
		{
			get
			{
				return this.m_kategorie;
			}
			set
			{
				this.m_kategorie = value;
			}
		}

		/// <summary>
		/// liefert die Eventdaten zum Event zurueck
		/// </summary>
		public ArrayList EventData
		{
			get
			{
				return this.m_aEventDaten;
			}
		}
	}
}

// Zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen
using System;
using System.Data.SqlTypes;

namespace ManageBuchungen
{
	///<summary>
	/// Klasse zu den UseCases 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen 
	///</summary>
	/// <remarks>
	/// Die Daten eines Events werden verwaltet
	/// </remarks>
	internal class EventDaten : IEventDaten
	{
		/// <summary>
		/// ID der Eventdaten in der Datenbank
		/// </summary>
		private int m_eventDatenID = 0;

		/// <summary>
		/// Der Preis des Events in der Datenbank
		/// </summary>
		private decimal m_preis = 0;

		/// <summary>
		/// Das Startdatum des Events in der Datenbank
		/// </summary>
		private System.DateTime m_beginn;

		/// <summary>
		/// Das Ende des Events in der Datenbank
		/// </summary>
		private System.DateTime m_ende;

		/// <summary>
		/// Der Startort des Events in der Datenbank
		/// </summary>
		private string m_startort = "";

		/// <summary>
		/// Der Zielort des Events in der Datenbank
		/// </summary>
		private string m_zielort = "";

		/// <summary>
		/// Die maximale Anzahl der Teilnehmer des Events in der Datenbank
		/// </summary>
		private int m_maxTeilnehmer = 0;

		/// <summary>
		/// Die aktuelle Anzahl der gebuchten Plaetze des Events in der Datenbank
		/// </summary>
		private int m_aktTeilnehmer = 0;

		/// <summary>
		/// Flag, ob der Veranstalter bereits ueber die Teilnehmerzahl benachrichtigt wurde
		/// </summary>
		private bool m_veranstalterBenachrichtigt;

		/// <summary>
		/// Konstruktor mit Initialisierungen
		/// </summary>
		public EventDaten()
		{
			
		}

		/// <summary>
		/// Property zu m_eventdatenID
		/// </summary>
		public int EventDatenID
		{
			get
			{
				return this.m_eventDatenID;
			}
			set
			{
				this.m_eventDatenID = value;
			}
		}

		/// <summary>
		/// Property zu m_preis
		/// </summary>
		public decimal Preis
		{
			get
			{
				return this.m_preis;
			}
			set
			{
				this.m_preis = value;
			}
		}

		/// <summary>
		/// Property zu m_beginn
		/// </summary>
		public DateTime Beginn
		{
			get
			{
				return this.m_beginn;
			}
			set
			{
				this.m_beginn = value;
			}
		}

		/// <summary>
		/// Property zu m_ende
		/// </summary>
		public DateTime Ende
		{
			get
			{
				return this.m_ende;
			}
			set
			{
				this.m_ende = value;
			}
		}

		/// <summary>
		/// Property zu m_startort
		/// </summary>
		public string StartOrt
		{
			get
			{
				return this.m_startort;
			}
			set
			{
				this.m_startort = value;
			}
		}

		/// <summary>
		/// Property zu m_zielort
		/// </summary>
		public string ZielOrt
		{
			get
			{
				return this.m_zielort;
			}
			set
			{
				this.m_zielort = value;
			}
		}

		/// <summary>
		/// Property zu m_maxTeilnehmer
		/// </summary>
		public int MaxTeilnehmer
		{
			get
			{
				return this.m_maxTeilnehmer; 
			}
			set
			{
				this.m_maxTeilnehmer = value;
			}
		}

		/// <summary>
		/// Property zu m_aktTeilnehmer
		/// </summary>
		public int AktTeilnehmer
		{
			get
			{
				return this.m_aktTeilnehmer; 
			}
			set
			{
				this.m_aktTeilnehmer = value;
			}
		}
		/// <summary>
		/// Property zu m_veranstalterBenachrichtigt
		/// </summary>
		public bool VeranstalterBenachrichtigt
		{
			get
			{
				return this.m_veranstalterBenachrichtigt;
			}
			set
			{
				this.m_veranstalterBenachrichtigt = value;
			}
		}
	}
}

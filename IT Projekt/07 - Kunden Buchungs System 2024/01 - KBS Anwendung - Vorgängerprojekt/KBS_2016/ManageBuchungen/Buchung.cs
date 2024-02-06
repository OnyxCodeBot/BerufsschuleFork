// Zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen
using System;

namespace ManageBuchungen
{
	/// <summary>
	/// Klasse zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen
	/// </summary>
	/// <remarks>
	/// Die Buchungsdaten eines Kunden werden verwaltet
	/// </remarks>
	internal class Buchung : IBuchung
	{
		/// <summary>
		/// ID der Buchung in der Datenbank
		/// </summary>
		/// 
		private int m_buchungsID = 0;
		/// <summary>
		/// Anzahl der gebuchten Plaetze der Buchung
		/// </summary>
		/// 
		private int m_gebuchtePlaetze = 0;

		/// <summary>
		/// Bezeichnung des gebuchten Events
		/// </summary>
		private string m_eventBezeichnung = "";

		/// <summary>
		/// Starttermin des gebuchten Events
		/// </summary>
		private DateTime m_startTermin;

		/// <summary>
		/// Startort des Events
		/// </summary>
		private string m_startOrt;

		/// <summary>
		/// Einzelpreis des gebuchten Events
		/// </summary>
		private decimal m_preis;

		/// <summary>
		/// Flag, ob die Rechnung bereits bezahlt wurde
		/// </summary>
		private bool m_bezahlt = false;

		/// <summary>
		/// Flag, ob die Buchung storniert wurde
		/// </summary>
		private bool m_storniert;

		/// <summary>
		/// Konstruktor mit Initialisierungen
		/// </summary>
		public Buchung()
		{
			
		}

		/// <summary>
		/// Property zu m_buchungsID
		/// </summary>
		public int BuchungsID
		{
			get
			{
				return this.m_buchungsID;
			}
			set
			{
				this.m_buchungsID = value;
			}
		}

		/// <summary>
		/// Property zu m_gebuchtePlaetze
		/// </summary>
		public int GebuchtePlaetze
		{
			get
			{
				return this.m_gebuchtePlaetze;
			}
			set
			{
				this.m_gebuchtePlaetze = value;
			}
		}

		/// <summary>
		/// Property zu m_eventBezeichnung
		/// </summary>
		public string EventBezeichnung
		{
			get
			{
				return this.m_eventBezeichnung;
			}
			set
			{
				this.m_eventBezeichnung = value;
			}
		}

		/// <summary>
		/// Property zu m_startTermin
		/// </summary>
		public DateTime StartTermin
		{
			get
			{
				return this.m_startTermin;
			}
			set
			{
				this.m_startTermin = value;
			}
		}
		
		/// <summary>
		/// Property zu m_StartOrt
		/// </summary>
		public string StartOrt
		{
			get
			{
				return this.m_startOrt;
			}
			set
			{
				this.m_startOrt = value;
			}
		}

		/// <summary>
		/// Property zu m_preis
		/// </summary>
		/// <remarks>
		/// bei Storno wird der Preis auf 10% des Preises herabgesetzt
		/// </remarks>
		public decimal Preis
		{
			get
			{
				// Wurde die Buchung storniert?
				if(this.Storniert==true)
					return this.m_preis/10.0M;
				else
					return this.m_preis;
			}
			set
			{
				this.m_preis = value;
			}
		}

		/// <summary>
		/// Property zu m_bezahlt
		/// </summary>
		public bool Bezahlt
		{
			get
			{
				return this.m_bezahlt;
			}
			set
			{
				this.m_bezahlt = value;
			}
		}

		/// <summary>
		/// Property zu m_storniert
		/// </summary>
		public bool Storniert
		{
			get
			{
				return m_storniert;
			}
			set
			{
				this.m_storniert = value;
			}
		}
	}
}

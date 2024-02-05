// Zum UC 01.6 Buchungen an den Veranstalter melden
using System;

namespace ManageBuchungen
{

	///<summary>
	///internal Klasse zum UseCase 01.6 Buchungen an den Veranstalter melden.
	///</summary>
	///<remarks>
	/// Die Daten zur Meldung an den Veranstalter werden verwaltet.
	///</remarks> 
	internal class VeranstalterBenachrichtigung : IVeranstalterBenachrichtigung 
	{

		/// <summary>
		/// Firmenname des Eventveranstalters
		/// </summary>
		private string m_firma = "";

		/// <summary>
		/// Adresse des Eventveranstalters
		/// </summary>
		private string m_strasse = "";

		/// <summary>
		/// Adresse des Eventveranstalters
		/// </summary>
		private string m_hNummer = "";

		/// <summary>
		///  Adresse des Eventveranstalters
		/// </summary>
		private string m_plz = "";

		/// <summary>
		/// Adresse des Eventveranstalters
		/// </summary>
		private string m_ort = "";

		/// <summary>
		/// Bezeichnung des Events
		/// </summary>
		private string m_eventBezeichnung = "";

		/// <summary>
		/// Startort des Events
		/// </summary>
		private string m_startort = "";

		/// <summary>
		/// Beginn des Events
		/// </summary>
		private System.DateTime m_beginn;

		/// <summary>
		/// Anzahl der Teilnehmer des Events
		/// </summary>
		private int m_teilnehmer = 0;

		/// <summary>
		/// ID der konkreten Veranstaltung
		/// </summary>
		private int m_evDatenID = 0;

		/// <summary>
		/// Property zu m_firma
		/// </summary>
		public string Firma
		{
			get
			{
				return this.m_firma;
			}
			set
			{
				this.m_firma = value;
			}
		}
		/// <summary>
		/// Property zu m_strasse
		/// </summary>
		public string Strasse
		{
			get
			{
				return this.m_strasse;
			}
			set
			{
				this.m_strasse = value;
			}
		}
		/// <summary>
		/// Property zu m_hNummer
		/// </summary>
		public string HNummer
		{
			get
			{
				return this.m_hNummer;
			}
			set
			{
				this.m_hNummer = value;
			}
		}
		/// <summary>
		/// Property zu m_plz
		/// </summary>
		public string PLZ
		{
			get
			{
				return this.m_plz;
			}
			set
			{
				this.m_plz = value;
			}
		}
		/// <summary>
		/// Property zu m_ort
		/// </summary>
		public string Ort
		{
			get
			{
				return this.m_ort;
			}
			set
			{
				this.m_ort = value;
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
		/// Property zu m_startort
		/// </summary>
		public string Startort
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
		/// Property zu m_teilnehmer
		/// </summary>
		public int Teilnehmer
		{
			get
			{
				return this.m_teilnehmer;
			}
			set
			{
				this.m_teilnehmer = value;
			}
		}

		/// <summary>
		/// Property zu m_evDatenID
		/// </summary>
		public int EvDatenID
		{
			get
			{
				return this.m_evDatenID;
			}
			set
			{
				this.m_evDatenID = value;
			}
		}

		/// <summary>
		/// UC 01.6 Benachrichtigung an den Veranstalter senden
		/// </summary>
		/// <remarks>
		/// Die Erstellung der Veranstalterbenachrichtigung wird
		/// in der Datenbank eingetragen.
		/// </remarks>
		public void BestaetigeBenachrichtigung()
		{
			DataTransferModule dtm = new DataTransferModule();

			try
			{
					// Update in Datenbank
					dtm.BestaetigeBenachrichtigung(this.EvDatenID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
	}
}

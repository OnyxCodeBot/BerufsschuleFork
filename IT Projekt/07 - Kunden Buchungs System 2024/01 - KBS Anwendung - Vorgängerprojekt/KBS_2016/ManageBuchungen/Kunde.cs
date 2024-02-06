// Zu den UCs 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen, 02.1, 02.1.1, 02.1.2 Kunden verwalten 
using System;
using System.Collections;

namespace ManageBuchungen
{
	///<summary>
	/// Klasse zu den UseCases 01.1, 01.1.1, 01.2, 01.5 Kundenbuchungen,
	/// 02.1, 02.1.1, 02.1.2 Kunden verwalten 
	///</summary>
	/// <remarks>
	/// Die Buchungsdaten sowie die Kundendaten werden verwaltet
	/// </remarks>
	internal class Kunde : IKunde
	{
		/// <summary>
		/// ID des Kunden in der Datenbank
		/// </summary>
		private int m_kundenID = 0;

		/// <summary>
		/// Name des Kunden in der Datenbank
		/// </summary>
		private string m_name = "";

		/// <summary>
		/// Vorname des Kunden in der Datenbank
		/// </summary>
		private string m_vorname = "";

		/// <summary>
		/// Adresse des Kunden in der Datenbank
		/// </summary>
		private string m_strasse = "";

		/// <summary>
		/// Adresse des Kunden in der Datenbank
		/// </summary>
		private string m_hNummer = "";

		/// <summary>
		/// Adresse des Kunden in der Datenbank
		/// </summary>
		private string m_plz = "";

		/// <summary>
		/// Adresse des Kunden in der Datenbank
		/// </summary>
		private string m_ort = "";

		/// <summary>
		/// Telefon des Kunden in der Datenbank
		/// </summary>
		private string m_telefon = "";

		/// <summary>
		/// EMailadresse des Kunden in der Datenbank
		/// </summary>
		private string m_email = "";

		/// <summary>
		/// Alle Buchungen des Kunden
		/// </summary>
		private System.Collections.ArrayList m_aBuchungen;

		/// <summary>
		/// Konstruktor der Klasse
		/// </summary>
		public Kunde()
		{
			// Buchungen werden in ArrayList gespeichert
			m_aBuchungen = new System.Collections.ArrayList(0);
		}

		/// <summary>
		/// Property zu m_kundenID
		/// </summary>
		public int KundenID
		{
			get
			{
				return this.m_kundenID;
			}
			set
			{
				this.m_kundenID = value;
			}
		}

		/// <summary>
		/// Property zu m_name
		/// </summary>
		public string Name
		{
			get
			{
				return this.m_name;
			}
			set
			{
				this.m_name = value;
			}
		}

		/// <summary>
		/// Property zu m_vorname
		/// </summary>
		public string Vorname
		{
			get
			{
				return this.m_vorname;
			}
			set
			{
				this.m_vorname = value;
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
		/// Property zu m_telefon, kann leer sein!
		/// </summary>
		public string Telefon
		{
			get
			{
				if(this.m_telefon != null)
					return this.m_telefon;
				else
					return "";
			}
			set
			{
				this.m_telefon = value;
			}
		}
		/// <summary>
		/// Property zu m_email, kann leer sein
		/// </summary>
		public string EMail
		{
			get
			{
				if(this.m_email != null)
					return this.m_email;
				else
					return "";
			}
			set
			{
				this.m_email = value;
			}
		}
		
		/// <summary>
		/// UC 01.1 Kunde bucht ein bestimmtes Event
		/// </summary>
		/// <remarks>
		/// Die folgenden Einschränkungen sind diesem Element zugeordnet:
		/// (Vorbedingung) :
		/// Im aktuellen Event muessen noch Plaetze frei sein
		/// Der Veranstalter darf noch nicht benachrichtigt sein
		/// Im aktuellen Event muessen noch Plaetze frei sein
		/// Der Veranstalter darf noch nicht benachrichtigt sein
		///</remarks>
		/// <param name="selEvent">das zu buchende Event</param>
		/// <param name="selEvDaten">die Eventdaten des konkreten Events</param>
		/// <param name="plaetze">Anzahl der zu buchenden Plaetze</param>
		/// <returns>true wenn Buchung erfolgreich</returns>
		public bool BucheEvent(IEvent selEvent, IEventDaten selEvDaten, int plaetze)
		{
			bool erfolgreich = false;
			bool benachrichtigt;
			int aktTeilnehmer;
			DataTransferModule dtm;

			try
			{
				// ist Kunde in Datenbank, sind noch Plaetze frei und werden mehr als 0 Plaetze gebucht?
				dtm = new DataTransferModule();
				// aktuellste Daten aus Datenbank ermitteln
				benachrichtigt = dtm.IstVeranstalterBenachrichtigt(selEvDaten.EventDatenID);
				aktTeilnehmer = dtm.ErmittleAktTeilnehmer(selEvDaten.EventDatenID);

				if(this.m_kundenID != 0 && (aktTeilnehmer + plaetze <= selEvDaten.MaxTeilnehmer) 
					&& plaetze > 0 && benachrichtigt == false)
				{
					// Buchung erzeugen
					Buchung bu = new Buchung();
					bu.GebuchtePlaetze = plaetze;
					bu.EventBezeichnung = selEvent.Bezeichnung;
					bu.Preis = selEvDaten.Preis;
					bu.StartOrt = selEvDaten.StartOrt;
					bu.StartTermin = selEvDaten.Beginn;
				
					// Buchung in DB eintragen
					dtm.BucheEvent(bu, this.KundenID, selEvDaten.EventDatenID);
					
					// Buchung beim Kunden aufnehmen
					this.m_aBuchungen.Add(bu);
					erfolgreich = true;
				}
			}
			catch(System.Exception ex)
			{
				throw ex;
			}
			// Status zurueckgeben
			return erfolgreich;
		}

		/// <summary>
		/// UC 01.5 Kunde storniert ein Event
		/// </summary>
		///<remarks>
		/// Die folgenden Einschränkungen sind diesem Element zugeordnet:
		/// (Vorbedingung) :
		/// Der Kunde kann nur bis 14 Tage vor dem Eventbeginn ein Event stornieren.
		/// Der Eventveranstalter darf dabei noch keine Benachrichtigung ueber die Teilnehmer-
		/// zahl erhalten haben
		/// </remarks> 
		/// <param name="selBuchung">die zu stornierende Buchung</param>
		/// <returns>true falls erfolgreiche Stornierung</returns>
		public bool StorniereBuchung(IBuchung selBuchung)
		{
			// Flag fuer Statusrueckgabe
			bool correctDate = false;

			try
			{
				DataTransferModule dtm = new DataTransferModule();
				
				// Datum fuer Stornierung ueberschritten?
				if(selBuchung.StartTermin.Subtract(System.DateTime.Today) > System.TimeSpan.FromDays(14))
				{
					// Buchung in Datenbank stornieren
					dtm.StorniereBuchung(selBuchung.BuchungsID, selBuchung.GebuchtePlaetze);
					correctDate = true;
				}
			}
			catch(System.Exception ex)
			{
				throw ex;
			}
			// Status zurueckgeben
			return correctDate;
		}
		
		/// <summary>
		/// Gibt die aktuellen Buchungen des Kunden als ArrayList zurueck
		/// </summary>
		public ArrayList Buchungen
		{
			get
			{
				return this.m_aBuchungen;
			}
		}

		/// <summary>
		/// UC 02.1.2, Uebertraegt geaenderte Kundendaten in die Datenbank.
		/// </summary>
		/// <remarks>
		/// Die Kundendaten werden auf Vollstaendigkeit geprueft
		/// </remarks>
		/// <returns>true, wenn Update in Datenbank erfolgreich verlaeuft</returns>
		public bool AktualisiereDaten()
		{
			// Alle Daten vorhanden?
			bool ok = true;

			try
			{
				// Daten nicht vollstaendig
				if(this.Name == "" || this.Vorname == "" || this.Strasse == "" || this.HNummer == "" || this.PLZ == "" || this.Ort == "")
					ok = false;
				else
				{
					// ManageBuchungenObjekt erzeugen und Kunden updaten
					DataTransferModule dtm = new ManageBuchungen.DataTransferModule();
					dtm.AktualisiereKunde(this);
				}
			}
			catch(System.Exception ex)
			{
				throw ex;
			}
			return ok;
		}
	}
}

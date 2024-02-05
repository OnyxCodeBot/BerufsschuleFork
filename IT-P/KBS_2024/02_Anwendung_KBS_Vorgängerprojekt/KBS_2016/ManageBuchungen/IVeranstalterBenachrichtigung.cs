// Zum UC 01.6 Buchungen an den Veranstalter melden
using System;

namespace ManageBuchungen
{
	///<summary>
	///Interface zum UseCase 01.6 Buchungen an den Veranstalter melden.
	///</summary>
	///<remarks>
	/// Interface zum UseCase 01.6 Buchungen an den Veranstalter melden.
	/// Die Daten zur Meldung an den Veranstalter werden verwaltet.
	///</remarks> 
	public interface IVeranstalterBenachrichtigung
	{
		///<summary>
		///Firmenname des Eventveranstalters
		///</summary>
		 string Firma
		{
			get;
			set;
		}

		///<summary>
		/// Adresse des Eventveranstalters
		///</summary>
		 string Strasse
		{
			get;
			set;
		}

		///<summary>
		///Adresse des Eventveranstalters
		///</summary>
		 string HNummer
		{
			get;
			set;
		}

		///<summary>
		///Adresse des Eventveranstalters
		///</summary>
		 string PLZ
		{
			get;
			set;
		}

		///<summary>
		///Adresse des Eventveranstalters
		///</summary>
		 string Ort
		{
			get;
			set;
		}

		///<summary>
		///Bezeichnung des Events
		///</summary>
		 string EventBezeichnung
		{
			get;
			set;
		}

		///<summary>
		///Startort des Events
		///</summary>
		 string Startort
		{
			get;
			set;
		}

		///<summary>
		///Beginn des Events
		///</summary>
		 DateTime Beginn
		{
			get;
			set;
		}

		///<summary>
		///Anzahl der Teilnehmer des Events
		///</summary>
		 int Teilnehmer
		{
			get;
			set;
		}
		///<summary>
		///ID der konkreten Veranstaltung
		///</summary>
		int EvDatenID
		{
			get;
			set;
		}

		/// <summary>
		/// UC 01.6 Benachrichtigung an den Veranstalter senden
		/// </summary>
		/// <remarks>
		/// Die Erstellung der Veranstalterbenachrichtigung wird
		/// in der Datenbank eingetragen.
		/// </remarks>
		void BestaetigeBenachrichtigung();
	}
}

// Wichtig: 
// Bei Verwendung von OFFICE XP und OFFICE 2003 folgende Anweisung auskommentieren!
#define OFFICE2013

using Microsoft.Office.Interop.Word;
using System;

namespace ManageDocuments
{
	/// <summary>
	/// Klasse zu den UCs 01.3, 01.4, 01.4.1, 01.6 Buchungsbestaetigungen, Rechnungen sowie
	/// Veranstalterbenachrichtigungen generieren
	/// </summary>
	/// <remarks>
	/// Dokumentgenerator fuer die Automatisierung der 
	/// Rechnungen und Bestaetigungen ueber MS-Word
	/// </remarks>
	public class DokumentManagement
	{
		/// <summary>
		/// Attribut zum Starten von MS-Word
		/// </summary>
		private Application wordApp;
        
        
        /// <summary>
        /// Attribut zur Mehrwertsteuer
        /// </summary>
        private const decimal MWST = 19;

		/// <summary>
		/// Konstruktor mit Initialisierungen
		/// </summary>
		public DokumentManagement()
		{
			
		}

		/// <summary>
		/// Word wird geoeffnet
		/// </summary>
		public void OpenWordGenerator()
		{
            wordApp = new Microsoft.Office.Interop.Word.Application();
		}

		/// <summary>
		/// Word wird geschlossen
		/// </summary>
		public void CloseWordGenerator()
		{
			// Missing.Value entspricht Referenz auf null
			object optional = System.Reflection.Missing.Value;
			wordApp.Quit(ref optional, ref optional, ref optional);
			wordApp = null;
		}

		/// <summary>
		/// UC 01.4, UC 01.4.1 Die Rechnung wird erstellt
		/// </summary>
		///<param name="re">Die zu erstellende Rechnung</param>
		public void ErstelleRechnung(ManageBuchungen.IRechnung re)
		{
			try
			{
				// Fuer alle optionalen Parameter
				object optional = System.Reflection.Missing.Value;

				// Pfad der Vorlage
				object openpath = System.Windows.Forms.Application.StartupPath+"\\Buchungsmanagement\\Vorlagen\\RechFormular.docx";
				
				// Document oeffnen
			#if OFFICE2013 // Version zur Automatisierung von Word 2000
				wordApp.Documents.Open(ref openpath, ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
			#else // Version zur Automatisierung von Word XP und Word 2003
				wordApp.Documents.Open2000(ref openpath, ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
			#endif
                
				// Formfields des Word Formulars ueber einen Enumerator fuellen
				System.Collections.IEnumerator iter = wordApp.ActiveDocument.FormFields.GetEnumerator();
				iter.Reset();
				/** Adresse**/
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsKunde.Name;
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsKunde.Vorname;
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsKunde.Strasse;
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsKunde.HNummer;
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsKunde.PLZ;
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsKunde.Ort;
				/**Adresse Ende**/

				/**Eventdaten**/
				iter.MoveNext();
				// Wurde die Buchung storniert?
				string result;
				if(re.RechnungsBuchung.Storniert)
					result = "Stornogebühr 10%";
				else
					result = "Rechnung";
				((FormField)iter.Current).Result = result;
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsNr;
				iter.MoveNext();
				// Storniert?
				if(re.RechnungsBuchung.Storniert)
					result = "storniert: ";
				else
					result = "";
				((FormField)iter.Current).Result = result + re.RechnungsBuchung.EventBezeichnung;
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsBuchung.StartTermin.ToLongDateString();
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsBuchung.StartOrt;
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsBuchung.GebuchtePlaetze.ToString();
				iter.MoveNext();
				((FormField)iter.Current).Result = re.RechnungsBuchung.Preis.ToString();
				iter.MoveNext();
				((FormField)iter.Current).Result = re.GesamtPreis.ToString();
				iter.MoveNext();
				((FormField)iter.Current).Result = (re.GesamtPreis / (100 + MWST) * MWST).ToString();
				iter.MoveNext();
				((FormField)iter.Current).Result = re.Zahlbar.ToLongDateString();
				/**Ende Eventdaten**/

				// Speichern des Dokuments
				object savepath = System.Windows.Forms.Application.StartupPath+"\\Buchungsmanagement\\Rechnungen\\"+re.RechnungsNr+" - "+System.DateTime.Today.ToShortDateString()+".docx";
                
			#if OFFICE2013 // Version zur Automatisierung von Word 2000
				wordApp.ActiveDocument.SaveAs2(ref savepath,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
#else // Version zur Automatisierung von Word XP und Word 2003
				wordApp.ActiveDocument.SaveAs2000(ref savepath,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
#endif
                //wordApp.ActiveDocument.SaveAs2() wdFormatPDF als 2. Parameter
            }
            catch (System.Exception ex)
			{
				throw ex;
			}
		}
		
		/// <summary>
		/// UC 01.6 Buchungen an den Veranstalter melden
		/// </summary>
		///<param name="benachrichtigung">die zu erstellende Veranstalterbenachrichtigung</param>
		public void ErstelleBenachrichtigung(ManageBuchungen.IVeranstalterBenachrichtigung benachrichtigung)
		{
			// Benachrichtigung erstellen
			try
			{
				// Fuer alle optionalen Parameter
				object optional = System.Reflection.Missing.Value;

				// Pfad der Vorlage
				object openpath = System.Windows.Forms.Application.StartupPath+"\\Buchungsmanagement\\Vorlagen\\BenachrichtFormular.docx";
				
				// Document oeffnen
			#if OFFICE2013 // Version zur Automatisierung von Word 2000
				wordApp.Documents.Open(ref openpath, ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
			#else // Version zur Automatisierung von Word XP und Word 2003
				wordApp.Documents.Open2000(ref openpath, ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
			#endif

				// Formfields des Word Formulars ueber einen Enumerator fuellen
				System.Collections.IEnumerator iter = wordApp.ActiveDocument.FormFields.GetEnumerator();
				iter.Reset();
				/** Adresse**/
				iter.MoveNext();
				((FormField) iter.Current).Result = benachrichtigung.Firma;
				iter.MoveNext();
				((FormField) iter.Current).Result = benachrichtigung.Strasse;
				iter.MoveNext();
				((FormField) iter.Current).Result = benachrichtigung.HNummer;
				iter.MoveNext();
				((FormField) iter.Current).Result = benachrichtigung.PLZ;
				iter.MoveNext();
				((FormField) iter.Current).Result = benachrichtigung.Ort;
				/**Adresse Ende**/

				/**Eventdaten**/
				iter.MoveNext();
				((FormField) iter.Current).Result = benachrichtigung.EventBezeichnung;
				iter.MoveNext();
				((FormField) iter.Current).Result = benachrichtigung.Beginn.ToLongDateString();
				iter.MoveNext();
				((FormField) iter.Current).Result = benachrichtigung.Startort;
				iter.MoveNext();
				((FormField) iter.Current).Result = benachrichtigung.Teilnehmer.ToString();
				/**Ende Eventdaten**/

				// Speichern des Dokuments
				object savepath = System.Windows.Forms.Application.StartupPath+"\\Buchungsmanagement\\Benachrichtigungen\\"+"EDNr-"+benachrichtigung.EvDatenID.ToString()+" - "+System.DateTime.Today.ToShortDateString()+".docx";
				
			#if OFFICE2013 // Version zur Automatisierung von Word 2000
				wordApp.ActiveDocument.SaveAs2(ref savepath,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
			#else // Version zur Automatisierung von Word XP und Word 2003
				wordApp.ActiveDocument.SaveAs2000(ref savepath,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
			#endif			
			}
			catch(System.Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// UC 01.3 Buchungsbestaetigung erstellen
		/// </summary>
		/// <param name="bu">die zu bestaetigende Buchung</param>
		/// <param name="k">der Kunde</param>
		public void ErstelleBestaetigung(ManageBuchungen.IBuchung bu, ManageBuchungen.IKunde k)
		{
			// Buchungsbestaetigung erstellen
			try
			{
				// Fuer alle optionalen Parameter
				object optional = System.Reflection.Missing.Value;

				// Pfad der Vorlage
				object openpath = System.Windows.Forms.Application.StartupPath+"\\Buchungsmanagement\\Vorlagen\\BestaetFormular.docx";
				
				// Document oeffnen
			#if OFFICE2013 // Version zur Automatisierung von Word 2000
				wordApp.Documents.Open(ref openpath, ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
			#else // Version zur Automatisierung von Word XP und Word 2003
				wordApp.Documents.Open2000(ref openpath, ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
			#endif
				// Formfields des Word Formulars ueber einen Enumerator fuellen
				System.Collections.IEnumerator iter = wordApp.ActiveDocument.FormFields.GetEnumerator();
				iter.Reset();
				/** Adresse**/
				iter.MoveNext();
				((FormField)iter.Current).Result = k.Name;
				iter.MoveNext();
				((FormField)iter.Current).Result = k.Vorname;
				iter.MoveNext();
				((FormField)iter.Current).Result = k.Strasse;
				iter.MoveNext();
				((FormField)iter.Current).Result = k.HNummer;
				iter.MoveNext();
				((FormField)iter.Current).Result = k.PLZ;
				iter.MoveNext();
				((FormField)iter.Current).Result = k.Ort;
				/**Adresse Ende**/

				/**Eventdaten**/
				iter.MoveNext();
				((FormField)iter.Current).Result = bu.EventBezeichnung;
				iter.MoveNext();
				((FormField)iter.Current).Result = bu.StartTermin.ToLongDateString();
				iter.MoveNext();
				((FormField)iter.Current).Result = bu.StartOrt;
				iter.MoveNext();
				((FormField)iter.Current).Result = bu.GebuchtePlaetze.ToString();
				iter.MoveNext();
				((FormField)iter.Current).Result = bu.Preis.ToString();
				iter.MoveNext();
				decimal gesamt = bu.Preis * bu.GebuchtePlaetze;
				((FormField)iter.Current).Result = gesamt.ToString();
				iter.MoveNext();
				((FormField)iter.Current).Result = (gesamt / (100 + MWST) * MWST).ToString();
				/**Ende Eventdaten**/

				// Speichern des Dokuments
				object savepath = System.Windows.Forms.Application.StartupPath+"\\Buchungsmanagement\\Bestaetigungen\\"+"BuNr-"+bu.BuchungsID.ToString()+" - "+System.DateTime.Today.ToShortDateString()+".docx";
				
			#if OFFICE2013 // Version zur Automatisierung von Word 2000
				wordApp.ActiveDocument.SaveAs2(ref savepath,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
			#else // Version zur Automatisierung von Word XP und Word 2003
				wordApp.ActiveDocument.SaveAs2000(ref savepath,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional,ref optional);
			#endif			
			}
			catch(System.Exception ex)
			{
				throw ex;
			}

		}
	}
}

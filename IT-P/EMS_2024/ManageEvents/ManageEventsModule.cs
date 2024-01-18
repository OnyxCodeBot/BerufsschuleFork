using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ManageEvents.ManageEventsDatasetTableAdapters;
using Microsoft.Extensions.Configuration;

namespace ManageEvents
{
    public class ManageEventsModule
    {
        private Microsoft.Data.SqlClient.SqlConnection cnEvents;
        private tbl_EventDatenTableAdapter taEvDaten;
        private tbl_EventsTableAdapter taEvents;
        private tbl_EvKategorieTableAdapter taKategorie;
        private tbl_EvVeranstalterTableAdapter taVeranstalter;

        public ManageEventsModule()
        {
            //Config Object mit *.json Datei
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            cnEvents = new Microsoft.Data.SqlClient.SqlConnection();
            //cnEvents.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FunEvents_Entwicklung_21ITA007;Data Source=ITSW16SQL2\SQL_A;Encrypt=False";

            string conStr = config.GetConnectionString("conString");

            cnEvents.ConnectionString = conStr;

            taEvDaten = new tbl_EventDatenTableAdapter();
            taEvents = new tbl_EventsTableAdapter();
            taKategorie = new tbl_EvKategorieTableAdapter();
            taVeranstalter = new tbl_EvVeranstalterTableAdapter();

            //Connect der Table Adapter manuell setzten,
            //damit nicht unnoetig durch die generierten 
            //Connections die Datenbank geoeffnet und geschlossen wird.
            taEvDaten.Connection = cnEvents;
            taEvents.Connection = cnEvents;
            taKategorie.Connection = cnEvents;
            taVeranstalter.Connection = cnEvents;
        }

        //Laedt die aktuellen Daten aus der Datenbank
        //in das Dataset dsEvents.
        public void LoadData(ManageEventsDataset dsEvents)
        {
            ManageEventsDataset tempEventsDs = new ManageEventsDataset();

            try
            {
                this.cnEvents.Open();

                //Füllen der Tabellen in der richtigen Reihenfolge
                this.taKategorie.Fill(tempEventsDs.tbl_EvKategorie);
                this.taVeranstalter.Fill(tempEventsDs.tbl_EvVeranstalter);
                this.taEvents.Fill(tempEventsDs.tbl_Events);
                this.taEvDaten.Fill(tempEventsDs.tbl_EventDaten);

                //Aenderungen in Dataset uebernehen
                tempEventsDs.AcceptChanges();

                dsEvents.Clear();
                dsEvents.Merge(tempEventsDs);

                dsEvents.AcceptChanges();
            }
            catch(Microsoft.Data.SqlClient.SqlException sqlEx)
            {
                //Exceptions weiter reichen
                throw sqlEx;
            }
            catch(System.Exception ex)
            {
                //Exceptions weiter reichen
                throw ex;
            }
            finally
            {
                if(this.cnEvents.State == ConnectionState.Open)
                {
                    this.cnEvents.Close();
                }
            }
        }

        public void UpdateDatabase(ManageEventsDataset dsEvents)
        {
            //Datenbankverbindung oeffnen
            this.cnEvents.Open();

            SqlTransaction trans = cnEvents.BeginTransaction(IsolationLevel.ReadCommitted);

            //Update und Insert Commands zur Transaktion hinzufuegen
            taEvents.Adapter.UpdateCommand.Transaction = trans;
            taEvents.Adapter.InsertCommand.Transaction = trans;

            taEvDaten.Adapter.UpdateCommand.Transaction = trans;
            taEvDaten.Adapter.InsertCommand.Transaction = trans;

            taKategorie.Adapter.UpdateCommand.Transaction = trans;
            taKategorie.Adapter.InsertCommand.Transaction = trans;

            taVeranstalter.Adapter.UpdateCommand.Transaction = trans;
            taVeranstalter.Adapter.InsertCommand.Transaction = trans;

            try
            {
                if (dsEvents.HasChanges())
                {
                    //Updates und Inserts in der richtigen Reihenfolge
                    taKategorie.Update(dsEvents.tbl_EvKategorie);
                    taVeranstalter.Update(dsEvents.tbl_EvVeranstalter);
                    taEvents.Update(dsEvents.tbl_Events);
                    taEvDaten.Update(dsEvents.tbl_EventDaten);
                }

                trans.Commit();
            }
            catch(SqlException ex)
            {
                trans.Rollback();
                throw ex;
            }
            catch(System.Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
            finally
            {
                //Datenbank schliessen
                if(this.cnEvents.State == ConnectionState.Open)
                {
                    this.cnEvents.Close();
                }

                //Aktuelle Daten aus der DB holen
                LoadData(dsEvents);
            }
        }
    }
}

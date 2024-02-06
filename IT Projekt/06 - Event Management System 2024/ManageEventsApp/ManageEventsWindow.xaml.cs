using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ManageEventsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ManageEventsWindow : Window
    {
        private ManageEvents.ManageEventsDataset dsEvents;

        private ICollectionView eventView;
        private ICollectionView eventDatenView;

        public ManageEventsWindow()
        {
            InitializeComponent();

            dsEvents = (ManageEvents.ManageEventsDataset)(FindResource("manageEventsDataset"));

            eventView = ((CollectionViewSource)this.FindResource("tbl_EventsViewSource")).View;
            eventDatenView = ((CollectionViewSource)this.FindResource("tbl_Events_tbl_EventDatenViewSource")).View;

            //lokale XML Daten laden
            try
            {
                ladenAusDateiMenuItem.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void beendenMenueItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RefreshBindings()
        {
            et_BezeichnungListBox.SelectedIndex = 0;

            //Binden der Elterntabellen
            Binding vBinding = new Binding();
            vBinding.Source = eventView;
            vBinding.Path = new PropertyPath("ev_EvVeranstalterID");

            cboVeranstalter.ItemsSource = dsEvents.tbl_EvVeranstalter;
            cboVeranstalter.DisplayMemberPath = "ev_Firma";
            cboVeranstalter.SelectedValuePath = "ev_EvVeranstalterID";
            cboVeranstalter.SetBinding(ComboBox.SelectedValueProperty, vBinding);
            cboVeranstalter.IsSynchronizedWithCurrentItem = true;

            Binding kBinding = new Binding();
            kBinding.Source = eventView;
            kBinding.Path = new PropertyPath("ek_EvKategorieID");

            cboKategorie.ItemsSource = dsEvents.tbl_EvKategorie;
            cboKategorie.DisplayMemberPath = "ek_KatBezeichnung";
            cboKategorie.SelectedValuePath = "ek_EvKategorieID";
            cboKategorie.SetBinding(ComboBox.SelectedValueProperty, kBinding);
            cboKategorie.IsSynchronizedWithCurrentItem = true;

            //NavBar
            eventNavBar.NavSourceView = (CollectionView)eventView;
            eventDatenView = ((CollectionViewSource)this.FindResource("tbl_Events_tbl_EventDatenViewSource")).View;
            eventDatenNavBar.NavSourceView = (CollectionView)eventDatenView;
            eventView.CurrentChanged += EventView_CurrentChanged;
        }

        private void EventView_CurrentChanged(object sender, EventArgs e)
        {
            eventDatenView = ((CollectionViewSource)FindResource("tbl_Events_tbl_EventDatenViewSource")).View;
            if(eventDatenView != null)
            {
                eventDatenNavBar.NavSourceView = (CollectionView)eventDatenView;
            }
        }

        private void ladenAusDatenbankMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Objeckt für Zugriff auf die Mittelschicht erzeugen
                ManageEvents.ManageEventsModule m = new ManageEvents.ManageEventsModule();

                if(MessageBox.Show(
                    "Achtung. Die Änderungen in der lokalen Datei werden durch die Daten aus der Datenbank überschrieben! Sollen die Daten aus der Datenbank wirklich übertragen werden?", 
                    "Warnung! Möglicher Datenverlust...", 
                    MessageBoxButton.YesNo, 
                    MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    this.Cursor = Cursors.Wait;

                    m.LoadData(dsEvents);
                    RefreshBindings();
                }
            }
            catch(Microsoft.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "SQL Fehler",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(), 
                    "Fehler", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void speichernInDateiMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dsEvents.WriteXml("Buchungen.xml", System.Data.XmlWriteMode.DiffGram);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ladenAusDateiMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Alle aktuellen Bearbeitungen stoppen
                eventBindingGroup.UpdateSources();

                dsEvents.Clear();
                dsEvents.ReadXml("Buchungen.xml", System.Data.XmlReadMode.DiffGram);

                RefreshBindings();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Der Dialog wird geschlossen. Aenderungen werden gespeichert.
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            // lokales Speichern der Daten
            speichernInDateiMenuItem.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent));
        }

        private void ed_FreigegebenCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //Event is freigegeben
            ed_FreigegebenCheckBox.IsEnabled = false;
        }

        private void ed_FreigegebenCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ed_FreigegebenCheckBox.IsEnabled = true;
        }

        private void synchronisierenMitDatenbankMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Objekt für Zugriff auf die Mittelschicht erzeugen
                ManageEvents.ManageEventsModule m = new ManageEvents.ManageEventsModule();

                //Alle aktuellen Bearbeitungen stoppen
                eventBindingGroup.UpdateSources();

                //Sind Änderungen im Dataset?
                if (dsEvents.HasChanges())
                {
                    MessageBox.Show("Die Änderungen werden zur Datenbank übertragen.", "Datentransfer", MessageBoxButton.OK, MessageBoxImage.Information);

                    Cursor = Cursors.Wait;

                    //Änderungen herausfiltern
                    ManageEvents.ManageEventsDataset dsChanges = (ManageEvents.ManageEventsDataset)dsEvents.GetChanges();

                    //Update mit der DB fahren
                    m.UpdateDatabase(dsChanges);

                    //Aktuellste Daten der DB übernehmen
                    dsEvents.Clear();
                    dsEvents.Merge(dsChanges);
                    dsEvents.AcceptChanges();

                    //Databindings aktualisieren
                    RefreshBindings();
                }
                else
                {
                    MessageBox.Show("Im Dataset finden sich zur Zeit keine Änderungen zum Abgleich mit der Datenbank.", "Kein Datentransfer", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch(Microsoft.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void SetProtection(bool stat)
        {
            //Menues/Textfelder/Buttons sperren oder freigeben
            ed_BeginnComboBox.IsEnabled = stat;
            et_BezeichnungListBox.IsEnabled = stat;

            btnNeuerEvent.IsEnabled = stat;
            btnNeuerTermin.IsEnabled = stat;
            btnVeranstalter.IsEnabled = stat;
            btnKategorie.IsEnabled = stat;

            btnAbbrechen.IsEnabled = !stat;
            btnUebernehmen.IsEnabled = !stat;

            dateiMenueItem.IsEnabled = stat;
            bearbeitenMenuItem.IsEnabled = stat;

            eventNavBar.IsEnabled = stat;
            eventDatenNavBar.IsEnabled = stat;
        }

        private void btnNeuerEvent_Click(object sender, RoutedEventArgs e)
        {
            //Constraints ausschalten
            dsEvents.EnforceConstraints = false;

            //Neue Rows erzeugen und hinzufügen
            ManageEvents.ManageEventsDataset.tbl_EventsRow evRow = (ManageEvents.ManageEventsDataset.tbl_EventsRow)dsEvents.tbl_Events.NewRow();
            dsEvents.tbl_Events.Rows.Add(evRow);

            //ParentRows setzen
            evRow.SetParentRow(dsEvents.tbl_EvKategorie.Rows[0]);
            evRow.SetParentRow(dsEvents.tbl_EvVeranstalter.Rows[0]);

            ManageEvents.ManageEventsDataset.tbl_EventDatenRow evDaRow = (ManageEvents.ManageEventsDataset.tbl_EventDatenRow)dsEvents.tbl_EventDaten.NewRow();

            //ParentRow und Standardwerte setzen
            evDaRow.SetParentRow(evRow);

            evDaRow.ed_AktTeilnehmer = 0;
            evDaRow.ed_Freigeben = false;
            evDaRow.ed_Preis = 0.0M;
            evDaRow.ed_VeranstalterBenachrichtigt = false;

            //Zeile der Tabelle tbl_EventDaten hinzufügen
            dsEvents.tbl_EventDaten.Rows.Add(evDaRow);

            //Auf aktuelle Position springen und Refresh
            eventView.MoveCurrentToLast();

            //Eingabefelder freigeben
            this.SetProtection(false);

            //Editiervorgang starten
            evRow.BeginEdit();
            evDaRow.BeginEdit();
        }

        private void btnNeuerTermin_Click(object sender, RoutedEventArgs e)
        {
            //Constraints ausschalten
            dsEvents.EnforceConstraints = false;

            //Neue DataRow für Eventstable erzeugen
            ManageEvents.ManageEventsDataset.tbl_EventDatenRow evDaRow = (ManageEvents.ManageEventsDataset.tbl_EventDatenRow)dsEvents.tbl_EventDaten.NewRow();

            //ParentRow und Standardwerte setzen
            evDaRow.SetParentRow(((DataRowView)eventView.CurrentItem).Row);

            evDaRow.ed_AktTeilnehmer = 0;
            evDaRow.ed_Freigeben = false;
            evDaRow.ed_Preis = 0.0M;
            evDaRow.ed_VeranstalterBenachrichtigt = false;

            //Row zur Eventdaten Tabelle hinzufügen
            dsEvents.tbl_EventDaten.Rows.Add(evDaRow);

            //Auf aktuelle Zeile springen
            eventDatenView.MoveCurrentToLast();

            //Mit den Änderungen in evDaRow beginnen
            evDaRow.BeginEdit();

            //Editfelder freischalten
            this.SetProtection(false);
        }

        private void btnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            //Lokale DataRow für das bearbeitete Event
            DataRow evRow = ((DataRowView)eventView.CurrentItem).Row;

            //Ein neuer Event wurde hinzugefügt
            if(((CollectionView)eventDatenView).Count == 1)
            {
                dsEvents.tbl_EventDaten.Rows.Remove(evRow.GetChildRows("FK_tbl_EventDaten_tbl_Events")[0]);

                dsEvents.tbl_Events.Rows.Remove(evRow);

                dsEvents.EnforceConstraints = true;

                eventView.MoveCurrentToFirst();
            }
            //Ein neuer Eventtermin wurde hinzugefügt
            else
            {
                dsEvents.tbl_EventDaten.Rows.Remove(evRow.GetChildRows("FK_tbl_EventDaten_tbl_Events")[((CollectionView)eventDatenView).Count - 1]);

                //Constraints im Dataset wieder zuschalten
                dsEvents.EnforceConstraints = true;
            }

            //Schreibschutz wieder herstellen
            this.SetProtection(true);
        }

        private void btnUebernehmen_Click(object sender, RoutedEventArgs e)
        {
            //Lokale Rows für EventDaten und Event
            DataRow evRow = ((DataRowView)eventView.CurrentItem).Row;
            DataRow evDaRow = ((DataRowView)eventDatenView.CurrentItem).Row;

            try
            {
                //Daten aus Steuerelementen übernehmen
                eventBindingGroup.UpdateSources();
                eventDatenBindingGroup.UpdateSources();

                //Neuer Event wurde erstellt
                if(evRow.RowState == DataRowState.Added)
                {
                    //ParentRows für Event setzen
                    //Eventveranstalter zuordnen
                    evRow.SetParentRow(dsEvents.tbl_EvVeranstalter.Rows[cboVeranstalter.SelectedIndex], dsEvents.Relations["FK_tbl_Events_tbl_EvVeranstalter"]);

                    //Eventkategorie zuordnen
                    evRow.SetParentRow(dsEvents.tbl_EvKategorie.Rows[cboKategorie.SelectedIndex], dsEvents.Relations["FK_tbl_Events_tbl_EvKategorie"]);
                }

                //Änderungen an Event und gewählter EventDataRow übernehmen
                evDaRow.EndEdit();
                evRow.EndEdit();

                //Constraints im Dataset zuschalten
                dsEvents.EnforceConstraints = true;

                //Refresh der Bindungen
                RefreshBindings();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Editieren", MessageBoxButton.OK, MessageBoxImage.Error);

                //Vorgang abbrechen
                btnAbbrechen.RaiseEvent(e);
            }
            finally
            {
                //Schreibschutz wiederherstellen
                SetProtection(true);
            }
        }

        //Startet das Editieren/Anlegen von Veranstaltern
        private void btnVeranstalter_Click(object sender, RoutedEventArgs e)
        {
            //Fenster erzeugen und anzeigen
            ManageVeranstalterWindow mvw = new ManageVeranstalterWindow();

            mvw.SetDataSet(dsEvents, cboVeranstalter.SelectedIndex);

            mvw.ShowDialog();
        }

        private void btnKategorie_Click(object sender, RoutedEventArgs e)
        {
            //Fenster erzeugen und anzeigen
            ManageKategorieWindow mkw = new ManageKategorieWindow();

            mkw.SetDataSet(dsEvents, cboKategorie.SelectedIndex);

            mkw.ShowDialog();
        }
    }
}

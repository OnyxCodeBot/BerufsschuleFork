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
using System.Windows.Shapes;

namespace ManageEventsApp
{
    /// <summary>
    /// Interaktionslogik für ManageVeranstalterWindow.xaml
    /// </summary>
    public partial class ManageVeranstalterWindow : Window
    {
        private ManageEvents.ManageEventsDataset dsVeranstalter;
        private ICollectionView veranstalterView;

        public ManageVeranstalterWindow()
        {
            InitializeComponent();
        }

        //Dataset und Eventveranstalter zum Bearbeiten übernehmen
        public void SetDataSet(ManageEvents.ManageEventsDataset ds, int index)
        {
            //Dataset initialisieren
            dsVeranstalter = ds;

            //Databindings setzen
            veranstalterGrid.DataContext = dsVeranstalter.tbl_EvVeranstalter;

            //View und NavBar initialisieren
            veranstalterView = (CollectionView)CollectionViewSource.GetDefaultView(dsVeranstalter.tbl_EvVeranstalter);

            veranstalterNavBar.NavSourceView = (CollectionView)veranstalterView;

            //Aktuell gewählten eventveranstalter setzen
            veranstalterView.MoveCurrentToPosition(index);
        }

        private void ShowErrorMessages(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show(((Exception)sender).Message
                + "\nVernanstalter, Straße, Hausnummer, Postleitzahl und Ort "
                + "müssen Werte enthalten.\n"
                + "Möchten Sie die fehlenden Einträge ergänzen?",
                "Fehler",
                MessageBoxButton.YesNo,
                MessageBoxImage.Error);

            //Abbrechen oder Überarbeiten?
            if(mr == MessageBoxResult.No)
            {
                btnAbbrechen.RaiseEvent(e);
            }
            else
            {
                ev_FirmaTextBox.Focus();
            }
        }

        private void btnNeuerVeranstalter_Click(object sender, RoutedEventArgs e)
        {
            //Buttons bei Bearbeitung sperren / freigeben
            veranstalterNavBar.IsEnabled = false;

            btnNeuerVeranstalter.IsEnabled = false;
            btnSchliessen.IsEnabled = false;

            btnAbbrechen.IsEnabled = true;
            btnUebernehmen.IsEnabled = true;

            try
            {
                //Neue Row erzeugen
                ManageEvents.ManageEventsDataset.tbl_EvVeranstalterRow verRow = 
                    (ManageEvents.ManageEventsDataset.tbl_EvVeranstalterRow)dsVeranstalter.tbl_EvVeranstalter.NewRow();

                //Überprüfung der Contraints zum Bearbeiten abschalten
                dsVeranstalter.EnforceConstraints = false;

                //Row hinzufügen und Anzeige updaten
                dsVeranstalter.tbl_EvVeranstalter.Rows.Add(verRow);

                veranstalterView.MoveCurrentToLast();

                //Bearbeitung der Zeile beginnen
                verRow.BeginEdit();

                ev_FirmaTextBox.Focus();
            }
            catch(Exception ex)
            {
                ShowErrorMessages(ex, e);
            }
        }

        private void btnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            //Neue Row wieder löschen
            dsVeranstalter.tbl_EvVeranstalter.Rows.Remove(((DataRowView)veranstalterView.CurrentItem).Row);

            //Constraints wieder herstellen
            dsVeranstalter.EnforceConstraints = true;

            //Button nach Bearbeitung sperren/freigeben
            veranstalterNavBar.IsEnabled = true;

            btnNeuerVeranstalter.IsEnabled = true;
            btnSchliessen.IsEnabled = true;

            btnAbbrechen.IsEnabled = false;
            btnUebernehmen.IsEnabled = false;
        }

        private void btnUebernehmen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Daten an Dataset senden
                veranstalterBindingGroup.UpdateSources();

                //aktuelle Bearbeitung beenden
                ((DataRowView)veranstalterView.CurrentItem).Row.EndEdit();

                //Überprüfung der constraints wieder zuschalten
                dsVeranstalter.EnforceConstraints = true;

                //TODO
            }
        }
    }
}

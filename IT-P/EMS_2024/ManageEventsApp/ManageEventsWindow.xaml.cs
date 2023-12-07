using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}

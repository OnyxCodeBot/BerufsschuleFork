using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für ManageKategorieWindow.xaml
    /// </summary>
    public partial class ManageKategorieWindow : Window
    {
        private ManageEvents.ManageEventsDataset dsKategorie;
        private CollectionView kategorieView;

        public ManageKategorieWindow()
        {
            InitializeComponent();
        }

        public void SetDataSet(ManageEvents.ManageEventsDataset ds, int index)
        {
            //Dataset initialisieren
            dsKategorie = ds;

            //Databinding setzen
            kategorieGrid.DataContext = dsKategorie.tbl_EvKategorie;

            //View und NavBar initialisieren
            kategorieView = (CollectionView)CollectionViewSource.GetDefaultView(dsKategorie.tbl_EvKategorie);
            kategorieNavBar.NavSourceView = kategorieView;

            //Auf gewählte Kategorie aus ManageEventsWindow springen
            kategorieView.MoveCurrentToPosition(index);
        }

        private void ShowErrorMessages(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show(((Exception)sender).Message
                + "\nKategorie muss einen Wert enthalten!"
                + "\nMöchten Sie die fehlenden Einträge ergänzen?",
                "Fehler",
                MessageBoxButton.YesNo,
                MessageBoxImage.Error);

            //Abbrechen oder Überarbeiten?
            if (mr == MessageBoxResult.No)
            {
                btnAbbrechen.RaiseEvent(e);
            }
            else
            {
                ek_KatBezeichnungTextBox.Focus();
            }
        }

        private void btnNeueKategorie_Click(object sender, RoutedEventArgs e)
        {
            //Sperren der Steuerelemente
            kategorieNavBar.IsEnabled = false;

            btnNeueKategorie.IsEnabled = false;
            btnSchliessen.IsEnabled = false;

            btnUebernehmen.IsEnabled = true;
            btnAbbrechen.IsEnabled = true;

            try
            {
                ManageEvents.ManageEventsDataset.tbl_EvKategorieRow katRow =
                    (ManageEvents.ManageEventsDataset.tbl_EvKategorieRow)dsKategorie.tbl_EvKategorie.NewRow();

                dsKategorie.EnforceConstraints = false;

                dsKategorie.tbl_EvKategorie.Rows.Add(katRow);

                kategorieView.MoveCurrentToLast();

                katRow.BeginEdit();

                ek_KatBezeichnungTextBox.Focus();
            }
            catch (Exception ex)
            {
                ShowErrorMessages(ex, e);
            }
        }

        private void btnUebernehmen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ((DataRowView)kategorieView.CurrentItem).Row.EndEdit();

                dsKategorie.EnforceConstraints = true;

                kategorieNavBar.NavSourceView = (CollectionView)kategorieView;

                kategorieNavBar.IsEnabled = true;

                btnNeueKategorie.IsEnabled = true;
                btnSchliessen.IsEnabled = true;

                btnUebernehmen.IsEnabled = false;
                btnAbbrechen.IsEnabled = false;
            }
            catch (Exception ex)
            {
                ShowErrorMessages(ex, e);
            }
        }

        private void btnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            dsKategorie.tbl_EvKategorie.Rows.Remove(((DataRowView)kategorieView.CurrentItem).Row);

            dsKategorie.EnforceConstraints = true;

            kategorieNavBar.IsEnabled = true;

            btnNeueKategorie.IsEnabled = true;
            btnSchliessen.IsEnabled = true;

            btnUebernehmen.IsEnabled = false;
            btnAbbrechen.IsEnabled = false;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                ((DataRowView)kategorieView.CurrentItem).Row.EndEdit();
            }
            catch (Exception ex)
            {
                ShowErrorMessages(ex, new RoutedEventArgs());
            }
        }

        private void btnSchliessen_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

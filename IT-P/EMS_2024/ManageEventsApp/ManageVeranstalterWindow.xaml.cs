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
    }
}

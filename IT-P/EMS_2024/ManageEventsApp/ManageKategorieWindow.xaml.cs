using System;
using System.Collections.Generic;
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
    }
}

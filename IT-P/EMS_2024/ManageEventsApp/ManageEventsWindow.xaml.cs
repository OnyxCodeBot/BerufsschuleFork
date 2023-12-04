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
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavBar
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class NavBar : UserControl
    {
        private CollectionView sourceView;
        private int count = 0;

        public NavBar()
        {
            InitializeComponent();
        }

        private void First_Click(object sender, RoutedEventArgs e)
        {
            sourceView.MoveCurrentToFirst();
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            if (sourceView.CurrentPosition != 0)
            {
                sourceView.MoveCurrentToPrevious();
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (sourceView.CurrentPosition + 1 != sourceView.Count)
            {
                sourceView.MoveCurrentToNext();
            }
        }

        private void Last_Click(object sender, RoutedEventArgs e)
        {
            sourceView.MoveCurrentToLast();
        }

        public CollectionView NavSourceView
        {
            get => sourceView;

            set
            {
                sourceView = value;
                //Anzahl Elemente
                count = sourceView.Count;
                sourceView.MoveCurrentToFirst();
                Number.Content = sourceView.CurrentPosition + 1 + " von " + count;
                sourceView.CurrentChanged += SourceView_CurrentChanged;
            }
        }

        private void SourceView_CurrentChanged(object sender, EventArgs e)
        {
            Number.Content = sourceView.CurrentPosition + 1 + " von " + count;
        }
    }
}
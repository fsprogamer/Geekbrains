using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ADO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ADO.ArtistDataSet artistDataSet = ((ADO.ArtistDataSet)(this.FindResource("artistDataSet")));
            // Load data into the table Artists. You can modify this code as needed.
            ADO.ArtistDataSetTableAdapters.ArtistsTableAdapter artistDataSetArtistsTableAdapter = new ADO.ArtistDataSetTableAdapters.ArtistsTableAdapter();
            artistDataSetArtistsTableAdapter.Fill(artistDataSet.Artists);
            System.Windows.Data.CollectionViewSource artistsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("artistsViewSource")));
            artistsViewSource.View.MoveCurrentToFirst();
        }
    }
}

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

namespace PROG2500_A2_Chinook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Pages.HomePage homePage { get; set; }
        public Pages.ArtistsPage artistsPage { get; set; }
        public Pages.AlbumsPage albumsPage { get; set; }
        public Pages.TracksPage tracksPage { get; set; }
        public Pages.MusicCategoriesPage catalogPage { get; set; }
        public Pages.CustomerOrderSearchPage customerSearchPage { get; set; }



        public MainWindow()
        {
            InitializeComponent();
            homePage = new Pages.HomePage();
            artistsPage = new Pages.ArtistsPage();
            albumsPage = new Pages.AlbumsPage();
            tracksPage = new Pages.TracksPage();
            catalogPage = new Pages.MusicCategoriesPage();
            customerSearchPage = new Pages.CustomerOrderSearchPage();

            mainFrame.NavigationService.Navigate(homePage);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(homePage);
        }

        private void ArtistButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(artistsPage);
        }

        private void AlbumButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(albumsPage);
        }

        private void TrackButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(tracksPage);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
  
        private void MusicCatalogButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(catalogPage);
        }

        private void CustomersOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(customerSearchPage);
        }
    }
}

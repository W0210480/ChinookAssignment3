using Chinook.Data;
using Microsoft.EntityFrameworkCore;
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

namespace PROG2500_A2_Chinook.Pages
{
    /// <summary>
    /// Interaction logic for ArtistsPage.xaml
    /// </summary>
    public partial class ArtistsPage : Page
    {
        private readonly ChinookContext _context = new ChinookContext();
        private CollectionViewSource artistsViewSource;
        public ArtistsPage()
        {
            InitializeComponent();
            artistsViewSource = (CollectionViewSource)FindResource(nameof(artistsViewSource));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Artists.Load();
            artistsViewSource.Source = _context.Artists.Local.ToObservableCollection();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var artistName = textSearch.Text;
            var artists = _context.Artists.Where(a => a.Name.Contains(artistName)).ToList();
            artistsViewSource.Source = artists;

        }

    }
}

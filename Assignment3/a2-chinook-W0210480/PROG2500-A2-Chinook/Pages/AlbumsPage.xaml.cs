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
    /// Interaction logic for AlbumsPage.xaml
    /// </summary>
    public partial class AlbumsPage : Page
    {

        private readonly ChinookContext _context = new ChinookContext();
        private CollectionViewSource albumsViewSource;
        
        public AlbumsPage()
        {
            InitializeComponent();

            albumsViewSource = (CollectionViewSource)FindResource(nameof(albumsViewSource));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Albums.Load();
            albumsViewSource.Source = _context.Albums.Local.ToObservableCollection();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var albumTitle = textSearch.Text;
            var albums = _context.Albums.Where(a => a.Title.Contains(albumTitle)).ToList();
            albumsViewSource.Source = albums;
            
        }
    }
}

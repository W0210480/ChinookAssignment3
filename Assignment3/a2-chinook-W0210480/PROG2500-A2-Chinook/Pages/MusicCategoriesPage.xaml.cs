using Chinook.Data;
using Microsoft.EntityFrameworkCore;
using PROG2500_A2_Chinook.Models;
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
    /// Interaction logic for MusicCategoriesPage.xaml
    /// </summary>
    public partial class MusicCategoriesPage : Page
    {

        private readonly ChinookContext _context = new ChinookContext();
        private CollectionViewSource categoriesViewSource;

        public MusicCategoriesPage()
        {
            InitializeComponent();

            categoriesViewSource = (CollectionViewSource)FindResource(nameof(categoriesViewSource));

            _context.Artists.Load();
            _context.Albums.Load();
            _context.Tracks.Load();

            categoriesViewSource.Source = _context.Albums.Local.ToObservableCollection();

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var query =
                from artist in _context.Artists
                where artist.Name.Contains(txtSearch.Text)
                group artist by artist.Name.ToUpper().Substring(0, 1) into newGroup
                select new
                {
                    Index = newGroup.Key,
                    artistsCount = newGroup.Count().ToString(),
                    artists = newGroup.ToList<Artist>()
                };

            categoriesListView.ItemsSource = query.ToList();
        }
    }
}

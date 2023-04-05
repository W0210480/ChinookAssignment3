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
    /// Interaction logic for TracksPage.xaml
    /// </summary>
    public partial class TracksPage : Page
    {
        private readonly ChinookContext _context = new ChinookContext();
        private CollectionViewSource tracksViewSource;
        public TracksPage()
        {
            InitializeComponent();
            tracksViewSource = (CollectionViewSource)FindResource(nameof(tracksViewSource));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Tracks.Load();
            tracksViewSource.Source = _context.Tracks.Local.ToObservableCollection();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var trackName = textSearch.Text;
            var tracks = _context.Tracks.Where(a => a.Name.Contains(trackName)).ToList();
            tracksViewSource.Source = tracks;

        }
    }
}

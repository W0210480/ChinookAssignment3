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
    /// Interaction logic for CustomerOrderSearchPage.xaml
    /// </summary>
    public partial class CustomerOrderSearchPage : Page
    {

        private readonly ChinookContext _context = new ChinookContext();
        private CollectionViewSource categoriesViewSource;
        
        public CustomerOrderSearchPage()
        {
        InitializeComponent();

        categoriesViewSource = (CollectionViewSource)FindResource(nameof(categoriesViewSource));

            _context.Customers.Load();
            _context.Invoices.Load();
            _context.InvoiceLines.Load();

            categoriesViewSource.Source = _context.Albums.Local.ToObservableCollection();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var query =
                from customer in _context.Customers
                where customer.LastName.Contains(txtSearch.Text) 
                select customer;

            categoriesListView.ItemsSource = query.ToList();
        }
    }
}

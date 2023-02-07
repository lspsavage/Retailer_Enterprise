using Retailer_App.Views.Inventories;
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

namespace Retailer_App.Views.Home
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void MnUsers_Click(Object sender, RoutedEventArgs e)
        {
            PnlContent.Children.Clear();
            PnlContent.Children.Add(new UsersView());
        }

        private void MnRelogin_Click(Object sender, RoutedEventArgs e)
        {
            //PnlContent.Children.Clear();
            //PnlContent.Children.Add(new LoginDialog());
            LoginDialog f = new LoginDialog();
            f.Show();
        }
        private void MnBackup_Click(Object sender, RoutedEventArgs e)
        {
            PnlContent.Children.Clear();
            PnlContent.Children.Add(new EditorView());
        }
        private void MnExit_Click(Object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MnInventory_Click(Object sender, RoutedEventArgs e)
        {
            PnlContent.Children.Clear();
            PnlContent.Children.Add(new InventoriesView());
        }
        private void MnStock_Click(Object sender, RoutedEventArgs e)
        {
            PnlContent.Children.Clear();
            PnlContent.Children.Add(new StockDialog());
        }
        private void MnProduct_Click(Object sender, RoutedEventArgs e)
        {
            PnlContent.Children.Clear();
            PnlContent.Children.Add(new ProductView());
        }
    }
}

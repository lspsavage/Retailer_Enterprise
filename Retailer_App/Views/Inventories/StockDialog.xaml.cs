using Retailer_App.Models;
using Retailer_App.ViewModels;
using Retailer_App.Views.Home;
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
using System.Xml.Linq;

namespace Retailer_App.Views.Inventories
{
    /// <summary>
    /// Interaction logic for StockDialog.xaml
    /// </summary>
    public partial class StockDialog : UserControl
    {
        public static string InsertType;
        public static int InsertQty;
        public static string Expdate;
        public static string InsertDesc;

        public StockDialog()
        {
            InitializeComponent();
            vm = new InventoryLogViewModel();
            vm.OnCallBack += ResetCommponent;
            DataContext = vm;
            ResetCommponent();
        }

        private InventoryLogViewModel vm;

        private void ResetCommponent()
        {
            ListBox.IsEnabled = false;
            Stock.IsEnabled = false;
            ExpDate.IsEnabled = false;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnMenu.Visibility = Visibility.Hidden;
            BtnOut.Visibility = Visibility.Hidden;
            BtnIn.Visibility = Visibility.Hidden;
            BtnInsert.Visibility = Visibility.Hidden;
            BtnReset.Visibility = Visibility.Hidden;

            vm.Model = new Inventorylog();
        }

        private void TblData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnIn.Visibility= Visibility.Hidden;
            BtnOut.Visibility= Visibility.Hidden;
            BtnMenu.Visibility= Visibility.Visible;
            BtnReset.Visibility= Visibility.Hidden;
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Dashboard.PnlContent.Children.Clear();
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            BtnUpdate.Visibility= Visibility.Hidden;
            BtnInsert.Visibility= Visibility.Hidden;
            BtnIn.Visibility= Visibility.Visible;
            BtnOut.Visibility =Visibility.Visible;
            BtnMenu.Visibility=Visibility.Visible;
        }

        private void BtnIn_Click(object sender, RoutedEventArgs e)
        {
            ListBox.IsEnabled = true;
            Stock.IsEnabled = true;
            ExpDate.IsEnabled = true;

            InsertType = "IN";
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnInsert.Visibility = Visibility.Visible;
            BtnIn.Visibility = Visibility.Hidden;
            BtnOut.Visibility = Visibility.Hidden;
            BtnMenu.Visibility = Visibility.Visible;
        }

        private void BtnOut_Click(object sender, RoutedEventArgs e)
        {
            ListBox.IsEnabled = true;
            Stock.IsEnabled = true;
            ExpDate.IsEnabled = true;

            InsertType = "OUT";
            BtnUpdate.Visibility= Visibility.Hidden;
            BtnInsert.Visibility = Visibility.Visible;
            BtnIn.Visibility = Visibility.Hidden;
            BtnOut.Visibility= Visibility.Hidden;
            BtnMenu.Visibility = Visibility.Visible;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Stock_TextChanged(object sender, TextChangedEventArgs e)
        {
            int valueQty;
            if (int.TryParse(Stock.Text, out valueQty))
            {
                InsertQty = valueQty;
            }
        }

        private void ExpDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            Expdate = ExpDate.Text;
        }

        private void Desc_TextChanged(object sender, TextChangedEventArgs e)
        {
            InsertDesc = Desc.Text;
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

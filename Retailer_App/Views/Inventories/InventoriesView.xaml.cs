using Retailer_App.ViewModels;
using Retailer_App.Models;
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
using System.Data;
using System.ComponentModel;

namespace Retailer_App.Views.Inventories
{
    /// <summary>
    /// Interaction logic for InventoriesView.xaml
    /// </summary>
    public partial class InventoriesView : UserControl
    {
        public static string startDate;
        public static string endDate;
        public static string ComboBoxValue;
        public InventoriesView()
        {
            InitializeComponent();
            vm = new InventoryViewModel();
            vm.OnCallBack += ResetCommponent;
            DataContext = vm;
            ResetCommponent();
       
        }

        private InventoryViewModel vm;

        private void TblData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            BtnNew.Visibility = Visibility.Hidden;
            BtnEdit.Visibility = Visibility.Visible;
            BtnReset.Visibility = Visibility.Hidden;

        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            App.Dashboard.PnlContent.Children.Clear();
            App.Dashboard.PnlContent.Children.Add(new EditorView());
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetCommponent();
            ICollectionView view = CollectionViewSource.GetDefaultView(TblData.ItemsSource);
            view.Filter = null;
            Tipe.SelectedIndex = -1;
            Tanggal.SelectedDate = null;
            NextTanggal.SelectedDate = null;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Dashboard.PnlContent.Children.Clear();
        }

        private void ResetCommponent()
        {
            vm.Model = new Inventory();
        }

        private void Tipe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Tipe.SelectedIndex != -1)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)Tipe.SelectedItem;
                ComboBoxValue = selectedItem.Content.ToString();
            }
        }

        private void Tanggal_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Tanggal.SelectedDate != null)
            {
                DateTime selectedDate = Tanggal.SelectedDate.Value;
                startDate = selectedDate.ToString("yyyy/MM/dd");
            }
        }

        private void NextTanggal_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NextTanggal.SelectedDate != null)
            {
                DateTime selectedDate = NextTanggal.SelectedDate.Value;
                endDate = selectedDate.ToString("yyyy/MM/dd");
            }
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
           // vm.Model = new Inventory();
            if (ComboBoxValue != null)
            {
                ICollectionView view = CollectionViewSource.GetDefaultView(TblData.ItemsSource);
                view.Filter = item =>
                {
                    var log = item as Inventory;
                    if (log != null)
                        return log.Type == ComboBoxValue;
                    else
                        return false;
                };
            }
            Tipe.SelectedIndex = -1;
        }
    }
}

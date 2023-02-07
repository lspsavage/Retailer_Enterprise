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
using Retailer_App.Models;
using System.Xml.Linq;
using Retailer_App.ViewModels;

namespace Retailer_App.Views.Inventories
{
    /// <summary>
    /// Interaction logic for ProductView.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();
            vm = new ProductViewModel();
            vm.OnCallBac += ResetCommponent;
            DataContext = vm;
            ResetCommponent();
        }

        private ProductViewModel vm;

        private void ResetCommponent()
        {
            TxtUid.IsReadOnly = true;
            BtnInsert.Visibility = Visibility.Hidden;
            BtnNew.Visibility = Visibility.Visible;
            BtnEdit.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;
            BtnReset.Visibility = Visibility.Hidden;
            ///LblUid.Visibility = Visibility.Hidden;
            TxtUid.Visibility = Visibility.Hidden;

            TxtName.IsEnabled = false;
            ChkStatus.IsEnabled = false;

            vm.Model = new Product();
            BtnNew.Focus();
        }
        private void TblData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            BtnNew.Visibility = Visibility.Hidden;
            BtnEdit.Visibility = Visibility.Visible;
            BtnReset.Visibility = Visibility.Visible;
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            BtnEdit.Visibility = Visibility.Hidden;
            BtnInsert.Visibility = Visibility.Hidden;
            BtnReset.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
            TxtName.IsEnabled = true;
            ChkStatus.IsEnabled = true;
            //LblUid.Visibility = Visibility.Visible;
            TxtUid.Visibility = Visibility.Visible;
            TxtName.Focus();
        }


        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetCommponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Dashboard.PnlContent.Children.Clear();
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            BtnNew.Visibility = Visibility.Hidden;
            BtnReset.Visibility = Visibility.Visible;
            BtnInsert.Visibility = Visibility.Visible;
            TxtName.IsEnabled = true;
            ChkStatus.IsEnabled = true;
            vm.Model = new Product();
            vm.IsChecked = true;
            TxtName.Focus();
        }
    }
}

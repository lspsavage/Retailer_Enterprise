using Retailer_App.Models;
using Retailer_App.Setup;
using Retailer_App.Views.Inventories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Retailer_App.ViewModels
{
    public class InventoryLogViewModel : INotifyPropertyChanged
    {
        public InventoryLogViewModel()
        {
            logcol = new ObservableCollection<Inventorylog>();
            dbconn = new Db_Connection();
            model = new Inventorylog();


            SelectCommand = new RelayCommand(async () => await ReadDataAsync());
            InsertCommand = new RelayCommand(async () => await InsertDataAsync());
            SelectCommand.Execute(null);
        }
        public RelayCommand InsertCommand { get; set; }
        public RelayCommand SelectCommand { get; set; }

        public ObservableCollection<Inventorylog> Logcol
        {
            get
            {
                return logcol;
            }
            set
            {
                logcol = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(null));
            }
        }

        public Inventorylog Model
        {
            get
            {
                return model;
            }
            set
            {
               /* if (value != null)
                {
                    IsChecked = (value.Qty == 1) ? true : false;
                }*/
                model = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(null));
            }
        }

        public bool IsChecked
        {
            get
            {
                return check;
            }
            set
            {
                check = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(null));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event Action OnCallBack;

        private readonly Db_Connection dbconn;
        private ObservableCollection<Inventorylog> logcol;
        private Inventorylog model;
        private bool check;

        private async Task ReadDataAsync()
        {
            dbconn.OpenConnection();

            await Task.Delay(0);
            var query = " select * from vproductstock ";
            var sqlcmd = new SqlCommand(query, dbconn.SqlConnect);
            var sqlresult = sqlcmd.ExecuteReader();

            if (sqlresult.HasRows)
            {
                logcol.Clear();
                while (sqlresult.Read())
                {
                    logcol.Add(new Inventorylog
                    {
                        Uid = Convert.ToInt32(sqlresult[0]),
                        Products = new Product
                        {
                            Name = sqlresult[1].ToString()
                        },
                        Qty = Convert.ToInt32(sqlresult[2])
                    });
                }
            }
            dbconn.CloseConnection();
            OnCallBack?.Invoke();
        }

        private async Task InsertDataAsync()
        {
            if (IsValidating())
            {
                dbconn.OpenConnection();
                var query = $"DECLARE @new_uid TABLE (uid INT) " +
                            $"INSERT INTO inventories(id_user, logdate, type, description, status, expdate) " +
                            $"OUTPUT inserted.uid INTO @new_uid " +
                            $"VALUES ('{App.SessionUid}', (SELECT CONVERT (VARCHAR(10),GETDATE(), 111)), " +
                            $"'{StockDialog.InsertType}', '{StockDialog.InsertDesc}', 1, '{StockDialog.Expdate}') " +
                            $"INSERT INTO inventorylogs(id_inventory, id_product, qty) " +
                            $"VALUES ((SELECT uid FROM @new_uid), {Model.Uid}, {StockDialog.InsertQty})";
                var sqlcmd = new SqlCommand(query, dbconn.SqlConnect);
                sqlcmd.ExecuteNonQuery();
                dbconn.CloseConnection();
                await ReadDataAsync();
            }
        }

        private bool IsValidating()
        {
            var flag = true;
            if (model.Uid == 0)
            {
                MessageBox.Show("Teks 1 tidak boleh kosong!!", "Warning",
                                MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                flag = false;
            }
            else if (StockDialog.Expdate == null)
            {
                MessageBox.Show("Teks 2 tidak boleh kosong!!", "Warning",
                                MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                flag = false;
            }
            else if (StockDialog.InsertQty == 0)
            {
                MessageBox.Show("Teks 3 tidak boleh kosong!!", "Warning",
                                MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                flag = false;
            }
            else if (StockDialog.InsertType == null)
            {
                MessageBox.Show("Teks 4 tidak boleh kosong!!", "Warning",
                                MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                flag = false;
            }
            return flag;
        }
    }
}


using Retailer_App.Models;
using Retailer_App.Setup;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Retailer_App.ViewModels
{
    internal class UserRuleView : INotifyPropertyChanged
    {
        public UserRuleView()
        {
            rulcol = new ObservableCollection<UserRule>();
            dbconn = new Db_Connection();
            model = new UserRule();

            SaveCommand = new RelayCommand(async () => await SaveDataAsync());

        }

        public RelayCommand SaveCommand { get; set; }

        public ObservableCollection<UserRule> Rulcol
        {
            get
            {
                return rulcol;
            }
            set
            {
                rulcol = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(null));
            }
        }

        public UserRule Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value != null)
                {
                    IsChecked = (value.Access == "Active") ? true : false;
                }
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
        private ObservableCollection<UserRule> rulcol;
        private UserRule model;
        private bool check;

        private async Task SaveDataAsync()
        {
            if (IsValidating())
            {
                dbconn.OpenConnection();
                var Access = check ? "1" : "0";
                var query = $"INSERT INTO vusersrule VALUES (" +
                            $"'{model.User.UserName}', " +
                            $"'{model.Menu}', " +
                            $"'{Access}'";
                var sqlcmd = new SqlCommand(query, dbconn.SqlConnect);
                sqlcmd.ExecuteNonQuery();
                dbconn.CloseConnection();
            }
        }

        private bool IsValidating()
        {
            var flag = true;
            if (model.Access == null)
            {
                MessageBox.Show("Teks 1 tidak boleh kosong!!", "Warning",
                                MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
                flag = false;
            }
            return flag;
        }
    }

    }


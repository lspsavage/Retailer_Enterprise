#pragma checksum "..\..\..\..\Views\Inventories\InventoriesView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4A8354C8954E24CD36FE84E212CCA7496AF81C85F9528EC1DEB1FAF02E6EDA2E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Retailer_App.Views.Inventories;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Retailer_App.Views.Inventories {
    
    
    /// <summary>
    /// InventoriesView
    /// </summary>
    public partial class InventoriesView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TblData;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Tipe;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Tanggal;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker NextTanggal;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnShow;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNew;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEdit;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReset;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Retailer_App;component/views/inventories/inventoriesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TblData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 50 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
            this.TblData.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.TblData_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Tipe = ((System.Windows.Controls.ComboBox)(target));
            
            #line 64 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
            this.Tipe.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Tipe_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Tanggal = ((System.Windows.Controls.DatePicker)(target));
            
            #line 69 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
            this.Tanggal.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Tanggal_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NextTanggal = ((System.Windows.Controls.DatePicker)(target));
            
            #line 72 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
            this.NextTanggal.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.NextTanggal_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnShow = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
            this.BtnShow.Click += new System.Windows.RoutedEventHandler(this.BtnShow_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnNew = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
            this.BtnNew.Click += new System.Windows.RoutedEventHandler(this.BtnNew_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
            this.BtnEdit.Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnReset = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
            this.BtnReset.Click += new System.Windows.RoutedEventHandler(this.BtnReset_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Views\Inventories\InventoriesView.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


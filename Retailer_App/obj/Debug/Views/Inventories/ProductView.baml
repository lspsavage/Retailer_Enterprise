   M S B A M L   `   `   `  ????G  CRetailer_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Retailer_App.Views.InventoriesRetailer_App.Views.Inventories  5      0    *Retailer_App.Views.Inventories.ProductView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Retailer_App.Views.Inventories     5        ? 	Resources  5	       ?? 
TargetType   Title_Label ?? Property ?? Value  	Isi_Label??%?  &	        &	 ?     ?? 5
   
   " ??6   .?5      ??  ? ??$ 30(?6)   ?? 5       ? ??$
 Bold"?6+   ?? 5       ? ??$ Bottom=?69   ?? 5       ? ??
 ?   ?6+   ?? 5       ? ??$ 
MADE TOMMY)?6+   5      ?? 5   
   " ??6   .?5      ??  ? ??$ 14(?6)   ?? 5       ? ??$
 Bold"?6+   ?? 5       ? ??$ Bottom=?69   ?? 5       ? ??
 ?   ?6+   ?? 5       ? ??$ 
MADE TOMMY)?6+   5      5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??10* ?6   ?? 5      $	??50* ?6   ?? 5      $	??25* ?6   ?? 5      $	??15* ?6    ? ColumnDefinitions 5!   
   ?? 5"      $	??75* ?6   ?? 5#      $	??25* ?6   .+?5%   
   ? $??0??6   $??0??6   .+?5&      ?? $??DATA PRODUCT??6   #??[  6+   $??	0,0,0,-16q?6P   5'      ? 5(   
   $??1??6   $??0??6   .+?5)      &   System.Windows.Controls.DataGrid  -   5          Name$ TblData??5)      $??10,10,10,10q?6(   
???????   HeadersVisibility$ Column=?5*         EnableRowVirtualization .  	   CanUserAddRows	 .  
   CanUserDeleteRows
 .     AutoGenerateColumns .     AlternatingRowBackground
 ???????5.      ?? *
Prodcoll+ ?? SelectedItem 64   ?? *Model+   Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$
 CODE??6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ?? *Uid+6O     51      $
 NAME??6)   $ * 6P    67   ?? *Name+6P     52      $ STATUS??6)   $
 auto 6T    69   ?? *Status+6T   54      55      ? 56   
   $??2??6   $??0??6   .+?57      ?? $??Product??6   #??[ 6&   $??97,-28,415,82q?6I   ?? 58      $??Status??6   #??[ 6%   $??109,13,419,48q?6H   ?? 59      $
??Code??6   #??[ 6#   $??449,18,74,46q?6F   ?? 5:      -   5         ??Name$ TxtName??5:       ?? TextWrapping$
 Wrap=?6P   $??178,-5,9,86q?6d   ??6'   ?? *
Model.Name+ ?? Mode$ TwoWay=?6d   ?? 5;      -   5         ??Name$ 	ChkStatus??5;      |?. $??176,28,380,46q?6h    d? 	IsChecked 6*   ?? *	IsChecked+$ TwoWay=?6h   ?? 5<      -   5        $ TxtUid??5<      $
 Wrap=?6O   $??505,28,9,52q?6c   ??6&   ?? *	Model.Uid+$ TwoWay=?6c   5=      ? 5>   
   $??1??6   $??3??6   $??1??60    5?      ?? 5@      $??* ?6    ?? 5A      $??* ?6    ?? 5B      $??* ?6    ?? 5C      $??* ?6    ?? 5D      $??* ?6    .+?5F      ?? -   5         ??Name$ 	BtnInsert??5F       
 Insert#??[ 6(   $??2??6j   $??10,10,10,10q?6w   ??6H   ?? *InsertCommand+6w   ?? 5G      -   5        $ 	BtnUpdate??5G       
 Update#??[ 6(   $??1??6j   $??10,10,10,10q?6w   ??6H   ?? *UpdateCommand+6w   ?? 5H      -   5        $ 	BtnDelete??5H       
 Delete#??[ 6(   $??2??6j   $??10,10,10,10q?6w   ??6H   ?? *DeleteCommand+6w   ?? 5I      -   5        $ BtnEdit??5I        Edit#??[ 6&   $??0??6D   $??10,10,10,10q?6h   ?? 5J      -	   5        $ BtnNew??5J        New#??[ 6%   $??0??6B   $??10,10,10,10q?6e   ?? 5K      -
   5        $ BtnReset??5K       	 Reset#??[ 6'   $??3??6F   $??10,10,10,10q?6k   ?? 5L      -   5        $ BtnClose??5L       	 Close#??[ 6'   $??4??6F   $??10,10,10,10q?6k   5M      5N      5O      
   M S B A M L   `   `   `  ????G  CRetailer_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Retailer_App.Views.InventoriesRetailer_App.Views.Inventories  5      4    .Retailer_App.Views.Inventories.InventoriesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Retailer_App.Views.Inventories     5        ? 	Resources  5	       ?? 
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
   ?? 5      $	??15* ?6   ?? 5      $	??10* ?6   ?? 5      $	??75* ?6    ? ColumnDefinitions 5    
   ?? 5!      $	??75* ?6   ?? 5"      $	??25* ?6   .+?5%   
   ? $??0??6   $??2??6   .+?5&      ?? $??DATA INVENTORIES??6   #??[  6/   $??20,0,0,0q?6T   5(      ? 5*   
   $??2??6   $??0??6    5+      ?? 5,      $??9* ?6#   ?? 5-      $	??31* ?6#   .+?5/      &   System.Windows.Controls.DataGrid  -   5          Name$ TblData??5/      $??9,9,9,10q?6(   
???????   HeadersVisibility$ Column=?50         EnableRowVirtualization .  	   CanUserAddRows	 .  
   CanUserDeleteRows
 .     AutoGenerateColumns .     AlternatingRowBackground
 ?????$??2??53   U   ??6   ?? *
Collection+ ?? SelectedItem 66   ?? *Model+   Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$
 CODE??6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ?? *Uid+6O     56      $
 DATE??6)   $ * 6S    67   ?? *	LogDate+6S     57      $
 USER??6)   $ * 6Y    67   ?? *Uid_User.Name+6Y     58      $ PASSWORD??6)      
Visibility$ Hidden=?6W    6;   ?? *	Keypass+6W     59      $
 TYPE??6)   $
 auto 6P    67   ?? *Type+6P     5:      $ STATUS??6)   $
 auto 6T    69   ?? *Status+6T   5<      5=      ? 5>   
   $??1??6   .+?5?      ?? $
??Type??6   #??[ 6#   $??	20,0,0,10q?6F   ?? 5@      -   5         ??Name$
 Tipe??5@      $??80,10,420,10q?6%   .@?5A      ?? $??IN??6   ?? 5B      $	??OUT??6   5C      ?? 5D      $??	Show Date??6   #??[ 6(   $??195,2,311,8q?6K    J? RenderTransformOrigin$ 
0.512,0.04&?6`   (  "System.Windows.Controls.DatePicker  5E      -   5          Name$ Tanggal??5E      $??295,7,191,9q?6\   ?? 5G      $??/??6   #??[ 6    $??407,-9,-7,9q?6C     5H      -   5        $ NextTanggal??5H      $??
431,8,54,0q?6d   $??29??6x   $	??Top=?6?   5I      ? 5J   
   $??1??6   $??0,67,0,0q?6   $??3??61    5K      ?? 5L      $??* ?6    ?? 5M      $??* ?6    ?? 5N      $??* ?6    ?? 5O      $??* ?6    ?? 5P      $??* ?6    .+?5R      ?? -   5         ??Name$ BtnShow??5R        Show#??[ 6&   $??0??6z   $??10,10,10,10q?6?   ??6D   ?? *ShowCommand+6?   ?? 5S      -   5        $ BtnNew??5S        New#??[ 6%   $??1??6B   $??10,10,10,10q?6d   ?? 5T      -   5        $ BtnEdit??5T        Edit#??[ 6&   $??2??6D   $??10,10,10,10q?6g   ?? 5U      -   5        $ BtnReset??5U       	 Reset#??[ 6'   $??3??6F   $??10,10,10,10q?6?   ??6S   ?? *SelectCommand+6?   ?? 5V      -	   5        $ BtnClose??5V       	 Close#??[ 6'   $??4??6F   $??10,10,10,10q?6j   5W      5X      5Y      
   M S B A M L   `   `   `  ????G  CRetailer_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Retailer_App.Views.HomeRetailer_App.Views.Home  5      '    !Retailer_App.Views.Home.UsersView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Retailer_App.Views.Home     5        ? 	Resources  5	       ?? 
TargetType   Title_Label ?? Property ?? Value  	Isi_Label??%  &	        &	 ?     ?? 5
   
   " ??6   .?5      ??  ? ??$ 20(?6)   ?? 5       ? ??$
 Bold"?6+   ?? 5       ? ??$ Bottom=?69   ?? 5       ? ??
 ?   ?6+   ?? 5       ? ??$ 
MADE TOMMY)?6+   5      ?? 5   
   " ??6   .?5      ??  ? ??$ 14(?6)   ?? 5       ? ??$
 Bold"?6+   ?? 5       ? ??$ Bottom=?69   ?? 5       ? ??$ 71??6&   ?? 5       ? ??
 ?   ?6+   ?? 5       ? ??$ 
MADE TOMMY)?6+   5      5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??75* ?6   ?? 5      $	??25* ?6   .+?5   
   ? $??0??6    ? RowDefinitions 5       ?? 5!      $	??15* ?6    ?? 5"      $	??45* ?6    ?? 5#      $	??40* ?6    .+?5%      ?? $??	DATA USER??6   $??0??6(   #??[  65   &   System.Windows.Controls.DataGrid  5'      -   5          Name$ TblData??5'      $??1??6(   
???????$??9,9,9,9q?6H      HeadersVisibility$ Column=?5(         EnableRowVirtualization .  	   CanUserAddRows	 .  
   CanUserDeleteRows
 .     AutoGenerateColumns .     AlternatingRowBackground
 ???????5+      ?? *
Collection+ ?? SelectedItem 66   ?? *Model+   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$
 CODE??6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ?? *Uid+6O     5.      $
 NAME??6)   $ * 6P    67   ?? *Name+6P     5/      $
 USER??6)   $ * 6T    67   ?? *
UserName+6T     50      $ PASSWORD??6)      
Visibility$ Hidden=?6W    6;   ?? *	Keypass+6W     51      $ STATUS??6)   $
 auto 6T    69   ?? *Status+6T   53      ? 54      $??2??6    55      ?? 56      $	??47* ?6'   ?? 57      $
??153* ?6'    59      ?? 5:      $??* ?6$   ?? 5;      $??* ?6$   ?? 5<      $??* ?6$   ?? 5=      $??* ?6$   ?? 5>      $??* ?6$   .+?5@      ?? $
??Name??6   #??[ 6'   $??0??6J   $??0??6Z   $??	54,0,16,0q?6g   ?? 5A      $??UserId??6   #??[ 6)   $??0??6L   $??1??6\   $??	54,0,16,0q?6i   ?? 5B      -   5         ??Name$ LblUid??5B      $
??Code??6(   #??[ 67   $??1??6Z   $??274,32,114,3q?6j   $??2??6?    J? RenderTransformOrigin$ 0.837,0.628&?6?   ?? 5C      $??Password??6   #??[ 6+   $??0??6N   $??2??6^   $??	54,0,16,0q?6k   ?? 5D      $??Status??6   #??[ 6)   $??0??6L   $??3??6\   $??	54,0,16,0q?6i   ?? 5F      -   5         ??Name$ TxtName??5F       ?? TextWrapping$
 Wrap=?6T   $??1??6h   $??0??6x   $??0,5,0,5q?6?   ??6+   ?? *
Model.Name+ ?? Mode$ TwoWay=?6?   ?? 5G      -   5        $ TxtUid??5G      $
 Wrap=?6R   $??1??6f   $??1??6v   $??	330,5,0,0q?6?   $??26??6?   $	??Top=?6?   ??6*   ?? *	Model.Uid+$ TwoWay=?6?   ?? 5H      -   5        $ TxtUser??5H      $
 Wrap=?6X   $??1??6l   $??1??6|   $??	0,5,200,5q?6?   ??6+   ?? *Model.UserName+$ TwoWay=?6?   ?? 5I      -   5        $ TxtPassword??5I      $
 Wrap=?6[   $??1??6o   $??2??6   $??0,5,0,5q?6?   ??6/   ?? *Model.Keypass+$ TwoWay=?6?   ?? 5J      -   5         ??Name$ 	ChkStatus??5J      |?. $??1??6l   $??3??6|   $??	0,11,0,30q?6?   $??2??6?    d? 	IsChecked 6.   ?? *	IsChecked+$ TwoWay=?6?   5K      5L      ? 5M   
   $??1??6    5N      ?? 5O      $	??15* ?6    ?? 5P      $	??85* ?6    .+?5R      ? $??1??6    5S      ?? 5T      $??* ?6$   ?? 5U      $??20 ?6$   ?? 5V      $??* ?6$   ?? 5W      $??20 ?6$   ?? 5X      $??* ?6$   ?? 5Y      $??20 ?6$   ?? 5Z      $??* ?6$   ?? 5[      $??20 ?6$   ?? 5\      $??* ?6$   .+?5^      ?? -   5         ??Name$ 	BtnInsert??5^       
 Insert#??[ 6,   $??6??6n   $??	15,0,15,0q?6{   ??6L   ?? *InsertCommand+6{   ?? 5_      -	   5        $ 	BtnDelete??5_       
 Delete#??[ 6,   $??0??6n   $??	15,0,15,0q?6{   ??6L   ?? *DeleteCommand+6{   ?? 5`      -
   5        $ 	BtnUpdate??5`       
 Update#??[ 6,   $??2??6n   $??	15,0,15,0q?6{   ??6L   ?? *UpdateCommand+6{   ?? 5a      -   5        $ BtnEdit??5a        Edit#??[ 6*   $??2??6_   $??	15,0,15,0q?6l   ?? 5b      -   5        $ BtnNew??5b        New#??[ 6)   $??0??6\   $??	15,0,15,0q?6i   ?? 5c      -   5        $ BtnMenu??5c        Menu#??[ 6*   $??6??6_   $??	15,0,15,0q?6l   ?? 5d      -   5        $ BtnReset??5d       	 Reset#??[ 6+   $??4??6b   $??	15,0,15,0q?6o   ?? 5e      -   5        $ BtnClose??5e       		 Close#??[	 6+   $??8??6c   $??15,-10,15,10q?6p   5f      5g      5h      5i      
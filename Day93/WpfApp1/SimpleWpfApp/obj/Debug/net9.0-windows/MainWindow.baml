   M S B A M L   `   `   `  ����G  CSimpleWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SimpleWpfAppSimpleWpfApp  5      A%clr-namespace:SimpleWpfApp.ViewModelsSimpleWpfApp.ViewModels  5      E'clr-namespace:SimpleWpfApp.UserControlsSimpleWpfApp.UserControls  5	          SimpleWpfApp.MainWindow   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:SimpleWpfApp     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      <
viewmodels%clr-namespace:SimpleWpfApp.ViewModels     5      9views'clr-namespace:SimpleWpfApp.UserControls     5	        � Title$  
MainWindow��5
      $	��500��5      $	��450��5       � DataContext 5      $   SimpleWpfApp.ViewModels.MainVM  5   
   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   7   1SimpleWpfApp.UserControls.FillUserDataUserControl  $��0��6(   1   +SimpleWpfApp.UserControls.ButtonUserControl  5   
   $��1��6"   &   System.Windows.Controls.DataGrid  5!   
   $��2��5"      $��0,10,0,0q�5#         AutoGenerateColumns$ False��5$         
IsReadOnly$
 True��5%      ��5&      �� *Users+   Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5)         Header$
 Name��5+      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5*      �� *Name+5+        5,      $ 2* 5-      $ Description��5/       5.      �� *Description+5/      4	  .System.Windows.Controls.DataGridCheckBoxColumn	  50      $ * 51      $ 	Is Active��53       52      �� *
IsActive+53      55      56      58      
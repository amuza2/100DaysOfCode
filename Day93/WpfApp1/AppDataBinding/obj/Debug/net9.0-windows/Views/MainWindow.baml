   M S B A M L   `   `   `  ����I  EAppDataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:AppDataBindingAppDataBinding  5          AppDataBinding.MainWindow   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:AppDataBinding     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��800��5	      $	��450��5
      .��5      � $��30q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $	��150��5      $��30��5      $��10q�5      $
��left=�5      $��Center=�5      $��16(�5      ��5      �� *
SearchUser+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��0��5      $	��150��5      $��30��5      $��10q�5      $��Right=�5       $��Center=�5!      $��0q�5"      $��
+ Add User��5$      $��16(�5%      ��5#      �� *AddUserCommand+5%      &   System.Windows.Controls.DataGrid  5&   
   $��1��5'      $��10q�5(      $��Stretch=�5)      $��Center=�5*         AutoGenerateColumns$ False��5+         CanUserAddRows$ False��5,         CanUserReorderColumns$ False��5-         CanUserSortColumns$
 True��5.      ��5/      �� *	UserItems+ � ContextMenu 50      �� 51      .@�52      m� $��
Click Here��6B   	 m� Command	 6   �� *AddUserCommand+6B   53      
   Columns
 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 57         Header$ ID��59      1  +System.Windows.Controls.DataGridBoundColumn   Binding 58      �� *Id+59        5:      $ * 5;      $
 Name��5=       5<      �� *Name+5=        5>      $ * 5?      $ Email��5A       5@      �� *Email+5A      5C      5D      5E      
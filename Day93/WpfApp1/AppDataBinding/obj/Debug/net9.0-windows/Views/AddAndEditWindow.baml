   M S B A M L   `   `   `  ����I  EAppDataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AppDataBinding.ViewsAppDataBinding.Views  5      +    %AppDataBinding.Views.AddAndEditWindow   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:AppDataBinding.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  AddAndEditWindow��5      $	��300��5	      $	��350��5
       � 	Resources 5         ValidationErrorTemplate ��Name��%�   &	        �� 5   
   .R�5      �� .+�5      �� $ textBox��6,   �� 5      
���  ����6-   �� *[0].ErrorContent+5      5      5      .��5      �� $��30q�5   	   $��Center=�5   	    �� Orientation$ Vertical=�5   	   .+�5'   
   �� $��20,10q�6   .+�5(      �� $��0,0,0,8q�5)      ���#97a5b4$��
Enter Name��5+      � 5-      .+�5.      �� $
��13,0q�5/      $��Center=�50       K� ZIndex$ 1��51      ���#868686 J� IsHitTestVisible$ False��53      $��
Enter Name��54      y�55      ��  �� ElementName$ txbName�� �� Path$ Text.IsEmpty�  	BoolToVis �� 	Converter# [ �� 57      -   5        	 ��Name$	 txbName��58      
 =� ErrorTemplate#
 [  5:      ��59      �� *Name+ �� Mode$ TwoWay=�" �� ValidatesOnNotifyDataErrors$
 True�� �� UpdateSourceTrigger$ PropertyChanged=�5:      5;      5<      �� 5?   
   $��
10,10,10,0q�6   $��Email��6$   �� 5@   
   $	��150��5A      $��	10,0,0,20q�5B      $
��Left=�5C      #
 [  5E      ��5D      �� *Email+$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��5E      �� 5G   
   $	��150��5H      $��10q�5I      $
��Left=�5J      $��0q�5K      $��+ Add��5M      ��5L      �� *AddUserCommand+5M      5O      5P      
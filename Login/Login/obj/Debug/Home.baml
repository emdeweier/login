   M S B A M L   `   `   `  ����@  <Login, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LoginLogin  5   	       
Login.Home   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Login     5   	     � Title$
  Home��5   	   $	��400��6   $	��800��6#    � WindowStyle$
 None=�6/    � 
ResizeMode$ NoResize=�6B   .��5	      � ���	#FFBDCEC4.+�5
   
   �� ���	#FF2a2b20$��Center=�6%   $��50��6B   $��0,0,0,0q�6N   $	��Top=�6_   $	��800��6w   ���	#FF2A2b206�   �� 5   
   ���	#FF9EC5A3$
��Left=�6%   $	��350��6@   $��0,50,0,0q�6M   $	��Top=�6_   $	��170��6w   ���	#FF9EC5A36�   �� 5   
   -   5        $��
BTN_Logout��5   "   $��LOGOUT��6   $��Center=�64   $��680,10,10,360q�6Q   
�������$��Center=�6{   $	��110��6�   $��30��6�   $��16(�6�   ��6�   Z� ��6�   Z� �� 5   
   -   5        $��BTN_Home��5       $
��HOME��6   $
��Left=�60   $��
10,0,0,100q�6K   $��Center=�6_   $	��145��6z   $��25��6�   ���	#FF3B3C20
���������6�   Z� 6�   �� 5   
   -   5        $��BTN_Profile��5   #   $��PROFILE��6   $
��Left=�66   $��	10,0,0,40q�6Q   $��Center=�6d   $	��145��6   $��25��6�   ���	#FF3B3C20
���������6�   Z� 6�   �� 5   
   -   5        $��BTN_Add_Data��5   $   $��ADD DATA��6   $
��Left=�6S   $��	10,20,0,0q�6n   $��Center=�6�   $	��145��6�   $��25��6�   ���	#FF3B3C20
���������6�   Z� 6�   �� 5   
   -   5        $��
BTN_MngBch��5   +   $��MANAGE BACHELOR��6   $
��Left=�6=   $��	10,80,0,0q�6X   $��Center=�6k   $	��145��6�   $��25��6�   ���	#FF3B3C20
���������6�   Z� 6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DataGrid��5     $��Center=�6   $	��280��60   $��
185,5,15,0q�6=      AutoGenerateColumns .  $��Center=�6�   $	��600��6�   $��Center=�6�   
 J� Uid$ 	DataGrid1��6     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6J     5      $
 Name��6%    63   �� *Name+6N     5      $ 
Department��6%    69   �� *DepartmentName+6^     5      $ Major��6%    64   �� *
MajorsName+6U     5      $	 Job��6%    62   �� *	JobName+6P     5      $ Address��6%    66   �� *	Address+6T     5      $ Email��6%    64   �� *Email+6P     5      $ Bachelor��6%    67   �� *BachelorName+6Z   5      �� 5   
   -   5         ��Name$ 
BTN_Delete��5   "   $��DELETE��6   $��Center=�6[   $��Center=�6x   $	��145��6�   $��24��6�   ���	#FF3B3C20
�������$��600,355,55,25q�6  	 �� SourceUpdated	 66   �� *Id+��6�   Z� 6  �� 5   
   $��Center=�6   $��
50,375,0,0q�61   $
��Wrap=�6E   $ ��Developed by #bapaknyajono��6Y   $��Center=�6{   $��10(�6�   $��Medium"�6�   �� 5   
   -   5        $��Username��5   9   $
��Left=�6   $��25��6-   $��	15,65,0,0q�6I   
 �� TextWrapping$

 Wrap=�6\   $	��Top=�6p   $	��140��6�   ��6�   Z� ��6�   Z� 5!      5"      
   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    
Checkpoint   Checkpoint.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � 
ResizeMode$  CanMinimize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	   $��1q�5
   	   ���	#FF086F9E � Title$% Пропускной пункт��5   	   $	��520��6"   $	��700��6/   .��5      � .+�5   
   � -   5         �Name$ AuthGrid��5      $y�Visible=�6!   .+�5      �� -   5         ��Name$ loginBox��5      $	��Top=�5      $��227,174,225,0q�5      $	��240��5      $��40��5      *   $MahApps.Metro.Controls.TextBoxHelper   IsWaitingForData .    UseFloatingWatermark .    	Watermark$ 
Логин��5         LoginTextBox#��[  5         ClearTextButton 5      �� 	 �� RelativeSource	 �� *Self+
 �� Path$&
  (Controls:TextBoxHelper.HasText)� �� Mode$ OneWay=�.��5   7   5      G� 5      -   5         G�Name$ passwordBox��5      $	��Top=�5      $��227,224,225,0q�5      $	��240��5      $��40��5       .  . $ Пароль��5"       " MetroButtonRevealedPasswordBox#��[ 5#       5      �� 	 �� *Self+$&
  (Controls:TextBoxHelper.HasText)�$ OneWay=�5#      �� 5$      -   5        $��ВХОД��5$      $��35��6$   $��226,274,224,0q�60   $	��242��6G   $	��Top=�6S   6k   5%      � 5&   
   -   5        $ MainGrid��5&      $y�Hidden=�6!   .+�5'      �� -   5         ��Name$ 
tabControl��5'      $	��490��6-   $	��Top=�6:   $��0,2,0,0q�6R   -   'MahApps.Metro.Controls.TabControlHelper   IsUnderlined . $
��Left=�6�   $	��692��6�      
Underlined$ SelectedTabItem=�6�   .@�5(      �� -   5         ��Name$ 	employees��5(      $��Работники��6-   
�������$��0,0,0,0q�6S   .��5)      � $��0,0,0,0q�6   $	��442��6,   $	��Top=�69   
�������.+�5*      &   System.Windows.Controls.DataGrid  -   5          Name$ employeesGrid��5*   #      
IsReadOnly .    SelectionMode$ Single=�6L      GridLinesVisibility$	 All=�6c   $��0,0,-7,0q�6}   $	��380��6�   $	��Top=�6�   �� 5+      -	   5        $��
Поиск��5+   !   $
��Left=�61   $��
10,391,0,0q�6L   $	��Top=�6`   $	��150��6x   $��35��6�   6�   �� 5,      -
   5        $��
Выбор��5,   !   $��Center=�61   $��0,391,175,0q�6N   $	��Top=�6c   $	��150��6{   $��35��6�   6�   �� 5-      -   5        $��Обновить��5-   !   $��Center=�64   $��220,391,50,0q�6Q   $	��Top=�6g   $	��150��6   $��35��6�   6�   �� 5.      -   5        $��Добавить��5.   !   $��Right=�64   $��
0,391,10,0q�6P   $	��Top=�6d   $	��150��6|   $��35��6�   6�   5/      50      �� 51      -   5        $ report��51      $��
Отчет��6*   
�������$��0,0,0,0q�6L   .��52      � $��0,0,0,0q�6   $	��442��6,   $	��Top=�69   
�������.+�53        -   5        $ reportsGrid��53   #    . $ Single=�6J   $	 All=�6a   $	��380��6{   $	��Top=�54      $��
-3,-3,-3,0q�65   $��Stretch=�6I   $��Stretch=�6g      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   �� 55      -   5        $)��#Зафиксировать вход��55   !   $
��Left=�6>   $��
50,391,0,0q�6Y   $	��Top=�6m   $	��176��6�   $��35��6�   6�   �� 56      -   5        $+��%Зафиксировать выход��56   !   $��Center=�6?   $��	0,391,0,0q�6\   $	��Top=�6o   $	��176��6�   $��35��6�   6�   �� 57      -   5        $��
Поиск��57   !   $��Right=�61   $��
0,391,50,0q�6M   $	��Top=�6a   $	��176��6y   $��35��6�   6�   58      59      �� 5:      -   5        $ reportsOfAllEmployees��5:      $��Все отчеты��69   
�������$��0,0,0,0q�6`   .��5;      � $��0,0,0,0q�6   $	��442��6,   $	��Top=�69   
�������.+�5<        -   5        $ allReportsGrid��5<   #    . $ Single=�6M   $	 All=�6d   $	��380��6~   $	��Top=�5=      $��
-3,-3,-3,0q�65   $��Stretch=�6I   $��Stretch=�6g   $ * 6�   �� 5>      -   5        $��
Поиск��5>   !   $��Center=�61   $��	0,391,0,0q�6N   $	��Top=�6a   $	��176��6y   $��35��6�   6�   5?      5@      5A      5B      5C      5D      
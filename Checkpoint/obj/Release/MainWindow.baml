   M S B A M L   `   `   `  ���� U  QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   
Checkpoint   Checkpoint.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro       � 
ResizeMode$  CanMinimize=� � WindowStartupLocation$ CenterScreen=�$��1q����	#FF086F9E � Title$% Пропускной пункт��$	��520��$	��700��.��� .+�� -    �Name$ AuthGrid��$y�Visible=�.+��� -    ��Name$ loginBox��$	��Top=�$��227,174,225,0q�$	��240��$��40��*   $MahApps.Metro.Controls.TextBoxHelper   IsWaitingForData .    UseFloatingWatermark .    	Watermark$ 
Логин��   LoginTextBox#��[     ClearTextButton �� 	 �� RelativeSource	 �� *Self+
 �� Path$&
  (Controls:TextBoxHelper.HasText)� �� Mode$ OneWay=�.��G� -    G�Name$ passwordBox��$	��Top=�$��227,224,225,0q�$	��240��$��40�� .  . $ Пароль�� " MetroButtonRevealedPasswordBox#��[  �� 	 �� *Self+$&
  (Controls:TextBoxHelper.HasText)�$ OneWay=��� -   $��ВХОД��$��35��$��226,274,224,0q�$	��242��$	��Top=�� -   $ MainGrid��$y�Hidden=�.+��� -    ��Name$ 
tabControl��$	��490��$	��Top=�$��0,2,0,0q�-   'MahApps.Metro.Controls.TabControlHelper   IsUnderlined . $
��Left=�$	��692��   
Underlined$ SelectedTabItem=�.@��� -    ��Name$ 	employees��$��Работники��
�������$��0,0,0,0q�.��� $��0,0,0,0q�$	��442��$	��Top=�
�������.+�&   System.Windows.Controls.DataGrid  -     Name$ employeesGrid��   
IsReadOnly .    SelectionMode$ Single=�   GridLinesVisibility$	 All=�$��0,0,-7,0q�$	��380��$	��Top=��� -	   $��
Поиск��$
��Left=�$��
10,391,0,0q�$	��Top=�$	��150��$��35���� -
   $��
Выбор��$��Center=�$��0,391,175,0q�$	��Top=�$	��150��$��35���� -   $��Обновить��$��Center=�$��220,391,50,0q�$	��Top=�$	��150��$��35���� -   $��Добавить��$��Right=�$��
0,391,10,0q�$	��Top=�$	��150��$��35���� -   $ report��$��
Отчет��
�������$��0,0,0,0q�.��� $��0,0,0,0q�$	��442��$	��Top=�
�������.+�  -   $ reportsGrid�� . $ Single=�$	 All=�$	��380��$	��Top=�$��
-3,-3,-3,0q�$��Stretch=�$��Stretch=�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * �� -   $)��#Зафиксировать вход��$
��Left=�$��
50,391,0,0q�$	��Top=�$	��176��$��35���� -   $+��%Зафиксировать выход��$��Center=�$��	0,391,0,0q�$	��Top=�$	��176��$��35���� -   $��
Поиск��$��Right=�$��
0,391,50,0q�$	��Top=�$	��176��$��35���� -   $ reportsOfAllEmployees��$��Все отчеты��
�������$��0,0,0,0q�.��� $��0,0,0,0q�$	��442��$	��Top=�
�������.+�  -   $ allReportsGrid�� . $ Single=�$	 All=�$	��380��$	��Top=�$��
-3,-3,-3,0q�$��Stretch=�$��Stretch=�$ * �� -   $��
Поиск��$��Center=�$��	0,391,0,0q�$	��Top=�$	��176��$��35��
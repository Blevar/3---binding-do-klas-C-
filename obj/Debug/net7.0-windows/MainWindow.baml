   M S B A M L   `   `   `  ����N  J3 - binding do klas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:_3___binding_do_klas_C__3___binding_do_klas_C_  5   	   (    "_3___binding_do_klas_C_.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:_3___binding_do_klas_C_     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��510��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $
��100* �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��100* �6   .+�5   
   �� -   5         ��Name$ DodajBtn��5      $��Dodaj��5      $��0��5      $��0��5      5      �� 5   
   -   5        $��Edytuj��5      $��0��5      $��1��5      5       �� 5!   
   -   5        $��Usuń��5!      $��0��5"      $��2��5#      5$      �� 5%   
   -   5        $��Importuj��5%      $��0��5&      $��3��5'      5(      �� 5)   
   -   5        $��	Eksportuj��5)      $��0��5*      $��4��5+      5,      �� 5/   
   -   5         ��Name$ ListaFilmow��5/      $��1��50      $��0��51      $��5��52      ��53      �� *Filmy+��54      �� 55      .R�56      � .+�57      �� $
��Bold"�6;   ��6$   �� *Tytul+6;   �� 58      $��, ��6$   �� 59      ��6$   �� *	Rezyser+�� 5:      $��, ��6$   �� 5;      ��6$   �� *Studio+�� 5<      $��, ��6$   �� 5=      ��6$   �� *Nosnik+�� 5>      $��, ��6$   �� 5?      ��6$   �� *DataWydania+ �� StringFormat$ {0:dd.MM.yyyy}��5@      5A      5C      5E      5F      
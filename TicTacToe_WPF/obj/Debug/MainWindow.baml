   M S B A M L   `   `   `  ����H  DTicTacToe_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TicTacToe_WPFTicTacToe_WPF  5   	       TicTacToe_WPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TicTacToe_WPF     5   	     � Title$#  Крестики-Нолики��5   	   $	��300��6!   $	��250��6.    � WindowStartupLocation$ CenterScreen=�6:    � WindowStyle$ 
ToolWindow=�6_   
�������.��5	      � -   5         �Name$ 
GameFields��5	       � ShowGridLines .   � RowDefinitions 5
   
   �� 5      $
��0.5* �6   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ 
textFields��5      $��0��6(   $��0��68   $��3��6E   �� 5   
   -   5         ��Name$	 one��5      $��0��6   $��1��6.   $��3q�6<   $��36(�6G   $
��Bold"�6U   �� 5   
   -   5        $	 two��5      $��1��6   $��1��6.   $��3q�6<   $��36(�6G   $
��Bold"�6U   �� 5   
   -   5        $ three��5      $��2��6    $��1��60   $��3q�6>   $��36(�6I   $
��Bold"�6W   �� 5   
   -   5        $
 four��5      $��0��6   $��2��6/   $��3q�6=   $��36(�6H   $
��Bold"�6V   �� 5   
   -   5        $
 five��5      $��1��6   $��2��6/   $��3q�6=   $��36(�6H   $
��Bold"�6V   �� 5   
   -   5        $	 six��5      $��2��6   $��2��6.   $��3q�6<   $��36(�6G   $
��Bold"�6U   �� 5   
   -	   5        $ seven��5      $��0��6    $��3��60   $��3q�6>   $��36(�6I   $
��Bold"�6W   �� 5   
   -
   5        $ eight��5      $��1��6    $��3��60   $��3q�6>   $��36(�6I   $
��Bold"�6W   �� 5   
   -   5        $
 nine��5      $��2��6   $��3��6/   $��3q�6=   $��36(�6H   $
��Bold"�6V   5      5       
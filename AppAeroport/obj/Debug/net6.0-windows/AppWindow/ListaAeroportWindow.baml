   M S B A M L   `   `   `  ����F  BAppAeroport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AppAeroport.AppWindowAppAeroport.AppWindow  5   	   /    )AppAeroport.AppWindow.ListaAeroportWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:AppAeroport.AppWindow     5   	     � Title$  ListaAeroportWindow��5   	   $	��450��6%   $	��750��62   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
���   �.+�5      �� $��Lista rutelor��6   $��20(�6-   $��Center=�6;   
�������$
��Bold"�6k   5      �� 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgRute��5         AutoGenerateColumns$ False��6'   $��10q�6C   $��20(�6O      
IsReadOnly$ False��6]   ��6p   �� *Aeroporturi+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Destinatia��6)      MinWidth$	 150Q�6\   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *
Destinatia+6\     5      $ Clasa��6)   $ 80Q�6R   	 68   �� *Clasa+6R     5      $
 Pret��6)   $ 80Q�6P   	 67   �� *Pret+6P     5      $ Nume pasager��6)   $	 150Q�6g   	 6?   �� *Pasager.NumePasager+6g     5      $ Prenume pasager��6)   $	 150Q�6m   	 6B   �� *Pasager.PrenumePasager+6m   
 � ContextMenu
 5       �� 5!      .@�5"      m� -   5        $��Editare��5"   #   64   m� 5#      -   5        $��Stergere��5#   #   65   5$      5&      5'      5(      5)      
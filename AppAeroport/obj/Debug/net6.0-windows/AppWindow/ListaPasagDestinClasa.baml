   M S B A M L   `   `   `  ����F  BAppAeroport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AppAeroport.AppWindowAppAeroport.AppWindow  5   	   1    +AppAeroport.AppWindow.ListaPasagDestinClasa   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:AppAeroport.AppWindow     5   	     � Title$  ListaPasagDestinClasa��5   	   $	��450��6'   $	��600��64   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
���   �.+�5      �� $<��6Lista pasageriilor cu destinatia spre Paris la clasa 1��6   $��20(�6V   $
��Bold"�6d   
�������$��Center=�5   +   5      �� 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgListaPasagDestinClasa��5         AutoGenerateColumns$ False��68   $��20(�5      $��10q�6%      
IsReadOnly$ False��61      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nume��6)      MinWidth$	 120Q�6_   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� *Pasager.NumePasager+6_     5      $ Prenume��6)   $	 120Q�6e   	 6:   �� *Pasager.PrenumePasager+6e     5      $ 
Destinatia��6)   $	 200Q�6\   	 6=   �� *
Destinatia+6\     5      $ Clasa��6)   $	 120Q�6R   	 68   �� *Clasa+6R   5!      5"      5#      5$      
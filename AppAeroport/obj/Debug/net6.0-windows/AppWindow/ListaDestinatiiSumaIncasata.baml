   M S B A M L   `   `   `  ����F  BAppAeroport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AppAeroport.AppWindowAppAeroport.AppWindow  5   	   7    1AppAeroport.AppWindow.ListaDestinatiiSumaIncasata   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:AppAeroport.AppWindow     5   	     � Title$!  ListaDestinatiiSumaIncasata��5   	   $	��450��6-   $	��500��6:   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
���   �.+�5      �� $9��3Lista destinatiilor si suma incasata de la pasageri��6   $��20(�6S   $
��Bold"�6a   
�������$��Center=�5   +   5      �� 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$# dgListaDestinatiiSumaIncasata��5         AutoGenerateColumns$ False��6>   $��20(�5      $��10q�6%      
IsReadOnly$ False��61      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Destinatia��6)      MinWidth$	 250Q�6\   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *
Destinatie+6\     5      $
 Suma��6)   $	 200Q�6P   	 67   �� *Suma+6P   5      5       5!      5"      
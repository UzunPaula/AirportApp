   M S B A M L   `   `   `  ����F  BAppAeroport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AppAeroportAppAeroport  5   	       AppAeroport.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AppAeroport     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��850��6)    � WindowStartupLocation$ CenterScreen=�65    � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%�  '��       �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   �� 5       � ��$ 16(�6)   �� 5       � ��$ 7q�6(   �� 5       � ��
 �   �6+   �� 5       � ��$
 Bold"�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 10��6!   #��z��63   ._�5      �� $��Center=�6/   $��Center=�6L   #��z��6g   5      5      5      5      5      .��5      ]� .+�5   
   �� $	��Top=�6    �� Orientation$ Vertical=�6*   
���   �.+�5      �� $��Aplicatia Aeroport��6   $
��Bold"�62   $��30(�6D   	 �� TextAlignment$	 Center=�6R   
�������$��10q�6|   5       �� 5!   
   $
��Left=�6   $ Vertical=�6+   $	��290��6B   
���   �.+�5"      �� -   5        
 ��Name$
 btnShowAddPasager��5"   5   $��Introduceti pasagerul��6   ��6P   �� *AddCommandPasager+6v   �� 5#      -   5        $
 btnShowListaPasageri��5#   .   $��Lista pasageri��6   ��6L   �� *ShowListaPasageri+6r   �� 5$      -   5        $
 btnShowAddRuta��5$   0   $��Introduceti ruta��6   ��6H   �� *AddCommandRuta+6k   �� 5%      -   5        $
 btnShowListaRute��5%   -   $��Lista rutelor��6   ��6G   �� *ShowListaRute+6i   �� 5'      -   5        $
 btnShowPasagDestClas��5'      ��63   �� *ShowListaPasagDestClas+.��5(      �� $
��Wrap=�6   $3��-Pasagerii cu destinatia spre Paris si clasa 1��60   $	 Center=�6e   5)      �� 5+      -   5        $%
 btnListaPasageriDestPretBetween��5+      ��6>   �� *ShowPasageriDestPretBetween+.��5,      �� $
��Wrap=�6   $3��-Destinatiile cu pretul intre 800 si 1200 euro��60   $	 Center=�6e   5-      �� 5/      -   5        $!
 btnListaDestinSumIncasatPas��5/      ��6:   �� *ShowDestinSumIncasatPas+.��50      �� $
��Wrap=�6   $>��8Destinatiile disponibile si suma incasata de la pasageri��60   $	 Center=�6p   51      53      �� 55   
   $��Bottom=�6   $ 
Horizontal=�6-   $	��560��6F   $��20��6R   
���   �.+�56      �� $��Subsol��6   $	 Center=�6&   $��	270 0 0 0q�6=   $
��Bold"�6P   
�������6b   57      �� 58   
   .+�59      �� $��Resources/aeroport.jpeg��6   $��UniformToFill=�65   $	��505��6M   $	��561��6Z   5:      5;      5<      
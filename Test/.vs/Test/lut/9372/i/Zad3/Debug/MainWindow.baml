   M S B A M L   `   `   `  ����?  ;Zad3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Zad3Zad3  5   	       Zad3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Zad3     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5   	   ��  �� Path$
 Main�   Locator �� Source# [  .��5
      � .+�5   
   �� $��<��5      $
��Left=�5      $��
220,10,0,0q�5      $	��Top=�5      $��75��5      $	��315��6   ��5      �� *MoveLeftCommand+5      �� 5   
   $��>��5      $
��Left=�5      $��
707,10,0,0q�5      $	��Top=�5      $��75��5      $	��315��6   ��5      �� *MoveRightCommand+5      �� 5   
   $	��Id:��6   $
��Left=�6   $��	10,26,0,0q�69   $	��Top=�6L   �� 5   
   $��Name:��6   $
��Left=�6    $��	10,68,0,0q�6;   $	��Top=�6N    J� RenderTransformOrigin$ 
0.49,2.855&�5      �� 5   
   $
��Left=�5      $��	62,26,0,0q�5      $	��Top=�5       ��5      �� *CurrentSelectedCatalogItem.Id+5       �� 5!   
   $
��Left=�5#      $��	62,68,0,0q�5$      $	��Top=�5%      $ 
0.49,2.855&�5&      ��5"      �� *!CurrentSelectedCatalogItem.Name+5&      �� 5'   
   $
��Left=�6   $��79��6.   $��
10,330,0,0q�6:   $	��Top=�6N   $	��772��6f   ��5(      �� *BasketItems+��5)      �� 5*      .R�5+      ��  �� Orientation$ Vertical=�6!   $��Stretch=�68   .+�5,      �� $��Center=�67   $��Bottom=�6T   ��6    �� *Id+6T   �� 5-      $��Center=�69   $��Bottom=�6V   ��6    �� *Name+6V   5.      5/      ��51      �� 52      .R�53      �� $ 
Horizontal=�6!   54      56      �� 57   
   $��Add item to basket��5:      $
��Left=�5;      $��393,288,0,0q�5<      $	��Top=�5=      $	��202��5>      $��37��6   ��58      �� *AddItemToBasketCommand+{�59      �� *IsItemInBasket+5>      � 5?   
   $
��Left=�6   $	��273��5@      $��
309,10,0,0q�5A      $	��Top=�5B      $	��382��6'   y�5C      �� *IsCarGridVisible+.+�5D      �� $
��Type��6   $
��Left=�6#   $��113,196,0,0q�6>   $	��Top=�6S   �� 5E      $��Color��6   $
��Left=�6$   $��113,227,0,0q�6?   $	��Top=�6T   �� 5F      -   5         ��Name$ lblType��5F      $
��Left=�6Y   $��177,196,0,0q�5G      $	��Top=�6)   ��5F   %   �� *!CurrentSelectedCatalogItem.Type+5G   )   �� 5H      -   5        $ lblColor��5H      $
��Left=�6[   $��177,227,0,0q�5I      $	��Top=�6)   $ 2.161,0.443&�6A   ��5H   &   �� *" CurrentSelectedCatalogItem.Color+5I   A   5J      � 5K   
   $
��Left=�5L      $	��278��5M      $��	309,5,0,0q�6   $	��Top=�5N      $	��382��6%   y�5O      �� *IsHouseGridVisible+.+�5P      �� $��Number of floors:��6   $
��Left=�60   $��118,234,0,0q�6K   $	��Top=�6`   �� 5Q      -   5        $ lblNumberOfFloors��5Q      $
��Left=�5R      $��244,234,0,0q�6/   $	��Top=�6D   $ 2.161,0.443&�5S      ��5Q   /   �� *+)CurrentSelectedCatalogItem.NumberOfFloors+5S      �� 5T      -   5         ��Name$ chkIsFlatRoof��5T      $��Is roof floor��5U      $
��Left=�6/   $��118,204,0,0q�6J   $	��Top=�6_   $	��138��5V       d� 	IsChecked 5T   .   �� *'%CurrentSelectedCatalogItem.IsFlatRoof+5V      5W      � 5X   
   $
��Left=�6   $	��273��5Y      $��
309,10,0,0q�5Z      $	��Top=�5[      $	��393��5\      y�6   �� *IsPersonGridVisible+.+�5]      �� $	��Age��6   $
��Left=�6"   $��111,197,0,0q�6=   $	��Top=�6R   �� 5^      $��Address��6   $
��Left=�6&   $��111,228,0,0q�6A   $	��Top=�6V   �� 5_      -   5        $ lblAge��5_      $
��Left=�6W   $��175,197,0,0q�5`      $	��Top=�6)   ��5_   $   �� * CurrentSelectedCatalogItem.Age+5`   )   �� 5a      -   5        $ 
lblAddress��5a      $
��Left=�5b      $��175,228,0,0q�6/   $	��Top=�6D   $ 2.161,0.443&�5c      ��5a   (   �� *$"CurrentSelectedCatalogItem.Address+5c      5e      5f      5g      
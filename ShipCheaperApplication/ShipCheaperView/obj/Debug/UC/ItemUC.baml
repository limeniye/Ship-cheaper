   M S B A M L   `   `   `  ����D  @ViewModel, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:ViewModel;assembly=ViewModel	ViewModel  5       ShipCheaperView   ShipCheaperView.UC.ItemUC   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9vm*clr-namespace:ViewModel;assembly=ViewModel     5      -   5        $��uc��5   7     � 	Resources  5	         ViewModel.ImageAsync 	  image��%   &	          5
   
   6   5      .��5      � $
��Auto��6   .+�5   
   �� $
��Auto��6     ItemMovieStyle#��[ 6!   � 5   
    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      �� $
��Left=�6   ._�5      �� -   5         ��Name$	 img��5      $��10q�5      $	��200��6$   $	��200��60   $
��Left=�6=   ��5   %   �� *Image+ �� Mode$ OneWay=� �� Source# [  5   =   5      � 5      $��1��6   .+�5      �� .+�5      ��  	 Titel#��[ 6L   $��10q�6k   $��Center=�6w   $	��Top=�6�   ��6    ��  �� ElementName$ uc�� �� Path$ Title�6�   �� 5       �� Orientation$ 
Horizontal=�6!   .+�5      �� $��Genre:��6$     Property#��[ 62   �� 5      $��4,0,0,0q�6$    	 Value#��[ 5    $   ��5   $   �� $ uc��$ Genre�5    $   5!      �� 5$      $ 
Horizontal=�6!   .+�5%      �� $��Runtime:��6$   #��[ 64   �� 5&      $��4,0,0,0q�6$   #��[ 5(   $   ��5'   $   �� $ uc��$ Runtime�5(   $   5)      �� 5,      $ 
Horizontal=�6!   .+�5-      �� $��Year:��6$   #��[ 61   �� 5.      $��4,0,0,0q�6$   #��[ 50   $   ��5/   $   �� $ uc��$
 Year�50   $   51      �� 54      $��0,10,0,0q�6      Content#��[ 55       $
��Wrap=�56       ��57       �� $ uc��$ Writer�58      �� 59        AddToFavorite#��[ 6   $��10q�6@   $��Right=�6L   $��Bottom=�6h   5:      5>      5?      5@      
   M S B A M L   `   `   `  ����B  >Results, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   9        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ,myclr-namespace:WpfApplication1     5   9   -   5          � Title$  PlayerDatabase��5   	   $	��358��6    $	��697��6-   
�����F� � 	Resources 5      '   !WpfApplication1.PlayerInfoDataSet   PlayerInfoDataSet  total_ResultsViewSource �� Source �� Path �� Source��%`   &	        &	      7     5   
   6   �� 5   
    6?   �� $ Total_Results�8   5      .��5	      � 
�����F� � DataContext# [ 6"   $	��435��6Y   $	��666��6f   .+�5
   
   �� -   5        $��button1��5
   \   $
��Home��6   $��23��6    $
��Left=�6,   $��196,287,0,0q�6G   $	��Top=�6k   $	��100��6�   6�   �� 5   
   -   5        $��gridSplitter1��5   T   $	��100��6   $
��Left=�6$   $��226,106,0,0q�6?   $	��Top=�6i   $��10��6�    6�   �� $ LayoutTransform�&   System.Windows.Controls.DataGrid  5   
   -   5        $��total_ResultsDataGrid��5   �      AutoGenerateColumns .     EnableRowVirtualization . $	��208��6N   $��Center=�6[   $��
90,64,98,0q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $	��Top=�6�   $	��478��6  ��6x   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        last_NameColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 	Last Name��5   a      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6t   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� $ 	Last Name�6t     5      -   5        first_NameColumn��$
 
First Name��5   c   $	 100 6w    6?   �� $ 
First Name�6w     5      -   5        emailColumn��$
 Email��5   Y   $	 150 6h    6:   �� $ Email�6h     5      -   5        tournaments_PlayedColumn��$
 Played��5   s   $ 50 6�    6G   �� $ Tournaments Played�6�     5      -	   5        _Record__W_L_T_Column��$
 Record��5   l   $ 80 6|    6D   �� $ Record (W-L-T)�6|   5      �� 5   
   -
   5        $��label1��5   d   $��Player Database��6   $��49��6*   $
��Left=�66   $��	196,0,0,0q�6Q   $	��Top=�6r   $	��283��6�   $��Verdana)�6�   $��32(�6�   �� 5   
   -   5        $��button2��5   h   $��Tourney Results��6   $��23��6+   $��Right=�67   $��0,287,202,0q�6S   $	��Top=�6w   $	��100��6�   �� 5   
   -   5        $��image1��5   J   $��57��6   $
��Left=�6   $��	10,10,0,0q�67   $
��Fill=�6X   $	��Top=�6g   $��63��6   $+��%/Results;component/Images/DSULogo.jpg��6�   �� 5   
   -   5        $��image2��5   K   $��57��6   $
��Left=�6   $��
582,12,0,0q�67   $+��%/Results;component/Images/DSULogo.jpg��6Y   $
��Fill=�6�   $	��Top=�6�   $��63��6�   5      5      
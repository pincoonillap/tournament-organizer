   M S B A M L   `   `   `  ����B  >Results, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   T       WpfApplication1.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ,myclr-namespace:WpfApplication1     5   T   -   5          � Title$  Tournament Results��5   	   $	��454��6$   $	��647��61   
�����F� � 	Resources 5      '   !WpfApplication1.PlayerInfoDataSet   PlayerInfoDataSet  total_ResultsViewSource �� Source �� Path �� Source'   !WpfApplication1.TournamentDataSet  TournamentDataSet   tournament_ResultsViewSource��%�   &	        &	      7   &	 H     &	 [     7    5   
   6   �� 5   
    6?   �� $ Total_Results�8     5   
   6   �� 5	   
    6D   �� $ Tournament_Results�8   5
      .��5      �  � DataContext# [ 6   $	��403��6B   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $ ��tournament_ResultsDataGrid��5   �      AutoGenerateColumns .     EnableRowVirtualization . $	��200��6N   $
��Left=�6[   $��
58,150,0,0q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $	��Top=�6(  $	��510��6@  ��6v   �� # [ 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        last_NameColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 	Last Name��5   a      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6t   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� $ 	Last Name�6t     5      -   5        first_NameColumn��$
 
First Name��5   c   $	 100 6w    6?   �� $ 
First Name�6w     5      -   5        emailColumn��$
 Email��5   Y   $	 150 6h    6:   �� $ Email�6h     5      -   5        recordColumn��$
 Record��5   [   $ SizeToHeader 6k    6;   �� $ Record�6k     5      -   5        resultColumn��$
 Result��5   [   $	 100 6k    6;   �� $ Result�6k   5      �� 5   
   -   5        $��label1��5   g   $��Tournament Results��6   $��50��6-   $
��Left=�69   $��	133,0,0,0q�6T   $	��Top=�6u   $	��354��6�   $��32(�6�   $��Verdana)�6�   �� 5   
   -	   5        $��label2��5   d   $��Tournament Name��6   $��28��6*   $
��Left=�66   $��	92,48,0,0q�6Q   $	��Top=�6r   $	��120��6�   $��12(�6�   $��Tahoma)�6�   �� 5   
   -
   5        $��label3��5   }   $
��Date��6   $��Tahoma)�6   $��12(�63   $��28��6A   $��Right=�6M   $��
0,88,424,0q�6i   $	��Top=�6�   $��37��6�   �� 5   
   -   5        $��label4��5   �   $��Number of Entrants��6   $��Tahoma)�6-   $��12(�6A   $��28��6O   $��Right=�6[   $��0,124,413,0q�6w   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $��listBox1��5   M   $��28��6   $
��Left=�6   $��
231,48,0,0q�69   $	��Top=�6]   $	��161��6u   .@�5      �� $��Fall Classic��6   5      �� 5   
   -   5        $��label5��5   n   $��Tahoma)�6   $��10(�6$   $��20��62   $��Right=�6>   $��
0,90,312,0q�6Z   $	��Top=�6|   $��80��6�   ���	#FFD8B1B1$��09/29/09��6�   ��5      �� 5       �� EndPoint$ 1,0.5&�6&    �� 
StartPoint$ 0,0.5&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5       $ White��6#   $ 1Q�61   5!      5#      �� 5$   
   -   5        $��label6��5$   o   $��Tahoma)�6   $��10(�6$   $��20��62   $��Right=�6>   $��0,124,312,0q�6Z   $	��Top=�6}   $��80��6�   ���	#FFD8B1B1$��8��6�   ��5%      �� 5&      $ 1,0.5&�6&   $ 0,0.5&�67   .��5'      � $ Black��6#   $ 0Q�61   � 5(      $ White��6#   $ 1Q�61   5)      5+      �� 5,   
   -   5        $��button1��5,   \   $
��Home��6   $��23��6    $
��Left=�6,   $��194,367,0,0q�6G   $	��Top=�6k   $��75��6�   �� 5-   
   -   5        $��button2��5-   `   $��Database��6   $��23��6$   $
��Left=�60   $��371,367,0,0q�6K   $	��Top=�6o   $��75��6�   �� 5.   
   -   5        $��image1��5.   J   $��57��6   $
��Left=�6   $��	12,12,0,0q�67   $
��Fill=�6X   $	��Top=�6g   $��63��6   $+��%/Results;component/Images/DSULogo.jpg��6�   �� 5/   
   -   5        $��image2��5/   K   $��57��6   $
��Left=�6   $��
550,12,0,0q�67   $+��%/Results;component/Images/DSULogo.jpg��6Y   $
��Fill=�6�   $	��Top=�6�   $��63��6�   50      51      
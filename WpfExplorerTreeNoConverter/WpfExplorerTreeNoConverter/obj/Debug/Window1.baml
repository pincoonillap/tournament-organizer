   M S B A M L   `   `   `  ����\  XWpfExplorerTreeNoConverter, Version=1.0.3614.27476, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WpfExplorerTreeNoConverterWpfExplorerTreeNoConverter  5      (    "WpfExplorerTreeNoConverter.Window1   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      8local(clr-namespace:WpfExplorerTreeNoConverter    5        � Title$   WpfExplorerTreeNoConverter��5      $	��300��6(   $	��300��65   .��5      � .+�5      R� -   5         R�Name$ foldersTree��5       � 	Resources 5	       �� 
TargetType �� Property �� Value �� DataType �� Orientation �� Triggers	 �� Value
 �� Binding �� RelativeSource �� Mode �� AncestorType �� Path �� 
TargetName��%  'Q�       �� 5
   
   " Q�6   .�5      ��  � �� 5      �� 5      $ ContentPresenter��6   .R�5      �� $ 
Horizontal=�6   .+�5      �� $	��img��5      $��20��5      $��20��6    $
��Fill=�5      �� 5      $	��5,0q�6/   ��6   �� 6/   5       5      �� 5      $
	 True��5      
 5       ��  �� $ FindAncestor=�" Q�$+ %(local:TreeViewItemProps.IsRootLevel)�.a�5      �� $	 img��5        � ��$ Images/diskdrive.png��5"      5$      �� 5&      $	 False��5+      
 5&       ��  �� $ FindAncestor=�" Q�$+ %(local:TreeViewItemProps.IsRootLevel)�.a�5-      �� $	 img��5.       � ��$ Images/folder.png��50      52      54      56      57      58   	   59      5:      5;      
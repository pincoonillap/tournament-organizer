   M S B A M L   `   `   `  ����G  CFileExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FileExplorer.ViewFileExplorer.View  5      ?$clr-namespace:FileExplorer.ViewModelFileExplorer.ViewModel  5      &     FileExplorer.View.ExplorerWindow   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      /Viewsclr-namespace:FileExplorer.View    5      4local$clr-namespace:FileExplorer.ViewModel    5        � Icon$  /Images/explorer.jpg��5      $
��Auto��5   2   $
��Auto��6?    � Title 6   ��  �� Path$ CurrentDirectory.Name� � 	Resources 5         BoolVisibilityConverter��%   &	        �� 5
   
   6I   5      .��5      � -   5         �Name$ 	OuterGrid��5       � DataContext 6   ��  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��5 �6   6)   .+�5   
   &    FileExplorer.View.FileSystemTree  $��0��6   $��0��6/   y�6=   �� $ ShowDirectoryTree� �� 	Converter# [  6�   �� 5   
   $��0��6   $��0��6'   $��Right=�64   $��3��6P   
�������y�6l   �� $ ShowDirectoryTree�# [  �� 5   
   $��1��6   $��0��6'   .��5      '   !FileExplorer.View.DirectoryViewer  6&   5      5      5       
   M S B A M L   `   `   `  ����H  DImageFromFont, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:ImageFromFont;assembly=ImageFromFontImageFromFont  5   	   @ <Demo1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Demo1.ViewModelDemo1.ViewModel 5   	   ?$clr-namespace:Demo1.View.UserControlDemo1.View.UserControl 5   	   +clr-namespace:Demo1.CommonDemo1.Common 5	   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5
   	      Demo1.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   I
imgFrmFont2clr-namespace:ImageFromFont;assembly=ImageFromFont     5   	   3	viewModelclr-namespace:Demo1.ViewModel     5   	   3uc$clr-namespace:Demo1.View.UserControl     5   	   -Commonclr-namespace:Demo1.Common     5	   	   ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase     5
   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   -   5          �Name$  
mainWindow��5      $	��350��5   	   $	��525��5   	    � WindowState$ 	Maximized=�5   	    � WindowStartupLocation$ CenterScreen=�6"    � Title$ 
Sample App��5   	    � Icon$6 0/Demo1;component/Resources/mickey-mouse-icon.png��6    � 	Resources 5      *  $Demo1.Common.BooleanToColorConverter   BooleanToColorConverter   BooleanToVisibilityConverter#  Demo1.Common.EditEmpConverter  EditEmpConverter  FontAwesome  LinearGradientBrushTest �� 
StartPoint �� EndPoint � Color	 � Offset  Templte
 �� ElementName��%h  &	        &	      &	 &     &	 9     &	      &	 A      5   
   6)   �� 5%   
   6'     5&   
   6"   *�5'   
   2./Resources/fontawesome-webfont.ttf#FontAwesome)�6Y   �� 5(   
   $	 0,0&�6>   $	 1,1&�6O   .��5)      � $ Yellow��6   $		 0.2Q�6*   � 5*      $ Orange��6   $		 0.5Q�6*   � 5+      $	 Red��6   $		 0.8Q�6'   5,      �� 5-   
   .R�5.      �� .+�5/      �� ��6   �� *Name+�� 50      ��6   �� *Age+�� 51      $
��Edit��6   ��6(   �� *NavigateToForm+��6K   �� *DataContext+$
 
mainWindow��52      53      55       � DataContext 58      "  Demo1.ViewModel.EmpViewModel  59   
   .��5=      �  � RowDefinitions 5>   
   �� 5?      $
��Auto �6   �� 5@      $��* �6   .+�5B   
   +  %System.Windows.Controls.Ribbon.Ribbon  $��0��6      ApplicationMenu 5C      :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5D      5  /System.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource 6(   !   ImageFromFont.ImageFromFont     Brush
 � ���   
FontFamily$- '/Demo1;component/Resources/#FontAwesome)�   Text$	 ��.@�5E      >  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem  $��Restart��60   3	  -System.Windows.Controls.Ribbon.RibbonMenuItem 	  ImageSource 6A     
 �  ��$- '/Demo1;component/Resources/#FontAwesome)�$	 ��  5F      $
��Save��60    6>     
 ��  �$- '/Demo1;component/Resources/#FontAwesome)�$	 ��5G      .@�5J      .
  (System.Windows.Controls.Ribbon.RibbonTab
   
  
IsSelected . $
��Main��6*   .@�5L      0  *System.Windows.Controls.Ribbon.RibbonGroup  $��Actions��6   .@�5M      1  +System.Windows.Controls.Ribbon.RibbonButton     Label$ Import data��6#   ��67   �� *IsImportDataVisible+ �� 	Converter# [     LargeImageSource 6�     
 �**��$- '/Demo1;component/Resources/#FontAwesome)�$	 ����6  �� *ImportCommand+5N        5O      $��Tools��6   .@�5P        $ Search��6#   ��62   �� *IsSearchVisible+# [   6�     # [ $- '/Demo1;component/Resources/#FontAwesome)�$	 ����6-  �� *SearchCommand+  5Q      $ Puzzle��6#   ��62   �� *IsSearchVisible+# [   6�     
 ��d�$- '/Demo1;component/Resources/#FontAwesome)�   Style$ Italic$�   Stretch$ 	Condensed&�$	 ��   Weight$
 Bold"�3  -System.Windows.Controls.Ribbon.RibbonCheckBox  5R         Label$ 
A checkbox��6�      SmallImageSource 6%     
 � � �$- '/Demo1;component/Resources/#FontAwesome)�$	 ��6�   5S      5T      5U      � 5V   
   -   5         �Name$
 grid��5V      $��1��6   
����� �y�6<   �� *IsImportDataVisible+# [  5W      �� 5X      $��45 �6    �� 5Y      $��* �6    �� 5Z      $��45 �6!   .+�5�      �� $��0��6    �� Orientation$ 
Horizontal=�6&   .+�5�      �� -   5        $��
SearchById��5�   .   $��
SearchById��6   $��23��6@   �� 5�      $	��123��6   $��23��6&   ��62   �� *Paging.SearchById+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.��6�   .  (System.Windows.Interactivity.Interaction    Triggers  5�      /  )System.Windows.Interactivity.EventTrigger  5�      !   	EventName$! KeyUp��6)   .  (System.Windows.Interactivity.TriggerBase"   Actions." 5�      6  0System.Windows.Interactivity.InvokeCommandAction  #   Command# 64   �� *Paging.SearchByColumnCommand+5�      .��5�   .   5�      �� 5�      -   5        $��SearchByName��5�   0   $��SearchByName��6   $��23��6D   �� 5�      $	��123��6   $��23��6&   ��62   �� *Paging.SearchByName+$ PropertyChanged=�$ TwoWay=�.��6�   .��5�   0     5�        5�      $! KeyUp��6)   ." 5�        # 64   �� *Paging.SearchByColumnCommand+5�      .��5�   .   5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5        $��LstVw��5�   }   $��1��6   $   CanUserSortColumns$ . 
�������$��1q�6V   
�������%   
IsReadOnly% . &   AutoGenerateColumns& .  ��6�   �� *Paging.ViewList.View+'   Columns' 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn(   Header$( Id��6)   )   Width5  /System.Windows.Controls.DataGridLengthConverter$) * 65   1  +System.Windows.Controls.DataGridBoundColumn*   Binding* 6A   �� *Id+  5�      $
( Name��6)   $) * 67   * 6A   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5�      $
( Edit��6-   $) * 6;   +   CellTemplate+ 5�      �� 5�      .R�5�   "   �� $
��Edit��6)   ��68   �� *DataContext.NavigateToForm+$
 LstVw����5�   -   �� 5�      5�      5�      /  )Demo1.View.UserControl.PaginationElements  5�      $��2��6$   5�      � 5�   
   $��1��6o   y�6   �� *IsSearchVisible+# [ .+�5�      $  Demo1.View.UserControl.EmpForm  5�      5�      5�      
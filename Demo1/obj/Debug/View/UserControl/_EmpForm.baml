   M S B A M L   `   `   `  ����@  <Demo1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Demo1.View.UserControlDemo1.View.UserControl  5      1clr-namespace:Demo1.ViewModelDemo1.ViewModel  5      +clr-namespace:Demo1.CommonDemo1.Common  5      $    Demo1.View.UserControl.EmpForm   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Demo1.View.UserControl     5      3	ViewModelclr-namespace:Demo1.ViewModel     5      -commonclr-namespace:Demo1.Common     5        � 	Resources  5      !   Demo1.Common.DebugConverter   DebugConverter  ErrorToolTipTemplate_1 � 	Resources  Key �� 
TargetType �� Property �� Value �� CornerRadius  textblockErrorTooltip �� ElementName �� Path  ErrorToolTipTemplate_2 �Name	 � ColumnDefinitions
 ��Name � ToolTip��%
  &	        &	      7  &	 �    '�� ;    '�� �      5   
   6    �� 5   
    5      ���� 5      textblockErrorTooltip " ��66   .�5      ��  � ��$ Center=�6<   �� 5       � ��$ Center=�6:   �� 5       � ��$
 Bold"�63   �� 5       � ��
 �����63   �� 5       � ��$ 	10 0 10 0q�6/   5      5      .R�5      ]� ��. .+�5      �� $
��Auto��6   $��5,0,0,0q�5      ���#DC000C$ 3��5      $��right=�5      ._�5      �� 8��  ��6O   �� $ customAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5      �� 5       $��customAdorner��6,   .v�5!      �� ���#DC000C$	��1.3q�63   5"      5$      5%      �� 5&   
   .R�5'      � $ 	container��6   	 5(      �� 5)      $��* �6'   �� 5*      $
��Auto �6'   .+�5,      �� $��customAdorner��6,   $��0��5-       $��Center=�5.       �� 5/      $
 ValidationErrorElement��6   ���	#FFDB000C$	��1.2q�51      $ 1��52       53      �� $ customAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�._�55      � $��12��6   $��12��56      $��	1,-4,-4,0q�57      $��Right=�58      $	��Top=�59      
������ .+�5;      F� $��1,3,0,0q�6   ;����@B     р�[     � z �� ��� �� �J]� z ��j 	���	#FFDC000C5=      F� 5>      $��1,3,0,0q�6   +����        р�     � z ��[ � z  z 	���#ffffff5@      5A      5B      �� 5C      $��0��6   $��15��5D      $��15��5E      $��0 0 3 0q�5F      $��Right=�5G      $��Center=�5H      
���  ��$ 10��5J       5K      �� $ customAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�._�5M      �� $��center=�6    $��center=�5N      $
��Bold"�5O      
�������$��!��5Q      5R      �� 5S      $��1��6   $
��Auto��5T      $��5,0,0,0q�5U      ���#DC000C$ 3��5W      $��right=�5X      ._�5Y      �� $��5q�6    
���������5[      �� $ customAdorner��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5]      5^      5_      �� 5`   
   " ��6   .�5a      ��  � ��$ 14(�6)   �� 5b       � ��$ Center=�64   �� 5c       � ��$
 Bold"�6+   �� 5d       � ��$ 5q�6'   5e      �� 5f   
   " ��6   .�5g      ��  � ��$
 Left=�64   �� 5h       � ��$	 Top=�62   �� 5i       � ��$ 30��6'   �� 5j       � ��$
 Auto��6&   �� 5k       � ��$	 100��6)   5l      5m      .��5n      �  � DataContext 6   �� *EmpFormViewModel+ �� 	Converter# [    5o   
    �� Triggers P� Property P� Value �� RelativeSource��%�  '��       '�� �    �� 5p      " ��6   .�5q      ��  � ��$
 Left=�68   �� 5r       � ��$	 Top=�66   �� 5s       � ��$	 150��6*   �� 5t       � ��$ 30��6+   �� 5u       �@=�ErrorTemplate# �  6=    5v      P� 5w       �@=�HasError . . �5x      ��  �@�ToolTip 64   ��  �� *Self+$) #(Validation.Errors)[0].ErrorContent�5y      5{      �� 5|      " ��6   .�5}      ��  � ��$
 Left=�68   �� 5~       � ��$	 Top=�66   �� 5       � ��$	 150��6*   �� 5�       � ��$ 30��6+   �� 5�       �@=�ErrorTemplate# �  6=   5�      5�      	 5�   
   �� 5�      $	��140 �6   �� 5�      $��* �6    � RowDefinitions 5�   
   �� 5�      $��60 �6   �� 5�      $��40 �6   �� 5�      $��40 �6   �� 5�      $��40 �6   �� 5�      $��40 �6   .+�5�   
   �� $��1��6   $��0��6!   $
��Name��61   �� 5�   
   -   5         ��Name$
 Name��5�   /   $��1��6   $��1��6   ��6=   �� *Name+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=��� 5�   
   $��2��6   $��0��6!   $	��Age��61   �� 5�   
   -   5        $	 Age��5�   /   $��2��6   $��1��6   .��6<   .��5�      �� $	 Age�6   $ PropertyChanged=�6!   $ TwoWay=�6G    �� ValidationRules 5�      ,   &Demo1.Common.StringToIntValidationRule  5�      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�67   5�      5�      �� 5�   
   $��3��6   $��0��6!   $��Salary��61   �� 5�   
   -   5        $ Salary��5�      $��3��5�      $��1��6   $
��Left=�5�      $	��Top=�5�      ��5�      �� *Salary+$ PropertyChanged=� . 5�      �� 5�   
   $��4��6   $��1��6   $
��Save��6/   ��6>   �� *SaveCommand+��5�      �� 5�      " ��6   .�5�      ��  � {� .  62    5�      ^� 5�       ^� 
Conditions 5�      �� 5�   "    �� Binding 6,   �� $ (Validation.HasError)�$
 Name�� �� Value	 False6m   �� 5�   "    6,   �� $ (Validation.HasError)�$	 Age��	 False6l   �� 5�   "    6,   �� $ (Validation.HasError)�$ Salary��	 False6o   .0�5�      ��  � {� . 6:   5�      5�      5�      5�      5�      
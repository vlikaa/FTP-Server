   M S B A M L   `   `   `  ����U  QSystem.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem  5   
   E AFTP Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FTP_Server.ConvertersFTP_Server.Converters 5   
   9!clr-namespace:FTP_Server.ControlsFTP_Server.Controls 5	   
   '   !FTP_Server.Controls.CustomTextBox   5   
   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   
   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   
   @d2http://schemas.microsoft.com/expression/blend/2008     5   
   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   6sys,clr-namespace:System;assembly=System.Runtime  5   
   +c#clr-namespace:FTP_Server.Converters  5   
   0controls!clr-namespace:FTP_Server.Controls  5	   
   .��5   3     � 	Resources  5      7  1FTP_Server.Converters.IsStringEmptyOrNotConverter   IsStringEmptyOrNotConverter  TextBoxTemplate �� CornerRadius �� 
TargetType �� Property �� Value �� Triggers �� Binding �� RelativeSource �� AncestorType	 �� 	Converter
 �� Value ��Name��%  &	        &	      7     5   
   6(   �� 5   
   .R�5      �� #��z��6   .+�5      �� $
��11.5(�5      $��2 0 0 5q�5      ��5      �� *Title+5      �� 5      ���#C0C5C5$��1q�5      $ 5��5      $��35��5      ._�5      � .+�5      �� $��Center=�6$   $	��6 0q�5   $   $	��500"�5   $   ���#94A3B8��5   $   �� *Placeholder+��5      �� 5    "   " ��6(   .�5!   &   ��  � y�$ Visible=�6C    5"   &   �� 5#   *    66   �� *Text+ ��  TextBox8	   
 True6�   .a�5$   .   ��  � y�$ 	Collapsed=�6K   5%   +   5'   #   5)      �� 5+      $ PART_ContentHost��5-   '   $��Center=�5+   '   $	��5 0q�5,   '   5-   '   5.      5/      50      51      52      .��6   ��54      �� 55   
   " ��6   .�56      ��  � ��# [ 6)   57      .��58      59      
   M S B A M L   `   `   `  ����  
Practos2_C    Practos2_C.NoteWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Заметка��5   	   $	��300��6   $	��500��6&   .��5      �  � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��Заголовок:��61   $��Center=�6C   $��5q�6^   �� 5   
   -   5         ��Name$ TitleTextBox��5      $��0��6(   $��1��65   $��5q�6�   ��6E   �� *Title+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��1��6   $��0��6!   $��Текст:��61   $��Center=�6?   $��5q�6Z   �� 5   
   -   5        $ TextBox��5      $��1��6#   $��1��60   $��2��6@   $��5q�6�    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6�   ��6Q   �� *Text+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ AddNoteButton��5      $%��Добавить заметку��6(   $��5q�6C   6N   5      5      
   M S B A M L   `   `   `  ����N  JGeburtstagskalender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:GeburtstagskalenderGeburtstagskalender  5   	   $    Geburtstagskalender.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Geburtstagskalender     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��4* �6   6*    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��3* �6   6,   .+�5   
   �� $��0��6   $��2��6   ���	#FF6FA8DC6K   �� 5   
   -   5         ��Name$ 	txt_Titel��5   �   $��0��6   $��0��6   $��2��6/   $��Center=�6C   $
��Left=�6^   $��20,0,0,0q�6y   $��36(�6�   $
��Bold"�6�   $��0q�6�   ��6�   Z� .��6�   
Adressbuch6�   �� 5   
   -   5        $ 
txt_search��5   ~   $��0��6   $��1��6   $��Bottom=�6/   $��Right=�6J   $	��150��6f   $��20q�6r   6�   � 5   
   $��1��6   $��0��6   $	��Top=�6,   $��30��6D    5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ btn_ShowGebList��5   2   $��0��6   $��0��6"   .��6j   �� $��
/Torte.png��6p   6�   �� 5      -   5        $ btn_ShowUser��5   2   $��0��6   $��1��6"   .��6d   �� $��/Mitarbeiter.png��6j   6�   �� 5      -   5        $ btn_DelUser��5   2   $��0��6   $��2��6"   .��6b   �� $��/Mülltonne.png��6h   6�   �� 5       -   5        $ btn_AddUser��5    2   $��0��6   $��3��6"   .��6b   �� $��/AddUser.png��6h   6�   5!      >� 5"   
   -   5        $��uc_Left��5"      $��1��6%   $��0��62   $��0,30,0,0q�6B   5$      >� 5%   
   -	   5        $��uc_Right��5%      $��1��6&   $��1��63   5'      5(      5)      
   M S B A M L   `   `   `  ����N  JGeburtstagskalender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:GeburtstagskalenderGeburtstagskalender  5      %    Geburtstagskalender.Uc_Kalender   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Geburtstagskalender     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��4* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   (� $��0��6   $��2��6   .��5      &   System.Windows.Controls.Calendar  -   5          Name$ cal_Kalender��5         SelectionMode$ MultipleRange=�6-   5      �� 5   
   -   5         ��Name$ img_BDayToday��5      $��
/Torte.png��6'   $��0��6;   $��1��6K   $��10q�6X   �� 5   
   -   5         ��Name$ LsV_BDayKids��5      $��1��6)   $��1��66   $
��Left=�6F   $��Center=�6a   $��
25,10,0,10q�6|    �� View 5      �� 5      ! �� ColumnHeaderContainerStyle 5      �� 5       �� 
TargetType" ��6    .�5      �� 	 �� Property	 � y�
 �� Value$
 	Collapsed=�6;   5      .P�5      �� -   5        
gvc_NN��$��Nachname��5   5    �� DisplayMemberBinding 6G   �� *
Nachname+�� 5      -   5        
gvc_VN��$��Vorname��5   5    6F   �� *	Vorname+5       5"      5#      5$      
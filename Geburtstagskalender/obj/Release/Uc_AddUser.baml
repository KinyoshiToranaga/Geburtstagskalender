   M S B A M L   `   `   `  ���� N  JGeburtstagskalender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:GeburtstagskalenderGeburtstagskalender  $    Geburtstagskalender.Uc_AddUser   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:Geburtstagskalender     .���� -     ��Name$  
cc_AddUser��.���  � RowDefinitions �� ��  � ColumnDefinitions �� $��2* ��� $��3* �.+�(� $��0��$��0��$��10q� (� Stretch$ Uniform=�.���� -    ��Name$ 	btn_Image��$	��200��$	��200��
�������.���� -    ��Name$ img_profile��$��Center=�$��Center=��� $��0��$��1��.+��  �� $��1* ��� $��2* �.+��� -   $��lbl_Vorname��$��0��$
��Left=�$	��Top=�$	��122��$��0q�.��
Vorname/n:�� -    ��Name$ txt_Vorname��$��1��$
��Left=�$	��Top=�$��26��$	��214��$��0q��� -   $��lbl_Nachname��$��0��$
��Left=�$	��Top=�$	��122��$��0,26,0,0q�.��	Nachname:�� -   $ txt_Nachname��$��1��$
��Left=�$	��Top=�$��26��$	��214��$��0,26,0,0q��� -   $��lbl_Kennung��$��0��$
��Left=�$	��Top=�$	��122��$��0,52,0,0q�.��Mitarbeiterkennung:�� -	   $ txt_Kennung��$��1��$
��Left=�$	��Top=�$��26��$	��214��$��0,52,0,0q��� -
   $��lbl_Geb��$��0��$
��Left=�$	��Top=�$	��122��$��0,78,0,0q�.��Geburtstag:(  "System.Windows.Controls.DatePicker  -     Name$ txt_Geb��$��1��$
��Left=�$	��Top=�$��26��$	��214��$��0,78,0,0q��� $��1��$��0��$��0,20,0,0q�.+��  �� $��1* ��� $��2* � �� �� �� �� �� .+��� -    ��Name$ lbl_Strasse��$��0��$��0��.��
Strasse:�� -   $ txt_Strasse��$��0��$��1���� -   $ lbl_Ort��$��1��$��0��.��Ort:�� -   $ txt_Ort��$��1��$��1���� -   $ lbl_PLZ��$��2��$��0��.��PLZ:�� -   $ txt_PLZ��$��2��$��1���� -   $ lbl_Tel��$��3��$��0��.��
Telefon:�� -   $ txt_Tel��$��3��$��1���� -   $ 	lbl_Email��$��4��$��0��.��Email:�� -   $ 	txt_Email��$��4��$��1���� -   $ btn_edit��
������ $��1��$��1��$��80��$��80��$��Bottom=�$��Right=�$��20q�.���� $��Schraubenschluessel.png���� -   $ btn_confirm��$��1��$��1��$��26��$��70��$��Bottom=�$��Right=�$��10,10,90,10q�.��Bestätigen�� -   $ 
btn_cancel��$��1��$��1��$��26��$��70��$��Bottom=�$��Right=�$��10q�.��	Abbrechen
   M S B A M L   `   `   `  ����J  FManageEventsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ManageEventsAppManageEventsApp  5   	   A =NavBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:NavBar;assembly=NavBarNavBar 5   	   E ACustomHelp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:CustomHelp;assembly=CustomHelp
CustomHelp 5   	   .    (ManageEventsApp.ManageVeranstalterWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ManageEventsApp     5   	   7NavBar$clr-namespace:NavBar;assembly=NavBar     5   	   :h,clr-namespace:CustomHelp;assembly=CustomHelp     5   	   -   5          � Title$'  !Bearbeitung der Eventveranstalter��5
   	   $	��460��63   $	��650��6@    � 
ResizeMode$ NoResize=�5   	   #  CustomHelp.CustomHelpProvider   
HelpString$2 ,Applikation zur Eventveranstalterbearbeitung��5   	    � Icon$ /Icons/App.ico��6X    � 	Resources 5         customErrorTemplate � ToolTip��%�   &	        �� 5   
   .R�5      ]� $. (Bitte geben Sie die fehlenden Werte ein!��6   .+�5      �� 
�������
���  ��$��	ExtraBold"�6@   $��20(�6W   !!6i   �� 5      $��20��6,   5      5      5      .��5      � .+�5   
   � -   5         �Name$ veranstalterGrid��5      $	��Top=�6)   $��
10,10,10,0q�6A   $	��335��6U    � RowDefinitions 5      �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5       $��1* �6    �� 5!      $��1* �6    �� 5"      $��1* �6    �� 5#      $��1* �6     � ColumnDefinitions 5%      �� 5&      $��2* �6#   �� 5'      $��1* �6#   �� 5(      $��1* �6#   �� 5)      $��1* �6#   	 � BindingGroup	 5,      &   System.Windows.Data.BindingGroup  5-      -   5        veranstalterBindingGroup��5-      .+�50      �� -   5        
 ��Name$
 ev_FirmaListBox��50      $��0��6/   $��0��6<   $��10��6L   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6^    �� DisplayMemberPath$ ev_Firma��6�   $��5q�6�   $# Liste aller Eventveranstalter��6�   $��1��6�   ��6�   �� 6�   �� 52      $��Eventveranstalter��6   $��0��60   $��1��6=   $��3��6M   �� 53      -   5         ��Name$ ev_FirmaTextBox��53       =� ErrorTemplate# [  6�   $��1��6�   $��1��6�   $��3��6  $7 1Eingabefeld für den Namen des Eventveranstalters��6   $7 1Eingabefeld für den Namen des Eventveranstalters��6[  $��3��6�  ��6/   �� *
ev_Firma+ �� Mode$ TwoWay=� �� NotifyOnValidationError$
 True�� �� ValidatesOnExceptions$
 True�� �� UpdateSourceTrigger$ 	LostFocus=�6�  �� 55      $��Straße��6   $��2��6%   $��1��62   $��2��6B   �� 56      -   5        $ ev_StrasseTextBox��56      # [  6�   $��3��6�   $��1��6   $��2��6  $9 3Eingabefeld für die Straße des Eventveranstalters��6$  $9 3Eingabefeld für die Straße des Eventveranstalters��6`  $��4��6�  ��61   �� *
ev_Strasse+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=�6�  �� 58      $��
Hausnummer��6   $��2��6)   $��3��66   �� 59      -   5        $ ev_HNummberTextBox��59      # [  6�   $��3��6�   $��3��6  $< 6Eingabefeld für die Hausnummer des Eventveranstalters��6  $< 6Eingabefeld für die Hausnummer des Eventveranstalters��6Q  $��5��6�  ��62   �� *
ev_HNummer+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=�6�  �� 5;      $	��PLZ��6   $��4��6"   $��1��6/   �� 5<      -   5        $ ev_PLZTextBox��5<      # [  6�   $��5��6�   $��1��6�   $5 /Eingabefeld für die PLZ des Eventveranstalters��6  $5 /Eingabefeld für die PLZ des Eventveranstalters��6A  $��6��6�  ��6-   �� *ev_PLZ+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=�6�  �� 5>      $	��Ort��6   $��4��6"   $��2��6/   $��2��6?   �� 5?      -	   5        $ ev_OrtTextBox��5?      # [  6�   $��5��6�   $��2��6�   $��2��6  $; 5Eingabefeld für den Ortsnamen des Eventveranstalters��6  $; 5Eingabefeld für den Ortsnamen des Eventveranstalters��6[  $��7��6�  ��6-   �� *ev_Ort+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=�6�  �� 5A      $��Telefon��6   $��6��6&   $��1��63   $��2��6C   �� 5B      -
   5        $ ev_TelefonTextBox��5B      # [  6�   $��7��6�   $��1��6   $��2��6  $? 9Eingabefeld für die Telefonnummer des Eventveranstalters��6$  $? 9Eingabefeld für die Telefonnummer des Eventveranstalters��6g  $��8��6�  ��61   �� *
ev_Telefon+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=�6�  �� 5D      $	��Fax��6   $��6��6"   $��3��6/   �� 5E      -   5        $ ev_FaxTextBox��5E      # [  6�   $��7��6�   $��3��6�   $< 6Eingabefeld für die Fax Nummer des Eventveranstalters��6  $< 6Eingabefeld für die Fax Nummer des Eventveranstalters��6H  $��9��6�  ��6-   �� *ev_Fax+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=�6�  �� 5G      $��E-Mailadresse��6   $��8��6,   $��1��69   $��3��6I   �� 5H      -   5        $ ev_EMailTextBox��5H      # [  6�   $��9��6�   $��1��6�   $��3��6  $@ :Eingabefeld für die E-Mail Adresse des Eventveranstalters��6   $@ :Eingabefeld für die E-Mail Adresse des Eventveranstalters��6d  $��10��6�  ��6/   �� *
ev_Email+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=�6�  5I        NavBar.NavBar  5K   
   -   5          Name$ veranstalterNavBar��5K      $
��Left=�64   $��
10,350,0,0q�6O   $	��Top=�6c   $	��245��6{   $��30��6�   $ Navigationsleiste��6�   $��2��6�   � 5M   
   -   5        $ 
buttonGrid��5M      $��Bottom=�6#   $��260,0,10,10q�6>   $��70��6S    5N      �� 5O      $��1* �6    �� 5P      $��1* �6     5R      �� 5S      $��1* �6#   �� 5T      $��1* �6#   �� 5U      $��1* �6#   .+�5X      �� -   5         ��Name$ btnNeuerVeranstalter��5X      $��_Neuer Veranstalter��63   $��0��6Q   $��0��6^   $��5q�6n   $) #Erstellen eines neuen Veranstalters��6�   $5 /Button fuer Erstellen eines neuen Veranstalters��6�   $��11��6  �� 5Y      -   5        $ btnUebernehmen��5Y      $��_Übernehmen��6-   $��0��6C   $��1��6P   $��5q�6`   ${�False��6k   $2 ,Uebernehmen des neu erstellten Veranstalters��6�   $B <Button fuer das Uebernehmen des neu erstellten Veranstalters��6�   $��12��60  �� 5Z      -   5        $ btnAbbrechen��5Z      $��
Abb_rechen��6+   $��0��6@   $��2��6M   $��5q�6]   ${�False��6h   $8 2Abbrechen der Erstellung eines neuen Veranstalters��6�   $H BButton fuer das Abbrechen der Erstellung eines neuen Veranstalters��6�   $��13��67  �� 5[      -   5        $ btnSchliessen��5[      $��_Schließen��6,   $��1��6A   $��0��6N   $��3��6^   $��5q�6r   $b \Bearbeitung der Eventveranstalter schließen und ausgewaehlten Eventveranstalter uebernehmen��6�   $C =Button um die Bearbeitung der Eventveranstalter zu schließen��6�   $��14��6^  5\      5]      5^      
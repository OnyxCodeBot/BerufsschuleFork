   M S B A M L   `   `   `  ���� J  FManageEventsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ManageEventsAppManageEventsApp  A =NavBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:NavBar;assembly=NavBarNavBar E ACustomHelp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:CustomHelp;assembly=CustomHelp
CustomHelp .    (ManageEventsApp.ManageVeranstalterWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:ManageEventsApp     7NavBar$clr-namespace:NavBar;assembly=NavBar     :h,clr-namespace:CustomHelp;assembly=CustomHelp     -     � Title$'  !Bearbeitung der Eventveranstalter��$	��460��$	��650�� � 
ResizeMode$ NoResize=�#  CustomHelp.CustomHelpProvider   
HelpString$2 ,Applikation zur Eventveranstalterbearbeitung�� � Icon$ /Icons/App.ico�� � 	Resources    customErrorTemplate � ToolTip��%�   &	        �� .R�]� $. (Bitte geben Sie die fehlenden Werte ein!��.+��� 
�������
���  ��$��	ExtraBold"�$��20(�!!�� $��20��.��� .+�� -    �Name$ veranstalterGrid��$	��Top=�$��
10,10,10,0q�$	��335�� � RowDefinitions �� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* � � ColumnDefinitions �� $��2* ��� $��1* ��� $��1* ��� $��1* �	 � BindingGroup	 &   System.Windows.Data.BindingGroup  -   veranstalterBindingGroup��.+��� -   
 ��Name$
 ev_FirmaListBox��$��0��$��0��$��10��$ �� IsSynchronizedWithCurrentItem$
 TrueY� �� DisplayMemberPath$ ev_Firma��$��5q�$# Liste aller Eventveranstalter��$��1������ �� $��Eventveranstalter��$��0��$��1��$��3���� -    ��Name$ ev_FirmaTextBox�� =� ErrorTemplate# [  $��1��$��1��$��3��$7 1Eingabefeld für den Namen des Eventveranstalters��$7 1Eingabefeld für den Namen des Eventveranstalters��$��3������ *
ev_Firma+ �� Mode$ TwoWay=� �� NotifyOnValidationError$
 True�� �� ValidatesOnExceptions$
 True�� �� UpdateSourceTrigger$ 	LostFocus=��� $��Straße��$��2��$��1��$��2���� -   $ ev_StrasseTextBox��# [  $��3��$��1��$��2��$9 3Eingabefeld für die Straße des Eventveranstalters��$9 3Eingabefeld für die Straße des Eventveranstalters��$��4������ *
ev_Strasse+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=��� $��
Hausnummer��$��2��$��3���� -   $ ev_HNummberTextBox��# [  $��3��$��3��$< 6Eingabefeld für die Hausnummer des Eventveranstalters��$< 6Eingabefeld für die Hausnummer des Eventveranstalters��$��5������ *
ev_HNummer+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=��� $	��PLZ��$��4��$��1���� -   $ ev_PLZTextBox��# [  $��5��$��1��$5 /Eingabefeld für die PLZ des Eventveranstalters��$5 /Eingabefeld für die PLZ des Eventveranstalters��$��6������ *ev_PLZ+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=��� $	��Ort��$��4��$��2��$��2���� -	   $ ev_OrtTextBox��# [  $��5��$��2��$��2��$; 5Eingabefeld für den Ortsnamen des Eventveranstalters��$; 5Eingabefeld für den Ortsnamen des Eventveranstalters��$��7������ *ev_Ort+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=��� $��Telefon��$��6��$��1��$��2���� -
   $ ev_TelefonTextBox��# [  $��7��$��1��$��2��$? 9Eingabefeld für die Telefonnummer des Eventveranstalters��$? 9Eingabefeld für die Telefonnummer des Eventveranstalters��$��8������ *
ev_Telefon+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=��� $	��Fax��$��6��$��3���� -   $ ev_FaxTextBox��# [  $��7��$��3��$< 6Eingabefeld für die Fax Nummer des Eventveranstalters��$< 6Eingabefeld für die Fax Nummer des Eventveranstalters��$��9������ *ev_Fax+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=��� $��E-Mailadresse��$��8��$��1��$��3���� -   $ ev_EMailTextBox��# [  $��9��$��1��$��3��$@ :Eingabefeld für die E-Mail Adresse des Eventveranstalters��$@ :Eingabefeld für die E-Mail Adresse des Eventveranstalters��$��10������ *
ev_Email+$ TwoWay=�$
 True��$
 True��$ 	LostFocus=�  NavBar.NavBar  -     Name$ veranstalterNavBar��$
��Left=�$��
10,350,0,0q�$	��Top=�$	��245��$��30��$ Navigationsleiste��$��2��� -   $ 
buttonGrid��$��Bottom=�$��260,0,10,10q�$��70�� �� $��1* ��� $��1* � �� $��1* ��� $��1* ��� $��1* �.+��� -    ��Name$ btnNeuerVeranstalter��$��_Neuer Veranstalter��$��0��$��0��$��5q�$) #Erstellen eines neuen Veranstalters��$5 /Button fuer Erstellen eines neuen Veranstalters��$��11���� -   $ btnUebernehmen��$��_Übernehmen��$��0��$��1��$��5q�${�False��$2 ,Uebernehmen des neu erstellten Veranstalters��$B <Button fuer das Uebernehmen des neu erstellten Veranstalters��$��12���� -   $ btnAbbrechen��$��
Abb_rechen��$��0��$��2��$��5q�${�False��$8 2Abbrechen der Erstellung eines neuen Veranstalters��$H BButton fuer das Abbrechen der Erstellung eines neuen Veranstalters��$��13���� -   $ btnSchliessen��$��_Schließen��$��1��$��0��$��3��$��5q�$b \Bearbeitung der Eventveranstalter schließen und ausgewaehlten Eventveranstalter uebernehmen��$C =Button um die Bearbeitung der Eventveranstalter zu schließen��$��14��
#include <iostream>
#include "zins.h"
using namespace std;

int mainSwitch()
{
	char auswahl = ' ', verlassen = ' ';
	double betrag = 0, zins = 0, ergebnis = 0;
	bool leave = false;

	do
	{
		betrag = -990;
		while (betrag < 0)
		{
			cout << "Bitte geben Sie das Startkapital ein: ";
			cin >> betrag;

			if (betrag < 0)
			{
				system("cls");
				cout << "Das Startkapital darf nicht negativ sein!\n\n";
			}
		}

		cout << "\nBitte geben Sie den Zinssatz ein: ";
		cin >> zins;

		 cout << "\n\n'1' fuer Kapital nach einem Jahr berechnen \n'2' fuer Kapital nach 2 Jahren berechnen \n'3' fuer Kapital nach 3 Jahren berechnen \n'4' fuer Kapital nach 4 Jahren berechnen\n\nWahl: ";
		cin >> auswahl;

		switch (auswahl)
		{
		case '1':
			ergebnis = KapitalNach1Jahr(betrag, zins);
			break;
		case '2':
			ergebnis = KapitalNach2Jahr(betrag, zins);
			break;
		case '3':
			ergebnis = KapitalNach3Jahr(betrag, zins);
			break;
		case '4':
			ergebnis = KapitalNach4Jahr(betrag, zins);
			break;
		default:
			 system("cls");
			 cout << "Auswahl nicht erkannt!\n\n";
			 system("pause");
			return 0;
		}

		 system("cls");
		 cout << "Kapital nach " << auswahl << " Jahr(en): " << ergebnis << endl << endl;


		 cout << "Wiederholen? J/N\t";
		cin >> verlassen;

		switch (verlassen)
		{
		case 'j':
			leave = false;
			break;
		case 'J':
			leave = false;
			break;
		default:
			leave = true;
			break;
		}
	} while (leave == false);
	 system("pause");
	return 0;
}
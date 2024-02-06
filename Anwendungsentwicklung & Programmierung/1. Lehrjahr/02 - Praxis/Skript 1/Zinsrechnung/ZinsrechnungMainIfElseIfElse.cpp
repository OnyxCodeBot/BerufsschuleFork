#include <iostream>
#include "zins.h"
using namespace std;

int mainIfELse()
{
	char auswahl = ' ';
	double betrag, zins, ergebnis = 0;

	cout << "Bitte geben Sie das Startkapital ein: ";
	cin >> betrag;

	cout << "\nBitte geben Sie den Zinssatz ein: ";
	cin >> zins;

	cout << "\n\n'1' fuer Kapital nach einem Jahr berechnen \n'2' fuer Kapital nach 2 Jahren berechnen \n'3' fuer Kapital nach 3 Jahren berechnen \n'4' fuer Kapital nach 4 Jahren berechnen\n\nWahl: ";
	cin >> auswahl;

	if (auswahl == '1')
	{
		ergebnis = KapitalNach1Jahr(betrag, zins);
	}
	else if(auswahl == '2')
	{
		ergebnis = KapitalNach2Jahr(betrag, zins);
	}
	else if (auswahl == '3')
	{
		ergebnis = KapitalNach3Jahr(betrag, zins);
	}
	else if (auswahl == '4')
	{
		ergebnis = KapitalNach4Jahr(betrag, zins);
	}
	else
	{
		system("cls");
		cout << "Auswahl nicht erkannt!\n\n";
		system("pause");
		return 0;
	}

	system("cls");
	cout << "Kapital nach " << auswahl << " Jahr(en): " << ergebnis << endl << endl;

	system("pause");
	return 0;
}
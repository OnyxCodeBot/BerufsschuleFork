#include <iostream>
#include "zins.h"
using namespace std;

int mainIf()
{
	char auswahl;
	double betrag, zins, ergebnis;

	cout << "Bitte geben Sie das Startkapital ein: ";
	cin >> betrag;

	cout << "\nBitte geben Sie den Zinssatz ein: ";
	cin >> zins;

	cout << "\n\n'1' fuer Kapital nach einem Jahr berechnen \n'2' fuer Kapital nach 2 Jahren berechnen\n\nWahl: ";
	cin >> auswahl;

	if (auswahl == '1')
	{
		ergebnis = KapitalNach1Jahr(betrag, zins);
	}
	else
	{
		ergebnis = KapitalNach2Jahr(betrag, zins);
	}

	system("cls");
	cout << "Kapital nach " << auswahl << " Jahr(en): " << ergebnis << endl << endl;

	system("pause");
	return 0;
}
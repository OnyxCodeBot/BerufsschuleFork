#include <iostream>
#include "zins.h"
#include "zins.h"
using namespace std;

int main()
{
	double startKapital, zinssatz, endKapital;
	
	cout << "Geben Sie bitte das Startkapital ein\n Eingabe: ";
	cin >> startKapital;

	cout << "Geben Sie bitte den Zinssatz in % ein\n Eingabe: ";
	cin >> zinssatz;

	system("cls");

	endKapital = KapitalNach1Jahr(startKapital, zinssatz);
	cout << "Ihr Kapital nach " << 1 << "\t Jahr(en) betraegt: \t" << endKapital << "\t EUR \n";

	endKapital = KapitalNach2Jahr(startKapital, zinssatz);
	cout << "Ihr Kapital nach " << 2 << "\t Jahr(en) betraegt: \t" << endKapital << "\t EUR \n";

	endKapital = KapitalNach3Jahr(startKapital, zinssatz);
	cout << "Ihr Kapital nach " << 3 << "\t Jahr(en) betraegt: \t" << endKapital << "\t EUR \n";

	endKapital = KapitalNach4Jahr(startKapital, zinssatz);
	cout << "Ihr Kapital nach " << 4 << "\t Jahr(en) betraegt: \t" << endKapital << "\t EUR \n";

	cout << "\n";
	cout << "\n";
	system("pause");
	return 0;
}
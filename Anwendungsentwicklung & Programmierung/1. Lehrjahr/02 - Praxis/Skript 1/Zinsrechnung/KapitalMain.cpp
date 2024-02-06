#include <iostream>
#include "zins.h"

using namespace std;


int main()
{
	double startKapital, zinssatz, endKapital;
	int Jahre;

	startKapital = 100;
	zinssatz = 1;

	for (int i = 0; i <= 100; i++)
	{
		endKapital = Kapital(startKapital, zinssatz, i);
		cout << "Ihr Kapital nach\t" << i << "\t Jahr(en) betraegt: \t" << endKapital << "\t EUR \n";
	}

	cout << "\n";
	cout << "\n";

	Jahre = 100;
	endKapital = KapitalRecursiv(startKapital, zinssatz, Jahre);
	cout << "Ihr Kapital nach\t" << Jahre << "\t Jahr(en) betraegt: \t" << endKapital << "\t EUR \n";

	cout << "\n";
	cout << "\n";

	system("pause");
	return 0;
}
#include <iostream>
#include "geometrie.h"

using namespace std;

int main()
{
	double seite1, seite2;
	double quadratFlaeche, rechteckFlaeche;

	cout << "Erste Seite eingeben:\n";
	cin >> seite1;
	cout << "Zweite Seite eingeben:\n";
	cin >> seite2;

	quadratFlaeche = flaeche(seite1);
	rechteckFlaeche = flaeche(seite1, seite2);

	cout << "\nQuadratflaeche = " << quadratFlaeche;
	cout << "\nRechteckflaeche = " << rechteckFlaeche;

	cout << endl << endl;
	system("pause");
	return 0;
}
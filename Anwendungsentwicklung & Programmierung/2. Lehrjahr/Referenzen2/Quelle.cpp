#include <iostream>

using namespace std;

void Quader(double& rf1, double& rf2, double& rf3)
{
	double l, b, h;
	cout << "Bitte geben Sie nacheinander Laenge, Breite, Hoehe an:" << endl;
	cin >> l;
	cin >> b;
	cin >> h;

	rf1 = l * b;
	rf2 = b * h;
	rf3 = l * h;
}

int main()
{
	double F1, F2, F3;
	char ende = ' ';

	while (ende != 'e' && ende != 'E')
	{
		Quader(F1, F2, F3);

		cout << endl << endl;

		cout << "Flaeche 1: " << F1 << endl;
		cout << "Flaeche 2: " << F2 << endl;
		cout << "Flaeche 3: " << F3 << endl << endl;

		cout << "Zum Beenden \"E\" eingeben! Sonst einen anderen Buchstaben eingeben: ";
		cin >> ende;
	}

		cout << endl << endl;
		system("pause");
}
#include <iostream>

using namespace std;

int mainXXX()
{
	int Zahl1, Zahl2;
	char choice = ' ';
	bool leave = false;

	do
	{
		system("cls");
		Zahl1 = 0;
		Zahl2 = 0;

		cout << "Geben Sie ganze Zahlen ein!\nZahl 1: ";
		cin.ignore();
		cin >> Zahl1;
		cin.clear();
		cout << "\nZahl 2: ";
		cin.ignore();
		cin >> Zahl2;
		cin.clear();

		cout << "\n\nDivision: " << Zahl1 / Zahl2 << "\tRest: " << Zahl1 % Zahl2 << endl << endl;

		cout << "\n\n\nNochmal mit anderen Zahlen wiederholen? (j|n)\n";
		cin >> choice;
		
		if (choice != 'j' && choice != 'J')
		{
			leave = true;
		}
	} while (leave == false);

	return 0;
}
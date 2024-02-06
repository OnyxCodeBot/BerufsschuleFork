#include <iostream>
#include <conio.h>

using namespace std;


int main()
{

	double note, durchschnitt, notensumme = 0.0;
	int dividend = 0;

	char bestaetigung = ' ', ms = ' ';

	while (bestaetigung != 27)
	{
		
		cout << "\n(M)uendlich / (S)chriftlich: ";
		cin >> ms;

		cout << "\nNote: ";
		cin >> note;

		if (ms == 's' || ms == 'S')
		{
			dividend += 2;
			notensumme += (note * 2);
		}
		else
		{
			dividend += 1;
			notensumme += note;
		}

        cout << "\"ESC\" Beenden\n\"SPACE\" Fortsetzten";
		bestaetigung = _getch();
	}

	durchschnitt = notensumme / dividend;
	cout << endl << endl << endl << durchschnitt << endl << endl << endl;

	system("pause");
	return 0;
}
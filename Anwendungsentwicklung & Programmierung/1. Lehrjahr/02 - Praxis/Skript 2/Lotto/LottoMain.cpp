#include <iostream>
#include "Lotto.h"

using namespace std;

int main()
{
	int Lotto[ZIEHUNGEN];
	int Zahlen[ZIEHUNGEN];
	int LottoTemp[ZIEHUNGEN];
	int ErrateneZahlen[ZIEHUNGEN];

	Eingabe(Zahlen);
	Ziehung(Lotto, LottoTemp);
	KorrekteZahlen(Lotto, Zahlen, ErrateneZahlen);

	system("cls");
	cout << "Die Lotto Zahlen der Woche sind:" << endl << endl;
	Ausgabe(Lotto, Zahlen, ErrateneZahlen);

	cout << endl << endl;

	system("pause");
	return 0;
}
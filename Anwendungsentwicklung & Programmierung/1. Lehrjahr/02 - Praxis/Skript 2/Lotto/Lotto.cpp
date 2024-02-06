#include <iostream>
#include "Lotto.h"

using namespace std;


void Ziehung(int* Lotto, int* LottoTemp)
{
	srand(time(nullptr));

	int Zahl;
	bool IntAvailible;

	for (int i = 0; i < ZIEHUNGEN; i++)
	{
		IntAvailible = false;

		while(!IntAvailible)
		{ 
			Zahl = rand() % FELDER + 1;
			if (!IstIntInArray(Zahl, LottoTemp))
			{
				IntAvailible = true;
			}
		}

		LottoTemp[i] = Zahl;
		Lotto[i] = Zahl;
	}

	SortArray(Lotto);
}

void Ausgabe(int* Lotto, int* Zahlen, int* ErrateneZahlen)
{
	int Zahl;

	for (int i = 0; i < ZIEHUNGEN; i++)
	{
		cout << Lotto[i] << endl;
	}

	cout << endl << "Dies sind Ihre Zahlen:";
	for (int x = 0; x < ZIEHUNGEN; x++)
	{
		cout << endl << Zahlen[x];
	}

	cout << endl << endl << "Diese Zahlen haben Sie erraten: ";

	for (int j = 0; j < ZIEHUNGEN; j++)
	{
		Zahl = ErrateneZahlen[j];

		if (Zahl != 0)
		{
			cout << endl << Zahl;
		}
	}
}

bool IstIntInArray(int Zahl, int* ArrayTemp)
{
	for (int j = 0; j < ZIEHUNGEN; j++)
	{
		if (ArrayTemp[j] == Zahl)
		{
			return true;
		}
	}
	return false;
}

void Eingabe(int* Zahlen)
{
	bool correctNum;
	int Zahl;

	for (int i = 0; i < ZIEHUNGEN; i++)
	{
		Zahlen[i] = 0;
	}

	for (int i = 0; i < ZIEHUNGEN; i++)
	{
		correctNum = false;

		while (!correctNum)
		{
			system("cls");

			cout << "Bitte geben Sie eine gueltige Zahl fuer Zahl \"" << i + 1 << "\" ein: ";

			cin >> Zahl;

			if (Zahl > 0 && Zahl <= FELDER)
			{
				if (!IstIntInArray(Zahl, Zahlen))
				{
					Zahlen[i] = Zahl;
					correctNum = true;
				}
			}
		}
	}

	SortArray(Zahlen);
}

void KorrekteZahlen(int* Lotto, int* Zahlen, int* ErrateneZahlen)
{
	for (int x = 0; x < ZIEHUNGEN; x++)
	{
		ErrateneZahlen[x] = 0;
	}

	for (int i = 0; i < ZIEHUNGEN; i++)
	{
		for (int j = 0; j < ZIEHUNGEN; j++)
		{
			if (Lotto[i] == Zahlen[j])
			{
				if (!IstIntInArray(Zahlen[j], ErrateneZahlen))
				{
					ErrateneZahlen[i] = Zahlen[j];
				}
			}
		}
	}
}

void SortArray(int* Array)
{
	int temp;

	for (int i = 0; i < ZIEHUNGEN; i++) {
		for (int j = i + 1; j < ZIEHUNGEN; j++)
		{
			if (Array[j] < Array[i]) {
				temp = Array[i];
				Array[i] = Array[j];
				Array[j] = temp;
			}
		}
	}
}
#include "Lottoschein.h"
#include <iostream>

using namespace std;

void InitialisiereLottoschein(Lottoschein* einLottoschein)
{
	einLottoschein->prüfzahl = 8320398475;
	einLottoschein->losnummer = 9283572;
	einLottoschein->hatAbo = false;
	einLottoschein->laufzeit = 0;
	einLottoschein->spieltAmMittwoch = true;
	einLottoschein->spieltAmSamstag = true;
	einLottoschein->glücksSpirale = false;
	einLottoschein->glücksSpiraleSigerChance = false;
	einLottoschein->spiel77 = true;
	einLottoschein->super6 = true;

	for (int spiel = 0; spiel < anzahlSpiele; spiel++)
	{
		for (int zahl = 0; zahl < anzahlGewählteZahlen; zahl++)
		{
			einLottoschein->lottoZahlen[spiel][zahl] = rand() % anzahlZahlen + 1;
		}
	}
}

void AusgabeLottoschein(Lottoschein einLottoschein)
{
	cout << "|-------------------------------------------------------------|" << endl
		 << "|  LOTTO 6 aus 49 \t\t\t Samstag + Mittwoch:  |" << endl
		 << "|  Normalschein   \t\t\t     Gleiche Chancen  |" << endl
		 << "|-------------------------------------------------------------|" << endl;

	for (int spiel = 0; spiel < anzahlSpiele; spiel++)
	{
		cout << "|  Spiel " << spiel + 1 << "          \t\t\t\t\t      |" << endl
			 << "|                                                             |" << endl;

		for (int zahl = 0; zahl < anzahlGewählteZahlen; zahl++)
		{
			cout << "|  " << einLottoschein.lottoZahlen[spiel][zahl] << "     \t\t\t\t\t\t      |" << endl;
		}
		cout << "|-------------------------------------------------------------|" << endl;
	}

	cout << endl << "Pruefzahl: " << einLottoschein.prüfzahl << "\tLosnummer: " << einLottoschein.losnummer << endl;

	if (einLottoschein.glücksSpirale == true)
	{
		cout << endl << "GluecksSpirale: Ja";
	}
	else
	{
		cout << endl << "GluecksSpirale: Nein";
	}

	if (einLottoschein.glücksSpiraleSigerChance == true)
	{
		cout << endl << "GluecksSpirale Sieger-Chance: Ja";
	}
	else
	{
		cout << endl << "GluecksSpirale Sieger-Chance: Nein";
	}

	if (einLottoschein.spiel77 == true)
	{
		cout << endl << "Spiel 77: Ja";
	}
	else
	{
		cout << endl << "Spiel 77: Nein";
	}

	if (einLottoschein.super6 == true)
	{
		cout << endl << "Super 6: Ja" << endl;
	}
	else
	{
		cout << endl << "Super 6: Nein" << endl;
	}

	if (einLottoschein.spieltAmMittwoch == true && einLottoschein.spieltAmSamstag == true)
	{
		cout << endl << "Ziehungstage: Mittwoch und Samstag";
	}
	else if(einLottoschein.spieltAmMittwoch == true)
	{
		cout << endl << "Ziehungstage: Mittwoch";
	}
	else if (einLottoschein.spieltAmSamstag == true)
	{
		cout << endl << "Ziehungstage: Samstag";
	}
	else
	{
		cout << endl << "ERROR ZIEHUNGSTAGE";
	}

	cout << endl << "Laufzeit in Wochen: " << einLottoschein.laufzeit;

	if (einLottoschein.hatAbo)
	{
		cout << endl << "ABO: Ja";
	}
	else
	{
		cout << endl << "ABO: Nein";
	}
}
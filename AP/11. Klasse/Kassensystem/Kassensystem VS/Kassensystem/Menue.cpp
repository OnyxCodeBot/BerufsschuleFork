/*	Konstruktoren und Funktionen implementieren	*/
#include<iostream>
#include"Menue.h"

using namespace std;

namespace Anwendung
{
	// Konstruktor /Destruktor
	Menue::Menue()
	{
		anzahl = 0;
		aMnuPunkte = NULL;
	}

	Menue::~Menue()
	{
		if(aMnuPunkte != NULL)
		{
			delete [] aMnuPunkte;
		}
	}

	// Konstruktor mit zwei Menuepunkten
	Menue::Menue(string a, string b)
	{
		// Setzt die Anzahl der Menuepunkte
		anzahl = 2;		

		// initialisiert das Menüpunkt - array
		aMnuPunkte = new string [anzahl];

		aMnuPunkte[0] = a;
		aMnuPunkte[1] = b;
		
	}

	// Konstruktor mit drei Menuepunkten
	Menue::Menue(string a, string b, string c)
	{
		// Setzt die Anzahl der Menuepunkte
		anzahl = 3;		

		// initialisiert das Menüpunkt - array
		aMnuPunkte = new string[anzahl];

		aMnuPunkte[0] = a;
		aMnuPunkte[1] = b;
		aMnuPunkte[2] = c;
	}

	// Konstruktor mit vier Menuepunkten
	Menue::Menue(string a, string b, string c, string d)
	{
		// Setzt die Anzahl der Menuepunkte
		anzahl = 4;		

		// initialisiert das Menüpunkt - array
		aMnuPunkte = new string[anzahl];
		aMnuPunkte[0] = a;	
		aMnuPunkte[1] = b;
		aMnuPunkte[2] = c;
		aMnuPunkte[3] = d;
	}

	// Konstruktor mit fuenf Menuepunkten
	Menue::Menue(string a, string b, string c, string d, string e)
	{
		// Setzt die Anzahl der Menuepunkte
		anzahl = 5;		
		
		// initialisiert das Menüpunkt - array
		aMnuPunkte = new string[anzahl];
		aMnuPunkte[0] = a;	
		aMnuPunkte[1] = b;
		aMnuPunkte[2] = c;
		aMnuPunkte[3] = d;
		aMnuPunkte[4] = e;
	}

	// Zeigt das Menue an und liefert die Auswahl des Benutzers zurueck
	char Menue::ZeigMenue()
	{
		char wahl='0';
		
		cout << "\n-------------------------"
			<< "\nMenue: Bitte waehlen Sie!"
			<< "\n-------------------------\n\n";

		for(int i=0; i<anzahl; i++)
		{
			cout << i << "  --  "<< aMnuPunkte[i] << " \n";
		}

		// Eingabe der Menueauswahl
		cin >> wahl;
		
		return wahl;
	}
}
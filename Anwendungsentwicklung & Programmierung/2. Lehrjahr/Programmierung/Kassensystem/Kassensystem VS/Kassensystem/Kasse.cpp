#include <iostream>
#include "Kasse.h"

Kassensystem::Kasse::Kasse(DB_Treiber::IArtDatenBank* db)
{
	ihreDatenBank = db;
	ihrMenue = new Anwendung::Menue("Beenden", "neue Ware", "hat getankt?", "Rechnung erstellen");
}

Kassensystem::Kasse::~Kasse()
{
	delete ihrMenue;
}

void Kassensystem::Kasse::Buche()
{
}

void Kassensystem::Kasse::Getankt()
{
}

void Kassensystem::Kasse::NeueWare()
{
}

void Kassensystem::Kasse::Rechnung()
{
}

void Kassensystem::Kasse::StarteAktion()
{
	do
	{
		switch (ihrMenue->ZeigMenue())
		{
		case '0':
			exit(-1);
			break;
		case '1':
			NeueWare();
			break;
		default:
			std::cout << "Falsche Eingabe!";
			break;
		}
	} while (true);
}

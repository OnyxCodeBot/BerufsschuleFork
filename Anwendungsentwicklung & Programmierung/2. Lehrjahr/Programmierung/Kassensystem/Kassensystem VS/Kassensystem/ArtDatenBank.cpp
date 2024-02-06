#include <iostream>
#include "ArtDatenBank.h"

long DB_Treiber::ArtDatenBank::GetArtNummer()
{
	return ihrDatensatz.artNummer;
}

char* DB_Treiber::ArtDatenBank::GetBezeichnung()
{
	return ihrDatensatz.bez;
}

double DB_Treiber::ArtDatenBank::GetHSP()
{
	return ihrDatensatz.hsp;
}

double DB_Treiber::ArtDatenBank::GetNetto()
{
	return ihrDatensatz.netto;
}

bool DB_Treiber::ArtDatenBank::SucheDatenSatz(long no)
{
	char buffer[128];
	char dataBuffer[25];
	long artnum = 0;

	char* next_token = NULL;


	ihreDaten.clear();

	ihreDaten.seekg(0, std::ios_base::beg);

	//Überspringen
	ihreDaten.ignore(128, '\n'); //XML-Header
	ihreDaten.ignore(128, '\n'); //Preisliste Tag
	ihreDaten.ignore(128, '\n'); //Artikel Tag

	ihreDaten.getline(buffer, 128);

	while (!ihreDaten.eof())
	{
		//Starttag extrahieren <Artikelnummer>
		strcpy_s(dataBuffer, strtok_s(buffer, ">", &next_token));
		//Artikelnummer extrahieren
		strcpy_s(dataBuffer, strtok_s(NULL, "<", &next_token));

		artnum = atol(dataBuffer);

		if (artnum == no)
		{
			ihrDatensatz.artNummer = artnum;

			//Bezeichnung
			ihreDaten.getline(buffer, 128);
			strcpy_s(dataBuffer, strtok_s(buffer, ">", &next_token));
			strcpy_s(ihrDatensatz.bez, strtok_s(NULL, "<", &next_token));

			//Preis
			ihreDaten.getline(buffer, 128);
			strcpy_s(dataBuffer, strtok_s(buffer, ">", &next_token));
			strcpy_s(dataBuffer, strtok_s(NULL, "<", &next_token));
			ihrDatensatz.netto = atof(dataBuffer);

			//Handelsspanne
			ihreDaten.getline(buffer, 128);
			strcpy_s(dataBuffer, strtok_s(buffer, ">", &next_token));
			strcpy_s(dataBuffer, strtok_s(NULL, "<", &next_token));
			ihrDatensatz.hsp = atof(dataBuffer);

			return true;
		}

		ihreDaten.ignore(128, '\n');
		ihreDaten.ignore(128, '\n');
		ihreDaten.ignore(128, '\n');
		ihreDaten.ignore(128, '\n');
		ihreDaten.ignore(128, '\n');
		ihreDaten.getline(buffer, 128);
	}

	std::cout << "Artikel nicht gefunden!\n\n";
	return false;
}

DB_Treiber::ArtDatenBank::ArtDatenBank()
{
	OeffneDatenQuelle();
}

DB_Treiber::ArtDatenBank::~ArtDatenBank()
{
}

void DB_Treiber::ArtDatenBank::OeffneDatenQuelle()
{
	ihreDaten.open("K:\\AP\\Kassensystem\\Daten\\Daten.xml", std::ios_base::in);

	if (!ihreDaten)
	{
		std::cout << "\n\aFehler beim Lesen der Daten";
		exit(-1);
	}
}

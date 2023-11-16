#include "Alarmanlage.h"
#include <string>
#include <iostream>

using namespace std;

Alarmanlage::Alarmanlage(Schliessanlage* schl)
{
	ihreSchiessanlage = schl;
	strcpy_s(ihrStatus, "bereit");
}

Alarmanlage::~Alarmanlage()
{
}

void Alarmanlage::SetFeuer()
{
	cout << endl << endl << "Die Feuerwehr wird alarmiert!";
	ihreSchiessanlage->TresorAuf();
	ihreSchiessanlage->TuerenAuf();
	strcpy_s(ihrStatus, "Feuer");
	ShowStatus();
}

void Alarmanlage::SetEinbruch()
{
	cout << endl << endl << "Die Polizei wird alamiert!";
	
	ihreSchiessanlage->TresorZu();
	if (strcmp(ihrStatus, "bereit") == 0)
	{
		ihreSchiessanlage->TuerenZu();
		strcpy_s(ihrStatus, "Einbruch");
	}
	else if (strcmp(ihrStatus, "Feuer") == 0)
	{
		cout << endl << "Aufgrund eines Feuers waehrend des Einbruchs wird nur der Tresor geschlossen!";
		strcpy_s(ihrStatus, "Einbruch-Feuer");
	}

	ShowStatus();
}

void Alarmanlage::Reset()
{
	strcpy_s(ihrStatus, "bereit");
	ShowStatus();
}

void Alarmanlage::ShowStatus()
{
	ihrDisplay.Show(ihrStatus);
}

#include "Angestellter.h"
#include <iostream>;

using namespace std;

Angestellter::Angestellter()
{
	PersNum = 1000;
	Name[0] = '\0';
}

Angestellter::~Angestellter()
{
}

char* Angestellter::getName()
{
	return Name;
}

int Angestellter::getPersNum()
{
	return PersNum;
}

void Angestellter::setName(const char* n)
{
	strcpy_s(Name, n);
}

void Angestellter::setPersNum(int pn)
{
	while (pn < 1000 || pn > 9999)
	{
		cout << endl << Name << endl << "PersNum muss 4 Stellig sein!" << endl << endl;
		cout << "Geben Sie die Personalnummer erneut ein: ";
		cin >> pn;
	}

	PersNum = pn;
}

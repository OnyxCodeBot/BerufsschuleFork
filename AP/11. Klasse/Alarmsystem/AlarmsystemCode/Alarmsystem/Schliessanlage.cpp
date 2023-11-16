#include "Schliessanlage.h"
#include <iostream>

using namespace std;

Schliessanlage::Schliessanlage()
{
}

Schliessanlage::~Schliessanlage()
{
}

void Schliessanlage::TuerenAuf()
{
	tuereOffen = true;
	cout << endl << "Tueren geoeffnet!";
}

void Schliessanlage::TuerenZu()
{
	tuereOffen = false;
	cout << endl << "Tueren geschlossen!";
}

void Schliessanlage::TresorAuf()
{
	tresorOffen = true;
	cout << endl << "Tresor geoffnet!";
}

void Schliessanlage::TresorZu()
{
	tresorOffen = false;
	cout << endl << "Tresor geschlossen!";
}
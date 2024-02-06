#include <iostream>
#include "Zaehler.h"
#include <iostream>

extern int counter;

void Zaehlen()
{
	counter = counter + 1;

	static int zaehler = 100;
	zaehler = zaehler + 1;

	std::cout << "\n\nZaehler: " << zaehler << std::endl << std::endl;
}
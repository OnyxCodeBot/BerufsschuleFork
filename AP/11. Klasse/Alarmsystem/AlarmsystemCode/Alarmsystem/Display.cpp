#include "Display.h"
#include <iostream>

using namespace std;

Display::Display()
{
}

Display::~Display()
{
}

void Display::Show(char* stat)
{
	cout << endl << stat << endl;
}

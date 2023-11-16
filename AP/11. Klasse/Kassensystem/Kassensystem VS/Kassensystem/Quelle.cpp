#include <iostream>
#include "ArtDatenBank.h"
#include "Kasse.h"

using namespace std;

int main()
{
	DB_Treiber::ArtDatenBank DB;

	Kassensystem::Kasse Kasse(&DB);

	Kasse.StarteAktion();
	
	return 0;
}
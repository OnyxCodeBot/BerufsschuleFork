#include "Lottoschein.h"
#include <iostream>

using namespace std;

int main()
{
	Lottoschein einLottoschein{};

	InitialisiereLottoschein(&einLottoschein);

	AusgabeLottoschein(einLottoschein);

	cout << endl << endl << endl;
	system("PAUSE");
	return 0;
}
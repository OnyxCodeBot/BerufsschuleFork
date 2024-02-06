#include <iostream>
#include <algorithm>
using namespace std;

// T ist ein "Joker" für den Datentyp (Wildcard)
template <class T> void Ausgabe(T aArray[])
{
	for (int i = 0; i < 12; i++)
	{
		cout << aArray[i] << ' ';
	}
	cout << endl;
}

//int main()
//{
//	int aZahlen[12] = { 1, 4, 77, 45, 34, 22, 33, 45, 6, 67, 8, 9 };
//	char aWort[12] = "Algorithmen";
//
//	cout << "Normal:\t\t";
//	Ausgabe(aZahlen);
//	
//	sort(&aZahlen[0], &aZahlen[12]);
//	cout << "Sortiert:\t";
//	Ausgabe(aZahlen);
//	
//	reverse(&aZahlen[0], &aZahlen[12]);
//	cout << "Inversiert:\t";
//	Ausgabe(aZahlen);
//
//	random_shuffle(&aZahlen[0], &aZahlen[12]);
//	cout << "Vermischt:\t";
//	Ausgabe(aZahlen);
//
//	replace(&aZahlen[0], &aZahlen[12], 45, 17);
//	cout << "Ersetzt:\t";
//	Ausgabe(aZahlen);
//
//	remove(&aZahlen[0], &aZahlen[12], 17);
//	cout << "Entfernt:\t";
//	Ausgabe(aZahlen);
//
//	cout << endl;
//
//	cout << "Normal:\t\t";
//	Ausgabe(aWort);
//
//	sort(&aWort[0], &aWort[12]);
//	cout << "Sortiert:\t";
//	Ausgabe(aWort);
//
//	reverse(&aWort[0], &aWort[12]);
//	cout << "Inversiert:\t";
//	Ausgabe(aWort);
//
//	random_shuffle(&aWort[0], &aWort[12]);
//	cout << "Vermischt:\t";
//	Ausgabe(aWort);
//
//	replace(&aWort[0], &aWort[12], 'A', 'B');
//	cout << "Ersetzt:\t";
//	Ausgabe(aWort);
//
//	remove(&aWort[0], &aWort[12], 'e');
//	cout << "Entfernt:\t";
//	Ausgabe(aWort);
//
//	cout << endl << endl << endl;
//	return 0;
//}
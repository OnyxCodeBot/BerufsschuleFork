#include <iostream>

using namespace std;

int main()
{
	int zahl = 16;
	int* pZahl = NULL;
	int* pPointerZahl = NULL;

	pZahl = &zahl;
	pPointerZahl = pZahl;

	cout << "\nDer Wert der int - Variable 'zahl':\t" << zahl;
	cout << "\nDie Adresse der int - Variable '&zahl':\t" << &zahl;
	cout << "\nDer Wert, auf den '*pzahl' deutet:\t" << *pZahl;
	cout << "\nDie Adresse, auf die 'pzahl' deutet:\t" << pZahl << endl << endl;

	zahl = 17;

	cout << "\nDer Wert der int - Variable 'zahl':\t" << zahl;
	cout << "\nDie Adresse der int - Variable '&zahl':\t" << &zahl;
	cout << "\nDer Wert, auf den '*pzahl' deutet:\t" << *pZahl;
	cout << "\nDie Adresse, auf die 'pzahl' deutet:\t" << pZahl << endl << endl;

	cout << *pPointerZahl << "  " << pPointerZahl;

	system("PAUSE");
	return 0;
}
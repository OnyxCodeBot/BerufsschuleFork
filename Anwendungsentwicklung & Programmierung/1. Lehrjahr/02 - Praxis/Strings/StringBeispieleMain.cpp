#include <iostream>
using namespace std;

int main()
{
	const char* aString = "Hallo"; //1. String Pool

	aString = "Wie viele Zeichen sind es?"; //2. String Pool

	char* pString = new char[26]; //3. Zeiger auf Heap

	pString[0] = 'H';
	pString[1] = 'A';
	pString[2] = 'L';
	pString[3] = 'L';
	pString[4] = 'O';
	pString[5] = '\0';

	int i = 0;

	do
	{
		cout << aString[i];
		i++;
	} while (aString[i] != '\0');

	cout << endl << endl << endl;

	i = 0;
	do
	{
		cout << pString[i];
		i++;
	} while (pString[i] != '\0');

	cout << endl << endl << endl;
	system("pause");
	return 0;
}
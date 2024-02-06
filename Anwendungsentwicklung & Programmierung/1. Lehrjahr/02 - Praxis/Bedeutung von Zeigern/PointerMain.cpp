#include <iostream>

using namespace std;

void vertauscheTemp(int a, int b)
{
	int tempA = a;
	a = b;
	b = tempA;

	cout << "a Vertauscht Temp = " << a << endl
		<< "b Vertauscht Temp = " << b << endl;
}

void vertausche(int* a, int* b)
{
	int tempA = *a;
	*a = *b;
	*b = tempA;

	cout << "a Vertauscht = " << *a << endl
		<< "b Vertauscht = " << *b << endl;
}

int main()
{
	int a = 8, b = 5;

	cout << "a Vorher = " << a << endl
		<< "b Vorher = " << b << endl;

	vertauscheTemp(a, b);

	cout << "a Nach Temp = " << a << endl
		<< "b Nach Temp = " << b << endl;

	int* pA = &a;
	int* pB = &b;

	vertausche(pA, pB);

	cout << "a Nachher = " << a << endl
		<< "b Nachher = " << b << endl;

	system("pause");
	return 0;
}
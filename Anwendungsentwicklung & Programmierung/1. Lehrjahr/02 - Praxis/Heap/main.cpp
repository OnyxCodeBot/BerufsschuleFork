#include <iostream>
#include "heap.h"

using namespace std;

int main()
{

	int* pointer = funktion();
	

	cout << *pointer;
delete pointer;
	system("pause");
	return 0;
}
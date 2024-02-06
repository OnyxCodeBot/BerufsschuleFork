#include "heap.h"

int* funktion()
{
	int* pZeiger;
	pZeiger = new int;

	*pZeiger = 4;

	return pZeiger;
}
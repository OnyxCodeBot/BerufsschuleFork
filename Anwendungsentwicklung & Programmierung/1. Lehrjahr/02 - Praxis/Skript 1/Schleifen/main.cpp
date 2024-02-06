#include <iostream>

using namespace std;

int main()
{
	int i = 10;

	cout << "\tWhile Schleife:\n\n";

	while (i > 0)
	{
		cout << "\t " << i << endl;
		i -= 1;
	}

	i = 10;
	cout << endl << "\tDo-While Schleife:\n" << endl;

	do
	{
		cout << "\t " << i << endl;
		i -= 1;
	} while (i > 0);

	cout << endl << "\tFor Schleife:\n" << endl;

	for (i = 10; i > 0; i--)
	{
		cout << "\t " << i << endl;
	}

	system("pause");
	return 0;
}
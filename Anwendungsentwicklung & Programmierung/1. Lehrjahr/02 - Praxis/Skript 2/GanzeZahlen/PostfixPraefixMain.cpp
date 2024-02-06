#include <iostream>

using namespace std;

int main()
{
	int x = 10, y = 10;

	cout << "y = " << y 
		<< endl << "y++ * 4 - y = " << y++ * 4 - y 
		<< endl 
		<< endl << "x = " << x 
		<< endl << "++x * 4 - x = " << ++x * 4 - x
		<< endl << endl;

	system("pause");
	return 0;
}
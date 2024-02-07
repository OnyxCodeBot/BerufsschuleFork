#include <iostream>

using namespace std;


int main()
{

int zahl = 5;
int& rRef = zahl;

cout << "zahl: " << zahl << endl;
cout << "rRef: " << rRef << endl;

cout << "&zahl: " << &zahl << endl;
cout << "&rRef: " << &rRef << endl;

cout << endl << endl << endl << endl;

zahl = 7;

cout << "zahl: " << zahl << endl;
cout << "rRef: " << rRef << endl;

cout << "&zahl: " << &zahl << endl;
cout << "&rRef: " << &rRef << endl;

cout << endl << endl << endl << endl;

int zahl2 = 9;
rRef = zahl2;

cout << "zahl: " << zahl << endl;
cout << "zahl2: " << zahl2 << endl;
cout << "rRef: " << rRef << endl;

cout << "&zahl: " << &zahl << endl;
cout << "&zahl2: " << &zahl2 << endl;
cout << "&rRef: " << &rRef << endl;

system("pause");

}

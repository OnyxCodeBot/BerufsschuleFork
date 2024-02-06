#include <iostream>
using namespace std;

int main()
{
	cout << "-------------------------------------------\n";
	cout << "short \t\t\t= " << sizeof(short) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "int \t\t\t= " << sizeof(int) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "long \t\t\t= " << sizeof(short) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "unsigned short \t\t= " << sizeof(unsigned short) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "unsinged int \t\t= " << sizeof(unsigned int) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "unsigned long \t\t= " << sizeof(unsigned long) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "unsinged long long \t= " << sizeof(unsigned long long) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "float \t\t\t= " << sizeof(float) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "double \t\t\t= " << sizeof(double) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "char \t\t\t= " << sizeof(char) << " Byte\n\n";

	char zeichen;
	cout << "zeichen \t\t= " << sizeof(zeichen) << " Byte\n\n";

	cout << "short* \t\t\t= " << sizeof(short*) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "int* \t\t\t= " << sizeof(int*) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "long* \t\t\t= " << sizeof(short*) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "unsigned short* \t= " << sizeof(unsigned short*) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "unsinged int* \t\t= " << sizeof(unsigned int*) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "unsigned long* \t\t= " << sizeof(unsigned long*) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "unsinged long long* \t= " << sizeof(unsigned long long*) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "float* \t\t\t= " << sizeof(float*) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "double* \t\t= " << sizeof(double*) << " Byte\n";
	cout << "-------------------------------------------\n";
	cout << "char* \t\t\t= " << sizeof(char*) << " Byte\n";
	cout << "-------------------------------------------\n";

	system("pause");
	return 0;
}
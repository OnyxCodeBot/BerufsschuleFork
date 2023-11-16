#include <vector>
#include <iostream>
using namespace std;

void Show(vector<char>& v)
{
	vector <char>::iterator I;
	I = v.begin();

	while (I != v.end())
	{
		cout << *I++;
	}
	cout << endl;
}

int main()
{
	vector<char> cont1;

	char test[200];

	cout << "Bitte ein beliebiges Wort eingeben:";
	cin >> test;

	for (int i = 0; test[i] != '\0'; i++)
	{
		cont1.push_back(test[i]);
	}

	cout << "Size:" << cont1.size() << endl;
	cout << "Max Size GiB:" << cont1.max_size() / 1024 / 1024 / 1024 << endl;

	cont1.clear();
	cout << "Size:" << cont1.size() << endl;

	cout << endl << endl;
	Show(cont1);
}
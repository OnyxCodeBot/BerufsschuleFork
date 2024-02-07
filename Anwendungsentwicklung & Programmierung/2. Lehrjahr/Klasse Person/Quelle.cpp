#include "iostream"
#include "Person.h"
#include "Angestellter.h"

using namespace std;

int main() 
{
	/*int alter;

	Person diePerson;

	do
	{
		cout << "Geben Sie ihr Alter ein: ";
		cin >> alter;


		if (diePerson.ValidAlter(alter))
		{
			diePerson.SetAlter(alter);
			cout << "Alter: " << diePerson.GetAlter() << endl;
		}
		else
		{
			cout << "Alter darf nicht Negativ sein." << endl << endl;
		}
	} while (diePerson.ValidAlter(alter) == false);*/


	Angestellter Dev1;

	Dev1.setName("Max Mustermann");
	Dev1.setPersNum(1001);

	Angestellter Dev2;

	Dev2.setName("Maximilian Adalbert");
	Dev2.setPersNum(13);


	cout << "Dev 1:" << endl << Dev1.getName() << endl << Dev1.getPersNum() << endl << endl;
	cout << "Dev 2:" << endl << Dev2.getName() << endl << Dev2.getPersNum() << endl << endl;


	system("pause");
	return 0;
}
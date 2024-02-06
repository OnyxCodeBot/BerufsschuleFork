#include <iostream>

int main()
{
	bool leave = false;
	char wahl = ' ';

	/*do
	{*/
		system("cls");
		double radius, flaeche;
		const double PI = 3.14159;
		const char ae = 132;

		/*		std::cout << "Bitte geben Sie den Radius des Kreises ein:\nEingabe: ";
		std::cin >> radius;

		flaeche = (radius * radius) * PI;

		std::cout << "\n\nDie Fl" << ae << "che des Kreises ist:\n";
		std::cout << flaeche << std::endl << std::endl;

		std::cout << "Willst du nochmal die Fl" << ae << "che eines Kreises berechnen? (J|N)\nEingabe: ";
		std::cin >> wahl;
		switch (wahl)
		{
		case 'J':
			leave = false;
			break;
		case 'j':
			leave = false;
			break;
		case 'N':
			leave = true;
			break;
		case 'n':
			leave = true;
			break;
		default:
			std::cout << "\n\nERROR Konnte Eingabe nicht erkennen!\n\n";
			leave = true;
			break;
		}

	} while (leave == false);		*/


		printf("Geben Sie den Radius ein: \t");
		scanf_s("%lf", &radius);
		flaeche = PI * (radius * radius);
		printf("Die Fl%cche ist %lf \n Ende \n", ae, flaeche);

	system("Pause");
	return 0;
}
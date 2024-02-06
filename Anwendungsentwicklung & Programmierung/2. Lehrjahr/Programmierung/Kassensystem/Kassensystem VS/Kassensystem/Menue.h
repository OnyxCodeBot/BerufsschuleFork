/***	Headerdatei f�r Menues mit 2 bis 5 Punkten	***/
/***	     in der Programmiersprache C++	    	***/
#include <string>
using namespace std;
namespace Anwendung
{
	#ifndef MENUE
		#define MENUE

	/*	Die Klasse "Menue" deklarieren	*/
	class Menue
	{

	public:	
		// Standard Konstruktor, Destruktor
		Menue();
		~Menue();

		// �berladene Konstruktoren f�r 2 bis 5 Men�punkte deklarieren
		// Konstruktor f�r zwei Men�punkte
			Menue(string a, string b);
		// Konstruktor f�r drei Men�punkte
			Menue(string a, string b,string c);
		// Konstruktor f�r vier Men�punkte
			Menue(string a, string b, string c, string d);
		// Konstruktor f�r f�nf Men�punkte
			Menue(string a, string b, string c, string d, string e);
		
		// Menue anzeigen und Benutzerauswahl zur�kliefern
		char ZeigMenue();

	private:
		//  String - Array als Pointer
		string* aMnuPunkte;

		// speichert die Anzahl der Menuepunkte
		int anzahl;
	};

	#endif
}
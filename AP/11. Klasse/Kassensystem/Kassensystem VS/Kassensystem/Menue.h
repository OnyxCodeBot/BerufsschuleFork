/***	Headerdatei für Menues mit 2 bis 5 Punkten	***/
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

		// Überladene Konstruktoren für 2 bis 5 Menüpunkte deklarieren
		// Konstruktor für zwei Menüpunkte
			Menue(string a, string b);
		// Konstruktor für drei Menüpunkte
			Menue(string a, string b,string c);
		// Konstruktor für vier Menüpunkte
			Menue(string a, string b, string c, string d);
		// Konstruktor für fünf Menüpunkte
			Menue(string a, string b, string c, string d, string e);
		
		// Menue anzeigen und Benutzerauswahl zurükliefern
		char ZeigMenue();

	private:
		//  String - Array als Pointer
		string* aMnuPunkte;

		// speichert die Anzahl der Menuepunkte
		int anzahl;
	};

	#endif
}
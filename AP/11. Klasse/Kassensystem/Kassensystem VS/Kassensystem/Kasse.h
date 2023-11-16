#pragma once
#include "IArtDatenBank.h"
#include "Menue.h"

namespace Kassensystem
{
	class Kasse
	{
	public:
		Kasse(DB_Treiber::IArtDatenBank* ihreDatenBank);
		~Kasse();
		void Buche();
		void Getankt();
		void NeueWare();
		void Rechnung();
		void StarteAktion();

	private:
		DB_Treiber::IArtDatenBank* ihreDatenBank;
		Anwendung::Menue* ihrMenue;
	};
}
#pragma once
#include <fstream>
#include "IArtDatenBank.h"

namespace DB_Treiber
{
	class ArtDatenBank : public IArtDatenBank
	{
	public:
		long GetArtNummer();
		char* GetBezeichnung();
		double GetHSP();
		double GetNetto();
		bool SucheDatenSatz(long no);

		ArtDatenBank();
		~ArtDatenBank();

	private:
		std::ifstream ihreDaten;
		struct DatenSatz
		{
			long artNummer;
			char bez[15];
			double hsp;
			double netto;
		} ihrDatensatz;

		void OeffneDatenQuelle();
	};
}
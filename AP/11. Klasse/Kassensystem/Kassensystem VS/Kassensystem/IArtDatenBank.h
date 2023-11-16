#pragma once

namespace DB_Treiber
{
	class IArtDatenBank
	{
	public:
		virtual long GetArtNummer() = 0;
		virtual char* GetBezeichnung() = 0;
		virtual double GetHSP() = 0;
		virtual double GetNetto() = 0;
		virtual bool SucheDatenSatz(long no) = 0;
	};
}
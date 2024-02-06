#ifndef test
#define test

const int anzahlSpiele = 120, anzahlGew�hlteZahlen = 6, anzahlZahlen = 49;

typedef struct Lottoschein
{
	int losnummer;

	long long pr�fzahl;

	int lottoZahlen[anzahlSpiele][anzahlGew�hlteZahlen];
	
	bool spieltAmSamstag;
	bool spieltAmMittwoch;

	short laufzeit;

	bool hatAbo;

	bool gl�cksSpirale;
	bool gl�cksSpiraleSigerChance;

	bool spiel77;

	bool super6;
};

void InitialisiereLottoschein(Lottoschein*);
void AusgabeLottoschein(Lottoschein);

#endif
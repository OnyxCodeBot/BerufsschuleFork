#ifndef test
#define test

const int anzahlSpiele = 120, anzahlGewählteZahlen = 6, anzahlZahlen = 49;

typedef struct Lottoschein
{
	int losnummer;

	long long prüfzahl;

	int lottoZahlen[anzahlSpiele][anzahlGewählteZahlen];
	
	bool spieltAmSamstag;
	bool spieltAmMittwoch;

	short laufzeit;

	bool hatAbo;

	bool glücksSpirale;
	bool glücksSpiraleSigerChance;

	bool spiel77;

	bool super6;
};

void InitialisiereLottoschein(Lottoschein*);
void AusgabeLottoschein(Lottoschein);

#endif
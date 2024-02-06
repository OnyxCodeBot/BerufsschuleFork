#pragma once

const int ZIEHUNGEN = 6;
const int FELDER = 49;

void Ziehung(int*, int*);
void Ausgabe(int*, int*, int*);
void Eingabe(int*);
bool IstIntInArray(int, int*);
void KorrekteZahlen(int*, int*, int*);
void SortArray(int*);
#include <iostream>
#include "zins.h"

double KapitalNach1Jahr(double startKapital, double zinssatz) {

	double endKapital = 0.0;

	endKapital = startKapital + (startKapital * (zinssatz / 100));

	return endKapital;
}

double KapitalNach2Jahr(double startKapital, double zinssatz) {

	double endKapital = 0.0;

	endKapital = KapitalNach1Jahr(startKapital, zinssatz) * (1 + zinssatz / 100);

	return endKapital;
}

double KapitalNach3Jahr(double startKapital, double zinssatz) {

	double endKapital = 0.0;

	endKapital = KapitalNach2Jahr(startKapital, zinssatz) * (1 + zinssatz / 100);

	return endKapital;
}

double KapitalNach4Jahr(double startKapital, double zinssatz) {

	double endKapital = 0.0;

	endKapital = KapitalNach3Jahr(startKapital, zinssatz) * (1 + zinssatz / 100);

	return endKapital;
}
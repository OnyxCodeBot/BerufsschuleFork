#include "Applikation.h"
#include "Schliessanlage.h"
#include "Alarmanlage.h"
#include "Feuersensor.h"
#include "Einbruchsmelder.h"

#include <iostream>

using namespace std;

Applikation::Applikation()
{

}

Applikation::~Applikation()
{

}

void Applikation::Run()
{
	Schliessanlage* dieSchliessanlage = new Schliessanlage();
	Alarmanlage* dieAlarmanlage = new Alarmanlage( dieSchliessanlage );

	IMelder* derFSensor = new Feuersensor();
	derFSensor->Anschliessen(dieAlarmanlage);

	IMelder* derEMelder = new Einbruchsmelder();
	derEMelder->Anschliessen(dieAlarmanlage);

	//Feuer
	cout << endl << endl << endl << "Testfall: Feuer" << endl << endl << endl;
	derFSensor->GibAlarm();
	dieAlarmanlage->Reset();

	//Einbruch
	cout << endl << endl << endl << "Testfall: Einbruch" << endl << endl << endl;
	derEMelder->GibAlarm();
	dieAlarmanlage->Reset();

	//Einbruch waehrend Feuer
	cout << endl << endl << endl << "Testfall: Feuer/Einbruch" << endl << endl << endl;
	derFSensor->GibAlarm();
	derEMelder->GibAlarm();
	dieAlarmanlage->Reset();
	derEMelder->GibAlarm();


	//Objekte löschen
	delete derFSensor;
	delete derEMelder;

	delete dieAlarmanlage;
	delete dieSchliessanlage;
}
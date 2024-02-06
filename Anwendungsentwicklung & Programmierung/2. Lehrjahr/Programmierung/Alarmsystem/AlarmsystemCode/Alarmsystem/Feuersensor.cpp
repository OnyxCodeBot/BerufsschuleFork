#include "Feuersensor.h"
Feuersensor::Feuersensor()
{
}

Feuersensor::~Feuersensor()
{
}

void Feuersensor::GibAlarm()
{
	seineAlarmanlage->SetFeuer();
}

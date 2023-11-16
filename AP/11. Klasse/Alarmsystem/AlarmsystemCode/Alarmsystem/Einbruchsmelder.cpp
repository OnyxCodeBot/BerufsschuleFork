#include "Einbruchsmelder.h"
void Einbruchsmelder::GibAlarm()
{
	seineAlarmanlage->SetEinbruch();
}
Einbruchsmelder::Einbruchsmelder()
{
}

Einbruchsmelder::~Einbruchsmelder()
{
}

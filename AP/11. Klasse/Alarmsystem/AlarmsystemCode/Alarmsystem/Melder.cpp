#include "Melder.h"

Melder::Melder()
{
	seineAlarmanlage = 0;
}

Melder::~Melder()
{
}

void Melder::Anschliessen(Alarmanlage* al)
{
	seineAlarmanlage = al;
}

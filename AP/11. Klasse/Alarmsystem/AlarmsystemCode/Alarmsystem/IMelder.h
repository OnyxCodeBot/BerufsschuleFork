#pragma once
#include "Alarmanlage.h"

class IMelder
{
public:
	virtual void GibAlarm() = 0;
	virtual void Anschliessen(Alarmanlage* al) = 0;
};
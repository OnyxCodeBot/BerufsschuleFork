#pragma once
#include "IMelder.h"

class Melder : public IMelder
{
public:
	Melder();
	~Melder();
	void Anschliessen(Alarmanlage* al);
protected:
	Alarmanlage* seineAlarmanlage;
};
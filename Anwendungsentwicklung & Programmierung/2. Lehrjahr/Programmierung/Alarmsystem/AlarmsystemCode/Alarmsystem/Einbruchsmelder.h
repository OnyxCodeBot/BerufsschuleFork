#pragma once
#include "Melder.h"

class Einbruchsmelder : public Melder
{
public:
	Einbruchsmelder();
	~Einbruchsmelder();
	void GibAlarm();
};
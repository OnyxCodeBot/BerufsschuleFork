#pragma once
#include "Melder.h"

class Feuersensor : public Melder
{
public:
	Feuersensor();
	~Feuersensor();
	void GibAlarm();
};
#pragma once
#include "Display.h"
#include "Schliessanlage.h"

class Alarmanlage 
{
public:
	Alarmanlage(Schliessanlage* schl);
	~Alarmanlage();
	void SetFeuer();
	void SetEinbruch();
	void Reset();
	void ShowStatus();
private:
	Schliessanlage* ihreSchiessanlage;
	Display ihrDisplay;
	char ihrStatus[20];
};
#pragma once

class Angestellter
{
public:
	Angestellter();
	~Angestellter();

	char* getName();
	int getPersNum();

	void setName(const char* n);
	void setPersNum(int pn);

private:
	int PersNum;
	char Name[40];
};
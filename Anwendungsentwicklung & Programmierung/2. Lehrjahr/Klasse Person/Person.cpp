#include "Person.h"
Person::Person()
{
	ihrAlter = 0;
}

Person::~Person()
{
}

int Person::GetAlter()
{
	return ihrAlter;
}

void Person::SetAlter(int alt)
{
	if (ValidAlter(alt))
	{
		ihrAlter = alt;
	}
}

bool Person::ValidAlter(int alt)
{
	if (alt < 0)
	{
		return false;
	}
	else
	{
		return true;
	}
}
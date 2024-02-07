#ifndef PERSON
#define PERSON

class Person
{
public:
	Person();
	~Person();

	int GetAlter();
	void SetAlter(int alt);
	bool ValidAlter(int alt);

private:
	int ihrAlter;
};

#endif
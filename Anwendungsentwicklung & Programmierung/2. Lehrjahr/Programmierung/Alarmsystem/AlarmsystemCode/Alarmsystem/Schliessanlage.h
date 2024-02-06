#pragma once
class Schliessanlage {
public:
	Schliessanlage();
	~Schliessanlage();
	void TuerenAuf();
	void TuerenZu();
	void TresorAuf();
	void TresorZu();
private:
	bool tuereOffen = true;
	bool tresorOffen = true;

};
#include <iostream>
using namespace std;

const int MAX = 200;
const char TRENNZEICHEN = ';';

struct Veranstaltung 
{
    char nr[5];
    char name[50];
    char durchgefuehrt[6];
    char teilnehmer[5];
};

int main() 
{
    FILE* CSV;

    char* line = new char[MAX];
    Veranstaltung v[100];

    fopen_s(&CSV, "Veranstaltungen.csv", "r");

    int i = 0;
    while (fgets(line, MAX, CSV) != 0) 
    {

        cout << line;
        i++;

    }

    cout << endl << "Zeilen Anzahl: " << i;

    fclose(CSV);

    cout << endl << endl;
    system("pause");
    return 0;
}
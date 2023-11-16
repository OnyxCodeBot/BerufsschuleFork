#include <windows.h>

// Fensterfunktion für die Anwendung
LRESULT CALLBACK WndProc(HWND hwnd,
	UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	// Gerätekontext für Grafikausgabe
	HDC hDC;
	PAINTSTRUCT ps;
	// Nachrichten auswerten
	switch (uMsg)
	{
	case WM_PAINT:
		hDC = BeginPaint(hwnd, &ps); //Gerätekontext laden
		if (hDC != NULL) //Wenn kein Fehler aufgetreten
		{
			char str[30] = "Hallo Windows Welt!";
			TextOut(hDC, 45, 15, str, strlen(str));//Ausgabe
			EndPaint(hwnd, &ps); //Gerätekontext freigeben
		}
		break;
	case WM_DESTROY: //Fenster wird geschlossen
		PostQuitMessage(0);
		break;
		//Andere Nachrichten an Standardfensterfunktion!
	default:
		return DefWindowProc(hwnd, uMsg, wParam, lParam);
	}
	return 0;
}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE
	hPrevInstance, LPSTR d3, int nCmdShow)
{
	// Message, Fensterhandle und Windowsklasse erzeugen
	MSG msg;
	HWND hwnd;
	WNDCLASS wndClass;
	// Wenn noch keine Instanz des Fensters läuft...
	if (hPrevInstance == NULL)
	{
		// Alle Werte der Fensterklasse mit 0 füllen
		memset(&wndClass, 0, sizeof(wndClass));
		// Windows Fensterklasse beschreiben...
		wndClass.style = CS_HREDRAW | CS_VREDRAW;
		wndClass.lpfnWndProc = WndProc;
		wndClass.hInstance = hInstance;
		wndClass.hCursor = LoadCursor(NULL, IDC_PERSON);
		wndClass.hbrBackground = CreateSolidBrush(RGB(160, 23, 66));
		wndClass.lpszClassName = "HELLO";
		// Fensterklasse kann nicht registriert werden,
		// Abbruch
		if (!RegisterClass(&wndClass))
			return FALSE;
	}
	// Fenster erzeugen
	hwnd = CreateWindow("HELLO", "HELLO WINDOWS WORLD",
		WS_OVERLAPPEDWINDOW,
		0, 0, 2560, 1440,
		NULL, NULL, hInstance, NULL);
	// Fenster anzeigen
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);
	// Message Loop starten
	while (GetMessage(&msg, NULL, 0, 0))
		DispatchMessage(&msg);
	return msg.wParam;
}

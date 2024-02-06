#include <Windows.h>

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE d2, LPSTR d3, int d4)
{
	//Message und Fensterhandle erzeugen
	MSG msg;
	HWND hwnd;

	//Fenster der Kategorie BUTTON erzeugen
	hwnd = CreateWindow("BUTTON", "Hallo Windows Welt!", WS_VISIBLE | BS_CENTER, 100, 100, 200, 80, NULL, NULL, hInstance, NULL);

	//Start der Nachrichtenschleife
	while (GetMessage(&msg, NULL, 0, 0))
	{
		//Wenn linke Maustaste losgelassen...
		if (msg.message == WM_LBUTTONUP)
		{
			//Fenster zerstören
			DestroyWindow(hwnd);
			//Message Loop verlassen
			PostQuitMessage(0);
		}
		DispatchMessage(&msg);
	}
	return msg.wParam;
}
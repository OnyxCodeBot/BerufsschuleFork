#include "Hello.h"
//Anwendungs-Objekt erzeugen
CMeineApp dieApp;
// Konstruktor von CRahmenfenster
CRahmenfenster::CRahmenfenster()
{
	//selbst die Fensterklasse definieren
	LPCTSTR classname;
	classname = AfxRegisterWndClass(CS_HREDRAW | CS_VREDRAW,
		LoadCursor(NULL, IDC_WAIT),
		(HBRUSH)(COLOR_WINDOW + 1), 0);
	//Fenster erzeugen
	Create(classname, "MFC Hello Windows World",
		WS_OVERLAPPEDWINDOW,
		CRect(10, 10, 250, 100));
	m_Text = "Hallo Windows Welt!";
}
//Antwortfunktion zu WM_PAINT
void CRahmenfenster::OnPaint()
{
	// DC im Rahmenfenster
	CClientDC dc(this);
	dc.TextOut(45, 10, m_Text);
	// Originalmethode aufrufen
	CFrameWnd::OnPaint();
}
// Antworttabelle
BEGIN_MESSAGE_MAP(CRahmenfenster, CFrameWnd)
	ON_WM_PAINT()
END_MESSAGE_MAP()

// Anwendung initialisieren
BOOL CMeineApp::InitInstance()
{
	// Rahmenfenster-Objekt erzeugen
	// und Fenster anzeigen
	m_pMainWnd = new CRahmenfenster;
	m_pMainWnd->ShowWindow(m_nCmdShow);
	m_pMainWnd->UpdateWindow();
	return TRUE;
}
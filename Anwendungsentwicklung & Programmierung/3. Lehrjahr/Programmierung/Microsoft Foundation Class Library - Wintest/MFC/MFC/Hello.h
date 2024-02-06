#ifndef HELLO
#define HELLO
//Grundprogramm für Windows mit MFC
#include <afxwin.h>
#include <cstring>
// Deklaration der abgeleiteten Rahmenfensterklasse
class CRahmenfenster : public CFrameWnd
{
public:
	CRahmenfenster();
	void OnPaint();
	DECLARE_MESSAGE_MAP()
private:
	CString m_Text;
};
// Deklaration der abgeleiteten Anwendungsklasse
class CMeineApp : public CWinApp
{
public:
	virtual BOOL InitInstance();
};
#endif
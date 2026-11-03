namespace Steamworks;

[Token(Token = "0x2000012")]
public static class SteamHTMLSurface
{

	[Address(RVA = "0x5EDF50", Offset = "0x5ED350", Length = "0x1BD")]
	[Token(Token = "0x600021F")]
	public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue) { }

	[Address(RVA = "0x5EE110", Offset = "0x5ED510", Length = "0x5F")]
	[Token(Token = "0x6000237")]
	public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed) { }

	[Address(RVA = "0x5EE170", Offset = "0x5ED570", Length = "0x4F")]
	[Token(Token = "0x600022D")]
	public static void CopyToClipboard(HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x5EE1C0", Offset = "0x5ED5C0", Length = "0x1D3")]
	[Token(Token = "0x6000217")]
	public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS) { }

	[Address(RVA = "0x5EE3A0", Offset = "0x5ED7A0", Length = "0x113")]
	[Token(Token = "0x6000220")]
	public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript) { }

	[Address(RVA = "0x5EE4C0", Offset = "0x5ED8C0", Length = "0x5E")]
	[Token(Token = "0x6000239")]
	public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles) { }

	[Address(RVA = "0x5EE520", Offset = "0x5ED920", Length = "0x135")]
	[Token(Token = "0x600022F")]
	public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse) { }

	[Address(RVA = "0x5EE660", Offset = "0x5EDA60", Length = "0x74")]
	[Token(Token = "0x6000231")]
	public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y) { }

	[Address(RVA = "0x5EE6E0", Offset = "0x5EDAE0", Length = "0x4F")]
	[Token(Token = "0x600021D")]
	public static void GoBack(HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x5EE730", Offset = "0x5EDB30", Length = "0x4F")]
	[Token(Token = "0x600021E")]
	public static void GoForward(HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x5EE780", Offset = "0x5EDB80", Length = "0x47")]
	[Token(Token = "0x6000215")]
	public static bool Init() { }

	[Address(RVA = "0x5EE7D0", Offset = "0x5EDBD0", Length = "0x5F")]
	[Token(Token = "0x6000238")]
	public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult) { }

	[Address(RVA = "0x5EE830", Offset = "0x5EDC30", Length = "0x74")]
	[Token(Token = "0x6000228")]
	public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	[Address(RVA = "0x5EE8B0", Offset = "0x5EDCB0", Length = "0x87")]
	[Token(Token = "0x6000226")]
	public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey = false) { }

	[Address(RVA = "0x5EE940", Offset = "0x5EDD40", Length = "0x74")]
	[Token(Token = "0x6000227")]
	public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	[Address(RVA = "0x5EE9C0", Offset = "0x5EDDC0", Length = "0x1BD")]
	[Token(Token = "0x6000219")]
	public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData) { }

	[Address(RVA = "0x5EEB80", Offset = "0x5EDF80", Length = "0x5D")]
	[Token(Token = "0x6000223")]
	public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	[Address(RVA = "0x5EEBE0", Offset = "0x5EDFE0", Length = "0x5D")]
	[Token(Token = "0x6000222")]
	public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	[Address(RVA = "0x5EEC40", Offset = "0x5EE040", Length = "0x74")]
	[Token(Token = "0x6000224")]
	public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y) { }

	[Address(RVA = "0x5EECC0", Offset = "0x5EE0C0", Length = "0x5D")]
	[Token(Token = "0x6000221")]
	public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	[Address(RVA = "0x5EED20", Offset = "0x5EE120", Length = "0x5D")]
	[Token(Token = "0x6000225")]
	public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta) { }

	[Address(RVA = "0x5EED80", Offset = "0x5EE180", Length = "0x4F")]
	[Token(Token = "0x6000236")]
	public static void OpenDeveloperTools(HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x5EEDD0", Offset = "0x5EE1D0", Length = "0x4F")]
	[Token(Token = "0x600022E")]
	public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x5EEE20", Offset = "0x5EE220", Length = "0x4F")]
	[Token(Token = "0x600021C")]
	public static void Reload(HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x5EEE70", Offset = "0x5EE270", Length = "0x4F")]
	[Token(Token = "0x6000218")]
	public static void RemoveBrowser(HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x5EEEC0", Offset = "0x5EE2C0", Length = "0x5F")]
	[Token(Token = "0x6000234")]
	public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode) { }

	[Address(RVA = "0x5EEF20", Offset = "0x5EE320", Length = "0x2FB")]
	[Token(Token = "0x6000232")]
	public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0, bool bSecure = false, bool bHTTPOnly = false) { }

	[Address(RVA = "0x5EF220", Offset = "0x5EE620", Length = "0x5F")]
	[Token(Token = "0x6000235")]
	public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling) { }

	[Address(RVA = "0x5EF280", Offset = "0x5EE680", Length = "0x5D")]
	[Token(Token = "0x6000229")]
	public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	[Address(RVA = "0x5EF2E0", Offset = "0x5EE6E0", Length = "0x5F")]
	[Token(Token = "0x600022B")]
	public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) { }

	[Address(RVA = "0x5EF340", Offset = "0x5EE740", Length = "0x86")]
	[Token(Token = "0x6000233")]
	public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) { }

	[Address(RVA = "0x5EF3D0", Offset = "0x5EE7D0", Length = "0x74")]
	[Token(Token = "0x600021A")]
	public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) { }

	[Address(RVA = "0x5EF450", Offset = "0x5EE850", Length = "0x5D")]
	[Token(Token = "0x600022A")]
	public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	[Address(RVA = "0x5EF4B0", Offset = "0x5EE8B0", Length = "0x47")]
	[Token(Token = "0x6000216")]
	public static bool Shutdown() { }

	[Address(RVA = "0x5EF500", Offset = "0x5EE900", Length = "0x4F")]
	[Token(Token = "0x6000230")]
	public static void StopFind(HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x5EF550", Offset = "0x5EE950", Length = "0x4F")]
	[Token(Token = "0x600021B")]
	public static void StopLoad(HHTMLBrowser unBrowserHandle) { }

	[Address(RVA = "0x5EF5A0", Offset = "0x5EE9A0", Length = "0x4F")]
	[Token(Token = "0x600022C")]
	public static void ViewSource(HHTMLBrowser unBrowserHandle) { }

}


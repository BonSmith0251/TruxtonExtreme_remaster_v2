namespace Steamworks;

[Token(Token = "0x2000023")]
public static class SteamScreenshots
{

	[Address(RVA = "0x5FEBB0", Offset = "0x5FDFB0", Length = "0x1F4")]
	[Token(Token = "0x60003D3")]
	public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight) { }

	[Address(RVA = "0x5FEDB0", Offset = "0x5FE1B0", Length = "0x1EF")]
	[Token(Token = "0x60003DA")]
	public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename) { }

	[Address(RVA = "0x5FEFA0", Offset = "0x5FE3A0", Length = "0x4E")]
	[Token(Token = "0x60003D5")]
	public static void HookScreenshots(bool bHook) { }

	[Address(RVA = "0x5FEFF0", Offset = "0x5FE3F0", Length = "0x44")]
	[Token(Token = "0x60003D9")]
	public static bool IsScreenshotsHooked() { }

	[Address(RVA = "0x5FF040", Offset = "0x5FE440", Length = "0x123")]
	[Token(Token = "0x60003D6")]
	public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation) { }

	[Address(RVA = "0x5FF170", Offset = "0x5FE570", Length = "0x5B")]
	[Token(Token = "0x60003D8")]
	public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID) { }

	[Address(RVA = "0x5FF1D0", Offset = "0x5FE5D0", Length = "0x5B")]
	[Token(Token = "0x60003D7")]
	public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID) { }

	[Address(RVA = "0x5FF230", Offset = "0x5FE630", Length = "0x44")]
	[Token(Token = "0x60003D4")]
	public static void TriggerScreenshot() { }

	[Address(RVA = "0x5FF280", Offset = "0x5FE680", Length = "0xBF")]
	[Token(Token = "0x60003D2")]
	public static ScreenshotHandle WriteScreenshot(Byte[] pubRGB, uint cubRGB, int nWidth, int nHeight) { }

}


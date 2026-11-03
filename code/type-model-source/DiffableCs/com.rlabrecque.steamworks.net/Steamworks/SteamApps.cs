namespace Steamworks;

[Token(Token = "0x2000004")]
public static class SteamApps
{

	[Address(RVA = "0x5D7110", Offset = "0x5D6510", Length = "0x125")]
	[Token(Token = "0x600000E")]
	public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize) { }

	[Address(RVA = "0x5D7240", Offset = "0x5D6640", Length = "0x4C")]
	[Token(Token = "0x6000016")]
	public static bool BIsAppInstalled(AppId_t appID) { }

	[Address(RVA = "0x5D7290", Offset = "0x5D6690", Length = "0x44")]
	[Token(Token = "0x6000005")]
	public static bool BIsCybercafe() { }

	[Address(RVA = "0x5D72E0", Offset = "0x5D66E0", Length = "0x4C")]
	[Token(Token = "0x600000A")]
	public static bool BIsDlcInstalled(AppId_t appID) { }

	[Address(RVA = "0x5D7330", Offset = "0x5D6730", Length = "0x44")]
	[Token(Token = "0x6000004")]
	public static bool BIsLowViolence() { }

	[Address(RVA = "0x5D7470", Offset = "0x5D6870", Length = "0x44")]
	[Token(Token = "0x6000003")]
	public static bool BIsSubscribed() { }

	[Address(RVA = "0x5D7380", Offset = "0x5D6780", Length = "0x4C")]
	[Token(Token = "0x6000009")]
	public static bool BIsSubscribedApp(AppId_t appID) { }

	[Address(RVA = "0x5D73D0", Offset = "0x5D67D0", Length = "0x44")]
	[Token(Token = "0x600001E")]
	public static bool BIsSubscribedFromFamilySharing() { }

	[Address(RVA = "0x5D7420", Offset = "0x5D6820", Length = "0x44")]
	[Token(Token = "0x600000C")]
	public static bool BIsSubscribedFromFreeWeekend() { }

	[Address(RVA = "0x5D74C0", Offset = "0x5D68C0", Length = "0x5D")]
	[Token(Token = "0x600001F")]
	public static bool BIsTimedTrial(out uint punSecondsAllowed, out uint punSecondsPlayed) { }

	[Address(RVA = "0x5D7520", Offset = "0x5D6920", Length = "0x44")]
	[Token(Token = "0x6000006")]
	public static bool BIsVACBanned() { }

	[Address(RVA = "0x5D7570", Offset = "0x5D6970", Length = "0x44")]
	[Token(Token = "0x600001A")]
	public static int GetAppBuildId() { }

	[Address(RVA = "0x5D75C0", Offset = "0x5D69C0", Length = "0x105")]
	[Token(Token = "0x6000015")]
	public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize) { }

	[Address(RVA = "0x5D76D0", Offset = "0x5D6AD0", Length = "0x85")]
	[Token(Token = "0x6000017")]
	public static CSteamID GetAppOwner() { }

	[Address(RVA = "0x5D7760", Offset = "0x5D6B60", Length = "0x4E")]
	[Token(Token = "0x6000008")]
	public static string GetAvailableGameLanguages() { }

	[Address(RVA = "0x5D77B0", Offset = "0x5D6BB0", Length = "0x18B")]
	[Token(Token = "0x6000022")]
	public static bool GetBetaInfo(int iBetaIndex, out uint punFlags, out uint punBuildID, out string pchBetaName, int cchBetaName, out string pchDescription, int cchDescription) { }

	[Address(RVA = "0x5D7940", Offset = "0x5D6D40", Length = "0xEA")]
	[Token(Token = "0x6000012")]
	public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize) { }

	[Address(RVA = "0x5D7A30", Offset = "0x5D6E30", Length = "0x4E")]
	[Token(Token = "0x6000007")]
	public static string GetCurrentGameLanguage() { }

	[Address(RVA = "0x5D7A80", Offset = "0x5D6E80", Length = "0x44")]
	[Token(Token = "0x600000D")]
	public static int GetDLCCount() { }

	[Address(RVA = "0x5D7AD0", Offset = "0x5D6ED0", Length = "0x72")]
	[Token(Token = "0x6000019")]
	public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	[Address(RVA = "0x5D7B50", Offset = "0x5D6F50", Length = "0x4C")]
	[Token(Token = "0x600000B")]
	public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID) { }

	[Address(RVA = "0x5D7BA0", Offset = "0x5D6FA0", Length = "0x148")]
	[Token(Token = "0x600001C")]
	public static SteamAPICall_t GetFileDetails(string pszFileName) { }

	[Address(RVA = "0x5D7CF0", Offset = "0x5D70F0", Length = "0x72")]
	[Token(Token = "0x6000014")]
	public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots) { }

	[Address(RVA = "0x5D7D70", Offset = "0x5D7170", Length = "0xE8")]
	[Token(Token = "0x600001D")]
	public static int GetLaunchCommandLine(out string pszCommandLine, int cubCommandLine) { }

	[Address(RVA = "0x5D7E60", Offset = "0x5D7260", Length = "0x124")]
	[Token(Token = "0x6000018")]
	public static string GetLaunchQueryParam(string pchKey) { }

	[Address(RVA = "0x5D7F90", Offset = "0x5D7390", Length = "0x5D")]
	[Token(Token = "0x6000021")]
	public static int GetNumBetas(out int pnAvailable, out int pnPrivate) { }

	[Address(RVA = "0x5D7FF0", Offset = "0x5D73F0", Length = "0x4C")]
	[Token(Token = "0x600000F")]
	public static void InstallDLC(AppId_t nAppID) { }

	[Address(RVA = "0x5D8040", Offset = "0x5D7440", Length = "0x4E")]
	[Token(Token = "0x6000013")]
	public static bool MarkContentCorrupt(bool bMissingFilesOnly) { }

	[Address(RVA = "0x5D8090", Offset = "0x5D7490", Length = "0x44")]
	[Token(Token = "0x600001B")]
	public static void RequestAllProofOfPurchaseKeys() { }

	[Address(RVA = "0x5D80E0", Offset = "0x5D74E0", Length = "0x4C")]
	[Token(Token = "0x6000011")]
	public static void RequestAppProofOfPurchaseKey(AppId_t nAppID) { }

	[Address(RVA = "0x5D8130", Offset = "0x5D7530", Length = "0x115")]
	[Token(Token = "0x6000023")]
	public static bool SetActiveBeta(string pchBetaName) { }

	[Address(RVA = "0x5D8250", Offset = "0x5D7650", Length = "0x4C")]
	[Token(Token = "0x6000020")]
	public static bool SetDlcContext(AppId_t nAppID) { }

	[Address(RVA = "0x5D82A0", Offset = "0x5D76A0", Length = "0x4C")]
	[Token(Token = "0x6000010")]
	public static void UninstallDLC(AppId_t nAppID) { }

}


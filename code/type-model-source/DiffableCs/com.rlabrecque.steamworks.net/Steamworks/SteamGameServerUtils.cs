namespace Steamworks;

[Token(Token = "0x2000011")]
public static class SteamGameServerUtils
{

	[Address(RVA = "0x5EB480", Offset = "0x5EA880", Length = "0x44")]
	[Token(Token = "0x6000200")]
	public static bool BOverlayNeedsPresent() { }

	[Address(RVA = "0x5EB4D0", Offset = "0x5EA8D0", Length = "0x148")]
	[Token(Token = "0x6000201")]
	public static SteamAPICall_t CheckFileSignature(string szFileName) { }

	[Address(RVA = "0x5EB620", Offset = "0x5EAA20", Length = "0x44")]
	[Token(Token = "0x6000213")]
	public static bool DismissFloatingGamepadTextInput() { }

	[Address(RVA = "0x5EB670", Offset = "0x5EAA70", Length = "0x44")]
	[Token(Token = "0x6000214")]
	public static bool DismissGamepadTextInput() { }

	[Address(RVA = "0x5EB6C0", Offset = "0x5EAAC0", Length = "0x1C1")]
	[Token(Token = "0x600020E")]
	public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	[Address(RVA = "0x5EB890", Offset = "0x5EAC90", Length = "0x4E")]
	[Token(Token = "0x60001FB")]
	public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall) { }

	[Address(RVA = "0x5EB8E0", Offset = "0x5EACE0", Length = "0x8F")]
	[Token(Token = "0x60001FC")]
	public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	[Address(RVA = "0x5EB970", Offset = "0x5EAD70", Length = "0x83")]
	[Token(Token = "0x60001F8")]
	public static AppId_t GetAppID() { }

	[Address(RVA = "0x5EBA00", Offset = "0x5EAE00", Length = "0x44")]
	[Token(Token = "0x60001F2")]
	public static EUniverse GetConnectedUniverse() { }

	[Address(RVA = "0x5EBA50", Offset = "0x5EAE50", Length = "0x44")]
	[Token(Token = "0x60001F7")]
	public static byte GetCurrentBatteryPower() { }

	[Address(RVA = "0x5EBAA0", Offset = "0x5EAEA0", Length = "0xEA")]
	[Token(Token = "0x6000204")]
	public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText) { }

	[Address(RVA = "0x5EBB90", Offset = "0x5EAF90", Length = "0x44")]
	[Token(Token = "0x6000203")]
	public static uint GetEnteredGamepadTextLength() { }

	[Address(RVA = "0x5EBCD0", Offset = "0x5EB0D0", Length = "0x72")]
	[Token(Token = "0x60001F6")]
	public static bool GetImageRGBA(int iImage, Byte[] pubDest, int nDestBufferSize) { }

	[Address(RVA = "0x5EBD50", Offset = "0x5EB150", Length = "0x72")]
	[Token(Token = "0x60001F5")]
	public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

	[Address(RVA = "0x5EBBE0", Offset = "0x5EAFE0", Length = "0x44")]
	[Token(Token = "0x60001FD")]
	public static uint GetIPCCallCount() { }

	[Address(RVA = "0x5EBC30", Offset = "0x5EB030", Length = "0x4E")]
	[Token(Token = "0x60001F4")]
	public static string GetIPCountry() { }

	[Address(RVA = "0x5EBC80", Offset = "0x5EB080", Length = "0x4C")]
	[Token(Token = "0x600020F")]
	public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol) { }

	[Address(RVA = "0x5EBDD0", Offset = "0x5EB1D0", Length = "0x44")]
	[Token(Token = "0x60001F0")]
	public static uint GetSecondsSinceAppActive() { }

	[Address(RVA = "0x5EBE20", Offset = "0x5EB220", Length = "0x44")]
	[Token(Token = "0x60001F1")]
	public static uint GetSecondsSinceComputerActive() { }

	[Address(RVA = "0x5EBE70", Offset = "0x5EB270", Length = "0x44")]
	[Token(Token = "0x60001F3")]
	public static uint GetServerRealTime() { }

	[Address(RVA = "0x5EBEC0", Offset = "0x5EB2C0", Length = "0x4E")]
	[Token(Token = "0x6000205")]
	public static string GetSteamUILanguage() { }

	[Address(RVA = "0x5EBF10", Offset = "0x5EB310", Length = "0x4C")]
	[Token(Token = "0x600020D")]
	public static bool InitFilterText(uint unFilterOptions = 0) { }

	[Address(RVA = "0x5EBF60", Offset = "0x5EB360", Length = "0x5D")]
	[Token(Token = "0x60001FA")]
	public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed) { }

	[Address(RVA = "0x5EBFC0", Offset = "0x5EB3C0", Length = "0x44")]
	[Token(Token = "0x60001FF")]
	public static bool IsOverlayEnabled() { }

	[Address(RVA = "0x5EC010", Offset = "0x5EB410", Length = "0x44")]
	[Token(Token = "0x600020C")]
	public static bool IsSteamChinaLauncher() { }

	[Address(RVA = "0x5EC060", Offset = "0x5EB460", Length = "0x44")]
	[Token(Token = "0x6000208")]
	public static bool IsSteamInBigPictureMode() { }

	[Address(RVA = "0x5EC0B0", Offset = "0x5EB4B0", Length = "0x44")]
	[Token(Token = "0x6000206")]
	public static bool IsSteamRunningInVR() { }

	[Address(RVA = "0x5EC100", Offset = "0x5EB500", Length = "0x44")]
	[Token(Token = "0x6000210")]
	public static bool IsSteamRunningOnSteamDeck() { }

	[Address(RVA = "0x5EC150", Offset = "0x5EB550", Length = "0x44")]
	[Token(Token = "0x600020A")]
	public static bool IsVRHeadsetStreamingEnabled() { }

	[Address(RVA = "0x5EC1A0", Offset = "0x5EB5A0", Length = "0x4E")]
	[Token(Token = "0x6000212")]
	public static void SetGameLauncherMode(bool bLauncherMode) { }

	[Address(RVA = "0x5EC1F0", Offset = "0x5EB5F0", Length = "0x5A")]
	[Token(Token = "0x6000207")]
	public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) { }

	[Address(RVA = "0x5EC250", Offset = "0x5EB650", Length = "0x4C")]
	[Token(Token = "0x60001F9")]
	public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition) { }

	[Address(RVA = "0x5EC2A0", Offset = "0x5EB6A0", Length = "0x4E")]
	[Token(Token = "0x600020B")]
	public static void SetVRHeadsetStreamingEnabled(bool bEnabled) { }

	[Address(RVA = "0x5EC2F0", Offset = "0x5EB6F0", Length = "0x4E")]
	[Token(Token = "0x60001FE")]
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	[Address(RVA = "0x5EC340", Offset = "0x5EB740", Length = "0x8A")]
	[Token(Token = "0x6000211")]
	public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) { }

	[Address(RVA = "0x5EC3D0", Offset = "0x5EB7D0", Length = "0x1D9")]
	[Token(Token = "0x6000202")]
	public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText) { }

	[Address(RVA = "0x5EC5B0", Offset = "0x5EB9B0", Length = "0x44")]
	[Token(Token = "0x6000209")]
	public static void StartVRDashboard() { }

}


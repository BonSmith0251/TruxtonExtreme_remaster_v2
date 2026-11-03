namespace Steamworks;

[Token(Token = "0x2000028")]
public static class SteamUtils
{

	[Address(RVA = "0x643430", Offset = "0x642830", Length = "0xAF")]
	[Token(Token = "0x600049B")]
	public static bool BOverlayNeedsPresent() { }

	[Address(RVA = "0x6434E0", Offset = "0x6428E0", Length = "0x21F")]
	[Token(Token = "0x600049C")]
	public static SteamAPICall_t CheckFileSignature(string szFileName) { }

	[Address(RVA = "0x643700", Offset = "0x642B00", Length = "0xAF")]
	[Token(Token = "0x60004AE")]
	public static bool DismissFloatingGamepadTextInput() { }

	[Address(RVA = "0x6437B0", Offset = "0x642BB0", Length = "0xAF")]
	[Token(Token = "0x60004AF")]
	public static bool DismissGamepadTextInput() { }

	[Address(RVA = "0x643860", Offset = "0x642C60", Length = "0x27B")]
	[Token(Token = "0x60004A9")]
	public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	[Address(RVA = "0x643AE0", Offset = "0x642EE0", Length = "0xB9")]
	[Token(Token = "0x6000496")]
	public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall) { }

	[Address(RVA = "0x643BA0", Offset = "0x642FA0", Length = "0x110")]
	[Token(Token = "0x6000497")]
	public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	[Address(RVA = "0x643CB0", Offset = "0x6430B0", Length = "0xDF")]
	[Token(Token = "0x6000493")]
	public static AppId_t GetAppID() { }

	[Address(RVA = "0x643D90", Offset = "0x643190", Length = "0xAA")]
	[Token(Token = "0x600048D")]
	public static EUniverse GetConnectedUniverse() { }

	[Address(RVA = "0x643E40", Offset = "0x643240", Length = "0xAA")]
	[Token(Token = "0x6000492")]
	public static byte GetCurrentBatteryPower() { }

	[Address(RVA = "0x643EF0", Offset = "0x6432F0", Length = "0x158")]
	[Token(Token = "0x600049F")]
	public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText) { }

	[Address(RVA = "0x644050", Offset = "0x643450", Length = "0xAA")]
	[Token(Token = "0x600049E")]
	public static uint GetEnteredGamepadTextLength() { }

	[Address(RVA = "0x644330", Offset = "0x643730", Length = "0xE6")]
	[Token(Token = "0x6000491")]
	public static bool GetImageRGBA(int iImage, Byte[] pubDest, int nDestBufferSize) { }

	[Address(RVA = "0x644420", Offset = "0x643820", Length = "0xDC")]
	[Token(Token = "0x6000490")]
	public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) { }

	[Address(RVA = "0x644100", Offset = "0x643500", Length = "0xAA")]
	[Token(Token = "0x6000498")]
	public static uint GetIPCCallCount() { }

	[Address(RVA = "0x6441B0", Offset = "0x6435B0", Length = "0xB3")]
	[Token(Token = "0x600048F")]
	public static string GetIPCountry() { }

	[Address(RVA = "0x644270", Offset = "0x643670", Length = "0xB7")]
	[Token(Token = "0x60004AA")]
	public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol) { }

	[Address(RVA = "0x644500", Offset = "0x643900", Length = "0xAA")]
	[Token(Token = "0x600048B")]
	public static uint GetSecondsSinceAppActive() { }

	[Address(RVA = "0x6445B0", Offset = "0x6439B0", Length = "0xAA")]
	[Token(Token = "0x600048C")]
	public static uint GetSecondsSinceComputerActive() { }

	[Address(RVA = "0x644660", Offset = "0x643A60", Length = "0xAA")]
	[Token(Token = "0x600048E")]
	public static uint GetServerRealTime() { }

	[Address(RVA = "0x644710", Offset = "0x643B10", Length = "0xB3")]
	[Token(Token = "0x60004A0")]
	public static string GetSteamUILanguage() { }

	[Address(RVA = "0x6447D0", Offset = "0x643BD0", Length = "0xBC")]
	[Token(Token = "0x60004A8")]
	public static bool InitFilterText(uint unFilterOptions = 0) { }

	[Address(RVA = "0x644890", Offset = "0x643C90", Length = "0xE2")]
	[Token(Token = "0x6000495")]
	public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed) { }

	[Address(RVA = "0x644980", Offset = "0x643D80", Length = "0xAF")]
	[Token(Token = "0x600049A")]
	public static bool IsOverlayEnabled() { }

	[Address(RVA = "0x644A30", Offset = "0x643E30", Length = "0xAF")]
	[Token(Token = "0x60004A7")]
	public static bool IsSteamChinaLauncher() { }

	[Address(RVA = "0x644AE0", Offset = "0x643EE0", Length = "0xAF")]
	[Token(Token = "0x60004A3")]
	public static bool IsSteamInBigPictureMode() { }

	[Address(RVA = "0x644B90", Offset = "0x643F90", Length = "0xAF")]
	[Token(Token = "0x60004A1")]
	public static bool IsSteamRunningInVR() { }

	[Address(RVA = "0x644C40", Offset = "0x644040", Length = "0xAF")]
	[Token(Token = "0x60004AB")]
	public static bool IsSteamRunningOnSteamDeck() { }

	[Address(RVA = "0x644CF0", Offset = "0x6440F0", Length = "0xAF")]
	[Token(Token = "0x60004A5")]
	public static bool IsVRHeadsetStreamingEnabled() { }

	[Address(RVA = "0x644DA0", Offset = "0x6441A0", Length = "0xB9")]
	[Token(Token = "0x60004AD")]
	public static void SetGameLauncherMode(bool bLauncherMode) { }

	[Address(RVA = "0x644E60", Offset = "0x644260", Length = "0xC6")]
	[Token(Token = "0x60004A2")]
	public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) { }

	[Address(RVA = "0x644F30", Offset = "0x644330", Length = "0xB7")]
	[Token(Token = "0x6000494")]
	public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition) { }

	[Address(RVA = "0x644FF0", Offset = "0x6443F0", Length = "0xB9")]
	[Token(Token = "0x60004A6")]
	public static void SetVRHeadsetStreamingEnabled(bool bEnabled) { }

	[Address(RVA = "0x6450B0", Offset = "0x6444B0", Length = "0xC3")]
	[Token(Token = "0x6000499")]
	public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) { }

	[Address(RVA = "0x645180", Offset = "0x644580", Length = "0xFB")]
	[Token(Token = "0x60004AC")]
	public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) { }

	[Address(RVA = "0x645280", Offset = "0x644680", Length = "0x2EF")]
	[Token(Token = "0x600049D")]
	public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText) { }

	[Address(RVA = "0x645570", Offset = "0x644970", Length = "0xAA")]
	[Token(Token = "0x60004A4")]
	public static void StartVRDashboard() { }

}


namespace Steamworks;

[Token(Token = "0x2000014")]
public static class SteamInput
{

	[Address(RVA = "0x5F0940", Offset = "0x5EFD40", Length = "0x60")]
	[Token(Token = "0x600025D")]
	public static void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle) { }

	[Address(RVA = "0x5F08E0", Offset = "0x5EFCE0", Length = "0x60")]
	[Token(Token = "0x600025F")]
	public static void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	[Address(RVA = "0x5F09A0", Offset = "0x5EFDA0", Length = "0x47")]
	[Token(Token = "0x6000258")]
	public static bool BNewDataAvailable() { }

	[Address(RVA = "0x5F09F0", Offset = "0x5EFDF0", Length = "0x60")]
	[Token(Token = "0x6000257")]
	public static bool BWaitForData(bool bWaitForever, uint unTimeout) { }

	[Address(RVA = "0x5F0A50", Offset = "0x5EFE50", Length = "0x60")]
	[Token(Token = "0x6000260")]
	public static void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	[Address(RVA = "0x5F0AB0", Offset = "0x5EFEB0", Length = "0x51")]
	[Token(Token = "0x6000261")]
	public static void DeactivateAllActionSetLayers(InputHandle_t inputHandle) { }

	[Address(RVA = "0x5F0B10", Offset = "0x5EFF10", Length = "0x51")]
	[Token(Token = "0x600025B")]
	public static void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback) { }

	[Address(RVA = "0x5F0B70", Offset = "0x5EFF70", Length = "0x47")]
	[Token(Token = "0x600025A")]
	public static void EnableDeviceCallbacks() { }

	[Address(RVA = "0x5F0BC0", Offset = "0x5EFFC0", Length = "0x5F")]
	[Token(Token = "0x600027D")]
	public static EInputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, EXboxOrigin eOrigin) { }

	[Address(RVA = "0x5F0C20", Offset = "0x5F0020", Length = "0x127")]
	[Token(Token = "0x600025C")]
	public static InputActionSetHandle_t GetActionSetHandle(string pszActionSetName) { }

	[Address(RVA = "0x5F0D50", Offset = "0x5F0150", Length = "0xB3")]
	[Token(Token = "0x6000262")]
	public static int GetActiveActionSetLayers(InputHandle_t inputHandle, InputActionSetHandle_t[] handlesOut) { }

	[Address(RVA = "0x5F0E10", Offset = "0x5F0210", Length = "0x91")]
	[Token(Token = "0x6000268")]
	public static InputAnalogActionData_t GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle) { }

	[Address(RVA = "0x5F0EB0", Offset = "0x5F02B0", Length = "0x127")]
	[Token(Token = "0x6000267")]
	public static InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName) { }

	[Address(RVA = "0x5F0FE0", Offset = "0x5F03E0", Length = "0xDC")]
	[Token(Token = "0x6000269")]
	public static int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, EInputActionOrigin[] originsOut) { }

	[Address(RVA = "0x5F10C0", Offset = "0x5F04C0", Length = "0xA4")]
	[Token(Token = "0x6000259")]
	public static int GetConnectedControllers(InputHandle_t[] handlesOut) { }

	[Address(RVA = "0x5F1170", Offset = "0x5F0570", Length = "0x59")]
	[Token(Token = "0x6000279")]
	public static InputHandle_t GetControllerForGamepadIndex(int nIndex) { }

	[Address(RVA = "0x5F11D0", Offset = "0x5F05D0", Length = "0x5B")]
	[Token(Token = "0x600025E")]
	public static InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle) { }

	[Address(RVA = "0x5F1230", Offset = "0x5F0630", Length = "0x77")]
	[Token(Token = "0x600027F")]
	public static bool GetDeviceBindingRevision(InputHandle_t inputHandle, out int pMajor, out int pMinor) { }

	[Address(RVA = "0x5F12B0", Offset = "0x5F06B0", Length = "0x60")]
	[Token(Token = "0x6000264")]
	public static InputDigitalActionData_t GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle) { }

	[Address(RVA = "0x5F1310", Offset = "0x5F0710", Length = "0x127")]
	[Token(Token = "0x6000263")]
	public static InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName) { }

	[Address(RVA = "0x5F1440", Offset = "0x5F0840", Length = "0xDC")]
	[Token(Token = "0x6000265")]
	public static int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, EInputActionOrigin[] originsOut) { }

	[Address(RVA = "0x5F1520", Offset = "0x5F0920", Length = "0x51")]
	[Token(Token = "0x600027A")]
	public static int GetGamepadIndexForController(InputHandle_t ulinputHandle) { }

	[Address(RVA = "0x5F1580", Offset = "0x5F0980", Length = "0x59")]
	[Token(Token = "0x600026C")]
	public static string GetGlyphForActionOrigin_Legacy(EInputActionOrigin eOrigin) { }

	[Address(RVA = "0x5F15E0", Offset = "0x5F09E0", Length = "0x59")]
	[Token(Token = "0x600027C")]
	public static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin) { }

	[Address(RVA = "0x5F1640", Offset = "0x5F0A40", Length = "0x7D")]
	[Token(Token = "0x600026A")]
	public static string GetGlyphPNGForActionOrigin(EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags) { }

	[Address(RVA = "0x5F16C0", Offset = "0x5F0AC0", Length = "0x67")]
	[Token(Token = "0x600026B")]
	public static string GetGlyphSVGForActionOrigin(EInputActionOrigin eOrigin, uint unFlags) { }

	[Address(RVA = "0x5F1730", Offset = "0x5F0B30", Length = "0x51")]
	[Token(Token = "0x6000278")]
	public static ESteamInputType GetInputTypeForHandle(InputHandle_t inputHandle) { }

	[Address(RVA = "0x5F1790", Offset = "0x5F0B90", Length = "0x7E")]
	[Token(Token = "0x6000270")]
	public static InputMotionData_t GetMotionData(InputHandle_t inputHandle) { }

	[Address(RVA = "0x5F1810", Offset = "0x5F0C10", Length = "0x51")]
	[Token(Token = "0x6000280")]
	public static uint GetRemotePlaySessionID(InputHandle_t inputHandle) { }

	[Address(RVA = "0x5F1870", Offset = "0x5F0C70", Length = "0x47")]
	[Token(Token = "0x6000281")]
	public static ushort GetSessionInputConfigurationSettings() { }

	[Address(RVA = "0x5F18C0", Offset = "0x5F0CC0", Length = "0x59")]
	[Token(Token = "0x600026D")]
	public static string GetStringForActionOrigin(EInputActionOrigin eOrigin) { }

	[Address(RVA = "0x5F1920", Offset = "0x5F0D20", Length = "0x5B")]
	[Token(Token = "0x600026E")]
	public static string GetStringForAnalogActionName(InputAnalogActionHandle_t eActionHandle) { }

	[Address(RVA = "0x5F1980", Offset = "0x5F0D80", Length = "0x5B")]
	[Token(Token = "0x6000266")]
	public static string GetStringForDigitalActionName(InputDigitalActionHandle_t eActionHandle) { }

	[Address(RVA = "0x5F19E0", Offset = "0x5F0DE0", Length = "0x59")]
	[Token(Token = "0x600027B")]
	public static string GetStringForXboxOrigin(EXboxOrigin eOrigin) { }

	[Address(RVA = "0x5F1A40", Offset = "0x5F0E40", Length = "0x51")]
	[Token(Token = "0x6000253")]
	public static bool Init(bool bExplicitlyCallRunFrame) { }

	[Address(RVA = "0x5F1AA0", Offset = "0x5F0EA0", Length = "0x78")]
	[Token(Token = "0x6000275")]
	public static void Legacy_TriggerHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) { }

	[Address(RVA = "0x5F1B20", Offset = "0x5F0F20", Length = "0x9D")]
	[Token(Token = "0x6000276")]
	public static void Legacy_TriggerRepeatedHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) { }

	[Address(RVA = "0x5F1BC0", Offset = "0x5F0FC0", Length = "0x51")]
	[Token(Token = "0x6000256")]
	public static void RunFrame(bool bReservedValue = true) { }

	[Address(RVA = "0x5F1C20", Offset = "0x5F1020", Length = "0x60")]
	[Token(Token = "0x6000282")]
	public static void SetDualSenseTriggerEffect(InputHandle_t inputHandle, IntPtr pParam) { }

	[Address(RVA = "0x5F1C80", Offset = "0x5F1080", Length = "0x118")]
	[Token(Token = "0x6000255")]
	public static bool SetInputActionManifestFilePath(string pchInputActionManifestAbsolutePath) { }

	[Address(RVA = "0x5F1DA0", Offset = "0x5F11A0", Length = "0x95")]
	[Token(Token = "0x6000274")]
	public static void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) { }

	[Address(RVA = "0x5F1E40", Offset = "0x5F1240", Length = "0x51")]
	[Token(Token = "0x6000277")]
	public static bool ShowBindingPanel(InputHandle_t inputHandle) { }

	[Address(RVA = "0x5F1EA0", Offset = "0x5F12A0", Length = "0x47")]
	[Token(Token = "0x6000254")]
	public static bool Shutdown() { }

	[Address(RVA = "0x5F1EF0", Offset = "0x5F12F0", Length = "0x60")]
	[Token(Token = "0x600026F")]
	public static void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction) { }

	[Address(RVA = "0x5F1F50", Offset = "0x5F1350", Length = "0x5D")]
	[Token(Token = "0x600027E")]
	public static EInputActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin) { }

	[Address(RVA = "0x5F1FB0", Offset = "0x5F13B0", Length = "0x9E")]
	[Token(Token = "0x6000273")]
	public static void TriggerSimpleHapticEvent(InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB) { }

	[Address(RVA = "0x5F20F0", Offset = "0x5F14F0", Length = "0x7A")]
	[Token(Token = "0x6000271")]
	public static void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed) { }

	[Address(RVA = "0x5F2050", Offset = "0x5F1450", Length = "0x97")]
	[Token(Token = "0x6000272")]
	public static void TriggerVibrationExtended(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed) { }

}


namespace UnityEngine.InputSystem.EnhancedTouch;

[Token(Token = "0x2000152")]
public static class EnhancedTouchSupport
{
	[Token(Token = "0x4000884")]
	private static int s_Enabled; //Field offset: 0x0
	[Token(Token = "0x4000885")]
	private static UpdateMode s_UpdateMode; //Field offset: 0x4

	[Token(Token = "0x170003EC")]
	public static bool enabled
	{
		[Address(RVA = "0x29EF5A0", Offset = "0x29EE9A0", Length = "0x39")]
		[Token(Token = "0x6000ECA")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x29EEB50", Offset = "0x29EDF50", Length = "0x8A")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6000ED2")]
	internal static void CheckEnabled() { }

	[Address(RVA = "0x29EEBE0", Offset = "0x29EDFE0", Length = "0x173")]
	[Token(Token = "0x6000ECC")]
	public static void Disable() { }

	[Address(RVA = "0x29EED60", Offset = "0x29EE160", Length = "0x14E")]
	[Token(Token = "0x6000ECB")]
	public static void Enable() { }

	[Address(RVA = "0x29EF5A0", Offset = "0x29EE9A0", Length = "0x39")]
	[Token(Token = "0x6000ECA")]
	public static bool get_enabled() { }

	[Address(RVA = "0x29EEEB0", Offset = "0x29EE2B0", Length = "0x238")]
	[Token(Token = "0x6000ED0")]
	private static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	[Address(RVA = "0x29EF0F0", Offset = "0x29EE4F0", Length = "0x7F")]
	[Token(Token = "0x6000ED1")]
	private static void OnSettingsChange() { }

	[Address(RVA = "0x29EF170", Offset = "0x29EE570", Length = "0xC0")]
	[Token(Token = "0x6000ECD")]
	internal static void Reset() { }

	[Address(RVA = "0x29EF230", Offset = "0x29EE630", Length = "0x1B2")]
	[Token(Token = "0x6000ECE")]
	private static void SetUpState() { }

	[Address(RVA = "0x29EF3F0", Offset = "0x29EE7F0", Length = "0x1AD")]
	[Token(Token = "0x6000ECF")]
	internal static void TearDownState() { }

}


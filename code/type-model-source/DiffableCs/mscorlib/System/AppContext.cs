namespace System;

[Token(Token = "0x2000177")]
public static class AppContext
{
	[Flags]
	[Token(Token = "0x2000178")]
	private enum SwitchValueState : int
	{
		HasFalseValue = 1,
		HasTrueValue = 2,
		HasLookedForOverride = 4,
		UnknownValue = 8,
	}

	[Token(Token = "0x400056B")]
	private static readonly Dictionary<String, SwitchValueState> s_switchMap; //Field offset: 0x0
	[Token(Token = "0x400056C")]
	private static bool s_defaultsInitialized; //Field offset: 0x8

	[Address(RVA = "0x2059C00", Offset = "0x2059000", Length = "0x9C")]
	[Token(Token = "0x6000D71")]
	private static AppContext() { }

	[Address(RVA = "0x2059640", Offset = "0x2058A40", Length = "0x14D")]
	[Token(Token = "0x6000D6F")]
	private static void InitializeDefaultSwitchValues() { }

	[Address(RVA = "0x2059790", Offset = "0x2058B90", Length = "0x466")]
	[Token(Token = "0x6000D70")]
	public static bool TryGetSwitch(string switchName, out bool isEnabled) { }

}


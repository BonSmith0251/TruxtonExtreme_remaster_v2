namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
[Token(Token = "0x2000167")]
public class PlayerPrefs
{

	[Address(RVA = "0x306E280", Offset = "0x306D680", Length = "0x2A")]
	[NativeMethod("DeleteAllWithCallback")]
	[Token(Token = "0x60011F3")]
	public static void DeleteAll() { }

	[Address(RVA = "0x306E2F0", Offset = "0x306D6F0", Length = "0x178")]
	[Token(Token = "0x60011F2")]
	public static void DeleteKey(string key) { }

	[Address(RVA = "0x306E2B0", Offset = "0x306D6B0", Length = "0x33")]
	[Token(Token = "0x60011FC")]
	private static void DeleteKey_Injected(ref ManagedSpanWrapper key) { }

	[Address(RVA = "0x306E4C0", Offset = "0x306D8C0", Length = "0x1A6")]
	[Token(Token = "0x60011ED")]
	public static float GetFloat(string key, float defaultValue) { }

	[Address(RVA = "0x306E670", Offset = "0x306DA70", Length = "0xD")]
	[Token(Token = "0x60011EE")]
	public static float GetFloat(string key) { }

	[Address(RVA = "0x306E470", Offset = "0x306D870", Length = "0x43")]
	[Token(Token = "0x60011F9")]
	private static float GetFloat_Injected(ref ManagedSpanWrapper key, float defaultValue) { }

	[Address(RVA = "0x306E6D0", Offset = "0x306DAD0", Length = "0x199")]
	[Token(Token = "0x60011EA")]
	public static int GetInt(string key, int defaultValue) { }

	[Address(RVA = "0x306E6C0", Offset = "0x306DAC0", Length = "0xC")]
	[Token(Token = "0x60011EB")]
	public static int GetInt(string key) { }

	[Address(RVA = "0x306E680", Offset = "0x306DA80", Length = "0x40")]
	[Token(Token = "0x60011F8")]
	private static int GetInt_Injected(ref ManagedSpanWrapper key, int defaultValue) { }

	[Address(RVA = "0x306E8D0", Offset = "0x306DCD0", Length = "0x2ED")]
	[Token(Token = "0x60011F0")]
	public static string GetString(string key, string defaultValue) { }

	[Address(RVA = "0x306E870", Offset = "0x306DC70", Length = "0x52")]
	[Token(Token = "0x60011FA")]
	private static void GetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x306EC00", Offset = "0x306E000", Length = "0x18D")]
	[Token(Token = "0x60011F1")]
	public static bool HasKey(string key) { }

	[Address(RVA = "0x306EBC0", Offset = "0x306DFC0", Length = "0x33")]
	[Token(Token = "0x60011FB")]
	private static bool HasKey_Injected(ref ManagedSpanWrapper key) { }

	[Address(RVA = "0x306ED90", Offset = "0x306E190", Length = "0x2A")]
	[NativeMethod("Sync")]
	[Token(Token = "0x60011F4")]
	public static void Save() { }

	[Address(RVA = "0x306EDC0", Offset = "0x306E1C0", Length = "0x67")]
	[Token(Token = "0x60011EC")]
	public static void SetFloat(string key, float value) { }

	[Address(RVA = "0x306EE30", Offset = "0x306E230", Length = "0x67")]
	[Token(Token = "0x60011E9")]
	public static void SetInt(string key, int value) { }

	[Address(RVA = "0x306EEA0", Offset = "0x306E2A0", Length = "0x67")]
	[Token(Token = "0x60011EF")]
	public static void SetString(string key, string value) { }

	[Address(RVA = "0x306EF60", Offset = "0x306E360", Length = "0x1A3")]
	[NativeMethod("SetFloat")]
	[Token(Token = "0x60011E7")]
	private static bool TrySetFloat(string key, float value) { }

	[Address(RVA = "0x306EF10", Offset = "0x306E310", Length = "0x43")]
	[Token(Token = "0x60011F6")]
	private static bool TrySetFloat_Injected(ref ManagedSpanWrapper key, float value) { }

	[Address(RVA = "0x306F150", Offset = "0x306E550", Length = "0x19A")]
	[NativeMethod("SetInt")]
	[Token(Token = "0x60011E6")]
	private static bool TrySetInt(string key, int value) { }

	[Address(RVA = "0x306F110", Offset = "0x306E510", Length = "0x40")]
	[Token(Token = "0x60011F5")]
	private static bool TrySetInt_Injected(ref ManagedSpanWrapper key, int value) { }

	[Address(RVA = "0x306F340", Offset = "0x306E740", Length = "0x2A2")]
	[NativeMethod("SetString")]
	[Token(Token = "0x60011E8")]
	private static bool TrySetSetString(string key, string value) { }

	[Address(RVA = "0x306F2F0", Offset = "0x306E6F0", Length = "0x42")]
	[Token(Token = "0x60011F7")]
	private static bool TrySetSetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper value) { }

}


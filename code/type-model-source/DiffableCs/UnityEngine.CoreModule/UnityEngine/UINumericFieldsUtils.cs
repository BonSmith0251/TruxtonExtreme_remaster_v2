namespace UnityEngine;

[Token(Token = "0x20001F4")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal static class UINumericFieldsUtils
{
	[Token(Token = "0x40006FE")]
	public static readonly string k_AllowedCharactersForFloat; //Field offset: 0x0
	[Token(Token = "0x40006FF")]
	public static readonly string k_AllowedCharactersForFloat_NoExpressions; //Field offset: 0x8
	[Token(Token = "0x4000700")]
	public static readonly string k_AllowedCharactersForInt; //Field offset: 0x10
	[Token(Token = "0x4000701")]
	public static readonly string k_AllowedCharactersForInt_NoExpressions; //Field offset: 0x18
	[Token(Token = "0x4000702")]
	public static readonly string k_AllowedCharactersForUInt_NoExpressions; //Field offset: 0x20
	[Token(Token = "0x4000703")]
	public static readonly string k_DoubleFieldFormatString; //Field offset: 0x28
	[Token(Token = "0x4000704")]
	public static readonly string k_FloatFieldFormatString; //Field offset: 0x30
	[Token(Token = "0x4000705")]
	public static readonly string k_IntFieldFormatString; //Field offset: 0x38

	[Address(RVA = "0x30955F0", Offset = "0x30949F0", Length = "0x237")]
	[Token(Token = "0x600160C")]
	private static UINumericFieldsUtils() { }

	[Address(RVA = "0x3094D00", Offset = "0x3094100", Length = "0x18B")]
	[Token(Token = "0x6001603")]
	public static bool TryConvertStringToDouble(string str, out double value, out Expression expr) { }

	[Address(RVA = "0x3094E90", Offset = "0x3094290", Length = "0x109")]
	[Token(Token = "0x6001604")]
	public static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value, out Expression expression) { }

	[Address(RVA = "0x3094FA0", Offset = "0x30943A0", Length = "0x162")]
	[Token(Token = "0x6001605")]
	public static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value, out Expression expression) { }

	[Address(RVA = "0x3095110", Offset = "0x3094510", Length = "0x9F")]
	[Token(Token = "0x600160A")]
	public static bool TryConvertStringToInt(string str, string initialValueAsString, out int value, out Expression expression) { }

	[Address(RVA = "0x3095300", Offset = "0x3094700", Length = "0x79")]
	[Token(Token = "0x6001606")]
	public static bool TryConvertStringToLong(string str, out long value, out Expression expr) { }

	[Address(RVA = "0x30951B0", Offset = "0x30945B0", Length = "0x14D")]
	[Token(Token = "0x6001607")]
	public static bool TryConvertStringToLong(string str, string initialValueAsString, out long value, out Expression expression) { }

	[Address(RVA = "0x3095380", Offset = "0x3094780", Length = "0x9F")]
	[Token(Token = "0x600160B")]
	public static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value, out Expression expression) { }

	[Address(RVA = "0x3095420", Offset = "0x3094820", Length = "0x79")]
	[Token(Token = "0x6001608")]
	public static bool TryConvertStringToULong(string str, out ulong value, out Expression expr) { }

	[Address(RVA = "0x30954A0", Offset = "0x30948A0", Length = "0x14D")]
	[Token(Token = "0x6001609")]
	public static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value, out Expression expression) { }

}


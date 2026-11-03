namespace UnityEngine.UIElements;

[Token(Token = "0x20000C8")]
internal static class EnumFieldHelpers
{
	[Token(Token = "0x40003E9")]
	internal static readonly UxmlTypeAttributeDescription<Enum> type; //Field offset: 0x0
	[Token(Token = "0x40003EA")]
	internal static readonly UxmlStringAttributeDescription value; //Field offset: 0x8
	[Token(Token = "0x40003EB")]
	internal static readonly UxmlBoolAttributeDescription includeObsoleteValues; //Field offset: 0x10

	[Address(RVA = "0x333BE00", Offset = "0x333B200", Length = "0x1B2")]
	[Token(Token = "0x600064E")]
	private static EnumFieldHelpers() { }

	[Address(RVA = "0x333B9C0", Offset = "0x333ADC0", Length = "0x43E")]
	[Token(Token = "0x600064D")]
	internal static bool ExtractValue(IUxmlAttributes bag, CreationContext cc, out Type resEnumType, out Enum resEnumValue, out bool resIncludeObsoleteValues) { }

}


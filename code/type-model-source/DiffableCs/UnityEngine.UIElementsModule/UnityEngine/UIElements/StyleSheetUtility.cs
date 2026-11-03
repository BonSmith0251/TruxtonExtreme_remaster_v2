namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x200048D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StyleSheetUtility
{
	[Token(Token = "0x4000EF5")]
	private static readonly Dictionary<String, String> SpecialEnumToStringCases; //Field offset: 0x0
	[Token(Token = "0x4000EF6")]
	private static readonly Dictionary<String, String> SpecialStringToEnumCases; //Field offset: 0x8

	[Address(RVA = "0x328CDE0", Offset = "0x328C1E0", Length = "0x1BD")]
	[Token(Token = "0x6002247")]
	private static StyleSheetUtility() { }

	[Address(RVA = "0x328B850", Offset = "0x328AC50", Length = "0xFC")]
	[Token(Token = "0x6002243")]
	public static string ConvertCamelToDash(string camel) { }

	[Address(RVA = "0x328B950", Offset = "0x328AD50", Length = "0x4F")]
	[Token(Token = "0x6002244")]
	public static string ConvertDashToHungarian(string dash) { }

	[Address(RVA = "0x328B9A0", Offset = "0x328ADA0", Length = "0x2F7")]
	[Token(Token = "0x6002245")]
	public static string ConvertDashToUpperNoSpace(string dash, bool firstCase, bool addSpace) { }

	[Address(RVA = "0x328BCA0", Offset = "0x328B0A0", Length = "0x54")]
	[Token(Token = "0x600223A")]
	public static StyleSheet CreateInstanceWithHideFlags() { }

	[Address(RVA = "0x328BD00", Offset = "0x328B100", Length = "0x8C")]
	[Token(Token = "0x6002246")]
	public static string GetDimensionUnitExportString(Unit unit) { }

	[Address(RVA = "0x328BEC0", Offset = "0x328B2C0", Length = "0x14F")]
	[Token(Token = "0x6002242")]
	public static string GetEnumExportString(Enum value) { }

	[Address(RVA = "0x328C350", Offset = "0x328B750", Length = "0x1BD")]
	[Extension]
	[Token(Token = "0x600223B")]
	public static Dimension ToDimension(Length length) { }

	[Address(RVA = "0x328C510", Offset = "0x328B910", Length = "0x1FF")]
	[Extension]
	[Token(Token = "0x600223D")]
	public static Dimension ToDimension(Angle angle) { }

	[Address(RVA = "0x328C240", Offset = "0x328B640", Length = "0x108")]
	[Extension]
	[Token(Token = "0x600223F")]
	public static Dimension ToDimension(TimeValue timeValue) { }

	[Address(RVA = "0x328C190", Offset = "0x328B590", Length = "0xAE")]
	[Extension]
	[Token(Token = "0x600223C")]
	public static Unit ToDimensionUnit(LengthUnit unit) { }

	[Address(RVA = "0x328C0C0", Offset = "0x328B4C0", Length = "0xCE")]
	[Extension]
	[Token(Token = "0x600223E")]
	public static Unit ToDimensionUnit(AngleUnit unit) { }

	[Address(RVA = "0x328C010", Offset = "0x328B410", Length = "0xAE")]
	[Extension]
	[Token(Token = "0x6002240")]
	public static Unit ToDimensionUnit(TimeUnit unit) { }

	[Address(RVA = "0x328C710", Offset = "0x328BB10", Length = "0x1F0")]
	[Token(Token = "0x6002241")]
	public static void TransferStylePropertyHandles(StyleSheet fromStyleSheet, StyleProperty fromStyleProperty, StyleSheet toStyleSheet, StyleProperty toStyleProperty) { }

}


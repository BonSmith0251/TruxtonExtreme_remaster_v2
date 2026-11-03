namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000631")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class CSSSpec
{
	[Token(Token = "0x4001744")]
	private static readonly Regex rgx; //Field offset: 0x0

	[Address(RVA = "0x334EAC0", Offset = "0x334DEC0", Length = "0x8D")]
	[Token(Token = "0x6002C0F")]
	private static CSSSpec() { }

	[Address(RVA = "0x334E2C0", Offset = "0x334D6C0", Length = "0x141")]
	[Token(Token = "0x6002C0C")]
	public static int GetSelectorSpecificity(string selector) { }

	[Address(RVA = "0x334E410", Offset = "0x334D810", Length = "0xDD")]
	[Token(Token = "0x6002C0D")]
	public static int GetSelectorSpecificity(StyleSelectorPart[] parts) { }

	[Address(RVA = "0x334E4F0", Offset = "0x334D8F0", Length = "0x5C4")]
	[Token(Token = "0x6002C0E")]
	public static bool ParseSelector(string selector, out StyleSelectorPart[] parts) { }

}


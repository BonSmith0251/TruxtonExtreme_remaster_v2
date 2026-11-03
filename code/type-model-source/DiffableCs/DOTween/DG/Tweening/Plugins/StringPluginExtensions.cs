namespace DG.Tweening.Plugins;

[Extension]
[Token(Token = "0x2000082")]
internal static class StringPluginExtensions
{
	[Token(Token = "0x400015C")]
	public static readonly Char[] ScrambledCharsAll; //Field offset: 0x0
	[Token(Token = "0x400015D")]
	public static readonly Char[] ScrambledCharsUppercase; //Field offset: 0x8
	[Token(Token = "0x400015E")]
	public static readonly Char[] ScrambledCharsLowercase; //Field offset: 0x10
	[Token(Token = "0x400015F")]
	public static readonly Char[] ScrambledCharsNumerals; //Field offset: 0x18
	[Token(Token = "0x4000160")]
	private static int _lastRndSeed; //Field offset: 0x20

	[Address(RVA = "0x6738F0", Offset = "0x672CF0", Length = "0x3BF")]
	[Token(Token = "0x6000342")]
	private static StringPluginExtensions() { }

	[Address(RVA = "0x6736F0", Offset = "0x672AF0", Length = "0x15D")]
	[Extension]
	[Token(Token = "0x6000344")]
	internal static StringBuilder AppendScrambledChars(StringBuilder buffer, int length, Char[] chars) { }

	[Address(RVA = "0x673850", Offset = "0x672C50", Length = "0x96")]
	[Extension]
	[Token(Token = "0x6000343")]
	internal static void ScrambleChars(Char[] chars) { }

}


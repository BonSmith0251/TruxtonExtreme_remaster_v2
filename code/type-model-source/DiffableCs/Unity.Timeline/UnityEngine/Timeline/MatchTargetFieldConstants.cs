namespace UnityEngine.Timeline;

[Extension]
[Token(Token = "0x2000013")]
internal static class MatchTargetFieldConstants
{
	[Token(Token = "0x4000043")]
	public static MatchTargetFields All; //Field offset: 0x0
	[Token(Token = "0x4000044")]
	public static MatchTargetFields None; //Field offset: 0x4
	[Token(Token = "0x4000045")]
	public static MatchTargetFields Position; //Field offset: 0x8
	[Token(Token = "0x4000046")]
	public static MatchTargetFields Rotation; //Field offset: 0xC

	[Address(RVA = "0x2F2FED0", Offset = "0x2F2F2D0", Length = "0x78")]
	[Token(Token = "0x600004A")]
	private static MatchTargetFieldConstants() { }

	[Address(RVA = "0x2F2FE60", Offset = "0x2F2F260", Length = "0x63")]
	[Extension]
	[Token(Token = "0x6000048")]
	public static bool HasAny(MatchTargetFields me, MatchTargetFields fields) { }

	[Address(RVA = "0x1E2AA10", Offset = "0x1E29E10", Length = "0x5")]
	[Extension]
	[Token(Token = "0x6000049")]
	public static MatchTargetFields Toggle(MatchTargetFields me, MatchTargetFields flag) { }

}


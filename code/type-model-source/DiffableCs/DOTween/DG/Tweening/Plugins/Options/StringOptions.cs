namespace DG.Tweening.Plugins.Options;

[Token(Token = "0x200008F")]
public struct StringOptions : IPlugOptions
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000185")]
	public bool richTextEnabled; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000186")]
	public ScrambleMode scrambleMode; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000187")]
	public Char[] scrambledChars; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000188")]
	internal int startValueStrippedLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000189")]
	internal int changeValueStrippedLength; //Field offset: 0x14

	[Address(RVA = "0x6736B0", Offset = "0x672AB0", Length = "0x33")]
	[Token(Token = "0x6000360")]
	public override void Reset() { }

}


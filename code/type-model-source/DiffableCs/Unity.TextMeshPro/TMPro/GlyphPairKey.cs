namespace TMPro;

[Token(Token = "0x200005E")]
public struct GlyphPairKey
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000273")]
	public uint firstGlyphIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000274")]
	public uint secondGlyphIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000275")]
	public uint key; //Field offset: 0x8

	[Address(RVA = "0x2EC5690", Offset = "0x2EC4A90", Length = "0x12")]
	[Token(Token = "0x60002E6")]
	public GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex) { }

	[Address(RVA = "0x2EC56B0", Offset = "0x2EC4AB0", Length = "0x29")]
	[Token(Token = "0x60002E7")]
	internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record) { }

}


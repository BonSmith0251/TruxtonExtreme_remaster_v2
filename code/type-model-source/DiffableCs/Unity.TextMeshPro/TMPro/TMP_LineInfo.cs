namespace TMPro;

[Token(Token = "0x2000071")]
public struct TMP_LineInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000313")]
	internal int controlCharacterCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000314")]
	public int characterCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000315")]
	public int visibleCharacterCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000316")]
	public int spaceCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000317")]
	public int visibleSpaceCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000318")]
	public int wordCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000319")]
	public int firstCharacterIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400031A")]
	public int firstVisibleCharacterIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400031B")]
	public int lastCharacterIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400031C")]
	public int lastVisibleCharacterIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400031D")]
	public float length; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400031E")]
	public float lineHeight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400031F")]
	public float ascender; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000320")]
	public float baseline; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000321")]
	public float descender; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000322")]
	public float maxAdvance; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000323")]
	public float width; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000324")]
	public float marginLeft; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000325")]
	public float marginRight; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000326")]
	public HorizontalAlignmentOptions alignment; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000327")]
	public Extents lineExtents; //Field offset: 0x50

}


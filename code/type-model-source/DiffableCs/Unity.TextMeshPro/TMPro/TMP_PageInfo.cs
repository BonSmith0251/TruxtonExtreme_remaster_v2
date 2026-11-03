namespace TMPro;

[Token(Token = "0x2000022")]
public struct TMP_PageInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C8")]
	public int firstCharacterIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000C9")]
	public int lastCharacterIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000CA")]
	public float ascender; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000CB")]
	public float baseLine; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CC")]
	public float descender; //Field offset: 0x10

}


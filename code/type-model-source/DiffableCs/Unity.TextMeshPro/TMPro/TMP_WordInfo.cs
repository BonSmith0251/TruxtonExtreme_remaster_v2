namespace TMPro;

[Token(Token = "0x2000024")]
public struct TMP_WordInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D4")]
	public TMP_Text textComponent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000D5")]
	public int firstCharacterIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000D6")]
	public int lastCharacterIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D7")]
	public int characterCount; //Field offset: 0x10

	[Address(RVA = "0x2EC3D20", Offset = "0x2EC3120", Length = "0xD3")]
	[Token(Token = "0x6000142")]
	public string GetWord() { }

}


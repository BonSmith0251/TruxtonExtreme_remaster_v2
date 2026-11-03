namespace TMPro;

[Token(Token = "0x2000023")]
public struct TMP_LinkInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000CD")]
	public TMP_Text textComponent; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000CE")]
	public int hashCode; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000CF")]
	public int linkIdFirstCharacterIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D0")]
	public int linkIdLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000D1")]
	public int linkTextfirstCharacterIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D2")]
	public int linkTextLength; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D3")]
	internal Char[] linkID; //Field offset: 0x20

	[Address(RVA = "0x2EC3860", Offset = "0x2EC2C60", Length = "0x7")]
	[Token(Token = "0x6000140")]
	public string GetLink() { }

	[Address(RVA = "0x2EC36E0", Offset = "0x2EC2AE0", Length = "0x94")]
	[Token(Token = "0x6000141")]
	public string GetLinkID() { }

	[Address(RVA = "0x2EC3780", Offset = "0x2EC2B80", Length = "0xD6")]
	[Token(Token = "0x600013F")]
	public string GetLinkText() { }

	[Address(RVA = "0x2EC3870", Offset = "0x2EC2C70", Length = "0xD6")]
	[Token(Token = "0x600013E")]
	internal void SetLinkID(Char[] text, int startIndex, int length) { }

}


namespace TMPro;

[Token(Token = "0x2000025")]
public struct TMP_SpriteInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D8")]
	public int spriteIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000D9")]
	public int characterIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000DA")]
	public int vertexIndex; //Field offset: 0x8

}


namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000063")]
internal struct TextCacheEntry
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003A0")]
	public TextHandle textHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003A1")]
	public TextInfo textInfo; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A2")]
	public float lastTimeInCache; //Field offset: 0x10

	[Address(RVA = "0x31C3FC0", Offset = "0x31C33C0", Length = "0xAA")]
	[Token(Token = "0x6000308")]
	public TextCacheEntry(TextHandle handle, TextInfo info, float time = 0) { }

}


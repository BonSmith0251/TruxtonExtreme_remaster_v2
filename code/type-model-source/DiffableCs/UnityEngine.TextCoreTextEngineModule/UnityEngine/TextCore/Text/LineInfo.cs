namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000024")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct LineInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000CE")]
	internal int controlCharacterCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000CF")]
	public int characterCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000D0")]
	public int visibleCharacterCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000D1")]
	public int visibleSpaceCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D2")]
	public int spaceCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000D3")]
	public int wordCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D4")]
	public int firstCharacterIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000D5")]
	public int firstVisibleCharacterIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D6")]
	public int lastCharacterIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000D7")]
	public int lastVisibleCharacterIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D8")]
	public float length; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000D9")]
	public float lineHeight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000DA")]
	public float ascender; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000DB")]
	public float baseline; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000DC")]
	public float descender; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000DD")]
	public float maxAdvance; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000DE")]
	public float width; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000DF")]
	public float marginLeft; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000E0")]
	public float marginRight; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40000E1")]
	public TextAlignment alignment; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000E2")]
	public Extents lineExtents; //Field offset: 0x50

}


namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000052")]
internal struct RichTextTagAttribute
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000324")]
	public int nameHashCode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000325")]
	public int valueHashCode; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000326")]
	public TagValueType valueType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000327")]
	public int valueStartIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000328")]
	public int valueLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000329")]
	public TagUnitType unitType; //Field offset: 0x14

}


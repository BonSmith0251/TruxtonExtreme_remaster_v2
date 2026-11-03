namespace TMPro;

[Token(Token = "0x200002A")]
internal struct RichTextTagAttribute
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400012A")]
	public int nameHashCode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400012B")]
	public int valueHashCode; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400012C")]
	public TagValueType valueType; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400012D")]
	public int valueStartIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012E")]
	public int valueLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400012F")]
	public TagUnitType unitType; //Field offset: 0x14

}


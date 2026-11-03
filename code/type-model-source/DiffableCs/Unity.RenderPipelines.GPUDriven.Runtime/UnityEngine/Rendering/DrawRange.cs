namespace UnityEngine.Rendering;

[Token(Token = "0x200003A")]
internal struct DrawRange
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C4")]
	public RangeKey key; //Field offset: 0x0
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000C5")]
	public int drawCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C6")]
	public int drawOffset; //Field offset: 0x20

}


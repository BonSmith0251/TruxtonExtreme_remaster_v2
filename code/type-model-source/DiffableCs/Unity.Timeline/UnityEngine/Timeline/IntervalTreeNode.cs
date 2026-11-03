namespace UnityEngine.Timeline;

[Token(Token = "0x200003B")]
internal struct IntervalTreeNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000110")]
	public long center; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000111")]
	public int first; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000112")]
	public int last; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000113")]
	public int left; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000114")]
	public int right; //Field offset: 0x14

}


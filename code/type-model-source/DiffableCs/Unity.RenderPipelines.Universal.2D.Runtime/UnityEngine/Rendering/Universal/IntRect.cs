namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200000C")]
internal struct IntRect
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000019")]
	public long left; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001A")]
	public long top; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001B")]
	public long right; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001C")]
	public long bottom; //Field offset: 0x18

	[Address(RVA = "0x27F6BF0", Offset = "0x27F5FF0", Length = "0x15")]
	[Token(Token = "0x6000032")]
	public IntRect(long l, long t, long r, long b) { }

	[Address(RVA = "0x289D030", Offset = "0x289C430", Length = "0x1F")]
	[Token(Token = "0x6000033")]
	public IntRect(IntRect ir) { }

}


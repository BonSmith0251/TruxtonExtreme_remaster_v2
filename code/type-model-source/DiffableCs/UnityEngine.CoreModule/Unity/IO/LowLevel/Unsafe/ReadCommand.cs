namespace Unity.IO.LowLevel.Unsafe;

[Token(Token = "0x200003A")]
public struct ReadCommand
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009D")]
	public Void* Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400009E")]
	public long Offset; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009F")]
	public long Size; //Field offset: 0x10

}


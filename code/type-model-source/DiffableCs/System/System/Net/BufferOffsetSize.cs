namespace System.Net;

[Token(Token = "0x2000260")]
internal class BufferOffsetSize
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009AE")]
	internal Byte[] Buffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009AF")]
	internal int Offset; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40009B0")]
	internal int Size; //Field offset: 0x1C

	[Address(RVA = "0x2698320", Offset = "0x2697720", Length = "0xBA")]
	[Token(Token = "0x600100F")]
	internal BufferOffsetSize(Byte[] buffer, int offset, int size, bool copyBuffer) { }

	[Address(RVA = "0x2698260", Offset = "0x2697660", Length = "0xB9")]
	[Token(Token = "0x6001010")]
	internal BufferOffsetSize(Byte[] buffer, bool copyBuffer) { }

}


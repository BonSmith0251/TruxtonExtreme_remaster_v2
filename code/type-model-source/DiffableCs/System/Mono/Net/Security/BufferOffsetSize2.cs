namespace Mono.Net.Security;

[Token(Token = "0x2000047")]
internal class BufferOffsetSize2 : BufferOffsetSize
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009E")]
	public readonly int InitialSize; //Field offset: 0x28

	[Address(RVA = "0x22BB330", Offset = "0x22BA730", Length = "0x113")]
	[Token(Token = "0x60000AF")]
	public BufferOffsetSize2(int size) { }

	[Address(RVA = "0x22BB0E0", Offset = "0x22BA4E0", Length = "0x10C")]
	[Token(Token = "0x60000B2")]
	public void AppendData(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x22BB1F0", Offset = "0x22BA5F0", Length = "0xD0")]
	[Token(Token = "0x60000B1")]
	public void MakeRoom(int size) { }

	[Address(RVA = "0x22BB2D0", Offset = "0x22BA6D0", Length = "0x57")]
	[Token(Token = "0x60000B0")]
	public void Reset() { }

}


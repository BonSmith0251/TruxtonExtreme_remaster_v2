namespace System.Threading;

[Token(Token = "0x200028D")]
internal class ReaderWriterCount
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004A9")]
	public long lockID; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004AA")]
	public int readercount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004AB")]
	public int writercount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004AC")]
	public int upgradecount; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004AD")]
	public ReaderWriterCount next; //Field offset: 0x28

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000CEE")]
	public ReaderWriterCount() { }

}


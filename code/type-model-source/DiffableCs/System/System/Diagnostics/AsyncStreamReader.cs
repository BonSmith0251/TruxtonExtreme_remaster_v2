namespace System.Diagnostics;

[Token(Token = "0x2000106")]
internal class AsyncStreamReader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000488")]
	private Stream stream; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000489")]
	private Encoding encoding; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400048A")]
	private Decoder decoder; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400048B")]
	private Byte[] byteBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400048C")]
	private Char[] charBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400048D")]
	private bool cancelOperation; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400048E")]
	private ManualResetEvent eofEvent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400048F")]
	private object syncObject; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000490")]
	private IAsyncResult asyncReadResult; //Field offset: 0x50

	[Address(RVA = "0x262C670", Offset = "0x262BA70", Length = "0x5")]
	[Token(Token = "0x600065D")]
	internal void CancelOperation() { }

	[Address(RVA = "0x25F01A0", Offset = "0x25EF5A0", Length = "0x16")]
	[Token(Token = "0x600065B")]
	public override void Close() { }

	[Address(RVA = "0x262C680", Offset = "0x262BA80", Length = "0x2FD")]
	[Token(Token = "0x600065C")]
	protected override void Dispose(bool disposing) { }

}


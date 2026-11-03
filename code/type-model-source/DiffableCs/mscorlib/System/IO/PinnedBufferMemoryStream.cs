namespace System.IO;

[Token(Token = "0x2000644")]
internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40018F5")]
	private Byte[] _array; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40018F6")]
	private GCHandle _pinningHandle; //Field offset: 0x70

	[Address(RVA = "0x1FDDE00", Offset = "0x1FDD200", Length = "0x118")]
	[Token(Token = "0x6002E84")]
	internal PinnedBufferMemoryStream(Byte[] array) { }

	[Address(RVA = "0x1FDDD00", Offset = "0x1FDD100", Length = "0x47")]
	[Token(Token = "0x6002E88")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1FDDD50", Offset = "0x1FDD150", Length = "0x65")]
	[Token(Token = "0x6002E87")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1FDDDC0", Offset = "0x1FDD1C0", Length = "0x1E")]
	[Token(Token = "0x6002E85")]
	public virtual int Read(Span<Byte> buffer) { }

	[Address(RVA = "0x1FDDDE0", Offset = "0x1FDD1E0", Length = "0x1E")]
	[Token(Token = "0x6002E86")]
	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

}


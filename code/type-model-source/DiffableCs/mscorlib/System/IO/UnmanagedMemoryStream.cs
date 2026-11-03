namespace System.IO;

[Token(Token = "0x2000658")]
public class UnmanagedMemoryStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001970")]
	private SafeBuffer _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001971")]
	private Byte* _mem; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001972")]
	private long _length; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001973")]
	private long _capacity; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001974")]
	private long _position; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001975")]
	private long _offset; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001976")]
	private FileAccess _access; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001977")]
	internal bool _isOpen; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001978")]
	private Task<Int32> _lastReadTask; //Field offset: 0x60

	[Token(Token = "0x17000764")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x1FEC940", Offset = "0x1FEBD40", Length = "0x10")]
		[Token(Token = "0x6002F3D")]
		 get { } //Length: 16
	}

	[Token(Token = "0x17000765")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x1FEC950", Offset = "0x1FEBD50", Length = "0x5")]
		[Token(Token = "0x6002F3E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000766")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x1FEC960", Offset = "0x1FEBD60", Length = "0x11")]
		[Token(Token = "0x6002F3F")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000767")]
	public virtual long Length
	{
		[Address(RVA = "0x1FEC980", Offset = "0x1FEBD80", Length = "0x44")]
		[Token(Token = "0x6002F46")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000768")]
	public virtual long Position
	{
		[Address(RVA = "0x1FECAC0", Offset = "0x1FEBEC0", Length = "0x51")]
		[Token(Token = "0x6002F47")]
		 get { } //Length: 81
		[Address(RVA = "0x1FECB20", Offset = "0x1FEBF20", Length = "0xC1")]
		[Token(Token = "0x6002F48")]
		 set { } //Length: 193
	}

	[CLSCompliant(False)]
	[Token(Token = "0x17000769")]
	public Byte* PositionPointer
	{
		[Address(RVA = "0x1FEC9D0", Offset = "0x1FEBDD0", Length = "0xE8")]
		[Token(Token = "0x6002F49")]
		 get { } //Length: 232
	}

	[Address(RVA = "0x1FEC8E0", Offset = "0x1FEBCE0", Length = "0x56")]
	[Token(Token = "0x6002F3A")]
	protected UnmanagedMemoryStream() { }

	[Address(RVA = "0x1FEC850", Offset = "0x1FEBC50", Length = "0x89")]
	[CLSCompliant(False)]
	[Token(Token = "0x6002F3B")]
	public UnmanagedMemoryStream(Byte* pointer, long length, long capacity, FileAccess access) { }

	[Address(RVA = "0x1FEA650", Offset = "0x1FE9A50", Length = "0x14")]
	[Token(Token = "0x6002F40")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1FEA670", Offset = "0x1FE9A70", Length = "0x3A")]
	[Token(Token = "0x6002F41")]
	private void EnsureNotClosed() { }

	[Address(RVA = "0x1FEA6B0", Offset = "0x1FE9AB0", Length = "0x4B")]
	[Token(Token = "0x6002F42")]
	private void EnsureReadable() { }

	[Address(RVA = "0x1FEA700", Offset = "0x1FE9B00", Length = "0x4B")]
	[Token(Token = "0x6002F43")]
	private void EnsureWriteable() { }

	[Address(RVA = "0x1FEA670", Offset = "0x1FE9A70", Length = "0x3A")]
	[Token(Token = "0x6002F44")]
	public virtual void Flush() { }

	[Address(RVA = "0x1FEA750", Offset = "0x1FE9B50", Length = "0x127")]
	[Token(Token = "0x6002F45")]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FEC940", Offset = "0x1FEBD40", Length = "0x10")]
	[Token(Token = "0x6002F3D")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x1FEC950", Offset = "0x1FEBD50", Length = "0x5")]
	[Token(Token = "0x6002F3E")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x1FEC960", Offset = "0x1FEBD60", Length = "0x11")]
	[Token(Token = "0x6002F3F")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1FEC980", Offset = "0x1FEBD80", Length = "0x44")]
	[Token(Token = "0x6002F46")]
	public virtual long get_Length() { }

	[Address(RVA = "0x1FECAC0", Offset = "0x1FEBEC0", Length = "0x51")]
	[Token(Token = "0x6002F47")]
	public virtual long get_Position() { }

	[Address(RVA = "0x1FEC9D0", Offset = "0x1FEBDD0", Length = "0xE8")]
	[Token(Token = "0x6002F49")]
	public Byte* get_PositionPointer() { }

	[Address(RVA = "0x1FEA880", Offset = "0x1FE9C80", Length = "0x282")]
	[CLSCompliant(False)]
	[Token(Token = "0x6002F3C")]
	protected void Initialize(Byte* pointer, long length, long capacity, FileAccess access) { }

	[Address(RVA = "0x1FEB610", Offset = "0x1FEAA10", Length = "0x214")]
	[Token(Token = "0x6002F4A")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1FEB560", Offset = "0x1FEA960", Length = "0xAF")]
	[Token(Token = "0x6002F4B")]
	public virtual int Read(Span<Byte> buffer) { }

	[Address(RVA = "0x1FEAB10", Offset = "0x1FE9F10", Length = "0x302")]
	[Token(Token = "0x6002F4E")]
	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1FEAE20", Offset = "0x1FEA220", Length = "0x301")]
	[Token(Token = "0x6002F4D")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FEB130", Offset = "0x1FEA530", Length = "0x194")]
	[Token(Token = "0x6002F4F")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x1FEB2D0", Offset = "0x1FEA6D0", Length = "0x28F")]
	[Token(Token = "0x6002F4C")]
	internal int ReadCore(Span<Byte> buffer) { }

	[Address(RVA = "0x1FEB830", Offset = "0x1FEAC30", Length = "0x1D4")]
	[Token(Token = "0x6002F50")]
	public virtual long Seek(long offset, SeekOrigin loc) { }

	[Address(RVA = "0x1FECB20", Offset = "0x1FEBF20", Length = "0xC1")]
	[Token(Token = "0x6002F48")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x1FEC550", Offset = "0x1FEB950", Length = "0x245")]
	[Token(Token = "0x6002F51")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1FEC7A0", Offset = "0x1FEBBA0", Length = "0xAF")]
	[Token(Token = "0x6002F52")]
	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	[Address(RVA = "0x1FEBA10", Offset = "0x1FEAE10", Length = "0x288")]
	[Token(Token = "0x6002F54")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FEBCA0", Offset = "0x1FEB0A0", Length = "0x25C")]
	[Token(Token = "0x6002F55")]
	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1FEBF00", Offset = "0x1FEB300", Length = "0x29D")]
	[Token(Token = "0x6002F56")]
	public virtual void WriteByte(byte value) { }

	[Address(RVA = "0x1FEC1A0", Offset = "0x1FEB5A0", Length = "0x3A4")]
	[Token(Token = "0x6002F53")]
	internal void WriteCore(ReadOnlySpan<Byte> buffer) { }

}


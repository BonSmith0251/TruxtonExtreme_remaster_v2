namespace System.IO;

[Token(Token = "0x2000641")]
public class MemoryStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40018EA")]
	private Byte[] _buffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40018EB")]
	private int _origin; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40018EC")]
	private int _position; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40018ED")]
	private int _length; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40018EE")]
	private int _capacity; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018EF")]
	private bool _expandable; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x40018F0")]
	private bool _writable; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x40018F1")]
	private bool _exposable; //Field offset: 0x42
	[FieldOffset(Offset = "0x43")]
	[Token(Token = "0x40018F2")]
	private bool _isOpen; //Field offset: 0x43
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018F3")]
	private Task<Int32> _lastReadTask; //Field offset: 0x48

	[Token(Token = "0x1700074A")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x1FDC510", Offset = "0x1FDB910", Length = "0x5")]
		[Token(Token = "0x6002E4F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700074B")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x1FDC510", Offset = "0x1FDB910", Length = "0x5")]
		[Token(Token = "0x6002E50")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700074C")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
		[Token(Token = "0x6002E51")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700074D")]
	public override int Capacity
	{
		[Address(RVA = "0x1FDC520", Offset = "0x1FDB920", Length = "0x40")]
		[Token(Token = "0x6002E5D")]
		 get { } //Length: 64
		[Address(RVA = "0x1FDC600", Offset = "0x1FDBA00", Length = "0x1AF")]
		[Token(Token = "0x6002E5E")]
		 set { } //Length: 431
	}

	[Token(Token = "0x1700074E")]
	public virtual long Length
	{
		[Address(RVA = "0x1FDC560", Offset = "0x1FDB960", Length = "0x42")]
		[Token(Token = "0x6002E5F")]
		 get { } //Length: 66
	}

	[Token(Token = "0x1700074F")]
	public virtual long Position
	{
		[Address(RVA = "0x1FDC5B0", Offset = "0x1FDB9B0", Length = "0x42")]
		[Token(Token = "0x6002E60")]
		 get { } //Length: 66
		[Address(RVA = "0x1FDC7B0", Offset = "0x1FDBBB0", Length = "0x110")]
		[Token(Token = "0x6002E61")]
		 set { } //Length: 272
	}

	[Address(RVA = "0x1FDC350", Offset = "0x1FDB750", Length = "0x97")]
	[Token(Token = "0x6002E49")]
	public MemoryStream() { }

	[Address(RVA = "0x1FDC3F0", Offset = "0x1FDB7F0", Length = "0x119")]
	[Token(Token = "0x6002E4A")]
	public MemoryStream(int capacity) { }

	[Address(RVA = "0x1FDC270", Offset = "0x1FDB670", Length = "0xDF")]
	[Token(Token = "0x6002E4B")]
	public MemoryStream(Byte[] buffer) { }

	[Address(RVA = "0x1FDC180", Offset = "0x1FDB580", Length = "0xED")]
	[Token(Token = "0x6002E4C")]
	public MemoryStream(Byte[] buffer, bool writable) { }

	[Address(RVA = "0x1FDBF20", Offset = "0x1FDB320", Length = "0x21")]
	[Token(Token = "0x6002E4D")]
	public MemoryStream(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1FDBF50", Offset = "0x1FDB350", Length = "0x222")]
	[Token(Token = "0x6002E4E")]
	public MemoryStream(Byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	[Address(RVA = "0x1FD9EC0", Offset = "0x1FD92C0", Length = "0x134")]
	[Token(Token = "0x6002E67")]
	public virtual void CopyTo(Stream destination, int bufferSize) { }

	[Address(RVA = "0x1FDA000", Offset = "0x1FD9400", Length = "0x94")]
	[Token(Token = "0x6002E54")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1FDA0A0", Offset = "0x1FD94A0", Length = "0xB7")]
	[Token(Token = "0x6002E55")]
	private bool EnsureCapacity(int value) { }

	[Address(RVA = "0x1FDA160", Offset = "0x1FD9560", Length = "0x3A")]
	[Token(Token = "0x6002E52")]
	private void EnsureNotClosed() { }

	[Address(RVA = "0x1FDA1A0", Offset = "0x1FD95A0", Length = "0x4B")]
	[Token(Token = "0x6002E53")]
	private void EnsureWriteable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6002E56")]
	public virtual void Flush() { }

	[Address(RVA = "0x1FDA1F0", Offset = "0x1FD95F0", Length = "0x127")]
	[Token(Token = "0x6002E57")]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FDC510", Offset = "0x1FDB910", Length = "0x5")]
	[Token(Token = "0x6002E4F")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x1FDC510", Offset = "0x1FDB910", Length = "0x5")]
	[Token(Token = "0x6002E50")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
	[Token(Token = "0x6002E51")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1FDC520", Offset = "0x1FDB920", Length = "0x40")]
	[Token(Token = "0x6002E5D")]
	public override int get_Capacity() { }

	[Address(RVA = "0x1FDC560", Offset = "0x1FDB960", Length = "0x42")]
	[Token(Token = "0x6002E5F")]
	public virtual long get_Length() { }

	[Address(RVA = "0x1FDC5B0", Offset = "0x1FDB9B0", Length = "0x42")]
	[Token(Token = "0x6002E60")]
	public virtual long get_Position() { }

	[Address(RVA = "0x1FDA320", Offset = "0x1FD9720", Length = "0x65")]
	[Token(Token = "0x6002E58")]
	public override Byte[] GetBuffer() { }

	[Address(RVA = "0x1FDA390", Offset = "0x1FD9790", Length = "0x55")]
	[Token(Token = "0x6002E5C")]
	internal int InternalEmulateRead(int count) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6002E59")]
	internal Byte[] InternalGetBuffer() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6002E5A")]
	internal int InternalGetPosition() { }

	[Address(RVA = "0x1FDA3F0", Offset = "0x1FD97F0", Length = "0xED")]
	[Token(Token = "0x6002E5B")]
	internal int InternalReadInt32() { }

	[Address(RVA = "0x1FDABE0", Offset = "0x1FD9FE0", Length = "0x271")]
	[Token(Token = "0x6002E62")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1FDAE60", Offset = "0x1FDA260", Length = "0x1CE")]
	[Token(Token = "0x6002E63")]
	public virtual int Read(Span<Byte> buffer) { }

	[Address(RVA = "0x1FDA820", Offset = "0x1FD9C20", Length = "0x339")]
	[Token(Token = "0x6002E64")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FDA4E0", Offset = "0x1FD98E0", Length = "0x33A")]
	[Token(Token = "0x6002E65")]
	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1FDAB60", Offset = "0x1FD9F60", Length = "0x77")]
	[Token(Token = "0x6002E66")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x1FDB030", Offset = "0x1FDA430", Length = "0x250")]
	[Token(Token = "0x6002E68")]
	public virtual long Seek(long offset, SeekOrigin loc) { }

	[Address(RVA = "0x1FDC600", Offset = "0x1FDBA00", Length = "0x1AF")]
	[Token(Token = "0x6002E5E")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x1FDC7B0", Offset = "0x1FDBBB0", Length = "0x110")]
	[Token(Token = "0x6002E61")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x1FDB280", Offset = "0x1FDA680", Length = "0x9B")]
	[Token(Token = "0x6002E69")]
	public override Byte[] ToArray() { }

	[Address(RVA = "0x1FDBC10", Offset = "0x1FDB010", Length = "0x303")]
	[Token(Token = "0x6002E6A")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1FDB9B0", Offset = "0x1FDADB0", Length = "0x25C")]
	[Token(Token = "0x6002E6B")]
	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	[Address(RVA = "0x1FDB320", Offset = "0x1FDA720", Length = "0x294")]
	[Token(Token = "0x6002E6D")]
	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1FDB5C0", Offset = "0x1FDA9C0", Length = "0x2C4")]
	[Token(Token = "0x6002E6C")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FDB890", Offset = "0x1FDAC90", Length = "0x114")]
	[Token(Token = "0x6002E6E")]
	public virtual void WriteByte(byte value) { }

}


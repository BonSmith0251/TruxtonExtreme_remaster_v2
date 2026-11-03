namespace System.Net.Sockets;

[Token(Token = "0x20002F4")]
public class NetworkStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CCD")]
	private readonly Socket _streamSocket; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CCE")]
	private readonly bool _ownsSocket; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000CCF")]
	private bool _readable; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4000CD0")]
	private bool _writeable; //Field offset: 0x32
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000CD1")]
	private int _closeTimeout; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000CD2")]
	private bool _cleanedUp; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000CD3")]
	private int _currentReadTimeout; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000CD4")]
	private int _currentWriteTimeout; //Field offset: 0x40

	[Token(Token = "0x17000440")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
		[Token(Token = "0x600137E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000441")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600137F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000443")]
	public virtual bool CanTimeout
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001381")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000442")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x1E075C0", Offset = "0x1E069C0", Length = "0x5")]
		[Token(Token = "0x6001380")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000448")]
	internal Socket InternalSocket
	{
		[Address(RVA = "0x25E1400", Offset = "0x25E0800", Length = "0x9C")]
		[Token(Token = "0x600139E")]
		internal get { } //Length: 156
	}

	[Token(Token = "0x17000446")]
	public virtual long Length
	{
		[Address(RVA = "0x25E14A0", Offset = "0x25E08A0", Length = "0x4E")]
		[Token(Token = "0x6001386")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000447")]
	public virtual long Position
	{
		[Address(RVA = "0x25E14F0", Offset = "0x25E08F0", Length = "0x4E")]
		[Token(Token = "0x6001387")]
		 get { } //Length: 78
		[Address(RVA = "0x25E1620", Offset = "0x25E0A20", Length = "0x4E")]
		[Token(Token = "0x6001388")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000444")]
	public virtual int ReadTimeout
	{
		[Address(RVA = "0x25E1540", Offset = "0x25E0940", Length = "0x60")]
		[Token(Token = "0x6001382")]
		 get { } //Length: 96
		[Address(RVA = "0x25E1670", Offset = "0x25E0A70", Length = "0x96")]
		[Token(Token = "0x6001383")]
		 set { } //Length: 150
	}

	[Token(Token = "0x17000445")]
	public virtual int WriteTimeout
	{
		[Address(RVA = "0x25E15B0", Offset = "0x25E09B0", Length = "0x60")]
		[Token(Token = "0x6001384")]
		 get { } //Length: 96
		[Address(RVA = "0x25E1710", Offset = "0x25E0B10", Length = "0x99")]
		[Token(Token = "0x6001385")]
		 set { } //Length: 153
	}

	[Address(RVA = "0x25E11B0", Offset = "0x25E05B0", Length = "0x20")]
	[Token(Token = "0x600137B")]
	public NetworkStream(Socket socket) { }

	[Address(RVA = "0x25E11D0", Offset = "0x25E05D0", Length = "0x21")]
	[Token(Token = "0x600137C")]
	public NetworkStream(Socket socket, bool ownsSocket) { }

	[Address(RVA = "0x25E1200", Offset = "0x25E0600", Length = "0x1F8")]
	[Token(Token = "0x600137D")]
	public NetworkStream(Socket socket, FileAccess access, bool ownsSocket) { }

	[Address(RVA = "0x25DEC40", Offset = "0x25DE040", Length = "0x2EE")]
	[Token(Token = "0x6001393")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x25DEF30", Offset = "0x25DE330", Length = "0x2EE")]
	[Token(Token = "0x6001395")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x25DF220", Offset = "0x25DE620", Length = "0x69")]
	[Token(Token = "0x6001390")]
	public void Close(int timeout) { }

	[Address(RVA = "0x25DF290", Offset = "0x25DE690", Length = "0xE4")]
	[Token(Token = "0x6001391")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x25DF380", Offset = "0x25DE780", Length = "0x185")]
	[Token(Token = "0x6001394")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x25DF510", Offset = "0x25DE910", Length = "0x189")]
	[Token(Token = "0x6001396")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1FDDD50", Offset = "0x1FDD150", Length = "0x65")]
	[Token(Token = "0x6001392")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600139B")]
	public virtual void Flush() { }

	[Address(RVA = "0x25DF6A0", Offset = "0x25DEAA0", Length = "0x8A")]
	[Token(Token = "0x600139C")]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
	[Token(Token = "0x600137E")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600137F")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6001381")]
	public virtual bool get_CanTimeout() { }

	[Address(RVA = "0x1E075C0", Offset = "0x1E069C0", Length = "0x5")]
	[Token(Token = "0x6001380")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x25E1400", Offset = "0x25E0800", Length = "0x9C")]
	[Token(Token = "0x600139E")]
	internal Socket get_InternalSocket() { }

	[Address(RVA = "0x25E14A0", Offset = "0x25E08A0", Length = "0x4E")]
	[Token(Token = "0x6001386")]
	public virtual long get_Length() { }

	[Address(RVA = "0x25E14F0", Offset = "0x25E08F0", Length = "0x4E")]
	[Token(Token = "0x6001387")]
	public virtual long get_Position() { }

	[Address(RVA = "0x25E1540", Offset = "0x25E0940", Length = "0x60")]
	[Token(Token = "0x6001382")]
	public virtual int get_ReadTimeout() { }

	[Address(RVA = "0x25E15B0", Offset = "0x25E09B0", Length = "0x60")]
	[Token(Token = "0x6001384")]
	public virtual int get_WriteTimeout() { }

	[Address(RVA = "0x25E0080", Offset = "0x25DF480", Length = "0x328")]
	[Token(Token = "0x600138A")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x25DFD50", Offset = "0x25DF150", Length = "0x328")]
	[Token(Token = "0x600138B")]
	public virtual int Read(Span<Byte> destination) { }

	[Address(RVA = "0x25DFAC0", Offset = "0x25DEEC0", Length = "0x20E")]
	[Token(Token = "0x6001398")]
	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DF730", Offset = "0x25DEB30", Length = "0x38F")]
	[Token(Token = "0x6001397")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25DFCD0", Offset = "0x25DF0D0", Length = "0x77")]
	[Token(Token = "0x600138C")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x25E03B0", Offset = "0x25DF7B0", Length = "0x4E")]
	[Token(Token = "0x6001389")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x25E1620", Offset = "0x25E0A20", Length = "0x4E")]
	[Token(Token = "0x6001388")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x25E1670", Offset = "0x25E0A70", Length = "0x96")]
	[Token(Token = "0x6001383")]
	public virtual void set_ReadTimeout(int value) { }

	[Address(RVA = "0x25E1710", Offset = "0x25E0B10", Length = "0x99")]
	[Token(Token = "0x6001385")]
	public virtual void set_WriteTimeout(int value) { }

	[Address(RVA = "0x25E0400", Offset = "0x25DF800", Length = "0x1A9")]
	[Token(Token = "0x600139D")]
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	[Address(RVA = "0x25E0BD0", Offset = "0x25DFFD0", Length = "0x2AB")]
	[Token(Token = "0x600138E")]
	public virtual void Write(ReadOnlySpan<Byte> source) { }

	[Address(RVA = "0x25E0E80", Offset = "0x25E0280", Length = "0x328")]
	[Token(Token = "0x600138D")]
	public virtual void Write(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x25E05B0", Offset = "0x25DF9B0", Length = "0x397")]
	[Token(Token = "0x6001399")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25E0950", Offset = "0x25DFD50", Length = "0x203")]
	[Token(Token = "0x600139A")]
	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x25E0B60", Offset = "0x25DFF60", Length = "0x67")]
	[Token(Token = "0x600138F")]
	public virtual void WriteByte(byte value) { }

}


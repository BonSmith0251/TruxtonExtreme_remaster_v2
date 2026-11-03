namespace System.IO.Compression;

[Token(Token = "0x2000212")]
public class DeflateStream : Stream
{
	[Token(Token = "0x2000213")]
	private sealed class ReadMethod : MulticastDelegate
	{

		[Address(RVA = "0x1FFDF50", Offset = "0x1FFD350", Length = "0xB5")]
		[Token(Token = "0x6000E01")]
		public ReadMethod(object object, IntPtr method) { }

		[Address(RVA = "0x1FFDED0", Offset = "0x1FFD2D0", Length = "0x72")]
		[Token(Token = "0x6000E03")]
		public override IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

		[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
		[Token(Token = "0x6000E04")]
		public override int EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6000E02")]
		public override int Invoke(Byte[] array, int offset, int count) { }

	}

	[Token(Token = "0x2000214")]
	private sealed class WriteMethod : MulticastDelegate
	{

		[Address(RVA = "0x2005250", Offset = "0x2004650", Length = "0xB5")]
		[Token(Token = "0x6000E05")]
		public WriteMethod(object object, IntPtr method) { }

		[Address(RVA = "0x1FFDED0", Offset = "0x1FFD2D0", Length = "0x72")]
		[Token(Token = "0x6000E07")]
		public override IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000E08")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6000E06")]
		public override void Invoke(Byte[] array, int offset, int count) { }

	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007AF")]
	private Stream base_stream; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007B0")]
	private CompressionMode mode; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40007B1")]
	private bool leaveOpen; //Field offset: 0x34
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x40007B2")]
	private bool disposed; //Field offset: 0x35
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007B3")]
	private DeflateStreamNative native; //Field offset: 0x38

	[Token(Token = "0x170002D3")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x2680FC0", Offset = "0x26803C0", Length = "0x3D")]
		[Token(Token = "0x6000DFB")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170002D4")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000DFC")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170002D5")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x2681000", Offset = "0x2680400", Length = "0x3D")]
		[Token(Token = "0x6000DFD")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170002D6")]
	public virtual long Length
	{
		[Address(RVA = "0x2681040", Offset = "0x2680440", Length = "0x3E")]
		[Token(Token = "0x6000DFE")]
		 get { } //Length: 62
	}

	[Token(Token = "0x170002D7")]
	public virtual long Position
	{
		[Address(RVA = "0x2681080", Offset = "0x2680480", Length = "0x3E")]
		[Token(Token = "0x6000DFF")]
		 get { } //Length: 62
		[Address(RVA = "0x26810C0", Offset = "0x26804C0", Length = "0x3E")]
		[Token(Token = "0x6000E00")]
		 set { } //Length: 62
	}

	[Address(RVA = "0x2680DE0", Offset = "0x26801E0", Length = "0x1F")]
	[Token(Token = "0x6000DE8")]
	public DeflateStream(Stream stream, CompressionMode mode) { }

	[Address(RVA = "0x2680FA0", Offset = "0x26803A0", Length = "0x13")]
	[Token(Token = "0x6000DE9")]
	internal DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	[Address(RVA = "0x2680E00", Offset = "0x2680200", Length = "0x19A")]
	[Token(Token = "0x6000DEA")]
	internal DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	[Address(RVA = "0x267F670", Offset = "0x267EA70", Length = "0x398")]
	[Token(Token = "0x6000DF6")]
	public virtual IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	[Address(RVA = "0x267FA10", Offset = "0x267EE10", Length = "0x398")]
	[Token(Token = "0x6000DF7")]
	public virtual IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	[Address(RVA = "0x267FDB0", Offset = "0x267F1B0", Length = "0xC2")]
	[Token(Token = "0x6000DEC")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x267FE80", Offset = "0x267F280", Length = "0x1CB")]
	[Token(Token = "0x6000DF8")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x2680050", Offset = "0x267F450", Length = "0x1AD")]
	[Token(Token = "0x6000DF9")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1FDDD50", Offset = "0x1FDD150", Length = "0x65")]
	[Token(Token = "0x6000DEB")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2680200", Offset = "0x267F600", Length = "0x13D")]
	[Token(Token = "0x6000DF5")]
	public virtual void Flush() { }

	[Address(RVA = "0x2680FC0", Offset = "0x26803C0", Length = "0x3D")]
	[Token(Token = "0x6000DFB")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000DFC")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x2681000", Offset = "0x2680400", Length = "0x3D")]
	[Token(Token = "0x6000DFD")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x2681040", Offset = "0x2680440", Length = "0x3E")]
	[Token(Token = "0x6000DFE")]
	public virtual long get_Length() { }

	[Address(RVA = "0x2681080", Offset = "0x2680480", Length = "0x3E")]
	[Token(Token = "0x6000DFF")]
	public virtual long get_Position() { }

	[Address(RVA = "0x26805B0", Offset = "0x267F9B0", Length = "0x319")]
	[Token(Token = "0x6000DF0")]
	public virtual int Read(Byte[] array, int offset, int count) { }

	[Address(RVA = "0x2680340", Offset = "0x267F740", Length = "0x39")]
	[Token(Token = "0x6000DEE")]
	internal ValueTask<Int32> ReadAsyncMemory(Memory<Byte> destination, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2680380", Offset = "0x267F780", Length = "0x114")]
	[Token(Token = "0x6000DEF")]
	internal int ReadCore(Span<Byte> destination) { }

	[Address(RVA = "0x26804A0", Offset = "0x267F8A0", Length = "0x102")]
	[Token(Token = "0x6000DED")]
	private int ReadInternal(Byte[] array, int offset, int count) { }

	[Address(RVA = "0x26808D0", Offset = "0x267FCD0", Length = "0x3E")]
	[Token(Token = "0x6000DFA")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x26810C0", Offset = "0x26804C0", Length = "0x3E")]
	[Token(Token = "0x6000E00")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x2680AD0", Offset = "0x267FED0", Length = "0x309")]
	[Token(Token = "0x6000DF4")]
	public virtual void Write(Byte[] array, int offset, int count) { }

	[Address(RVA = "0x2680910", Offset = "0x267FD10", Length = "0x39")]
	[Token(Token = "0x6000DF2")]
	internal ValueTask WriteAsyncMemory(ReadOnlyMemory<Byte> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2680950", Offset = "0x267FD50", Length = "0x78")]
	[Token(Token = "0x6000DF3")]
	internal void WriteCore(ReadOnlySpan<Byte> source) { }

	[Address(RVA = "0x26809D0", Offset = "0x267FDD0", Length = "0xF5")]
	[Token(Token = "0x6000DF1")]
	private void WriteInternal(Byte[] array, int offset, int count) { }

}


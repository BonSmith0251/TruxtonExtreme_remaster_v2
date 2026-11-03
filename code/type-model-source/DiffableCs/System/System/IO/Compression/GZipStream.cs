namespace System.IO.Compression;

[Token(Token = "0x2000211")]
public class GZipStream : Stream
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007AE")]
	private DeflateStream _deflateStream; //Field offset: 0x28

	[Token(Token = "0x170002CE")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x2682AC0", Offset = "0x2681EC0", Length = "0x20")]
		[Token(Token = "0x6000DCE")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170002D0")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x2682AE0", Offset = "0x2681EE0", Length = "0x20")]
		[Token(Token = "0x6000DD0")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170002CF")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x2682B00", Offset = "0x2681F00", Length = "0x20")]
		[Token(Token = "0x6000DCF")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170002D1")]
	public virtual long Length
	{
		[Address(RVA = "0x2682B20", Offset = "0x2681F20", Length = "0x4E")]
		[Token(Token = "0x6000DD1")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170002D2")]
	public virtual long Position
	{
		[Address(RVA = "0x2682B70", Offset = "0x2681F70", Length = "0x4E")]
		[Token(Token = "0x6000DD2")]
		 get { } //Length: 78
		[Address(RVA = "0x2682BC0", Offset = "0x2681FC0", Length = "0x4E")]
		[Token(Token = "0x6000DD3")]
		 set { } //Length: 78
	}

	[Address(RVA = "0x2682930", Offset = "0x2681D30", Length = "0xB6")]
	[Token(Token = "0x6000DCC")]
	public GZipStream(Stream stream, CompressionMode mode) { }

	[Address(RVA = "0x26829F0", Offset = "0x2681DF0", Length = "0xC7")]
	[Token(Token = "0x6000DCD")]
	public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen) { }

	[Address(RVA = "0x2681F70", Offset = "0x2681370", Length = "0xAB")]
	[Token(Token = "0x6000DD7")]
	public virtual IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	[Address(RVA = "0x2682020", Offset = "0x2681420", Length = "0xAB")]
	[Token(Token = "0x6000DDB")]
	public virtual IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	[Address(RVA = "0x26820D0", Offset = "0x26814D0", Length = "0x17")]
	[Token(Token = "0x6000DE6")]
	private void CheckDeflateStream() { }

	[Address(RVA = "0x26820F0", Offset = "0x26814F0", Length = "0x2E")]
	[Token(Token = "0x6000DDF")]
	public virtual void CopyTo(Stream destination, int bufferSize) { }

	[Address(RVA = "0x2682120", Offset = "0x2681520", Length = "0x9C")]
	[Token(Token = "0x6000DE0")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x26821C0", Offset = "0x26815C0", Length = "0x39")]
	[Token(Token = "0x6000DD8")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1E9E750", Offset = "0x1E9DB50", Length = "0xA")]
	[Token(Token = "0x6000DDC")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x2682230", Offset = "0x2681630", Length = "0x2E")]
	[Token(Token = "0x6000DD4")]
	public virtual void Flush() { }

	[Address(RVA = "0x2682200", Offset = "0x2681600", Length = "0x2E")]
	[Token(Token = "0x6000DE5")]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2682AC0", Offset = "0x2681EC0", Length = "0x20")]
	[Token(Token = "0x6000DCE")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x2682AE0", Offset = "0x2681EE0", Length = "0x20")]
	[Token(Token = "0x6000DD0")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x2682B00", Offset = "0x2681F00", Length = "0x20")]
	[Token(Token = "0x6000DCF")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x2682B20", Offset = "0x2681F20", Length = "0x4E")]
	[Token(Token = "0x6000DD1")]
	public virtual long get_Length() { }

	[Address(RVA = "0x2682B70", Offset = "0x2681F70", Length = "0x4E")]
	[Token(Token = "0x6000DD2")]
	public virtual long get_Position() { }

	[Address(RVA = "0x26823C0", Offset = "0x26817C0", Length = "0x33")]
	[Token(Token = "0x6000DD9")]
	public virtual int Read(Byte[] array, int offset, int count) { }

	[Address(RVA = "0x2682400", Offset = "0x2681800", Length = "0x1DB")]
	[Token(Token = "0x6000DDA")]
	public virtual int Read(Span<Byte> buffer) { }

	[Address(RVA = "0x2682260", Offset = "0x2681660", Length = "0x33")]
	[Token(Token = "0x6000DE1")]
	public virtual Task<Int32> ReadAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x26822A0", Offset = "0x26816A0", Length = "0xE6")]
	[Token(Token = "0x6000DE2")]
	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2682390", Offset = "0x2681790", Length = "0x2E")]
	[Token(Token = "0x6000DD6")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x26825E0", Offset = "0x26819E0", Length = "0x4E")]
	[Token(Token = "0x6000DD5")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x2682BC0", Offset = "0x2681FC0", Length = "0x4E")]
	[Token(Token = "0x6000DD3")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x2682630", Offset = "0x2681A30", Length = "0x50")]
	[Token(Token = "0x6000DE7")]
	private static void ThrowStreamClosedException() { }

	[Address(RVA = "0x26827C0", Offset = "0x2681BC0", Length = "0x33")]
	[Token(Token = "0x6000DDD")]
	public virtual void Write(Byte[] array, int offset, int count) { }

	[Address(RVA = "0x2682800", Offset = "0x2681C00", Length = "0x127")]
	[Token(Token = "0x6000DDE")]
	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	[Address(RVA = "0x2682690", Offset = "0x2681A90", Length = "0x33")]
	[Token(Token = "0x6000DE3")]
	public virtual Task WriteAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x26826D0", Offset = "0x2681AD0", Length = "0xE6")]
	[Token(Token = "0x6000DE4")]
	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

}


namespace System.IO;

[ComVisible(True)]
[Token(Token = "0x2000677")]
public class FileStream : Stream
{
	[Token(Token = "0x2000678")]
	private sealed class ReadDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1FFDF50", Offset = "0x1FFD350", Length = "0xB5")]
		[Token(Token = "0x60030A4")]
		public ReadDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x1FFDED0", Offset = "0x1FFD2D0", Length = "0x72")]
		[Token(Token = "0x60030A6")]
		public override IAsyncResult BeginInvoke(Byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

		[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
		[Token(Token = "0x60030A7")]
		public override int EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x60030A5")]
		public override int Invoke(Byte[] buffer, int offset, int count) { }

	}

	[Token(Token = "0x2000679")]
	private sealed class WriteDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2005250", Offset = "0x2004650", Length = "0xB5")]
		[Token(Token = "0x60030A8")]
		public WriteDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x1FFDED0", Offset = "0x1FFD2D0", Length = "0x72")]
		[Token(Token = "0x60030AA")]
		public override IAsyncResult BeginInvoke(Byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x60030AB")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x60030A9")]
		public override void Invoke(Byte[] buffer, int offset, int count) { }

	}

	[Token(Token = "0x4001A04")]
	private static Byte[] buf_recycle; //Field offset: 0x0
	[Token(Token = "0x4001A05")]
	private static readonly object buf_recycle_lock; //Field offset: 0x8
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A06")]
	private Byte[] buf; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A07")]
	private string name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A08")]
	private SafeFileHandle safeHandle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A09")]
	private bool isExposed; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A0A")]
	private long append_startpos; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A0B")]
	private FileAccess access; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001A0C")]
	private bool owner; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x4001A0D")]
	private bool async; //Field offset: 0x55
	[FieldOffset(Offset = "0x56")]
	[Token(Token = "0x4001A0E")]
	private bool canseek; //Field offset: 0x56
	[FieldOffset(Offset = "0x57")]
	[Token(Token = "0x4001A0F")]
	private bool anonymous; //Field offset: 0x57
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A10")]
	private bool buf_dirty; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001A11")]
	private int buf_size; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A12")]
	private int buf_length; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4001A13")]
	private int buf_offset; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A14")]
	private long buf_start; //Field offset: 0x68

	[Token(Token = "0x17000793")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x1FF51D0", Offset = "0x1FF45D0", Length = "0x11")]
		[Token(Token = "0x6003080")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000795")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x1CF2AD0", Offset = "0x1CF1ED0", Length = "0x5")]
		[Token(Token = "0x6003082")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000794")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x1FF51F0", Offset = "0x1FF45F0", Length = "0x11")]
		[Token(Token = "0x6003081")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000797")]
	public virtual long Length
	{
		[Address(RVA = "0x1FF5210", Offset = "0x1FF4610", Length = "0x1A0")]
		[Token(Token = "0x6003084")]
		 get { } //Length: 416
	}

	[Token(Token = "0x17000796")]
	public override string Name
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6003083")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000798")]
	public virtual long Position
	{
		[Address(RVA = "0x1FF53C0", Offset = "0x1FF47C0", Length = "0x1B4")]
		[Token(Token = "0x6003085")]
		 get { } //Length: 436
		[Address(RVA = "0x1FF55C0", Offset = "0x1FF49C0", Length = "0x9C")]
		[Token(Token = "0x6003086")]
		 set { } //Length: 156
	}

	[Token(Token = "0x17000799")]
	public override SafeFileHandle SafeFileHandle
	{
		[Address(RVA = "0x1FF5580", Offset = "0x1FF4980", Length = "0x3E")]
		[Token(Token = "0x6003087")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x1FF4560", Offset = "0x1FF3960", Length = "0x78")]
	[Token(Token = "0x60030A3")]
	private static FileStream() { }

	[Address(RVA = "0x1FF47D0", Offset = "0x1FF3BD0", Length = "0x939")]
	[Token(Token = "0x600307E")]
	internal FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	[Address(RVA = "0x1FF5190", Offset = "0x1FF4590", Length = "0x3D")]
	[Token(Token = "0x600307D")]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	[Address(RVA = "0x1FF4620", Offset = "0x1FF3A20", Length = "0x1A0")]
	[Token(Token = "0x6003079")]
	internal FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	[Address(RVA = "0x1FF45E0", Offset = "0x1FF39E0", Length = "0x33")]
	[Token(Token = "0x600307B")]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	[Address(RVA = "0x1FF5110", Offset = "0x1FF4510", Length = "0x30")]
	[Token(Token = "0x600307A")]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share) { }

	[Address(RVA = "0x1FF5140", Offset = "0x1FF4540", Length = "0x41")]
	[Token(Token = "0x600307C")]
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	[Address(RVA = "0x1FF14B0", Offset = "0x1FF08B0", Length = "0x3F7")]
	[Token(Token = "0x600308D")]
	public virtual IAsyncResult BeginRead(Byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	[Address(RVA = "0x1FF18B0", Offset = "0x1FF0CB0", Length = "0x4FF")]
	[Token(Token = "0x6003091")]
	public virtual IAsyncResult BeginWrite(Byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	[Address(RVA = "0x1FF1DB0", Offset = "0x1FF11B0", Length = "0x31D")]
	[Token(Token = "0x6003096")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1FF20D0", Offset = "0x1FF14D0", Length = "0x1F3")]
	[Token(Token = "0x600308E")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1FF22D0", Offset = "0x1FF16D0", Length = "0x1D5")]
	[Token(Token = "0x6003092")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1FF24B0", Offset = "0x1FF18B0", Length = "0x29")]
	[Token(Token = "0x6003088")]
	private void ExposeHandle() { }

	[Address(RVA = "0x1FDDD50", Offset = "0x1FDD150", Length = "0x65")]
	[Token(Token = "0x6003095")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1FF2950", Offset = "0x1FF1D50", Length = "0x7A")]
	[Token(Token = "0x6003094")]
	public virtual void Flush() { }

	[Address(RVA = "0x1FF24E0", Offset = "0x1FF18E0", Length = "0x265")]
	[Token(Token = "0x6003097")]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FF2760", Offset = "0x1FF1B60", Length = "0x1E4")]
	[Token(Token = "0x600309C")]
	private void FlushBuffer() { }

	[Address(RVA = "0x1FF2750", Offset = "0x1FF1B50", Length = "0xE")]
	[Token(Token = "0x600309D")]
	private void FlushBufferIfDirty() { }

	[Address(RVA = "0x1FF51D0", Offset = "0x1FF45D0", Length = "0x11")]
	[Token(Token = "0x6003080")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x1CF2AD0", Offset = "0x1CF1ED0", Length = "0x5")]
	[Token(Token = "0x6003082")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x1FF51F0", Offset = "0x1FF45F0", Length = "0x11")]
	[Token(Token = "0x6003081")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x1FF5210", Offset = "0x1FF4610", Length = "0x1A0")]
	[Token(Token = "0x6003084")]
	public virtual long get_Length() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6003083")]
	public override string get_Name() { }

	[Address(RVA = "0x1FF53C0", Offset = "0x1FF47C0", Length = "0x1B4")]
	[Token(Token = "0x6003085")]
	public virtual long get_Position() { }

	[Address(RVA = "0x1FF5580", Offset = "0x1FF4980", Length = "0x3E")]
	[Token(Token = "0x6003087")]
	public override SafeFileHandle get_SafeFileHandle() { }

	[Address(RVA = "0x1FF29D0", Offset = "0x1FF1DD0", Length = "0xDB")]
	[Token(Token = "0x60030A2")]
	private string GetSecureFileName(string filename, bool full) { }

	[Address(RVA = "0x1FF2AB0", Offset = "0x1FF1EB0", Length = "0xBC")]
	[Token(Token = "0x60030A1")]
	private string GetSecureFileName(string filename) { }

	[Address(RVA = "0x1FF2E20", Offset = "0x1FF2220", Length = "0x36A")]
	[Token(Token = "0x600307F")]
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	[Address(RVA = "0x1FF2B70", Offset = "0x1FF1F70", Length = "0x2A5")]
	[Token(Token = "0x60030A0")]
	private void InitBuffer(int size, bool isZeroSize) { }

	[Address(RVA = "0x1FF36A0", Offset = "0x1FF2AA0", Length = "0x3AC")]
	[Token(Token = "0x600308B")]
	public virtual int Read(out Byte[] array, int offset, int count) { }

	[Address(RVA = "0x1FF3190", Offset = "0x1FF2590", Length = "0xDD")]
	[Token(Token = "0x6003098")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FF3270", Offset = "0x1FF2670", Length = "0x16D")]
	[Token(Token = "0x6003089")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x1FF33E0", Offset = "0x1FF27E0", Length = "0x134")]
	[Token(Token = "0x600309F")]
	private int ReadData(SafeHandle safeHandle, Byte[] buf, int offset, int count) { }

	[Address(RVA = "0x1FF3520", Offset = "0x1FF2920", Length = "0xD0")]
	[Token(Token = "0x600308C")]
	private int ReadInternal(Byte[] dest, int offset, int count) { }

	[Address(RVA = "0x1FF35F0", Offset = "0x1FF29F0", Length = "0xAD")]
	[Token(Token = "0x600309A")]
	private int ReadSegment(Byte[] dest, int dest_offset, int count) { }

	[Address(RVA = "0x1FF3A50", Offset = "0x1FF2E50", Length = "0x3C")]
	[Token(Token = "0x600309E")]
	private void RefillBuffer() { }

	[Address(RVA = "0x1FF3A90", Offset = "0x1FF2E90", Length = "0x306")]
	[Token(Token = "0x6003093")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x1FF55C0", Offset = "0x1FF49C0", Length = "0x9C")]
	[Token(Token = "0x6003086")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x1FF4290", Offset = "0x1FF3690", Length = "0x2CF")]
	[Token(Token = "0x600308F")]
	public virtual void Write(Byte[] array, int offset, int count) { }

	[Address(RVA = "0x1FF3DA0", Offset = "0x1FF31A0", Length = "0xCC")]
	[Token(Token = "0x6003099")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FF3E70", Offset = "0x1FF3270", Length = "0x167")]
	[Token(Token = "0x600308A")]
	public virtual void WriteByte(byte value) { }

	[Address(RVA = "0x1FF3FE0", Offset = "0x1FF33E0", Length = "0x238")]
	[Token(Token = "0x6003090")]
	private void WriteInternal(Byte[] src, int offset, int count) { }

	[Address(RVA = "0x1FF4220", Offset = "0x1FF3620", Length = "0x6C")]
	[Token(Token = "0x600309B")]
	private int WriteSegment(Byte[] src, int src_offset, int count) { }

}


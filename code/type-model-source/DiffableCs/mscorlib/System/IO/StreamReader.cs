namespace System.IO;

[Token(Token = "0x2000647")]
public class StreamReader : TextReader
{
	[CompilerGenerated]
	[Token(Token = "0x2000649")]
	private struct <ReadAsyncInternal>d__66 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400190B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400190C")]
		public AsyncValueTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400190D")]
		public StreamReader <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400190E")]
		public Memory<Char> buffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400190F")]
		public CancellationToken cancellationToken; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4001910")]
		private int <charsRead>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4001911")]
		private bool <readToUserBuffer>5__3; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001912")]
		private Byte[] <tmpByteBuffer>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4001913")]
		private Stream <tmpStream>5__5; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4001914")]
		private int <count>5__6; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4001915")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4001916")]
		private int <n>5__7; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4001917")]
		private ConfiguredValueTaskAwaiter<Int32> <>u__2; //Field offset: 0x80

		[Address(RVA = "0x1FE7060", Offset = "0x1FE6460", Length = "0x121D")]
		[Token(Token = "0x6002EB5")]
		private override void MoveNext() { }

		[Address(RVA = "0x1FE8280", Offset = "0x1FE7680", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6002EB6")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200064A")]
	private struct <ReadBufferAsync>d__69 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001918")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001919")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400191A")]
		public StreamReader <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400191B")]
		private Byte[] <tmpByteBuffer>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400191C")]
		private Stream <tmpStream>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400191D")]
		private ConfiguredValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x38

		[Address(RVA = "0x1FE82D0", Offset = "0x1FE76D0", Length = "0xD64")]
		[Token(Token = "0x6002EB7")]
		private override void MoveNext() { }

		[Address(RVA = "0x1FE9040", Offset = "0x1FE8440", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6002EB8")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000648")]
	private class NullStreamReader : StreamReader
	{

		[Token(Token = "0x17000754")]
		public virtual Stream BaseStream
		{
			[Address(RVA = "0x1FDCA10", Offset = "0x1FDBE10", Length = "0x4E")]
			[Token(Token = "0x6002EAC")]
			 get { } //Length: 78
		}

		[Token(Token = "0x17000755")]
		public virtual Encoding CurrentEncoding
		{
			[Address(RVA = "0x1FDCA60", Offset = "0x1FDBE60", Length = "0x7")]
			[Token(Token = "0x6002EAD")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x1FDC8D0", Offset = "0x1FDBCD0", Length = "0x132")]
		[Token(Token = "0x6002EAB")]
		internal NullStreamReader() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002EAE")]
		protected virtual void Dispose(bool disposing) { }

		[Address(RVA = "0x1FDCA10", Offset = "0x1FDBE10", Length = "0x4E")]
		[Token(Token = "0x6002EAC")]
		public virtual Stream get_BaseStream() { }

		[Address(RVA = "0x1FDCA60", Offset = "0x1FDBE60", Length = "0x7")]
		[Token(Token = "0x6002EAD")]
		public virtual Encoding get_CurrentEncoding() { }

		[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
		[Token(Token = "0x6002EAF")]
		public virtual int Peek() { }

		[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
		[Token(Token = "0x6002EB0")]
		public virtual int Read() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002EB1")]
		public virtual int Read(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002EB4")]
		internal virtual int ReadBuffer() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002EB2")]
		public virtual string ReadLine() { }

		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x6002EB3")]
		public virtual string ReadToEnd() { }

	}

	[Token(Token = "0x40018FB")]
	public static readonly StreamReader Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40018FC")]
	private Stream _stream; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40018FD")]
	private Encoding _encoding; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40018FE")]
	private Decoder _decoder; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40018FF")]
	private Byte[] _byteBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001900")]
	private Char[] _charBuffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001901")]
	private int _charPos; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001902")]
	private int _charLen; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001903")]
	private int _byteLen; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001904")]
	private int _bytePos; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001905")]
	private int _maxCharsPerBuffer; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001906")]
	private bool _detectEncoding; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x4001907")]
	private bool _checkPreamble; //Field offset: 0x55
	[FieldOffset(Offset = "0x56")]
	[Token(Token = "0x4001908")]
	private bool _isBlocked; //Field offset: 0x56
	[FieldOffset(Offset = "0x57")]
	[Token(Token = "0x4001909")]
	private bool _closable; //Field offset: 0x57
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400190A")]
	private Task _asyncReadTask; //Field offset: 0x58

	[Token(Token = "0x17000752")]
	public override Stream BaseStream
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6002E98")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000751")]
	public override Encoding CurrentEncoding
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6002E97")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000753")]
	internal bool LeaveOpen
	{
		[Address(RVA = "0x1FE0E30", Offset = "0x1FE0230", Length = "0x8")]
		[Token(Token = "0x6002E99")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x1FE05D0", Offset = "0x1FDF9D0", Length = "0x18C")]
	[Token(Token = "0x6002EAA")]
	private static StreamReader() { }

	[Address(RVA = "0x1FE0B40", Offset = "0x1FDFF40", Length = "0x2C1")]
	[Token(Token = "0x6002E92")]
	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	[Address(RVA = "0x1FE0840", Offset = "0x1FDFC40", Length = "0xBA")]
	[Token(Token = "0x6002E8C")]
	internal StreamReader() { }

	[Address(RVA = "0x1FE0810", Offset = "0x1FDFC10", Length = "0x27")]
	[Token(Token = "0x6002E8D")]
	public StreamReader(Stream stream, Encoding encoding) { }

	[Address(RVA = "0x1FE0900", Offset = "0x1FDFD00", Length = "0x239")]
	[Token(Token = "0x6002E8E")]
	public StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	[Address(RVA = "0x1FE0760", Offset = "0x1FDFB60", Length = "0x44")]
	[Token(Token = "0x6002E8F")]
	public StreamReader(string path) { }

	[Address(RVA = "0x1FE07B0", Offset = "0x1FDFBB0", Length = "0x53")]
	[Token(Token = "0x6002E90")]
	public StreamReader(string path, bool detectEncodingFromByteOrderMarks) { }

	[Address(RVA = "0x1FE0E10", Offset = "0x1FE0210", Length = "0x1F")]
	[Token(Token = "0x6002E91")]
	public StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	[Address(RVA = "0x1FDE1E0", Offset = "0x1FDD5E0", Length = "0x58")]
	[Token(Token = "0x6002E8A")]
	private void CheckAsyncTaskInProgress() { }

	[Address(RVA = "0x1EF4750", Offset = "0x1EF3B50", Length = "0x16")]
	[Token(Token = "0x6002E95")]
	public virtual void Close() { }

	[Address(RVA = "0x1FDE240", Offset = "0x1FDD640", Length = "0x3E")]
	[Token(Token = "0x6002EA0")]
	private void CompressBuffer(int n) { }

	[Address(RVA = "0x1FDE280", Offset = "0x1FDD680", Length = "0xA")]
	[Token(Token = "0x6002EA9")]
	internal bool DataAvailable() { }

	[Address(RVA = "0x1FDE290", Offset = "0x1FDD690", Length = "0x2EC")]
	[Token(Token = "0x6002EA1")]
	private void DetectEncoding() { }

	[Address(RVA = "0x1FDE580", Offset = "0x1FDD980", Length = "0x7E")]
	[Token(Token = "0x6002E96")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6002E98")]
	public override Stream get_BaseStream() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6002E97")]
	public override Encoding get_CurrentEncoding() { }

	[Address(RVA = "0x1FE0E30", Offset = "0x1FE0230", Length = "0x8")]
	[Token(Token = "0x6002E99")]
	internal bool get_LeaveOpen() { }

	[Address(RVA = "0x1FDE620", Offset = "0x1FDDA20", Length = "0x162")]
	[Token(Token = "0x6002E93")]
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	[Address(RVA = "0x1FDE600", Offset = "0x1FDDA00", Length = "0x20")]
	[Token(Token = "0x6002E94")]
	internal void Init(Stream stream) { }

	[Address(RVA = "0x1FDE790", Offset = "0x1FDDB90", Length = "0x122")]
	[Token(Token = "0x6002EA2")]
	private bool IsPreamble() { }

	[Address(RVA = "0x1FDE8C0", Offset = "0x1FDDCC0", Length = "0x106")]
	[Token(Token = "0x6002E9A")]
	public virtual int Peek() { }

	[Address(RVA = "0x1FE01F0", Offset = "0x1FDF5F0", Length = "0xAF")]
	[Token(Token = "0x6002E9D")]
	public virtual int Read(Span<Char> buffer) { }

	[Address(RVA = "0x1FE03B0", Offset = "0x1FDF7B0", Length = "0x1C7")]
	[Token(Token = "0x6002E9C")]
	public virtual int Read(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1FE02A0", Offset = "0x1FDF6A0", Length = "0x103")]
	[Token(Token = "0x6002E9B")]
	public virtual int Read() { }

	[Address(RVA = "0x1FDEB70", Offset = "0x1FDDF70", Length = "0x316")]
	[Token(Token = "0x6002EA6")]
	public virtual Task<Int32> ReadAsync(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1FDE9D0", Offset = "0x1FDDDD0", Length = "0x194")]
	[AsyncStateMachine(typeof(<ReadAsyncInternal>d__66))]
	[Token(Token = "0x6002EA7")]
	internal virtual ValueTask<Int32> ReadAsyncInternal(Memory<Char> buffer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FDEFA0", Offset = "0x1FDE3A0", Length = "0x4BB")]
	[Token(Token = "0x6002EA3")]
	internal override int ReadBuffer() { }

	[Address(RVA = "0x1FDF460", Offset = "0x1FDE860", Length = "0x6D8")]
	[Token(Token = "0x6002EA4")]
	private int ReadBuffer(Span<Char> userBuffer, out bool readToUserBuffer) { }

	[Address(RVA = "0x1FDEE90", Offset = "0x1FDE290", Length = "0x109")]
	[AsyncStateMachine(typeof(<ReadBufferAsync>d__69))]
	[Token(Token = "0x6002EA8")]
	private Task<Int32> ReadBufferAsync() { }

	[Address(RVA = "0x1FDFB40", Offset = "0x1FDEF40", Length = "0x297")]
	[Token(Token = "0x6002EA5")]
	public virtual string ReadLine() { }

	[Address(RVA = "0x1FDFDE0", Offset = "0x1FDF1E0", Length = "0x289")]
	[Token(Token = "0x6002E9E")]
	private int ReadSpan(Span<Char> buffer) { }

	[Address(RVA = "0x1FE0070", Offset = "0x1FDF470", Length = "0x173")]
	[Token(Token = "0x6002E9F")]
	public virtual string ReadToEnd() { }

	[Address(RVA = "0x1FE0580", Offset = "0x1FDF980", Length = "0x4E")]
	[Token(Token = "0x6002E8B")]
	private static void ThrowAsyncIOInProgress() { }

}


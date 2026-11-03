namespace System.IO;

[Token(Token = "0x200064B")]
public class StreamWriter : TextWriter
{
	[CompilerGenerated]
	[Token(Token = "0x200064F")]
	private struct <FlushAsyncInternal>d__74 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001952")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001953")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001954")]
		public bool haveWrittenPreamble; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001955")]
		public StreamWriter _this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001956")]
		public Encoding encoding; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001957")]
		public Stream stream; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001958")]
		public CancellationToken cancellationToken; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4001959")]
		public Encoder encoder; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400195A")]
		public Char[] charBuffer; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400195B")]
		public int charPos; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400195C")]
		public Byte[] byteBuffer; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400195D")]
		public bool flushEncoder; //Field offset: 0x68
		[FieldOffset(Offset = "0x69")]
		[Token(Token = "0x400195E")]
		public bool flushStream; //Field offset: 0x69
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400195F")]
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x70
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4001960")]
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x80

		[Address(RVA = "0x1FE62E0", Offset = "0x1FE56E0", Length = "0x61D")]
		[Token(Token = "0x6002EE4")]
		private override void MoveNext() { }

		[Address(RVA = "0x1FE6900", Offset = "0x1FE5D00", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6002EE5")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200064C")]
	private struct <WriteAsyncInternal>d__57 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400192A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400192B")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400192C")]
		public int charPos; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400192D")]
		public int charLen; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400192E")]
		public StreamWriter _this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400192F")]
		public Char[] charBuffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001930")]
		public char value; //Field offset: 0x38
		[FieldOffset(Offset = "0x3A")]
		[Token(Token = "0x4001931")]
		public bool appendNewLine; //Field offset: 0x3A
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001932")]
		public Char[] coreNewLine; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4001933")]
		public bool autoFlush; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001934")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4001935")]
		private int <i>5__2; //Field offset: 0x60

		[Address(RVA = "0x1FE9530", Offset = "0x1FE8930", Length = "0x491")]
		[Token(Token = "0x6002EDE")]
		private override void MoveNext() { }

		[Address(RVA = "0x1FE99D0", Offset = "0x1FE8DD0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6002EDF")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200064D")]
	private struct <WriteAsyncInternal>d__59 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001936")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001937")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001938")]
		public string value; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001939")]
		public int charPos; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400193A")]
		public int charLen; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400193B")]
		public StreamWriter _this; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400193C")]
		public Char[] charBuffer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400193D")]
		public bool appendNewLine; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400193E")]
		public Char[] coreNewLine; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400193F")]
		public bool autoFlush; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4001940")]
		private int <count>5__2; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4001941")]
		private int <index>5__3; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4001942")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4001943")]
		private int <i>5__4; //Field offset: 0x70

		[Address(RVA = "0x1FE9A30", Offset = "0x1FE8E30", Length = "0x4BA")]
		[Token(Token = "0x6002EE0")]
		private override void MoveNext() { }

		[Address(RVA = "0x1FE9EF0", Offset = "0x1FE92F0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6002EE1")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200064E")]
	private struct <WriteAsyncInternal>d__62 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001944")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001945")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001946")]
		public int charPos; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4001947")]
		public int charLen; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001948")]
		public StreamWriter _this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001949")]
		public Char[] charBuffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400194A")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400194B")]
		public ReadOnlyMemory<Char> source; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400194C")]
		public bool appendNewLine; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400194D")]
		public Char[] coreNewLine; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400194E")]
		public bool autoFlush; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400194F")]
		private int <copied>5__2; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4001950")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x68
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4001951")]
		private int <i>5__3; //Field offset: 0x78

		[Address(RVA = "0x1FE9F50", Offset = "0x1FE9350", Length = "0x649")]
		[Token(Token = "0x6002EE2")]
		private override void MoveNext() { }

		[Address(RVA = "0x1FEA5A0", Offset = "0x1FE99A0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6002EE3")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x400191E")]
	public static readonly StreamWriter Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400191F")]
	private Stream _stream; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001920")]
	private Encoding _encoding; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001921")]
	private Encoder _encoder; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001922")]
	private Byte[] _byteBuffer; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001923")]
	private Char[] _charBuffer; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001924")]
	private int _charPos; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001925")]
	private int _charLen; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001926")]
	private bool _autoFlush; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4001927")]
	private bool _haveWrittenPreamble; //Field offset: 0x61
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x4001928")]
	private bool _closable; //Field offset: 0x62
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001929")]
	private Task _asyncWriteTask; //Field offset: 0x68

	[Token(Token = "0x17000757")]
	public override bool AutoFlush
	{
		[Address(RVA = "0x1FE39A0", Offset = "0x1FE2DA0", Length = "0x7D")]
		[Token(Token = "0x6002EC8")]
		 set { } //Length: 125
	}

	[Token(Token = "0x17000758")]
	public override Stream BaseStream
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6002EC9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700075B")]
	private int CharPos_Prop
	{
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[Token(Token = "0x6002ED9")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700075A")]
	public virtual Encoding Encoding
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6002ECB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700075C")]
	private bool HaveWrittenPreamble_Prop
	{
		[Address(RVA = "0x1FE3A30", Offset = "0x1FE2E30", Length = "0x4")]
		[Token(Token = "0x6002EDA")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000759")]
	internal bool LeaveOpen
	{
		[Address(RVA = "0x1FE3950", Offset = "0x1FE2D50", Length = "0x8")]
		[Token(Token = "0x6002ECA")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000756")]
	private static Encoding UTF8NoBOM
	{
		[Address(RVA = "0x1FE3960", Offset = "0x1FE2D60", Length = "0x40")]
		[Token(Token = "0x6002EBB")]
		private get { } //Length: 64
	}

	[Address(RVA = "0x1FE2FB0", Offset = "0x1FE23B0", Length = "0x102")]
	[Token(Token = "0x6002EDD")]
	private static StreamWriter() { }

	[Address(RVA = "0x1FE3330", Offset = "0x1FE2730", Length = "0x339")]
	[Token(Token = "0x6002EC2")]
	public StreamWriter(string path, bool append, Encoding encoding, int bufferSize) { }

	[Address(RVA = "0x1FE3720", Offset = "0x1FE2B20", Length = "0xB5")]
	[Token(Token = "0x6002EC1")]
	public StreamWriter(string path, bool append) { }

	[Address(RVA = "0x1FE3890", Offset = "0x1FE2C90", Length = "0xBD")]
	[Token(Token = "0x6002EBC")]
	internal StreamWriter() { }

	[Address(RVA = "0x1FE3670", Offset = "0x1FE2A70", Length = "0xA6")]
	[Token(Token = "0x6002EBD")]
	public StreamWriter(Stream stream) { }

	[Address(RVA = "0x1FE3300", Offset = "0x1FE2700", Length = "0x22")]
	[Token(Token = "0x6002EBE")]
	public StreamWriter(Stream stream, Encoding encoding) { }

	[Address(RVA = "0x1FE30C0", Offset = "0x1FE24C0", Length = "0x233")]
	[Token(Token = "0x6002EBF")]
	public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	[Address(RVA = "0x1FE37E0", Offset = "0x1FE2BE0", Length = "0xA6")]
	[Token(Token = "0x6002EC0")]
	public StreamWriter(string path) { }

	[Address(RVA = "0x1FE0E40", Offset = "0x1FE0240", Length = "0x58")]
	[Token(Token = "0x6002EB9")]
	private void CheckAsyncTaskInProgress() { }

	[Address(RVA = "0x1FE0EA0", Offset = "0x1FE02A0", Length = "0x61")]
	[Token(Token = "0x6002EC4")]
	public virtual void Close() { }

	[Address(RVA = "0x1FE0F10", Offset = "0x1FE0310", Length = "0xC3")]
	[Token(Token = "0x6002EC5")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1FE15B0", Offset = "0x1FE09B0", Length = "0x69")]
	[Token(Token = "0x6002EC6")]
	public virtual void Flush() { }

	[Address(RVA = "0x1FE1620", Offset = "0x1FE0A20", Length = "0x1B5")]
	[Token(Token = "0x6002EC7")]
	private void Flush(bool flushStream, bool flushEncoder) { }

	[Address(RVA = "0x1FE1430", Offset = "0x1FE0830", Length = "0x17E")]
	[Token(Token = "0x6002ED8")]
	public virtual Task FlushAsync() { }

	[Address(RVA = "0x1FE0FE0", Offset = "0x1FE03E0", Length = "0x192")]
	[AsyncStateMachine(typeof(<FlushAsyncInternal>d__74))]
	[Token(Token = "0x6002EDC")]
	private static Task FlushAsyncInternal(StreamWriter _this, bool flushStream, bool flushEncoder, Char[] charBuffer, int charPos, bool haveWrittenPreamble, Encoding encoding, Encoder encoder, Byte[] byteBuffer, Stream stream, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FE1180", Offset = "0x1FE0580", Length = "0x2B0")]
	[Token(Token = "0x6002EDB")]
	private Task FlushAsyncInternal(bool flushStream, bool flushEncoder, Char[] sCharBuffer, int sCharPos, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6002EC9")]
	public override Stream get_BaseStream() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6002ECB")]
	public virtual Encoding get_Encoding() { }

	[Address(RVA = "0x1FE3950", Offset = "0x1FE2D50", Length = "0x8")]
	[Token(Token = "0x6002ECA")]
	internal bool get_LeaveOpen() { }

	[Address(RVA = "0x1FE3960", Offset = "0x1FE2D60", Length = "0x40")]
	[Token(Token = "0x6002EBB")]
	private static Encoding get_UTF8NoBOM() { }

	[Address(RVA = "0x1FE17E0", Offset = "0x1FE0BE0", Length = "0x16C")]
	[Token(Token = "0x6002EC3")]
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	[Address(RVA = "0x1FE39A0", Offset = "0x1FE2DA0", Length = "0x7D")]
	[Token(Token = "0x6002EC8")]
	public override void set_AutoFlush(bool value) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x6002ED9")]
	private void set_CharPos_Prop(int value) { }

	[Address(RVA = "0x1FE3A30", Offset = "0x1FE2E30", Length = "0x4")]
	[Token(Token = "0x6002EDA")]
	private void set_HaveWrittenPreamble_Prop(bool value) { }

	[Address(RVA = "0x1FE1950", Offset = "0x1FE0D50", Length = "0x4E")]
	[Token(Token = "0x6002EBA")]
	private static void ThrowAsyncIOInProgress() { }

	[Address(RVA = "0x1FE2BA0", Offset = "0x1FE1FA0", Length = "0x7D")]
	[Token(Token = "0x6002ED0")]
	public virtual void Write(string value) { }

	[Address(RVA = "0x1FE2D50", Offset = "0x1FE2150", Length = "0x25C")]
	[Token(Token = "0x6002ECE")]
	public virtual void Write(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1FE2CE0", Offset = "0x1FE20E0", Length = "0x69")]
	[Token(Token = "0x6002ECD")]
	public virtual void Write(Char[] buffer) { }

	[Address(RVA = "0x1FE2C20", Offset = "0x1FE2020", Length = "0xB2")]
	[Token(Token = "0x6002ECC")]
	public virtual void Write(char value) { }

	[Address(RVA = "0x1FE1DC0", Offset = "0x1FE11C0", Length = "0x2B1")]
	[Token(Token = "0x6002ED2")]
	public virtual Task WriteAsync(char value) { }

	[Address(RVA = "0x1FE2080", Offset = "0x1FE1480", Length = "0x2F7")]
	[Token(Token = "0x6002ED4")]
	public virtual Task WriteAsync(string value) { }

	[Address(RVA = "0x1FE2380", Offset = "0x1FE1780", Length = "0x47A")]
	[Token(Token = "0x6002ED6")]
	public virtual Task WriteAsync(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1FE1C70", Offset = "0x1FE1070", Length = "0x143")]
	[AsyncStateMachine(typeof(<WriteAsyncInternal>d__57))]
	[Token(Token = "0x6002ED3")]
	private static Task WriteAsyncInternal(StreamWriter _this, char value, Char[] charBuffer, int charPos, int charLen, Char[] coreNewLine, bool autoFlush, bool appendNewLine) { }

	[Address(RVA = "0x1FE19A0", Offset = "0x1FE0DA0", Length = "0x152")]
	[AsyncStateMachine(typeof(<WriteAsyncInternal>d__59))]
	[Token(Token = "0x6002ED5")]
	private static Task WriteAsyncInternal(StreamWriter _this, string value, Char[] charBuffer, int charPos, int charLen, Char[] coreNewLine, bool autoFlush, bool appendNewLine) { }

	[Address(RVA = "0x1FE1B00", Offset = "0x1FE0F00", Length = "0x165")]
	[AsyncStateMachine(typeof(<WriteAsyncInternal>d__62))]
	[Token(Token = "0x6002ED7")]
	private static Task WriteAsyncInternal(StreamWriter _this, ReadOnlyMemory<Char> source, Char[] charBuffer, int charPos, int charLen, Char[] coreNewLine, bool autoFlush, bool appendNewLine, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1FE2800", Offset = "0x1FE1C00", Length = "0xC6")]
	[Token(Token = "0x6002ED1")]
	public virtual void WriteLine(string value) { }

	[Address(RVA = "0x1FE28D0", Offset = "0x1FE1CD0", Length = "0x2CC")]
	[Token(Token = "0x6002ECF")]
	private void WriteSpan(ReadOnlySpan<Char> buffer, bool appendNewLine) { }

}


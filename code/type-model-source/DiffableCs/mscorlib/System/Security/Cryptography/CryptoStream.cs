namespace System.Security.Cryptography;

[Token(Token = "0x20002E3")]
public class CryptoStream : Stream, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20002E8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000CA8")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000CA9")]
		public static Func<SemaphoreSlim> <>9__54_0; //Field offset: 0x8

		[Address(RVA = "0x1EC44E0", Offset = "0x1EC38E0", Length = "0x67")]
		[Token(Token = "0x6001829")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600182A")]
		public <>c() { }

		[Address(RVA = "0x1EC4490", Offset = "0x1EC3890", Length = "0x4D")]
		[Token(Token = "0x600182B")]
		internal SemaphoreSlim <get_AsyncActiveSemaphore>b__54_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002E5")]
	private struct <ReadAsyncCore>d__42 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C82")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C83")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C84")]
		public int count; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000C85")]
		public int offset; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C86")]
		public CryptoStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C87")]
		public Byte[] buffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C88")]
		public bool useAsync; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C89")]
		public CancellationToken cancellationToken; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C8A")]
		private int <bytesToDeliver>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000C8B")]
		private int <currentOutputIndex>5__3; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C8C")]
		private int <numWholeBlocksInBytes>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000C8D")]
		private Byte[] <tempInputBuffer>5__5; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000C8E")]
		private Byte[] <tempOutputBuffer>5__6; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000C8F")]
		private ValueTaskAwaiter<Int32> <>u__1; //Field offset: 0x68

		[Address(RVA = "0x1EAF0A0", Offset = "0x1EAE4A0", Length = "0xFB4")]
		[Token(Token = "0x6001823")]
		private override void MoveNext() { }

		[Address(RVA = "0x1EB0060", Offset = "0x1EAF460", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6001824")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002E4")]
	private struct <ReadAsyncInternal>d__37 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C78")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C79")]
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C7A")]
		public CryptoStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C7B")]
		public Byte[] buffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C7C")]
		public int offset; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000C7D")]
		public int count; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C7E")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C7F")]
		private SemaphoreSlim <semaphore>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C80")]
		private ForceAsyncAwaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C81")]
		private TaskAwaiter<Int32> <>u__2; //Field offset: 0x50

		[Address(RVA = "0x1EB00D0", Offset = "0x1EAF4D0", Length = "0x5D9")]
		[Token(Token = "0x6001821")]
		private override void MoveNext() { }

		[Address(RVA = "0x1EB06B0", Offset = "0x1EAFAB0", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6001822")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002E7")]
	private struct <WriteAsyncCore>d__49 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C9A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C9B")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C9C")]
		public int count; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000C9D")]
		public int offset; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C9E")]
		public CryptoStream <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C9F")]
		public Byte[] buffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000CA0")]
		public bool useAsync; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000CA1")]
		public CancellationToken cancellationToken; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000CA2")]
		private int <bytesToWrite>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000CA3")]
		private int <currentInputIndex>5__3; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000CA4")]
		private int <numOutputBytes>5__4; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000CA5")]
		private ValueTaskAwaiter <>u__1; //Field offset: 0x58
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000CA6")]
		private int <numWholeBlocksInBytes>5__5; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000CA7")]
		private Byte[] <tempOutputBuffer>5__6; //Field offset: 0x70

		[Address(RVA = "0x1EC4550", Offset = "0x1EC3950", Length = "0xE30")]
		[Token(Token = "0x6001827")]
		private override void MoveNext() { }

		[Address(RVA = "0x1EC5390", Offset = "0x1EC4790", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001828")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002E6")]
	private struct <WriteAsyncInternal>d__46 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C90")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C91")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C92")]
		public CryptoStream <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C93")]
		public Byte[] buffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C94")]
		public int offset; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000C95")]
		public int count; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C96")]
		public CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C97")]
		private SemaphoreSlim <semaphore>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000C98")]
		private ForceAsyncAwaiter <>u__1; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000C99")]
		private TaskAwaiter <>u__2; //Field offset: 0x50

		[Address(RVA = "0x1EC53F0", Offset = "0x1EC47F0", Length = "0x493")]
		[Token(Token = "0x6001825")]
		private override void MoveNext() { }

		[Address(RVA = "0x1EC5890", Offset = "0x1EC4C90", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6001826")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C6A")]
	private readonly Stream _stream; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C6B")]
	private readonly ICryptoTransform _transform; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C6C")]
	private readonly CryptoStreamMode _transformMode; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C6D")]
	private Byte[] _inputBuffer; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C6E")]
	private int _inputBufferIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000C6F")]
	private int _inputBlockSize; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C70")]
	private Byte[] _outputBuffer; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C71")]
	private int _outputBufferIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000C72")]
	private int _outputBlockSize; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C73")]
	private bool _canRead; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000C74")]
	private bool _canWrite; //Field offset: 0x61
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x4000C75")]
	private bool _finalBlockTransformed; //Field offset: 0x62
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C76")]
	private SemaphoreSlim _lazyAsyncActiveSemaphore; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C77")]
	private readonly bool _leaveOpen; //Field offset: 0x70

	[Token(Token = "0x17000265")]
	private SemaphoreSlim AsyncActiveSemaphore
	{
		[Address(RVA = "0x1E9F9F0", Offset = "0x1E9EDF0", Length = "0x10E")]
		[Token(Token = "0x6001820")]
		private get { } //Length: 270
	}

	[Token(Token = "0x1700025F")]
	public virtual bool CanRead
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[Token(Token = "0x6001802")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000260")]
	public virtual bool CanSeek
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001803")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000261")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
		[Token(Token = "0x6001804")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000264")]
	public bool HasFlushedFinalBlock
	{
		[Address(RVA = "0x121E390", Offset = "0x121D790", Length = "0x5")]
		[Token(Token = "0x6001808")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000262")]
	public virtual long Length
	{
		[Address(RVA = "0x1E9FB10", Offset = "0x1E9EF10", Length = "0x4E")]
		[Token(Token = "0x6001805")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000263")]
	public virtual long Position
	{
		[Address(RVA = "0x1E9FB60", Offset = "0x1E9EF60", Length = "0x4E")]
		[Token(Token = "0x6001806")]
		 get { } //Length: 78
		[Address(RVA = "0x1E9FBB0", Offset = "0x1E9EFB0", Length = "0x4E")]
		[Token(Token = "0x6001807")]
		 set { } //Length: 78
	}

	[Address(RVA = "0x1E9F9D0", Offset = "0x1E9EDD0", Length = "0x1C")]
	[Token(Token = "0x6001800")]
	public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	[Address(RVA = "0x1E9F6D0", Offset = "0x1E9EAD0", Length = "0x2F5")]
	[Token(Token = "0x6001801")]
	public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen) { }

	[Address(RVA = "0x1E9E1A0", Offset = "0x1E9D5A0", Length = "0xAB")]
	[Token(Token = "0x600180E")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1E9E250", Offset = "0x1E9D650", Length = "0xAB")]
	[Token(Token = "0x6001817")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1E9E300", Offset = "0x1E9D700", Length = "0x1AA")]
	[Token(Token = "0x6001814")]
	private void CheckReadArguments(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1E9E4B0", Offset = "0x1E9D8B0", Length = "0x1AA")]
	[Token(Token = "0x600181B")]
	private void CheckWriteArguments(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1E9E660", Offset = "0x1E9DA60", Length = "0x14")]
	[Token(Token = "0x600181D")]
	public void Clear() { }

	[Address(RVA = "0x1E9E680", Offset = "0x1E9DA80", Length = "0x8F")]
	[Token(Token = "0x600181E")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1E9E710", Offset = "0x1E9DB10", Length = "0x39")]
	[Token(Token = "0x600180F")]
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1E9E750", Offset = "0x1E9DB50", Length = "0xA")]
	[Token(Token = "0x6001818")]
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600180A")]
	public virtual void Flush() { }

	[Address(RVA = "0x1E9E760", Offset = "0x1E9DB60", Length = "0x16E")]
	[Token(Token = "0x600180B")]
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[Address(RVA = "0x1E9E8D0", Offset = "0x1E9DCD0", Length = "0x1E6")]
	[Token(Token = "0x6001809")]
	public void FlushFinalBlock() { }

	[Address(RVA = "0x1E9F9F0", Offset = "0x1E9EDF0", Length = "0x10E")]
	[Token(Token = "0x6001820")]
	private SemaphoreSlim get_AsyncActiveSemaphore() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[Token(Token = "0x6001802")]
	public virtual bool get_CanRead() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001803")]
	public virtual bool get_CanSeek() { }

	[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
	[Token(Token = "0x6001804")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x121E390", Offset = "0x121D790", Length = "0x5")]
	[Token(Token = "0x6001808")]
	public bool get_HasFlushedFinalBlock() { }

	[Address(RVA = "0x1E9FB10", Offset = "0x1E9EF10", Length = "0x4E")]
	[Token(Token = "0x6001805")]
	public virtual long get_Length() { }

	[Address(RVA = "0x1E9FB60", Offset = "0x1E9EF60", Length = "0x4E")]
	[Token(Token = "0x6001806")]
	public virtual long get_Position() { }

	[Address(RVA = "0x1E9EAC0", Offset = "0x1E9DEC0", Length = "0xB6")]
	[Token(Token = "0x600181F")]
	private void InitializeBuffer() { }

	[Address(RVA = "0x1E9F010", Offset = "0x1E9E410", Length = "0xC4")]
	[Token(Token = "0x6001813")]
	public virtual int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1E9EE30", Offset = "0x1E9E230", Length = "0x15C")]
	[Token(Token = "0x600180D")]
	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1E9EB80", Offset = "0x1E9DF80", Length = "0x15D")]
	[AsyncStateMachine(typeof(<ReadAsyncCore>d__42))]
	[Token(Token = "0x6001815")]
	private Task<Int32> ReadAsyncCore(Byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	[Address(RVA = "0x1E9ECE0", Offset = "0x1E9E0E0", Length = "0x14E")]
	[AsyncStateMachine(typeof(<ReadAsyncInternal>d__37))]
	[Token(Token = "0x6001810")]
	private Task<Int32> ReadAsyncInternal(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1E9EF90", Offset = "0x1E9E390", Length = "0x74")]
	[Token(Token = "0x6001811")]
	public virtual int ReadByte() { }

	[Address(RVA = "0x1E9F0E0", Offset = "0x1E9E4E0", Length = "0x4E")]
	[Token(Token = "0x600180C")]
	public virtual long Seek(long offset, SeekOrigin origin) { }

	[Address(RVA = "0x1E9FBB0", Offset = "0x1E9EFB0", Length = "0x4E")]
	[Token(Token = "0x6001807")]
	public virtual void set_Position(long value) { }

	[Address(RVA = "0x1E9F560", Offset = "0x1E9E960", Length = "0x164")]
	[Token(Token = "0x600181A")]
	public virtual void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1E9F3B0", Offset = "0x1E9E7B0", Length = "0x159")]
	[Token(Token = "0x6001816")]
	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1E9F130", Offset = "0x1E9E530", Length = "0x13A")]
	[AsyncStateMachine(typeof(<WriteAsyncCore>d__49))]
	[Token(Token = "0x600181C")]
	private Task WriteAsyncCore(Byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	[Address(RVA = "0x1E9F270", Offset = "0x1E9E670", Length = "0x13C")]
	[AsyncStateMachine(typeof(<WriteAsyncInternal>d__46))]
	[Token(Token = "0x6001819")]
	private Task WriteAsyncInternal(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1E9F510", Offset = "0x1E9E910", Length = "0x4D")]
	[Token(Token = "0x6001812")]
	public virtual void WriteByte(byte value) { }

}


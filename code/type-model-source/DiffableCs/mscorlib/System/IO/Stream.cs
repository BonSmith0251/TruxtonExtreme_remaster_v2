namespace System.IO;

[Token(Token = "0x2000669")]
public abstract class Stream : MarshalByRefObject, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000671")]
	private struct <<ReadAsync>g__FinishReadAsync|44_0>d : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40019E6")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40019E7")]
		public AsyncValueTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40019E8")]
		public Task<Int32> readTask; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40019E9")]
		public Byte[] localBuffer; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40019EA")]
		public Memory<Byte> localDestination; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40019EB")]
		private ConfiguredTaskAwaiter<Int32> <>u__1; //Field offset: 0x48

		[Address(RVA = "0x2003A50", Offset = "0x2002E50", Length = "0x31E")]
		[Token(Token = "0x6003022")]
		private override void MoveNext() { }

		[Address(RVA = "0x2003D70", Offset = "0x2003170", Length = "0x49")]
		[DebuggerHidden]
		[Token(Token = "0x6003023")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200066F")]
	private sealed class <>c
	{
		[Token(Token = "0x40019D7")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40019D8")]
		public static Func<SemaphoreSlim> <>9__4_0; //Field offset: 0x8
		[Token(Token = "0x40019D9")]
		public static Action<Object> <>9__37_0; //Field offset: 0x10
		[Token(Token = "0x40019DA")]
		public static Func<Object, Int32> <>9__40_0; //Field offset: 0x18
		[Token(Token = "0x40019DB")]
		public static Func<Stream, ReadWriteParameters, AsyncCallback, Object, IAsyncResult> <>9__45_0; //Field offset: 0x20
		[Token(Token = "0x40019DC")]
		public static Func<Stream, IAsyncResult, Int32> <>9__45_1; //Field offset: 0x28
		[Token(Token = "0x40019DD")]
		public static Func<Object, Int32> <>9__48_0; //Field offset: 0x30
		[Token(Token = "0x40019DE")]
		public static Action<Task, Object> <>9__49_0; //Field offset: 0x38
		[Token(Token = "0x40019DF")]
		public static Func<Stream, ReadWriteParameters, AsyncCallback, Object, IAsyncResult> <>9__58_0; //Field offset: 0x40
		[Token(Token = "0x40019E0")]
		public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__58_1; //Field offset: 0x48

		[Address(RVA = "0x2004A20", Offset = "0x2003E20", Length = "0x67")]
		[Token(Token = "0x6003015")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6003016")]
		public <>c() { }

		[Address(RVA = "0x2003DC0", Offset = "0x20031C0", Length = "0x52")]
		[Token(Token = "0x600301A")]
		internal IAsyncResult <BeginEndReadAsync>b__45_0(Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) { }

		[Address(RVA = "0x2003E20", Offset = "0x2003220", Length = "0x32")]
		[Token(Token = "0x600301B")]
		internal int <BeginEndReadAsync>b__45_1(Stream stream, IAsyncResult asyncResult) { }

		[Address(RVA = "0x2003E60", Offset = "0x2003260", Length = "0x52")]
		[Token(Token = "0x600301E")]
		internal IAsyncResult <BeginEndWriteAsync>b__58_0(Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) { }

		[Address(RVA = "0x2003EC0", Offset = "0x20032C0", Length = "0x34")]
		[Token(Token = "0x600301F")]
		internal VoidTaskResult <BeginEndWriteAsync>b__58_1(Stream stream, IAsyncResult asyncResult) { }

		[Address(RVA = "0x2003F00", Offset = "0x2003300", Length = "0x130")]
		[Token(Token = "0x6003019")]
		internal int <BeginReadInternal>b__40_0(object <p0>) { }

		[Address(RVA = "0x2004040", Offset = "0x2003440", Length = "0x128")]
		[Token(Token = "0x600301C")]
		internal int <BeginWriteInternal>b__48_0(object <p0>) { }

		[Address(RVA = "0x2004170", Offset = "0x2003570", Length = "0x4D")]
		[Token(Token = "0x6003017")]
		internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

		[Address(RVA = "0x20041C0", Offset = "0x20035C0", Length = "0x7C")]
		[Token(Token = "0x6003018")]
		internal void <FlushAsync>b__37_0(object state) { }

		[Address(RVA = "0x20046C0", Offset = "0x2003AC0", Length = "0x66")]
		[Token(Token = "0x600301D")]
		internal void <RunReadWriteTaskWhenReady>b__49_0(Task t, object state) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000670")]
	private struct <FinishWriteAsync>d__57 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40019E1")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40019E2")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40019E3")]
		public Task writeTask; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40019E4")]
		public Byte[] localBuffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40019E5")]
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		[Address(RVA = "0x20026A0", Offset = "0x2001AA0", Length = "0x24D")]
		[Token(Token = "0x6003020")]
		private override void MoveNext() { }

		[Address(RVA = "0x20028F0", Offset = "0x2001CF0", Length = "0x5A")]
		[DebuggerHidden]
		[Token(Token = "0x6003021")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x200066C")]
	private sealed class NullStream : Stream
	{
		[Token(Token = "0x40019CE")]
		private static readonly Task<Int32> s_zeroTask; //Field offset: 0x0

		[Token(Token = "0x17000788")]
		public virtual bool CanRead
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002FEE")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700078A")]
		public virtual bool CanSeek
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002FF0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000789")]
		public virtual bool CanWrite
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002FEF")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700078B")]
		public virtual long Length
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x6002FF1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700078C")]
		public virtual long Position
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x6002FF2")]
			 get { } //Length: 3
			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x6002FF3")]
			 set { } //Length: 3
		}

		[Address(RVA = "0x1FF9480", Offset = "0x1FF8880", Length = "0x86")]
		[Token(Token = "0x6003007")]
		private static NullStream() { }

		[Address(RVA = "0x1FF9510", Offset = "0x1FF8910", Length = "0x49")]
		[Token(Token = "0x6002FED")]
		internal NullStream() { }

		[Address(RVA = "0x1FF8CE0", Offset = "0x1FF80E0", Length = "0x89")]
		[Token(Token = "0x6002FF8")]
		public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		[Address(RVA = "0x1FF8D70", Offset = "0x1FF8170", Length = "0x89")]
		[Token(Token = "0x6002FFA")]
		public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

		[Address(RVA = "0x1FF8E00", Offset = "0x1FF8200", Length = "0x8")]
		[Token(Token = "0x6002FF4")]
		public virtual void CopyTo(Stream destination, int bufferSize) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002FF5")]
		protected virtual void Dispose(bool disposing) { }

		[Address(RVA = "0x1FF8E10", Offset = "0x1FF8210", Length = "0x187")]
		[Token(Token = "0x6002FF9")]
		public virtual int EndRead(IAsyncResult asyncResult) { }

		[Address(RVA = "0x1FF8FA0", Offset = "0x1FF83A0", Length = "0x17F")]
		[Token(Token = "0x6002FFB")]
		public virtual void EndWrite(IAsyncResult asyncResult) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002FF6")]
		public virtual void Flush() { }

		[Address(RVA = "0x1FF9120", Offset = "0x1FF8520", Length = "0xDF")]
		[Token(Token = "0x6002FF7")]
		public virtual Task FlushAsync(CancellationToken cancellationToken) { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002FEE")]
		public virtual bool get_CanRead() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002FF0")]
		public virtual bool get_CanSeek() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002FEF")]
		public virtual bool get_CanWrite() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002FF1")]
		public virtual long get_Length() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002FF2")]
		public virtual long get_Position() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002FFC")]
		public virtual int Read(Byte[] buffer, int offset, int count) { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6002FFD")]
		public virtual int Read(Span<Byte> buffer) { }

		[Address(RVA = "0x1FF9250", Offset = "0x1FF8650", Length = "0x52")]
		[Token(Token = "0x6002FFF")]
		public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

		[Address(RVA = "0x1FF9200", Offset = "0x1FF8600", Length = "0x4E")]
		[Token(Token = "0x6002FFE")]
		public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
		[Token(Token = "0x6003000")]
		public virtual int ReadByte() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6003006")]
		public virtual long Seek(long offset, SeekOrigin origin) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002FF3")]
		public virtual void set_Position(long value) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6003001")]
		public virtual void Write(Byte[] buffer, int offset, int count) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6003002")]
		public virtual void Write(ReadOnlySpan<Byte> buffer) { }

		[Address(RVA = "0x1FF93A0", Offset = "0x1FF87A0", Length = "0xDA")]
		[Token(Token = "0x6003003")]
		public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1FF92B0", Offset = "0x1FF86B0", Length = "0xE2")]
		[Token(Token = "0x6003004")]
		public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6003005")]
		public virtual void WriteByte(byte value) { }

	}

	[Token(Token = "0x200066A")]
	private struct ReadWriteParameters
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40019C2")]
		internal Byte[] Buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40019C3")]
		internal int Offset; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40019C4")]
		internal int Count; //Field offset: 0xC

	}

	[Token(Token = "0x200066B")]
	private sealed class ReadWriteTask : Task<Int32>, ITaskCompletionAction
	{
		[Token(Token = "0x40019CD")]
		private static ContextCallback s_invokeAsyncCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40019C5")]
		internal readonly bool _isRead; //Field offset: 0x58
		[FieldOffset(Offset = "0x59")]
		[Token(Token = "0x40019C6")]
		internal readonly bool _apm; //Field offset: 0x59
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40019C7")]
		internal Stream _stream; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40019C8")]
		internal Byte[] _buffer; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40019C9")]
		internal readonly int _offset; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x40019CA")]
		internal readonly int _count; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40019CB")]
		private AsyncCallback _callback; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40019CC")]
		private ExecutionContext _context; //Field offset: 0x80

		[Token(Token = "0x17000787")]
		private override bool System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002FEC")]
			private get { } //Length: 3
		}

		[Address(RVA = "0x1FFE230", Offset = "0x1FFD630", Length = "0x144")]
		[Token(Token = "0x6002FE9")]
		public ReadWriteTask(bool isRead, bool apm, Func<Object, Int32> function, object state, Stream stream, Byte[] buffer, int offset, int count, AsyncCallback callback) { }

		[Address(RVA = "0x1FFE010", Offset = "0x1FFD410", Length = "0x34")]
		[Token(Token = "0x6002FE8")]
		internal void ClearBeginState() { }

		[Address(RVA = "0x1FFE050", Offset = "0x1FFD450", Length = "0x8A")]
		[Token(Token = "0x6002FEA")]
		private static void InvokeAsyncCallback(object completedTask) { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002FEC")]
		private override bool System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode() { }

		[Address(RVA = "0x1FFE0E0", Offset = "0x1FFD4E0", Length = "0x14C")]
		[Token(Token = "0x6002FEB")]
		private override void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

	}

	[Token(Token = "0x200066D")]
	private sealed class SynchronousAsyncResult : IAsyncResult
	{
		[CompilerGenerated]
		[Token(Token = "0x200066E")]
		private sealed class <>c
		{
			[Token(Token = "0x40019D5")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x40019D6")]
			public static Func<ManualResetEvent> <>9__12_0; //Field offset: 0x8

			[Address(RVA = "0x2004B00", Offset = "0x2003F00", Length = "0x67")]
			[Token(Token = "0x6003012")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6003013")]
			public <>c() { }

			[Address(RVA = "0x2004740", Offset = "0x2003B40", Length = "0x47")]
			[Token(Token = "0x6003014")]
			internal ManualResetEvent <get_AsyncWaitHandle>b__12_0() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40019CF")]
		private readonly object _stateObject; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40019D0")]
		private readonly bool _isWrite; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40019D1")]
		private ManualResetEvent _waitHandle; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40019D2")]
		private ExceptionDispatchInfo _exceptionInfo; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40019D3")]
		private bool _endXxxCalled; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40019D4")]
		private int _bytesRead; //Field offset: 0x34

		[Token(Token = "0x1700078F")]
		public override object AsyncState
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x600300D")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700078E")]
		public override WaitHandle AsyncWaitHandle
		{
			[Address(RVA = "0x2002550", Offset = "0x2001950", Length = "0x10E")]
			[Token(Token = "0x600300C")]
			 get { } //Length: 270
		}

		[Token(Token = "0x17000790")]
		public override bool CompletedSynchronously
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x600300E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700078D")]
		public override bool IsCompleted
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x600300B")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x20024D0", Offset = "0x20018D0", Length = "0x40")]
		[Token(Token = "0x6003008")]
		internal SynchronousAsyncResult(int bytesRead, object asyncStateObject) { }

		[Address(RVA = "0x2002510", Offset = "0x2001910", Length = "0x36")]
		[Token(Token = "0x6003009")]
		internal SynchronousAsyncResult(object asyncStateObject) { }

		[Address(RVA = "0x2002460", Offset = "0x2001860", Length = "0x6B")]
		[Token(Token = "0x600300A")]
		internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite) { }

		[Address(RVA = "0x1FFEF20", Offset = "0x1FFE320", Length = "0x105")]
		[Token(Token = "0x6003010")]
		internal static int EndRead(IAsyncResult asyncResult) { }

		[Address(RVA = "0x1FFF030", Offset = "0x1FFE430", Length = "0xFD")]
		[Token(Token = "0x6003011")]
		internal static void EndWrite(IAsyncResult asyncResult) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600300D")]
		public override object get_AsyncState() { }

		[Address(RVA = "0x2002550", Offset = "0x2001950", Length = "0x10E")]
		[Token(Token = "0x600300C")]
		public override WaitHandle get_AsyncWaitHandle() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600300E")]
		public override bool get_CompletedSynchronously() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600300B")]
		public override bool get_IsCompleted() { }

		[Address(RVA = "0x2002440", Offset = "0x2001840", Length = "0x13")]
		[Token(Token = "0x600300F")]
		internal void ThrowIfError() { }

	}

	[Token(Token = "0x40019BF")]
	public static readonly Stream Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40019C0")]
	private ReadWriteTask _activeReadWriteTask; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019C1")]
	private SemaphoreSlim _asyncActiveSemaphore; //Field offset: 0x20

	[Token(Token = "0x1700077F")]
	public abstract bool CanRead
	{
		[Token(Token = "0x6002FB3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000780")]
	public abstract bool CanSeek
	{
		[Token(Token = "0x6002FB4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000781")]
	public override bool CanTimeout
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002FB5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000782")]
	public abstract bool CanWrite
	{
		[Token(Token = "0x6002FB6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000783")]
	public abstract long Length
	{
		[Token(Token = "0x6002FB7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000784")]
	public abstract long Position
	{
		[Token(Token = "0x6002FB8")]
		 get { } //Length: 0
		[Token(Token = "0x6002FB9")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000785")]
	public override int ReadTimeout
	{
		[Address(RVA = "0x2001120", Offset = "0x2000520", Length = "0x4E")]
		[Token(Token = "0x6002FBA")]
		 get { } //Length: 78
		[Address(RVA = "0x20011C0", Offset = "0x20005C0", Length = "0x4E")]
		[Token(Token = "0x6002FBB")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000786")]
	public override int WriteTimeout
	{
		[Address(RVA = "0x2001170", Offset = "0x2000570", Length = "0x4E")]
		[Token(Token = "0x6002FBC")]
		 get { } //Length: 78
		[Address(RVA = "0x2001210", Offset = "0x2000610", Length = "0x4E")]
		[Token(Token = "0x6002FBD")]
		 set { } //Length: 78
	}

	[Address(RVA = "0x2001070", Offset = "0x2000470", Length = "0xA4")]
	[Token(Token = "0x6002FE6")]
	private static Stream() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002FE5")]
	protected Stream() { }

	[Address(RVA = "0x2000800", Offset = "0x1FFFC00", Length = "0x18B")]
	[AsyncStateMachine(typeof(<<ReadAsync>g__FinishReadAsync|44_0>d))]
	[CompilerGenerated]
	[Token(Token = "0x6002FE7")]
	internal static ValueTask<Int32> <ReadAsync>g__FinishReadAsync|44_0(Task<Int32> readTask, Byte[] localBuffer, Memory<Byte> localDestination) { }

	[Address(RVA = "0x1FFE380", Offset = "0x1FFD780", Length = "0x24C")]
	[Token(Token = "0x6002FCC")]
	private Task<Int32> BeginEndReadAsync(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1FFE5D0", Offset = "0x1FFD9D0", Length = "0x24C")]
	[Token(Token = "0x6002FD7")]
	private Task BeginEndWriteAsync(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1FFEA60", Offset = "0x1FFDE60", Length = "0x3B")]
	[Token(Token = "0x6002FC6")]
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1FFE820", Offset = "0x1FFDC20", Length = "0x238")]
	[Token(Token = "0x6002FC7")]
	internal IAsyncResult BeginReadInternal(Byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	[Address(RVA = "0x1FFECE0", Offset = "0x1FFE0E0", Length = "0x3B")]
	[Token(Token = "0x6002FCD")]
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1FFEAA0", Offset = "0x1FFDEA0", Length = "0x238")]
	[Token(Token = "0x6002FCE")]
	internal IAsyncResult BeginWriteInternal(Byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	[Address(RVA = "0x1FFED20", Offset = "0x1FFE120", Length = "0xFF")]
	[Token(Token = "0x6002FDF")]
	internal IAsyncResult BlockingBeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1FFEE20", Offset = "0x1FFE220", Length = "0xFD")]
	[Token(Token = "0x6002FE1")]
	internal IAsyncResult BlockingBeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	[Address(RVA = "0x1FFEF20", Offset = "0x1FFE320", Length = "0x105")]
	[Token(Token = "0x6002FE0")]
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1FFF030", Offset = "0x1FFE430", Length = "0xFD")]
	[Token(Token = "0x6002FE2")]
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1FFF130", Offset = "0x1FFE530", Length = "0x61")]
	[Token(Token = "0x6002FC1")]
	public override void Close() { }

	[Address(RVA = "0x1FFF310", Offset = "0x1FFE710", Length = "0xEE")]
	[Token(Token = "0x6002FBE")]
	public void CopyTo(Stream destination) { }

	[Address(RVA = "0x1FFF1A0", Offset = "0x1FFE5A0", Length = "0x16A")]
	[Token(Token = "0x6002FBF")]
	public override void CopyTo(Stream destination, int bufferSize) { }

	[Address(RVA = "0x1E9E660", Offset = "0x1E9DA60", Length = "0x14")]
	[Token(Token = "0x6002FC2")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6002FC3")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1FFF400", Offset = "0x1FFE800", Length = "0x21D")]
	[Token(Token = "0x6002FC8")]
	public override int EndRead(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1FFF620", Offset = "0x1FFEA20", Length = "0x214")]
	[Token(Token = "0x6002FD2")]
	public override void EndWrite(IAsyncResult asyncResult) { }

	[Address(RVA = "0x1FFF840", Offset = "0x1FFEC40", Length = "0x10E")]
	[Token(Token = "0x6002FB2")]
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	[Address(RVA = "0x1FFF950", Offset = "0x1FFED50", Length = "0x36")]
	[Token(Token = "0x6002FD1")]
	private void FinishTrackingAsyncOperation() { }

	[Address(RVA = "0x1FFF990", Offset = "0x1FFED90", Length = "0xFD")]
	[AsyncStateMachine(typeof(<FinishWriteAsync>d__57))]
	[Token(Token = "0x6002FD6")]
	private Task FinishWriteAsync(Task writeTask, Byte[] localBuffer) { }

	[Token(Token = "0x6002FC4")]
	public abstract void Flush() { }

	[Address(RVA = "0x1FFFA90", Offset = "0x1FFEE90", Length = "0x201")]
	[Token(Token = "0x6002FC5")]
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	[Token(Token = "0x6002FB3")]
	public abstract bool get_CanRead() { }

	[Token(Token = "0x6002FB4")]
	public abstract bool get_CanSeek() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002FB5")]
	public override bool get_CanTimeout() { }

	[Token(Token = "0x6002FB6")]
	public abstract bool get_CanWrite() { }

	[Token(Token = "0x6002FB7")]
	public abstract long get_Length() { }

	[Token(Token = "0x6002FB8")]
	public abstract long get_Position() { }

	[Address(RVA = "0x2001120", Offset = "0x2000520", Length = "0x4E")]
	[Token(Token = "0x6002FBA")]
	public override int get_ReadTimeout() { }

	[Address(RVA = "0x2001170", Offset = "0x2000570", Length = "0x4E")]
	[Token(Token = "0x6002FBC")]
	public override int get_WriteTimeout() { }

	[Address(RVA = "0x1FFFCA0", Offset = "0x1FFF0A0", Length = "0xDF")]
	[Token(Token = "0x6002FC0")]
	private int GetCopyBufferSize() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6002FE3")]
	private bool HasOverriddenBeginEndRead() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6002FE4")]
	private bool HasOverriddenBeginEndWrite() { }

	[Token(Token = "0x6002FD9")]
	public abstract int Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x2000350", Offset = "0x1FFF750", Length = "0x20B")]
	[Token(Token = "0x6002FDA")]
	public override int Read(Span<Byte> buffer) { }

	[Address(RVA = "0x1FFFE60", Offset = "0x1FFF260", Length = "0x3AA")]
	[Token(Token = "0x6002FCB")]
	public override ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x1FFFD80", Offset = "0x1FFF180", Length = "0xD3")]
	[Token(Token = "0x6002FCA")]
	public override Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2000210", Offset = "0x1FFF610", Length = "0x97")]
	[Token(Token = "0x6002FC9")]
	public Task<Int32> ReadAsync(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x20002B0", Offset = "0x1FFF6B0", Length = "0x9E")]
	[Token(Token = "0x6002FDB")]
	public override int ReadByte() { }

	[Address(RVA = "0x2000730", Offset = "0x1FFFB30", Length = "0xC1")]
	[Token(Token = "0x6002FD0")]
	private void RunReadWriteTask(ReadWriteTask readWriteTask) { }

	[Address(RVA = "0x2000560", Offset = "0x1FFF960", Length = "0x1C7")]
	[Token(Token = "0x6002FCF")]
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, ReadWriteTask readWriteTask) { }

	[Token(Token = "0x6002FD8")]
	public abstract long Seek(long offset, SeekOrigin origin) { }

	[Token(Token = "0x6002FB9")]
	public abstract void set_Position(long value) { }

	[Address(RVA = "0x20011C0", Offset = "0x20005C0", Length = "0x4E")]
	[Token(Token = "0x6002FBB")]
	public override void set_ReadTimeout(int value) { }

	[Address(RVA = "0x2001210", Offset = "0x2000610", Length = "0x4E")]
	[Token(Token = "0x6002FBD")]
	public override void set_WriteTimeout(int value) { }

	[Token(Token = "0x6002FDC")]
	public abstract void Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x2000F10", Offset = "0x2000310", Length = "0x155")]
	[Token(Token = "0x6002FDD")]
	public override void Write(ReadOnlySpan<Byte> buffer) { }

	[Address(RVA = "0x2000990", Offset = "0x1FFFD90", Length = "0x372")]
	[Token(Token = "0x6002FD5")]
	public override ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2000DB0", Offset = "0x20001B0", Length = "0xC2")]
	[Token(Token = "0x6002FD4")]
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2000D10", Offset = "0x2000110", Length = "0x97")]
	[Token(Token = "0x6002FD3")]
	public Task WriteAsync(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x2000E80", Offset = "0x2000280", Length = "0x8A")]
	[Token(Token = "0x6002FDE")]
	public override void WriteByte(byte value) { }

}


namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x2000004")]
public static class AddressablesAsyncExtensions
{
	[Token(Token = "0x2000005")]
	internal struct AsyncOperationHandleAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000006")]
		private AsyncOperationHandle handle; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000007")]
		private Action<AsyncOperationHandle> continuationAction; //Field offset: 0x18

		[Token(Token = "0x17000001")]
		public bool IsCompleted
		{
			[Address(RVA = "0x272C320", Offset = "0x272B720", Length = "0x7")]
			[Token(Token = "0x600000A")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x272C2E0", Offset = "0x272B6E0", Length = "0x38")]
		[Token(Token = "0x6000009")]
		public AsyncOperationHandleAwaiter(AsyncOperationHandle handle) { }

		[Address(RVA = "0x272C320", Offset = "0x272B720", Length = "0x7")]
		[Token(Token = "0x600000A")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x272C170", Offset = "0x272B570", Length = "0x8E")]
		[Token(Token = "0x600000B")]
		public void GetResult() { }

		[Address(RVA = "0x272C200", Offset = "0x272B600", Length = "0x8")]
		[Token(Token = "0x600000C")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x272C210", Offset = "0x272B610", Length = "0xCE")]
		[Token(Token = "0x600000D")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[Token(Token = "0x2000006")]
	private sealed class AsyncOperationHandleConfiguredSource : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AsyncOperationHandleConfiguredSource>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000007")]
		private sealed class <>c
		{
			[Token(Token = "0x4000010")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x272D040", Offset = "0x272C440", Length = "0x67")]
			[Token(Token = "0x6000019")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600001A")]
			public <>c() { }

			[Address(RVA = "0x272CFE0", Offset = "0x272C3E0", Length = "0x5A")]
			[Token(Token = "0x600001B")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000008")]
		private static TaskPool<AsyncOperationHandleConfiguredSource> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000009")]
		private AsyncOperationHandleConfiguredSource nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000A")]
		private readonly Action<AsyncOperationHandle> continuationAction; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400000B")]
		private AsyncOperationHandle handle; //Field offset: 0x20
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400000C")]
		private CancellationToken cancellationToken; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400000D")]
		private IProgress<Single> progress; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400000E")]
		private bool completed; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400000F")]
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x50

		[Token(Token = "0x17000002")]
		public override AsyncOperationHandleConfiguredSource NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x600000E")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x272CE60", Offset = "0x272C260", Length = "0x100")]
		[Token(Token = "0x600000F")]
		private static AsyncOperationHandleConfiguredSource() { }

		[Address(RVA = "0x272CF60", Offset = "0x272C360", Length = "0x7D")]
		[Token(Token = "0x6000010")]
		private AsyncOperationHandleConfiguredSource() { }

		[Address(RVA = "0x272C330", Offset = "0x272B730", Length = "0x144")]
		[Token(Token = "0x6000012")]
		private void Continuation(AsyncOperationHandle _) { }

		[Address(RVA = "0x272C480", Offset = "0x272B880", Length = "0x281")]
		[Token(Token = "0x6000011")]
		public static IUniTaskSource Create(AsyncOperationHandle handle, PlayerLoopTiming timing, IProgress<Single> progress, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x600000E")]
		public override AsyncOperationHandleConfiguredSource get_NextNode() { }

		[Address(RVA = "0x272C710", Offset = "0x272BB10", Length = "0x49")]
		[Token(Token = "0x6000013")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x272C760", Offset = "0x272BB60", Length = "0x14E")]
		[Token(Token = "0x6000014")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x272C8B0", Offset = "0x272BCB0", Length = "0x164")]
		[Token(Token = "0x6000017")]
		public override bool MoveNext() { }

		[Address(RVA = "0x272CA20", Offset = "0x272BE20", Length = "0x1D0")]
		[Token(Token = "0x6000016")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x272CC00", Offset = "0x272C000", Length = "0x1A8")]
		[Token(Token = "0x6000018")]
		private bool TryReturn() { }

		[Address(RVA = "0x272CDB0", Offset = "0x272C1B0", Length = "0xAD")]
		[Token(Token = "0x6000015")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000008")]
	private sealed class AsyncOperationHandleConfiguredSource : IUniTaskSource<T>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AsyncOperationHandleConfiguredSource`1<T>>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000009")]
		private sealed class <>c
		{
			[Token(Token = "0x4000019")]
			public static readonly <>c<T> <>9; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000028")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000029")]
			public <>c() { }

			[Address(RVA = "0xA35AD0", Offset = "0xA34ED0", Length = "0x98")]
			[Token(Token = "0x600002A")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000011")]
		private static TaskPool<AsyncOperationHandleConfiguredSource`1<T>> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000012")]
		private AsyncOperationHandleConfiguredSource<T> nextNode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000013")]
		private readonly Action<AsyncOperationHandle`1<T>> continuationAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000014")]
		private AsyncOperationHandle<T> handle; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000015")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000016")]
		private IProgress<Single> progress; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000017")]
		private bool completed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000018")]
		private UniTaskCompletionSourceCore<T> core; //Field offset: 0x0

		[Token(Token = "0x17000003")]
		public override AsyncOperationHandleConfiguredSource<T>& NextNode
		{
			[Address(RVA = "0x11617C0", Offset = "0x1160BC0", Length = "0x1E")]
			[Token(Token = "0x600001C")]
			 get { } //Length: 30
		}

		[Address(RVA = "0x1161580", Offset = "0x1160980", Length = "0x172")]
		[Token(Token = "0x600001D")]
		private static AsyncOperationHandleConfiguredSource`1() { }

		[Address(RVA = "0x1161700", Offset = "0x1160B00", Length = "0xB6")]
		[Token(Token = "0x600001E")]
		private AsyncOperationHandleConfiguredSource`1() { }

		[Address(RVA = "0x1160490", Offset = "0x115F890", Length = "0x386")]
		[Token(Token = "0x6000020")]
		private void Continuation(AsyncOperationHandle<T> argHandle) { }

		[Address(RVA = "0x1160820", Offset = "0x115FC20", Length = "0x5C9")]
		[Token(Token = "0x600001F")]
		public static IUniTaskSource<T> Create(AsyncOperationHandle<T> handle, PlayerLoopTiming timing, IProgress<Single> progress, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x1160DF0", Offset = "0x11601F0", Length = "0xB8")]
		[Token(Token = "0x6000022")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x11617C0", Offset = "0x1160BC0", Length = "0x1E")]
		[Token(Token = "0x600001C")]
		public override AsyncOperationHandleConfiguredSource<T>& get_NextNode() { }

		[Address(RVA = "0x1160EB0", Offset = "0x11602B0", Length = "0xF7")]
		[Token(Token = "0x6000021")]
		public override T GetResult(short token) { }

		[Address(RVA = "0x1160FB0", Offset = "0x11603B0", Length = "0x6D")]
		[Token(Token = "0x6000023")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1161020", Offset = "0x1160420", Length = "0x2BD")]
		[Token(Token = "0x6000026")]
		public override bool MoveNext() { }

		[Address(RVA = "0x11612E0", Offset = "0x11606E0", Length = "0x98")]
		[Token(Token = "0x6000025")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1161380", Offset = "0x1160780", Length = "0x194")]
		[Token(Token = "0x6000027")]
		private bool TryReturn() { }

		[Address(RVA = "0x1161520", Offset = "0x1160920", Length = "0x5D")]
		[Token(Token = "0x6000024")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}


	[Address(RVA = "0x272BE60", Offset = "0x272B260", Length = "0xB0")]
	[Extension]
	[Token(Token = "0x6000003")]
	public static Awaiter GetAwaiter(AsyncOperationHandle handle) { }

	[Address(RVA = "0x6DC730", Offset = "0x6DBB30", Length = "0x186")]
	[Extension]
	[Token(Token = "0x6000006")]
	public static Awaiter<T> GetAwaiter(AsyncOperationHandle<T> handle) { }

	[Address(RVA = "0x272BF10", Offset = "0x272B310", Length = "0x1F5")]
	[Extension]
	[Token(Token = "0x6000005")]
	public static UniTask ToUniTask(AsyncOperationHandle handle, IProgress<Single> progress = null, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x6DC8C0", Offset = "0x6DBCC0", Length = "0x43C")]
	[Extension]
	[Token(Token = "0x6000008")]
	public static UniTask<T> ToUniTask(AsyncOperationHandle<T> handle, IProgress<Single> progress = null, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x272C110", Offset = "0x272B510", Length = "0x51")]
	[Extension]
	[Token(Token = "0x6000004")]
	public static UniTask WithCancellation(AsyncOperationHandle handle, CancellationToken cancellationToken) { }

	[Address(RVA = "0x6DCD00", Offset = "0x6DC100", Length = "0x105")]
	[Extension]
	[Token(Token = "0x6000007")]
	public static UniTask<T> WithCancellation(AsyncOperationHandle<T> handle, CancellationToken cancellationToken) { }

}


namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000023")]
internal class SingleConsumerUnboundedChannel : Channel<T>
{
	[Token(Token = "0x2000025")]
	private sealed class SingleConsumerUnboundedChannelReader : ChannelReader<T>, IUniTaskSource<Boolean>, IUniTaskSource
	{
		[Token(Token = "0x2000026")]
		private sealed class ReadAllAsyncEnumerable : IUniTaskAsyncEnumerable<T>, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400006B")]
			private readonly Action<Object> CancellationCallback1Delegate; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400006C")]
			private readonly Action<Object> CancellationCallback2Delegate; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400006D")]
			private readonly SingleConsumerUnboundedChannelReader<T> parent; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400006E")]
			private CancellationToken cancellationToken1; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400006F")]
			private CancellationToken cancellationToken2; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000070")]
			private CancellationTokenRegistration cancellationTokenRegistration1; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000071")]
			private CancellationTokenRegistration cancellationTokenRegistration2; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000072")]
			private T current; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000073")]
			private bool cacheValue; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000074")]
			private bool running; //Field offset: 0x0

			[Token(Token = "0x17000019")]
			public override T Current
			{
				[Address(RVA = "0xE9B300", Offset = "0xE9A700", Length = "0x157")]
				[Token(Token = "0x60000D3")]
				 get { } //Length: 343
			}

			[Address(RVA = "0xE9B140", Offset = "0xE9A540", Length = "0x1BD")]
			[Token(Token = "0x60000D1")]
			public ReadAllAsyncEnumerable(SingleConsumerUnboundedChannelReader<T> parent, CancellationToken cancellationToken) { }

			[Address(RVA = "0xE9A8D0", Offset = "0xE99CD0", Length = "0x147")]
			[Token(Token = "0x60000D6")]
			private static void CancellationCallback1(object state) { }

			[Address(RVA = "0xE9AA20", Offset = "0xE99E20", Length = "0x147")]
			[Token(Token = "0x60000D7")]
			private static void CancellationCallback2(object state) { }

			[Address(RVA = "0xE9AB70", Offset = "0xE99F70", Length = "0x95")]
			[Token(Token = "0x60000D5")]
			public override UniTask DisposeAsync() { }

			[Address(RVA = "0xE9B300", Offset = "0xE9A700", Length = "0x157")]
			[Token(Token = "0x60000D3")]
			public override T get_Current() { }

			[Address(RVA = "0xE9AC10", Offset = "0xE9A010", Length = "0x418")]
			[Token(Token = "0x60000D2")]
			public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

			[Address(RVA = "0xE9B030", Offset = "0xE9A430", Length = "0x10C")]
			[Token(Token = "0x60000D4")]
			public override UniTask<Boolean> MoveNextAsync() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000065")]
		private readonly Action<Object> CancellationCallbackDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000066")]
		private readonly SingleConsumerUnboundedChannel<T> parent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000067")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000068")]
		private CancellationTokenRegistration cancellationTokenRegistration; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000069")]
		private UniTaskCompletionSourceCore<Boolean> core; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006A")]
		internal bool isWaiting; //Field offset: 0x0

		[Token(Token = "0x17000018")]
		public virtual UniTask Completion
		{
			[Address(RVA = "0xF63670", Offset = "0xF62A70", Length = "0xCA")]
			[Token(Token = "0x60000C4")]
			 get { } //Length: 202
		}

		[Address(RVA = "0xF635C0", Offset = "0xF629C0", Length = "0xAE")]
		[Token(Token = "0x60000C3")]
		public SingleConsumerUnboundedChannelReader(SingleConsumerUnboundedChannel<T> parent) { }

		[Address(RVA = "0xF627B0", Offset = "0xF61BB0", Length = "0xD6")]
		[Token(Token = "0x60000D0")]
		private static void CancellationCallback(object state) { }

		[Address(RVA = "0xF628E0", Offset = "0xF61CE0", Length = "0x49")]
		[Token(Token = "0x60000CC")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0xF62930", Offset = "0xF61D30", Length = "0x14E")]
		[Token(Token = "0x60000CD")]
		private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token) { }

		[Address(RVA = "0xF62A80", Offset = "0xF61E80", Length = "0x1D0")]
		[Token(Token = "0x60000CE")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0xF62C60", Offset = "0xF62060", Length = "0xAD")]
		[Token(Token = "0x60000CF")]
		private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus() { }

		[Address(RVA = "0xF62890", Offset = "0xF61C90", Length = "0x49")]
		[Token(Token = "0x60000CB")]
		private override bool Cysharp.Threading.Tasks.IUniTaskSource<System.Boolean>.GetResult(short token) { }

		[Address(RVA = "0xF63670", Offset = "0xF62A70", Length = "0xCA")]
		[Token(Token = "0x60000C4")]
		public virtual UniTask get_Completion() { }

		[Address(RVA = "0xE7E1B0", Offset = "0xE7D5B0", Length = "0x7E")]
		[Token(Token = "0x60000CA")]
		public virtual IUniTaskAsyncEnumerable<T> ReadAllAsync(CancellationToken cancellationToken = null) { }

		[Address(RVA = "0xF62D10", Offset = "0xF62110", Length = "0x49")]
		[Token(Token = "0x60000C8")]
		public void SingalCancellation(CancellationToken cancellationToken) { }

		[Address(RVA = "0xF62D60", Offset = "0xF62160", Length = "0x72")]
		[Token(Token = "0x60000C9")]
		public void SingalCompleted(Exception error) { }

		[Address(RVA = "0xF62DE0", Offset = "0xF621E0", Length = "0x3C")]
		[Token(Token = "0x60000C7")]
		public void SingalContinuation() { }

		[Address(RVA = "0xF62E20", Offset = "0xF62220", Length = "0x376")]
		[Token(Token = "0x60000C5")]
		public virtual bool TryRead(out T item) { }

		[Address(RVA = "0xF631A0", Offset = "0xF625A0", Length = "0x414")]
		[Token(Token = "0x60000C6")]
		public virtual UniTask<Boolean> WaitToReadAsync(CancellationToken cancellationToken) { }

	}

	[Token(Token = "0x2000024")]
	private sealed class SingleConsumerUnboundedChannelWriter : ChannelWriter<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000064")]
		private readonly SingleConsumerUnboundedChannel<T> parent; //Field offset: 0x0

		[Address(RVA = "0xF63C50", Offset = "0xF63050", Length = "0x3D")]
		[Token(Token = "0x60000C0")]
		public SingleConsumerUnboundedChannelWriter(SingleConsumerUnboundedChannel<T> parent) { }

		[Address(RVA = "0xF63740", Offset = "0xF62B40", Length = "0x2DC")]
		[Token(Token = "0x60000C2")]
		public virtual bool TryComplete(Exception error = null) { }

		[Address(RVA = "0xF63A20", Offset = "0xF62E20", Length = "0x22E")]
		[Token(Token = "0x60000C1")]
		public virtual bool TryWrite(T item) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005E")]
	private readonly Queue<T> items; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005F")]
	private readonly SingleConsumerUnboundedChannelReader<T> readerSource; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000060")]
	private UniTaskCompletionSource completedTaskSource; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000061")]
	private UniTask completedTask; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000062")]
	private Exception completionError; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000063")]
	private bool closed; //Field offset: 0x0

	[Address(RVA = "0xF63C90", Offset = "0xF63090", Length = "0x15D")]
	[Token(Token = "0x60000BF")]
	public SingleConsumerUnboundedChannel`1() { }

}


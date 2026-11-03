namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000162")]
internal sealed class QueueOperator : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x2000163")]
	private sealed class _Queue : IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000164")]
		private struct <ConsumeAll>d__10 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EAA")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EAB")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EAC")]
			public ChannelWriter<TSource> writer; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EAD")]
			public IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EAE")]
			public _Queue<TSource> self; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EAF")]
			private object <>7__wrap1; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EB0")]
			private int <>7__wrap2; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EB1")]
			private Awaiter<Boolean> <>u__1; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EB2")]
			private Awaiter <>u__2; //Field offset: 0x0

			[Address(RVA = "0x11420A0", Offset = "0x11414A0", Length = "0x863")]
			[Token(Token = "0x60006C3")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60006C4")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x2000165")]
		private struct <DisposeAsync>d__11 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EB3")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EB4")]
			public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EB5")]
			public _Queue<TSource> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000EB6")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x16E4560", Offset = "0x16E3960", Length = "0x41C")]
			[Token(Token = "0x60006C5")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60006C6")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EA4")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EA5")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EA6")]
		private Channel<TSource> channel; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EA7")]
		private IUniTaskAsyncEnumerator<TSource> channelEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EA8")]
		private IUniTaskAsyncEnumerator<TSource> sourceEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EA9")]
		private bool channelClosed; //Field offset: 0x0

		[Token(Token = "0x17000031")]
		public override TSource Current
		{
			[Address(RVA = "0x16097B0", Offset = "0x1608BB0", Length = "0xB8")]
			[Token(Token = "0x60006BF")]
			 get { } //Length: 184
		}

		[Address(RVA = "0xF63F80", Offset = "0xF63380", Length = "0x4D")]
		[Token(Token = "0x60006BE")]
		public _Queue(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1609360", Offset = "0x1608760", Length = "0x100")]
		[AsyncStateMachine(typeof(<ConsumeAll>d__10))]
		[Token(Token = "0x60006C1")]
		private static UniTaskVoid ConsumeAll(_Queue<TSource> self, IUniTaskAsyncEnumerator<TSource> enumerator, ChannelWriter<TSource> writer) { }

		[Address(RVA = "0x1609460", Offset = "0x1608860", Length = "0xA7")]
		[AsyncStateMachine(typeof(<DisposeAsync>d__11))]
		[Token(Token = "0x60006C2")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x16097B0", Offset = "0x1608BB0", Length = "0xB8")]
		[Token(Token = "0x60006BF")]
		public override TSource get_Current() { }

		[Address(RVA = "0x1609510", Offset = "0x1608910", Length = "0x299")]
		[Token(Token = "0x60006C0")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EA3")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60006BC")]
	public QueueOperator`1(IUniTaskAsyncEnumerable<TSource> source) { }

	[Address(RVA = "0xE12E80", Offset = "0xE12280", Length = "0x7F")]
	[Token(Token = "0x60006BD")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}


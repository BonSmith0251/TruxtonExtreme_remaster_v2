namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200020B")]
internal class ToUniTaskAsyncEnumerableUniTask : IUniTaskAsyncEnumerable<T>
{
	[Token(Token = "0x200020C")]
	private class _ToUniTaskAsyncEnumerableUniTask : IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200020D")]
		private struct <MoveNextAsync>d__7 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400138C")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400138D")]
			public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400138E")]
			public _ToUniTaskAsyncEnumerableUniTask<T> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400138F")]
			private Awaiter<T> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x19762C0", Offset = "0x19756C0", Length = "0x7C7")]
			[Token(Token = "0x60008E2")]
			private override void MoveNext() { }

			[Address(RVA = "0x1976AE0", Offset = "0x1975EE0", Length = "0x94")]
			[DebuggerHidden]
			[Token(Token = "0x60008E3")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001388")]
		private readonly UniTask<T> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001389")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400138A")]
		private T current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400138B")]
		private bool called; //Field offset: 0x0

		[Token(Token = "0x1700004E")]
		public override T Current
		{
			[Address(RVA = "0x1621610", Offset = "0x1620A10", Length = "0xAD")]
			[Token(Token = "0x60008DF")]
			 get { } //Length: 173
		}

		[Address(RVA = "0x16218D0", Offset = "0x1620CD0", Length = "0x139")]
		[Token(Token = "0x60008DE")]
		public _ToUniTaskAsyncEnumerableUniTask(UniTask<T> source, CancellationToken cancellationToken) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x60008E1")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1621610", Offset = "0x1620A10", Length = "0xAD")]
		[Token(Token = "0x60008DF")]
		public override T get_Current() { }

		[Address(RVA = "0x16216C0", Offset = "0x1620AC0", Length = "0x206")]
		[AsyncStateMachine(typeof(<MoveNextAsync>d__7))]
		[Token(Token = "0x60008E0")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001387")]
	private readonly UniTask<T> source; //Field offset: 0x0

	[Address(RVA = "0x108FA90", Offset = "0x108EE90", Length = "0xAA")]
	[Token(Token = "0x60008DC")]
	public ToUniTaskAsyncEnumerableUniTask`1(UniTask<T> source) { }

	[Address(RVA = "0x108F980", Offset = "0x108ED80", Length = "0x106")]
	[Token(Token = "0x60008DD")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}


namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000208")]
internal class ToUniTaskAsyncEnumerableTask : IUniTaskAsyncEnumerable<T>
{
	[Token(Token = "0x2000209")]
	private class _ToUniTaskAsyncEnumerableTask : IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200020A")]
		private struct <MoveNextAsync>d__7 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001383")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001384")]
			public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001385")]
			public _ToUniTaskAsyncEnumerableTask<T> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001386")]
			private TaskAwaiter<T> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1975E50", Offset = "0x1975250", Length = "0x467")]
			[Token(Token = "0x60008DA")]
			private override void MoveNext() { }

			[Address(RVA = "0x1976A90", Offset = "0x1975E90", Length = "0x49")]
			[DebuggerHidden]
			[Token(Token = "0x60008DB")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400137F")]
		private readonly Task<T> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001380")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001381")]
		private T current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001382")]
		private bool called; //Field offset: 0x0

		[Token(Token = "0x1700004D")]
		public override T Current
		{
			[Address(RVA = "0x1621610", Offset = "0x1620A10", Length = "0xAD")]
			[Token(Token = "0x60008D7")]
			 get { } //Length: 173
		}

		[Address(RVA = "0x1621500", Offset = "0x1620900", Length = "0x10B")]
		[Token(Token = "0x60008D6")]
		public _ToUniTaskAsyncEnumerableTask(Task<T> source, CancellationToken cancellationToken) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x60008D9")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1621610", Offset = "0x1620A10", Length = "0xAD")]
		[Token(Token = "0x60008D7")]
		public override T get_Current() { }

		[Address(RVA = "0x1621410", Offset = "0x1620810", Length = "0xE4")]
		[AsyncStateMachine(typeof(<MoveNextAsync>d__7))]
		[Token(Token = "0x60008D8")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400137E")]
	private readonly Task<T> source; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60008D4")]
	public ToUniTaskAsyncEnumerableTask`1(Task<T> source) { }

	[Address(RVA = "0xE12E80", Offset = "0xE12280", Length = "0x7F")]
	[Token(Token = "0x60008D5")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}


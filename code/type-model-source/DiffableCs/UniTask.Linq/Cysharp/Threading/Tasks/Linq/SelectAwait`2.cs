namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000173")]
internal sealed class SelectAwait : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x2000174")]
	private sealed class _SelectAwait : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EE8")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EE9")]
		private readonly Func<TSource, UniTask`1<TResult>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EEA")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EEB")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EEC")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EED")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EEE")]
		private Awaiter<TResult> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EEF")]
		private Action moveNextAction; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EF0")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000038")]
		public private override TResult Current
		{
			[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x60006F5")]
			 get { } //Length: 175
			[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x60006F6")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x160D2A0", Offset = "0x160C6A0", Length = "0x1E2")]
		[Token(Token = "0x60006F4")]
		public _SelectAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TResult>> selector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x160BD20", Offset = "0x160B120", Length = "0xED")]
		[Token(Token = "0x60006F9")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x160BA40", Offset = "0x160AE40", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x60006F5")]
		public override TResult get_Current() { }

		[Address(RVA = "0x160C0E0", Offset = "0x160B4E0", Length = "0x890")]
		[Token(Token = "0x60006F8")]
		private void MoveNext() { }

		[Address(RVA = "0x160BFF0", Offset = "0x160B3F0", Length = "0xE3")]
		[Token(Token = "0x60006F7")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160BBA0", Offset = "0x160AFA0", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x60006F6")]
		private void set_Current(TResult value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EE6")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EE7")]
	private readonly Func<TSource, UniTask`1<TResult>> selector; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60006F2")]
	public SelectAwait`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TResult>> selector) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x60006F3")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}


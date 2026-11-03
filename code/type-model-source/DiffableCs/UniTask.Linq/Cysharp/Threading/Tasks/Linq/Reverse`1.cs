namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200016C")]
internal sealed class Reverse : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200016D")]
	private sealed class _Reverse : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200016E")]
		private struct <MoveNextAsync>d__9 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000ECD")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000ECE")]
			public AsyncUniTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000ECF")]
			public _Reverse<TSource> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000ED0")]
			private Awaiter<TSource[]> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1976B80", Offset = "0x1975F80", Length = "0x75E")]
			[Token(Token = "0x60006E0")]
			private override void MoveNext() { }

			[Address(RVA = "0x19772E0", Offset = "0x19766E0", Length = "0x49")]
			[DebuggerHidden]
			[Token(Token = "0x60006E1")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EC8")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EC9")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ECA")]
		private TSource[] array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ECB")]
		private int index; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000ECC")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000035")]
		public private override TSource Current
		{
			[Address(RVA = "0x1609F10", Offset = "0x1609310", Length = "0xAD")]
			[CompilerGenerated]
			[Token(Token = "0x60006DC")]
			 get { } //Length: 173
			[Address(RVA = "0x1609FC0", Offset = "0x16093C0", Length = "0xBA")]
			[CompilerGenerated]
			[Token(Token = "0x60006DD")]
			private set { } //Length: 186
		}

		[Address(RVA = "0x1607680", Offset = "0x1606A80", Length = "0xC9")]
		[Token(Token = "0x60006DB")]
		public _Reverse(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x60006DF")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1609F10", Offset = "0x1609310", Length = "0xAD")]
		[CompilerGenerated]
		[Token(Token = "0x60006DC")]
		public override TSource get_Current() { }

		[Address(RVA = "0x1609E20", Offset = "0x1609220", Length = "0xF0")]
		[AsyncStateMachine(typeof(<MoveNextAsync>d__9))]
		[Token(Token = "0x60006DE")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1609FC0", Offset = "0x16093C0", Length = "0xBA")]
		[CompilerGenerated]
		[Token(Token = "0x60006DD")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EC7")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60006D9")]
	public Reverse`1(IUniTaskAsyncEnumerable<TSource> source) { }

	[Address(RVA = "0xE12E80", Offset = "0xE12280", Length = "0x7F")]
	[Token(Token = "0x60006DA")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}


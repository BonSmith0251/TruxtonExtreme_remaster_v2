namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000179")]
internal sealed class SelectIntAwaitWithCancellation : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x200017A")]
	private sealed class _SelectAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F0A")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F0B")]
		private readonly Func<TSource, Int32, CancellationToken, UniTask`1<TResult>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F0C")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F0D")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F0E")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F0F")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F10")]
		private Awaiter<TResult> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F11")]
		private Action moveNextAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F12")]
		private int index; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F13")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700003B")]
		public private override TResult Current
		{
			[Address(RVA = "0x160BAF0", Offset = "0x160AEF0", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x600070D")]
			 get { } //Length: 175
			[Address(RVA = "0x160BC60", Offset = "0x160B060", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x600070E")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x160B850", Offset = "0x160AC50", Length = "0x1E2")]
		[Token(Token = "0x600070C")]
		public _SelectAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, CancellationToken, UniTask`1<TResult>> selector, CancellationToken cancellationToken) { }

		[Address(RVA = "0x160A170", Offset = "0x1609570", Length = "0xED")]
		[Token(Token = "0x6000711")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x160BAF0", Offset = "0x160AEF0", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x600070D")]
		public override TResult get_Current() { }

		[Address(RVA = "0x160AD10", Offset = "0x160A110", Length = "0x940")]
		[Token(Token = "0x6000710")]
		private void MoveNext() { }

		[Address(RVA = "0x160A260", Offset = "0x1609660", Length = "0xE3")]
		[Token(Token = "0x600070F")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x160BC60", Offset = "0x160B060", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x600070E")]
		private void set_Current(TResult value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F08")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F09")]
	private readonly Func<TSource, Int32, CancellationToken, UniTask`1<TResult>> selector; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600070A")]
	public SelectIntAwaitWithCancellation`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, CancellationToken, UniTask`1<TResult>> selector) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x600070B")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}


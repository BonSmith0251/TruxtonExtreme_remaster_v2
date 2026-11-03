namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001DD")]
internal sealed class TakeWhileInt : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20001DE")]
	private class _TakeWhileInt : AsyncEnumeratorBase<TSource, TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400124D")]
		private readonly Func<TSource, Int32, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400124E")]
		private int index; //Field offset: 0x0

		[Address(RVA = "0x1619CD0", Offset = "0x16190D0", Length = "0xD3")]
		[Token(Token = "0x600085F")]
		public _TakeWhileInt(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, Boolean> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161F010", Offset = "0x161E410", Length = "0x227")]
		[Token(Token = "0x6000860")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400124B")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400124C")]
	private readonly Func<TSource, Int32, Boolean> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600085D")]
	public TakeWhileInt`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, Boolean> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x600085E")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}


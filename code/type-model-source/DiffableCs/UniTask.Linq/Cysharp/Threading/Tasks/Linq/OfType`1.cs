namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200014C")]
internal sealed class OfType : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x200014D")]
	private class _OfType : AsyncEnumeratorBase<Object, TResult>
	{

		[Address(RVA = "0x1553B50", Offset = "0x1552F50", Length = "0x82")]
		[Token(Token = "0x600066F")]
		public _OfType(IUniTaskAsyncEnumerable<Object> source, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1607040", Offset = "0x1606440", Length = "0x1E0")]
		[Token(Token = "0x6000670")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E3B")]
	private readonly IUniTaskAsyncEnumerable<Object> source; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x600066D")]
	public OfType`1(IUniTaskAsyncEnumerable<Object> source) { }

	[Address(RVA = "0xE10880", Offset = "0xE0FC80", Length = "0x7F")]
	[Token(Token = "0x600066E")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}


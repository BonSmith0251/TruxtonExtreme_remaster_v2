namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200005D")]
internal sealed class Cast : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x200005E")]
	private class _Cast : AsyncEnumeratorBase<Object, TResult>
	{

		[Address(RVA = "0x1553B50", Offset = "0x1552F50", Length = "0x82")]
		[Token(Token = "0x60002F7")]
		public _Cast(IUniTaskAsyncEnumerable<Object> source, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1553A10", Offset = "0x1552E10", Length = "0x132")]
		[Token(Token = "0x60002F8")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000323")]
	private readonly IUniTaskAsyncEnumerable<Object> source; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60002F5")]
	public Cast`1(IUniTaskAsyncEnumerable<Object> source) { }

	[Address(RVA = "0xE10880", Offset = "0xE0FC80", Length = "0x7F")]
	[Token(Token = "0x60002F6")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}


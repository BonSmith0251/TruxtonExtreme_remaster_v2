namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x2000014")]
public static class StateExtensions
{

	[Address(RVA = "0x914090", Offset = "0x913490", Length = "0x7F")]
	[Extension]
	[Token(Token = "0x600007F")]
	public static ReadOnlyAsyncReactiveProperty<T> ToReadOnlyAsyncReactiveProperty(IUniTaskAsyncEnumerable<T> source, CancellationToken cancellationToken) { }

	[Address(RVA = "0x914110", Offset = "0x913510", Length = "0x115")]
	[Extension]
	[Token(Token = "0x6000080")]
	public static ReadOnlyAsyncReactiveProperty<T> ToReadOnlyAsyncReactiveProperty(IUniTaskAsyncEnumerable<T> source, T initialValue, CancellationToken cancellationToken) { }

}


namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x2000036")]
public static class UniTaskAsyncEnumerableExtensions
{

	[Address(RVA = "0x9C6B70", Offset = "0x9C5F70", Length = "0x63")]
	[Extension]
	[Token(Token = "0x6000118")]
	public static UniTaskCancelableAsyncEnumerable<T> WithCancellation(IUniTaskAsyncEnumerable<T> source, CancellationToken cancellationToken) { }

}


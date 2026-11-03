namespace Cysharp.Threading.Tasks;

[Extension]
[Token(Token = "0x2000027")]
public static class EnumerableAsyncExtensions
{

	[Address(RVA = "0x7D6090", Offset = "0x7D5490", Length = "0x4D")]
	[Extension]
	[Token(Token = "0x60000D8")]
	public static IEnumerable<UniTask> Select(IEnumerable<T> source, Func<T, UniTask> selector) { }

	[Address(RVA = "0x7D6090", Offset = "0x7D5490", Length = "0x4D")]
	[Extension]
	[Token(Token = "0x60000D9")]
	public static IEnumerable<UniTask`1<TR>> Select(IEnumerable<T> source, Func<T, UniTask`1<TR>> selector) { }

	[Address(RVA = "0x7D6090", Offset = "0x7D5490", Length = "0x4D")]
	[Extension]
	[Token(Token = "0x60000DA")]
	public static IEnumerable<UniTask> Select(IEnumerable<T> source, Func<T, Int32, UniTask> selector) { }

	[Address(RVA = "0x7D6090", Offset = "0x7D5490", Length = "0x4D")]
	[Extension]
	[Token(Token = "0x60000DB")]
	public static IEnumerable<UniTask`1<TR>> Select(IEnumerable<T> source, Func<T, Int32, UniTask`1<TR>> selector) { }

}


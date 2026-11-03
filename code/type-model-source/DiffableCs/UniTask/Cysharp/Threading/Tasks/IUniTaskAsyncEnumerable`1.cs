namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000031")]
public interface IUniTaskAsyncEnumerable
{

	[Token(Token = "0x6000110")]
	public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}


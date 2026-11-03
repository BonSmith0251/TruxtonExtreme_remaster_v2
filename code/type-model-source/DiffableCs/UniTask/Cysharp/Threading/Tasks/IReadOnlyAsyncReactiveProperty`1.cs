namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000007")]
public interface IReadOnlyAsyncReactiveProperty : IUniTaskAsyncEnumerable<T>
{

	[Token(Token = "0x17000004")]
	public T Value
	{
		[Token(Token = "0x6000017")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000017")]
	public T get_Value() { }

	[Token(Token = "0x6000019")]
	public UniTask<T> WaitAsync(CancellationToken cancellationToken = null) { }

	[Token(Token = "0x6000018")]
	public IUniTaskAsyncEnumerable<T> WithoutCurrent() { }

}


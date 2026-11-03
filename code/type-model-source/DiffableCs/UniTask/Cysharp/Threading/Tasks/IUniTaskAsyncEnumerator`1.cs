namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000032")]
public interface IUniTaskAsyncEnumerator : IUniTaskAsyncDisposable
{

	[Token(Token = "0x17000023")]
	public T Current
	{
		[Token(Token = "0x6000111")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000111")]
	public T get_Current() { }

	[Token(Token = "0x6000112")]
	public UniTask<Boolean> MoveNextAsync() { }

}


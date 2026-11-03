namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000156")]
public interface IAsyncEndEditEventHandler : IDisposable
{

	[Token(Token = "0x6000845")]
	public UniTask<T> OnEndEditAsync() { }

}


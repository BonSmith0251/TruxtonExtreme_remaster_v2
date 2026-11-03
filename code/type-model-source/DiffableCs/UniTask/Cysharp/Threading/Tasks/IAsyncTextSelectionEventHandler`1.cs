namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000158")]
public interface IAsyncTextSelectionEventHandler : IDisposable
{

	[Token(Token = "0x6000847")]
	public UniTask<T> OnTextSelectionAsync() { }

}


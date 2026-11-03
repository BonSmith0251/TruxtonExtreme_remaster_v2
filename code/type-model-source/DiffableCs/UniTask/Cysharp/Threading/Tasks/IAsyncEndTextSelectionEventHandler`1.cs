namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000157")]
public interface IAsyncEndTextSelectionEventHandler : IDisposable
{

	[Token(Token = "0x6000846")]
	public UniTask<T> OnEndTextSelectionAsync() { }

}


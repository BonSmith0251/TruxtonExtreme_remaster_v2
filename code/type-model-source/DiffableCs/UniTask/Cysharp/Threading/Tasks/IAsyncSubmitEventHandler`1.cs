namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200015B")]
public interface IAsyncSubmitEventHandler : IDisposable
{

	[Token(Token = "0x600084A")]
	public UniTask<T> OnSubmitAsync() { }

}


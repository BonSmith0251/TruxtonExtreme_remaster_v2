namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000155")]
public interface IAsyncValueChangedEventHandler : IDisposable
{

	[Token(Token = "0x6000844")]
	public UniTask<T> OnValueChangedAsync() { }

}


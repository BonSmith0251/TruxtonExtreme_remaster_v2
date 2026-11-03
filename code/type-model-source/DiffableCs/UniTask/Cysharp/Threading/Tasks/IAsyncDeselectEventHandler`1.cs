namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000159")]
public interface IAsyncDeselectEventHandler : IDisposable
{

	[Token(Token = "0x6000848")]
	public UniTask<T> OnDeselectAsync() { }

}


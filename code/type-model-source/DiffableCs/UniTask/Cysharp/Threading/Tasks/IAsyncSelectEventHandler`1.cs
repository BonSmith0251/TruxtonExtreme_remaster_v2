namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200015A")]
public interface IAsyncSelectEventHandler : IDisposable
{

	[Token(Token = "0x6000849")]
	public UniTask<T> OnSelectAsync() { }

}


namespace Cysharp.Threading.Tasks;

[Token(Token = "0x20000FF")]
public interface IResolvePromise
{

	[Token(Token = "0x6000649")]
	public bool TrySetResult(T value) { }

}


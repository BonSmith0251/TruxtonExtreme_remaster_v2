namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000186")]
public interface IAsyncOnBecameVisibleHandler
{

	[Token(Token = "0x6000A03")]
	public UniTask OnBecameVisibleAsync() { }

}


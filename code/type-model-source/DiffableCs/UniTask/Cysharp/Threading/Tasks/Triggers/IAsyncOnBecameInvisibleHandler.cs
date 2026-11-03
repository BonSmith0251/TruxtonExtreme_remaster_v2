namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000184")]
public interface IAsyncOnBecameInvisibleHandler
{

	[Token(Token = "0x60009FC")]
	public UniTask OnBecameInvisibleAsync() { }

}


namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000180")]
public interface IAsyncOnApplicationQuitHandler
{

	[Token(Token = "0x60009EE")]
	public UniTask OnApplicationQuitAsync() { }

}


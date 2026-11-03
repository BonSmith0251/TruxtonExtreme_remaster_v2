namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000172")]
public interface IAsyncOneShotTrigger
{

	[Token(Token = "0x6000965")]
	public UniTask OneShotAsync() { }

}


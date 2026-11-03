namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001A0")]
public interface IAsyncOnEnableHandler
{

	[Token(Token = "0x6000A5E")]
	public UniTask OnEnableAsync() { }

}


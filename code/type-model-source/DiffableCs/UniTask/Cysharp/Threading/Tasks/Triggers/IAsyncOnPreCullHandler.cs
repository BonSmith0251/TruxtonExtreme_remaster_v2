namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001C0")]
public interface IAsyncOnPreCullHandler
{

	[Token(Token = "0x6000ACE")]
	public UniTask OnPreCullAsync() { }

}


namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001CC")]
public interface IAsyncOnServerInitializedHandler
{

	[Token(Token = "0x6000AF8")]
	public UniTask OnServerInitializedAsync() { }

}


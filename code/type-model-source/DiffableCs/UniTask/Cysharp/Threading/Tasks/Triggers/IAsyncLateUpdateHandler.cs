namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000176")]
public interface IAsyncLateUpdateHandler
{

	[Token(Token = "0x60009CB")]
	public UniTask LateUpdateAsync() { }

}


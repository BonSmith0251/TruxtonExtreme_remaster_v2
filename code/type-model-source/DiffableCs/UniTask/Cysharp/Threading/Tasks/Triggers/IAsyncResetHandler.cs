namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001E2")]
public interface IAsyncResetHandler
{

	[Token(Token = "0x6000B45")]
	public UniTask ResetAsync() { }

}


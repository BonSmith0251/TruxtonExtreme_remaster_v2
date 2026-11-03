namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000206")]
public interface IAsyncOnUpdateSelectedHandler
{

	[Token(Token = "0x6000BC3")]
	public UniTask<BaseEventData> OnUpdateSelectedAsync() { }

}


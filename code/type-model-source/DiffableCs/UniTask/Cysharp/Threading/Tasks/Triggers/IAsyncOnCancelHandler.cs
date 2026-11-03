namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001E8")]
public interface IAsyncOnCancelHandler
{

	[Token(Token = "0x6000B5A")]
	public UniTask<BaseEventData> OnCancelAsync() { }

}


namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001EA")]
public interface IAsyncOnDeselectHandler
{

	[Token(Token = "0x6000B61")]
	public UniTask<BaseEventData> OnDeselectAsync() { }

}


namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000202")]
public interface IAsyncOnSelectHandler
{

	[Token(Token = "0x6000BB5")]
	public UniTask<BaseEventData> OnSelectAsync() { }

}


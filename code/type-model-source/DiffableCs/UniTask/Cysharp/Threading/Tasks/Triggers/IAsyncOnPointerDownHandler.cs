namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001F8")]
public interface IAsyncOnPointerDownHandler
{

	[Token(Token = "0x6000B92")]
	public UniTask<PointerEventData> OnPointerDownAsync() { }

}


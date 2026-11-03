namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001F0")]
public interface IAsyncOnEndDragHandler
{

	[Token(Token = "0x6000B76")]
	public UniTask<PointerEventData> OnEndDragAsync() { }

}


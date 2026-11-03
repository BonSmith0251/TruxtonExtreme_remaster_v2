namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001E6")]
public interface IAsyncOnBeginDragHandler
{

	[Token(Token = "0x6000B53")]
	public UniTask<PointerEventData> OnBeginDragAsync() { }

}


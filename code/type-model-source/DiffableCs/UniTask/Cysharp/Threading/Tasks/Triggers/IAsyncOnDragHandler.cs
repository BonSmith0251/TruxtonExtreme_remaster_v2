namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001EC")]
public interface IAsyncOnDragHandler
{

	[Token(Token = "0x6000B68")]
	public UniTask<PointerEventData> OnDragAsync() { }

}


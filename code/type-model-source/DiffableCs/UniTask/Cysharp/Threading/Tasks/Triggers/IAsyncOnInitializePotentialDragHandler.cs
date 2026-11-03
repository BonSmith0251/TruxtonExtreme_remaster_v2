namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001F2")]
public interface IAsyncOnInitializePotentialDragHandler
{

	[Token(Token = "0x6000B7D")]
	public UniTask<PointerEventData> OnInitializePotentialDragAsync() { }

}


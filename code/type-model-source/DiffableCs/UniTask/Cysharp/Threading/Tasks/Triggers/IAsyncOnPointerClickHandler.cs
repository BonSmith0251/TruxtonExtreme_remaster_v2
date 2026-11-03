namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001F6")]
public interface IAsyncOnPointerClickHandler
{

	[Token(Token = "0x6000B8B")]
	public UniTask<PointerEventData> OnPointerClickAsync() { }

}


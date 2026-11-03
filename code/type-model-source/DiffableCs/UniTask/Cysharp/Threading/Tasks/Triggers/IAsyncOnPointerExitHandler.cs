namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001FC")]
public interface IAsyncOnPointerExitHandler
{

	[Token(Token = "0x6000BA0")]
	public UniTask<PointerEventData> OnPointerExitAsync() { }

}


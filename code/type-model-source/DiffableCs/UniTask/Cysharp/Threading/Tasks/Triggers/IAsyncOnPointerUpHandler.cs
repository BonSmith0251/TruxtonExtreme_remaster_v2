namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001FE")]
public interface IAsyncOnPointerUpHandler
{

	[Token(Token = "0x6000BA7")]
	public UniTask<PointerEventData> OnPointerUpAsync() { }

}


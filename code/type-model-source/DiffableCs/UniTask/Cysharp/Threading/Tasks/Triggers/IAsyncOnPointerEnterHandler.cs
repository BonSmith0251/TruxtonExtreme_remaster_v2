namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001FA")]
public interface IAsyncOnPointerEnterHandler
{

	[Token(Token = "0x6000B99")]
	public UniTask<PointerEventData> OnPointerEnterAsync() { }

}


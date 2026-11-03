namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001EE")]
public interface IAsyncOnDropHandler
{

	[Token(Token = "0x6000B6F")]
	public UniTask<PointerEventData> OnDropAsync() { }

}


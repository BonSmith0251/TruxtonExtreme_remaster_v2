namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000200")]
public interface IAsyncOnScrollHandler
{

	[Token(Token = "0x6000BAE")]
	public UniTask<PointerEventData> OnScrollAsync() { }

}


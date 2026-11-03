namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000204")]
public interface IAsyncOnSubmitHandler
{

	[Token(Token = "0x6000BBC")]
	public UniTask<BaseEventData> OnSubmitAsync() { }

}


namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x200017C")]
public interface IAsyncOnApplicationFocusHandler
{

	[Token(Token = "0x60009E0")]
	public UniTask<Boolean> OnApplicationFocusAsync() { }

}


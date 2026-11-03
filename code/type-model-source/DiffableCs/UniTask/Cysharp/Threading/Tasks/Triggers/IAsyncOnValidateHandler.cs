namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001DE")]
public interface IAsyncOnValidateHandler
{

	[Token(Token = "0x6000B37")]
	public UniTask OnValidateAsync() { }

}


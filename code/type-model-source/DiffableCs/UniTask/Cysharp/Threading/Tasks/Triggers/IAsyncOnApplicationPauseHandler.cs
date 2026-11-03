namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x200017E")]
public interface IAsyncOnApplicationPauseHandler
{

	[Token(Token = "0x60009E7")]
	public UniTask<Boolean> OnApplicationPauseAsync() { }

}


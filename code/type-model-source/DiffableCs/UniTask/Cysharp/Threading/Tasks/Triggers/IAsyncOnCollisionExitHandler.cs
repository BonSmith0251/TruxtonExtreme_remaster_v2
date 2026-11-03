namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000190")]
public interface IAsyncOnCollisionExitHandler
{

	[Token(Token = "0x6000A26")]
	public UniTask<Collision> OnCollisionExitAsync() { }

}


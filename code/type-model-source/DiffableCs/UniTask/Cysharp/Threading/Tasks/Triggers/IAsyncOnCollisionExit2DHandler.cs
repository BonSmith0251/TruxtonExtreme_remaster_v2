namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000192")]
public interface IAsyncOnCollisionExit2DHandler
{

	[Token(Token = "0x6000A2D")]
	public UniTask<Collision2D> OnCollisionExit2DAsync() { }

}


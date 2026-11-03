namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000196")]
public interface IAsyncOnCollisionStay2DHandler
{

	[Token(Token = "0x6000A3B")]
	public UniTask<Collision2D> OnCollisionStay2DAsync() { }

}


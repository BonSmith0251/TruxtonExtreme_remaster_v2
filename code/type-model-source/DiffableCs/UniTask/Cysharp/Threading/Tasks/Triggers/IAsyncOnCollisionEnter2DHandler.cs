namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x200018E")]
public interface IAsyncOnCollisionEnter2DHandler
{

	[Token(Token = "0x6000A1F")]
	public UniTask<Collision2D> OnCollisionEnter2DAsync() { }

}


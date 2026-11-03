namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001D4")]
public interface IAsyncOnTriggerEnter2DHandler
{

	[Token(Token = "0x6000B14")]
	public UniTask<Collider2D> OnTriggerEnter2DAsync() { }

}


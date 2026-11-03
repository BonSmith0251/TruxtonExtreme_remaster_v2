namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001D8")]
public interface IAsyncOnTriggerExit2DHandler
{

	[Token(Token = "0x6000B22")]
	public UniTask<Collider2D> OnTriggerExit2DAsync() { }

}


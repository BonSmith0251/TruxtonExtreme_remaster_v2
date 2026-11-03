namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001DC")]
public interface IAsyncOnTriggerStay2DHandler
{

	[Token(Token = "0x6000B30")]
	public UniTask<Collider2D> OnTriggerStay2DAsync() { }

}


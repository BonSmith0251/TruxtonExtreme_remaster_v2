namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x200018C")]
public interface IAsyncOnCollisionEnterHandler
{

	[Token(Token = "0x6000A18")]
	public UniTask<Collision> OnCollisionEnterAsync() { }

}


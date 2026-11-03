namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000194")]
public interface IAsyncOnCollisionStayHandler
{

	[Token(Token = "0x6000A34")]
	public UniTask<Collision> OnCollisionStayAsync() { }

}


namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000198")]
public interface IAsyncOnControllerColliderHitHandler
{

	[Token(Token = "0x6000A42")]
	public UniTask<ControllerColliderHit> OnControllerColliderHitAsync() { }

}


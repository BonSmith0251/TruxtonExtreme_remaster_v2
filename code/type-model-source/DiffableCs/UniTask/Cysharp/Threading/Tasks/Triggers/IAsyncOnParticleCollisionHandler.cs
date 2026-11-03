namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001B6")]
public interface IAsyncOnParticleCollisionHandler
{

	[Token(Token = "0x6000AAB")]
	public UniTask<GameObject> OnParticleCollisionAsync() { }

}


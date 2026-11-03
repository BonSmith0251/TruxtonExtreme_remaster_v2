namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001D6")]
public interface IAsyncOnTriggerExitHandler
{

	[Token(Token = "0x6000B1B")]
	public UniTask<Collider> OnTriggerExitAsync() { }

}


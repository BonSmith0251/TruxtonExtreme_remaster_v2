namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x20001D2")]
public interface IAsyncOnTriggerEnterHandler
{

	[Token(Token = "0x6000B0D")]
	public UniTask<Collider> OnTriggerEnterAsync() { }

}


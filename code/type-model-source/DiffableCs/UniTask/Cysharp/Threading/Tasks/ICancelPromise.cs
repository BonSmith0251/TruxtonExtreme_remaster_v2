namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000101")]
public interface ICancelPromise
{

	[Token(Token = "0x600064B")]
	public bool TrySetCanceled(CancellationToken cancellationToken = null) { }

}


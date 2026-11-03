namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000100")]
public interface IRejectPromise
{

	[Token(Token = "0x600064A")]
	public bool TrySetException(Exception exception) { }

}


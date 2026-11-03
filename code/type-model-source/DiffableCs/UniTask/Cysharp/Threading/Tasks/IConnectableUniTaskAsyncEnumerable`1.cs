namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000035")]
public interface IConnectableUniTaskAsyncEnumerable : IUniTaskAsyncEnumerable<T>
{

	[Token(Token = "0x6000117")]
	public IDisposable Connect() { }

}


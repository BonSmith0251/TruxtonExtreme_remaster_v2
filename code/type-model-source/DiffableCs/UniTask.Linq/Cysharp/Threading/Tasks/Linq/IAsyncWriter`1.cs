namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000094")]
public interface IAsyncWriter
{

	[Token(Token = "0x6000418")]
	public UniTask YieldAsync(T value) { }

}


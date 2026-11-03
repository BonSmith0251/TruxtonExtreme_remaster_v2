namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000154")]
public interface IAsyncClickEventHandler : IDisposable
{

	[Token(Token = "0x6000843")]
	public UniTask OnClickAsync() { }

}


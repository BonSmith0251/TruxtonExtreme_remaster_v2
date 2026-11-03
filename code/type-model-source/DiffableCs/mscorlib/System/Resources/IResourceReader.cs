namespace System.Resources;

[Token(Token = "0x20004B6")]
public interface IResourceReader : IEnumerable, IDisposable
{

	[Token(Token = "0x600219D")]
	public void Close() { }

	[Token(Token = "0x600219E")]
	public IDictionaryEnumerator GetEnumerator() { }

}


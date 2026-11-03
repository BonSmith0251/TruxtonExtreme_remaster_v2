namespace System.Collections;

[Token(Token = "0x20005A2")]
public interface ICollection : IEnumerable
{

	[Token(Token = "0x17000611")]
	public int Count
	{
		[Token(Token = "0x6002940")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000613")]
	public bool IsSynchronized
	{
		[Token(Token = "0x6002942")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000612")]
	public object SyncRoot
	{
		[Token(Token = "0x6002941")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600293F")]
	public void CopyTo(Array array, int index) { }

	[Token(Token = "0x6002940")]
	public int get_Count() { }

	[Token(Token = "0x6002942")]
	public bool get_IsSynchronized() { }

	[Token(Token = "0x6002941")]
	public object get_SyncRoot() { }

}


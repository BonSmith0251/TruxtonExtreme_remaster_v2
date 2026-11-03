namespace System.Collections.Generic;

[Token(Token = "0x20005F9")]
public interface IReadOnlyCollection : IEnumerable<T>, IEnumerable
{

	[Token(Token = "0x17000714")]
	public int Count
	{
		[Token(Token = "0x6002C99")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002C99")]
	public int get_Count() { }

}


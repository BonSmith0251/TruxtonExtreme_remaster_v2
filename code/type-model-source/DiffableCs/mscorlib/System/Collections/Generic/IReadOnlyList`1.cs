namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x20005FB")]
public interface IReadOnlyList : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
{

	[Token(Token = "0x17000718")]
	public T Item
	{
		[Token(Token = "0x6002C9F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002C9F")]
	public T get_Item(int index) { }

}


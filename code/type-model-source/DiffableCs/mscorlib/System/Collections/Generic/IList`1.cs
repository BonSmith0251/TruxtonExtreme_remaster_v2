namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x20005F8")]
public interface IList : ICollection<T>, IEnumerable<T>, IEnumerable
{

	[Token(Token = "0x17000713")]
	public T Item
	{
		[Token(Token = "0x6002C94")]
		 get { } //Length: 0
		[Token(Token = "0x6002C95")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6002C94")]
	public T get_Item(int index) { }

	[Token(Token = "0x6002C96")]
	public int IndexOf(T item) { }

	[Token(Token = "0x6002C97")]
	public void Insert(int index, T item) { }

	[Token(Token = "0x6002C98")]
	public void RemoveAt(int index) { }

	[Token(Token = "0x6002C95")]
	public void set_Item(int index, T value) { }

}


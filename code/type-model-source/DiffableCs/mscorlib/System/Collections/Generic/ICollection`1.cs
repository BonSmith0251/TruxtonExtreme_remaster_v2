namespace System.Collections.Generic;

[Token(Token = "0x20005EE")]
public interface ICollection : IEnumerable<T>, IEnumerable
{

	[Token(Token = "0x1700070D")]
	public int Count
	{
		[Token(Token = "0x6002C80")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700070E")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6002C81")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6002C82")]
	public void Add(T item) { }

	[Token(Token = "0x6002C83")]
	public void Clear() { }

	[Token(Token = "0x6002C84")]
	public bool Contains(T item) { }

	[Token(Token = "0x6002C85")]
	public void CopyTo(T[] array, int arrayIndex) { }

	[Token(Token = "0x6002C80")]
	public int get_Count() { }

	[Token(Token = "0x6002C81")]
	public bool get_IsReadOnly() { }

	[Token(Token = "0x6002C86")]
	public bool Remove(T item) { }

}


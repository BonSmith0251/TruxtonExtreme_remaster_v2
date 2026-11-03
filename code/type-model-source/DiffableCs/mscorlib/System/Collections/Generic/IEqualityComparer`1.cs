namespace System.Collections.Generic;

[Token(Token = "0x20005F7")]
public interface IEqualityComparer
{

	[Token(Token = "0x6002C92")]
	public bool Equals(T x, T y) { }

	[Token(Token = "0x6002C93")]
	public int GetHashCode(T obj) { }

}


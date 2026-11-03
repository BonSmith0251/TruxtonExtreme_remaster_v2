namespace System;

[Token(Token = "0x2000150")]
internal interface IValueTupleInternal : ITuple
{

	[Token(Token = "0x6000BAC")]
	public int GetHashCode(IEqualityComparer comparer) { }

	[Token(Token = "0x6000BAD")]
	public string ToStringEnd() { }

}


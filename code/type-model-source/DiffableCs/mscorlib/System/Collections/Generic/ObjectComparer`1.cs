namespace System.Collections.Generic;

[Token(Token = "0x200061A")]
internal class ObjectComparer : Comparer<T>
{

	[Address(RVA = "0xDAAD40", Offset = "0xDAA140", Length = "0x14")]
	[Token(Token = "0x6002D96")]
	public ObjectComparer`1() { }

	[Address(RVA = "0xDAA3F0", Offset = "0xDA97F0", Length = "0xD6")]
	[Token(Token = "0x6002D93")]
	public virtual int Compare(T x, T y) { }

	[Address(RVA = "0xDAACC0", Offset = "0xDAA0C0", Length = "0x72")]
	[Token(Token = "0x6002D94")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xCF02A0", Offset = "0xCEF6A0", Length = "0x51")]
	[Token(Token = "0x6002D95")]
	public virtual int GetHashCode() { }

}


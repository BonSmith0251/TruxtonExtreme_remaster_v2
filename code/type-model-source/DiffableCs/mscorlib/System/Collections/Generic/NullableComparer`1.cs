namespace System.Collections.Generic;

[Token(Token = "0x2000619")]
internal class NullableComparer : Comparer<Nullable`1<T>>
{

	[Address(RVA = "0xD9A550", Offset = "0xD99950", Length = "0x14")]
	[Token(Token = "0x6002D92")]
	public NullableComparer`1() { }

	[Address(RVA = "0xD9A310", Offset = "0xD99710", Length = "0xC8")]
	[Token(Token = "0x6002D8F")]
	public virtual int Compare(Nullable<T> x, Nullable<T> y) { }

	[Address(RVA = "0xD9A4D0", Offset = "0xD998D0", Length = "0x72")]
	[Token(Token = "0x6002D90")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xCF02A0", Offset = "0xCEF6A0", Length = "0x51")]
	[Token(Token = "0x6002D91")]
	public virtual int GetHashCode() { }

}


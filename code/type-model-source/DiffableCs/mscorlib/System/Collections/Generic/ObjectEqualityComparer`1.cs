namespace System.Collections.Generic;

[Token(Token = "0x200061F")]
internal class ObjectEqualityComparer : EqualityComparer<T>
{

	[Address(RVA = "0xDC3E30", Offset = "0xDC3230", Length = "0x14")]
	[Token(Token = "0x6002DB6")]
	public ObjectEqualityComparer`1() { }

	[Address(RVA = "0xDC2790", Offset = "0xDC1B90", Length = "0x96")]
	[Token(Token = "0x6002DB0")]
	public virtual bool Equals(T x, T y) { }

	[Address(RVA = "0xDC2540", Offset = "0xDC1940", Length = "0x72")]
	[Token(Token = "0x6002DB4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xDC2A60", Offset = "0xDC1E60", Length = "0x63")]
	[Token(Token = "0x6002DB1")]
	public virtual int GetHashCode(T obj) { }

	[Address(RVA = "0xCF02A0", Offset = "0xCEF6A0", Length = "0x51")]
	[Token(Token = "0x6002DB5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xDC2D40", Offset = "0xDC2140", Length = "0x106")]
	[Token(Token = "0x6002DB2")]
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0xDC3820", Offset = "0xDC2C20", Length = "0x106")]
	[Token(Token = "0x6002DB3")]
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }

}


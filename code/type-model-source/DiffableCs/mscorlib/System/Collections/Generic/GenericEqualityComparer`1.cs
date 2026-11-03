namespace System.Collections.Generic;

[Token(Token = "0x200061D")]
internal class GenericEqualityComparer : EqualityComparer<T>
{

	[Address(RVA = "0x1C23F30", Offset = "0x1C23330", Length = "0x14")]
	[Token(Token = "0x6002DA8")]
	public GenericEqualityComparer`1() { }

	[Address(RVA = "0x1C1E3A0", Offset = "0x1C1D7A0", Length = "0x3A")]
	[Token(Token = "0x6002DA2")]
	public virtual bool Equals(T x, T y) { }

	[Address(RVA = "0x1C1DC00", Offset = "0x1C1D000", Length = "0x72")]
	[Token(Token = "0x6002DA6")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1C1EDC0", Offset = "0x1C1E1C0", Length = "0x20")]
	[Token(Token = "0x6002DA3")]
	public virtual int GetHashCode(T obj) { }

	[Address(RVA = "0xCF02A0", Offset = "0xCEF6A0", Length = "0x51")]
	[Token(Token = "0x6002DA7")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1C20020", Offset = "0x1C1F420", Length = "0xB3")]
	[Token(Token = "0x6002DA4")]
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0x1C23DA0", Offset = "0x1C231A0", Length = "0xB5")]
	[Token(Token = "0x6002DA5")]
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }

}


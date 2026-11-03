namespace System.Collections.Generic;

[Token(Token = "0x2000618")]
internal class GenericComparer : Comparer<T>
{

	[Address(RVA = "0x1C1BD70", Offset = "0x1C1B170", Length = "0x14")]
	[Token(Token = "0x6002D8E")]
	public GenericComparer`1() { }

	[Address(RVA = "0x1C1AD10", Offset = "0x1C1A110", Length = "0x2A")]
	[Token(Token = "0x6002D8B")]
	public virtual int Compare(T x, T y) { }

	[Address(RVA = "0x1C1BCF0", Offset = "0x1C1B0F0", Length = "0x72")]
	[Token(Token = "0x6002D8C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xCF02A0", Offset = "0xCEF6A0", Length = "0x51")]
	[Token(Token = "0x6002D8D")]
	public virtual int GetHashCode() { }

}


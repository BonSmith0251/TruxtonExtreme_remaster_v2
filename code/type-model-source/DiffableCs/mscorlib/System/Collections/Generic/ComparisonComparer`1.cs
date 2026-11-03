namespace System.Collections.Generic;

[Token(Token = "0x200061B")]
internal class ComparisonComparer : Comparer<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40018AF")]
	private readonly Comparison<T> _comparison; //Field offset: 0x0

	[Address(RVA = "0x179FE10", Offset = "0x179F210", Length = "0x3D")]
	[Token(Token = "0x6002D97")]
	public ComparisonComparer`1(Comparison<T> comparison) { }

	[Address(RVA = "0x179DDF0", Offset = "0x179D1F0", Length = "0x40")]
	[Token(Token = "0x6002D98")]
	public virtual int Compare(T x, T y) { }

}


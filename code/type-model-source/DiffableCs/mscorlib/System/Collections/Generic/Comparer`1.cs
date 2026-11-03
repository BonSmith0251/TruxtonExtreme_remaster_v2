namespace System.Collections.Generic;

[Token(Token = "0x2000617")]
[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
public abstract class Comparer : IComparer, IComparer<T>
{
	[Token(Token = "0x40018AE")]
	private static Comparer<T> defaultComparer; //Field offset: 0x0

	[Token(Token = "0x1700073D")]
	public static Comparer<T> Default
	{
		[Address(RVA = "0x16E19A0", Offset = "0x16E0DA0", Length = "0x10C")]
		[Token(Token = "0x6002D85")]
		 get { } //Length: 268
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002D8A")]
	protected Comparer`1() { }

	[Token(Token = "0x6002D88")]
	public abstract int Compare(T x, T y) { }

	[Address(RVA = "0x16E07E0", Offset = "0x16DFBE0", Length = "0xD0")]
	[Token(Token = "0x6002D86")]
	public static Comparer<T> Create(Comparison<T> comparison) { }

	[Address(RVA = "0x16D95C0", Offset = "0x16D89C0", Length = "0x520")]
	[Token(Token = "0x6002D87")]
	private static Comparer<T> CreateComparer() { }

	[Address(RVA = "0x16E19A0", Offset = "0x16E0DA0", Length = "0x10C")]
	[Token(Token = "0x6002D85")]
	public static Comparer<T> get_Default() { }

	[Address(RVA = "0x16E08C0", Offset = "0x16DFCC0", Length = "0x188")]
	[Token(Token = "0x6002D89")]
	private override int System.Collections.IComparer.Compare(object x, object y) { }

}


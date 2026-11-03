namespace System.Collections.Generic;

[Token(Token = "0x200061C")]
[TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
public abstract class EqualityComparer : IEqualityComparer, IEqualityComparer<T>
{
	[Token(Token = "0x40018B0")]
	private static EqualityComparer<T> defaultComparer; //Field offset: 0x0

	[Token(Token = "0x1700073E")]
	public static EqualityComparer<T> Default
	{
		[Address(RVA = "0x19D78D0", Offset = "0x19D6CD0", Length = "0x10C")]
		[Token(Token = "0x6002D99")]
		 get { } //Length: 268
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002DA1")]
	protected EqualityComparer`1() { }

	[Address(RVA = "0x19D3470", Offset = "0x19D2870", Length = "0xA9C")]
	[Token(Token = "0x6002D9A")]
	private static EqualityComparer<T> CreateComparer() { }

	[Token(Token = "0x6002D9B")]
	public abstract bool Equals(T x, T y) { }

	[Address(RVA = "0x19D78D0", Offset = "0x19D6CD0", Length = "0x10C")]
	[Token(Token = "0x6002D99")]
	public static EqualityComparer<T> get_Default() { }

	[Token(Token = "0x6002D9C")]
	public abstract int GetHashCode(T obj) { }

	[Address(RVA = "0x19D6AF0", Offset = "0x19D5EF0", Length = "0xCC")]
	[Token(Token = "0x6002D9D")]
	internal override int IndexOf(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0x19D6D80", Offset = "0x19D6180", Length = "0xCC")]
	[Token(Token = "0x6002D9E")]
	internal override int LastIndexOf(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0x19D70C0", Offset = "0x19D64C0", Length = "0x187")]
	[Token(Token = "0x6002DA0")]
	private override bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	[Address(RVA = "0x19D75D0", Offset = "0x19D69D0", Length = "0xDB")]
	[Token(Token = "0x6002D9F")]
	private override int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

}


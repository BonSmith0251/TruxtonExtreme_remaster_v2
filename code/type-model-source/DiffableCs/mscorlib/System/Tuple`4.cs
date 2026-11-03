namespace System;

[Token(Token = "0x2000145")]
public class Tuple : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000458")]
	private readonly T1 m_Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000459")]
	private readonly T2 m_Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400045A")]
	private readonly T3 m_Item3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400045B")]
	private readonly T4 m_Item4; //Field offset: 0x0

	[Token(Token = "0x170000B4")]
	public T1 Item1
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000A96")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B5")]
	public T2 Item2
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[Token(Token = "0x6000A97")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B6")]
	public T3 Item3
	{
		[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
		[Token(Token = "0x6000A98")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B7")]
	public T4 Item4
	{
		[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
		[Token(Token = "0x6000A99")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B8")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x6000AA3")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x10AA960", Offset = "0x10A9D60", Length = "0x51")]
	[Token(Token = "0x6000A9A")]
	public Tuple`4(T1 item1, T2 item2, T3 item3, T4 item4) { }

	[Address(RVA = "0x10A7B90", Offset = "0x10A6F90", Length = "0x72")]
	[Token(Token = "0x6000A9B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000A96")]
	public T1 get_Item1() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[Token(Token = "0x6000A97")]
	public T2 get_Item2() { }

	[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
	[Token(Token = "0x6000A98")]
	public T3 get_Item3() { }

	[Address(RVA = "0x10AAD90", Offset = "0x10AA190", Length = "0x5")]
	[Token(Token = "0x6000A99")]
	public T4 get_Item4() { }

	[Address(RVA = "0x10A7C10", Offset = "0x10A7010", Length = "0x63")]
	[Token(Token = "0x6000A9F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x10A7DD0", Offset = "0x10A71D0", Length = "0x2DC")]
	[Token(Token = "0x6000A9E")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x10A8DC0", Offset = "0x10A81C0", Length = "0x243")]
	[Token(Token = "0x6000A9C")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x10A9C60", Offset = "0x10A9060", Length = "0x173")]
	[Token(Token = "0x6000AA0")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x10A9DE0", Offset = "0x10A91E0", Length = "0x72")]
	[Token(Token = "0x6000A9D")]
	private override int System.IComparable.CompareTo(object obj) { }

	[Address(RVA = "0x10AA140", Offset = "0x10A9540", Length = "0x15B")]
	[Token(Token = "0x6000AA2")]
	private override string System.ITupleInternal.ToString(StringBuilder sb) { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x6000AA3")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x10AA7F0", Offset = "0x10A9BF0", Length = "0x8B")]
	[Token(Token = "0x6000AA1")]
	public virtual string ToString() { }

}


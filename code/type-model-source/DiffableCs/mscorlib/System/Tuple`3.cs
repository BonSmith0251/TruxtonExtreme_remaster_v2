namespace System;

[Token(Token = "0x2000144")]
public class Tuple : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000455")]
	private readonly T1 m_Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000456")]
	private readonly T2 m_Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000457")]
	private readonly T3 m_Item3; //Field offset: 0x0

	[Token(Token = "0x170000B0")]
	public T1 Item1
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000A89")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B1")]
	public T2 Item2
	{
		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[Token(Token = "0x6000A8A")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000B2")]
	public T3 Item3
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000A8B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B3")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6000A95")]
		private get { } //Length: 6
	}

	[Address(RVA = "0xF640E0", Offset = "0xF634E0", Length = "0x6D")]
	[Token(Token = "0x6000A8C")]
	public Tuple`3(T1 item1, T2 item2, T3 item3) { }

	[Address(RVA = "0x10A5BD0", Offset = "0x10A4FD0", Length = "0x72")]
	[Token(Token = "0x6000A8D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000A89")]
	public T1 get_Item1() { }

	[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
	[Token(Token = "0x6000A8A")]
	public T2 get_Item2() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000A8B")]
	public T3 get_Item3() { }

	[Address(RVA = "0x10A5E30", Offset = "0x10A5230", Length = "0x63")]
	[Token(Token = "0x6000A91")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x10A64C0", Offset = "0x10A58C0", Length = "0x1F8")]
	[Token(Token = "0x6000A90")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x10A6BB0", Offset = "0x10A5FB0", Length = "0x16B")]
	[Token(Token = "0x6000A8E")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x10A7010", Offset = "0x10A6410", Length = "0xD8")]
	[Token(Token = "0x6000A92")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x10A7170", Offset = "0x10A6570", Length = "0x72")]
	[Token(Token = "0x6000A8F")]
	private override int System.IComparable.CompareTo(object obj) { }

	[Address(RVA = "0x10A7580", Offset = "0x10A6980", Length = "0xEA")]
	[Token(Token = "0x6000A94")]
	private override string System.ITupleInternal.ToString(StringBuilder sb) { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6000A95")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x10A7790", Offset = "0x10A6B90", Length = "0x8B")]
	[Token(Token = "0x6000A93")]
	public virtual string ToString() { }

}


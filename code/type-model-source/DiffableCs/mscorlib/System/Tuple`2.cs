namespace System;

[Token(Token = "0x2000143")]
public class Tuple : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000453")]
	private readonly T1 m_Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000454")]
	private readonly T2 m_Item2; //Field offset: 0x0

	[Token(Token = "0x170000AD")]
	public T1 Item1
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x6000A7D")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170000AE")]
	public T2 Item2
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000A7E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000AF")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000A88")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x10A5860", Offset = "0x10A4C60", Length = "0x45")]
	[Token(Token = "0x6000A7F")]
	public Tuple`2(T1 item1, T2 item2) { }

	[Address(RVA = "0x10A3480", Offset = "0x10A2880", Length = "0x72")]
	[Token(Token = "0x6000A80")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x6000A7D")]
	public T1 get_Item1() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000A7E")]
	public T2 get_Item2() { }

	[Address(RVA = "0x10A35F0", Offset = "0x10A29F0", Length = "0x63")]
	[Token(Token = "0x6000A84")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x10A4030", Offset = "0x10A3430", Length = "0x1CC")]
	[Token(Token = "0x6000A83")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x10A45C0", Offset = "0x10A39C0", Length = "0x141")]
	[Token(Token = "0x6000A81")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x10A4B10", Offset = "0x10A3F10", Length = "0xAD")]
	[Token(Token = "0x6000A85")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x10A4EF0", Offset = "0x10A42F0", Length = "0x72")]
	[Token(Token = "0x6000A82")]
	private override int System.IComparable.CompareTo(object obj) { }

	[Address(RVA = "0x10A53D0", Offset = "0x10A47D0", Length = "0xC5")]
	[Token(Token = "0x6000A87")]
	private override string System.ITupleInternal.ToString(StringBuilder sb) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000A88")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x10A55D0", Offset = "0x10A49D0", Length = "0x8B")]
	[Token(Token = "0x6000A86")]
	public virtual string ToString() { }

}


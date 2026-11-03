namespace System;

[Token(Token = "0x2000159")]
public struct ValueTuple : IEquatable<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, TRest>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000499")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049A")]
	public T2 Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049B")]
	public T3 Item3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049C")]
	public T4 Item4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049D")]
	public T5 Item5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049E")]
	public T6 Item6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049F")]
	public T7 Item7; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004A0")]
	public TRest Rest; //Field offset: 0x0

	[Token(Token = "0x170000FB")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x1350400", Offset = "0x134F800", Length = "0x91")]
		[Token(Token = "0x6000C30")]
		private get { } //Length: 145
	}

	[Address(RVA = "0x1352950", Offset = "0x1351D50", Length = "0xE9")]
	[Token(Token = "0x6000C23")]
	public ValueTuple`8(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) { }

	[Address(RVA = "0x1341A80", Offset = "0x1340E80", Length = "0x33D")]
	[Token(Token = "0x6000C28")]
	public override int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { }

	[Address(RVA = "0x1342140", Offset = "0x1341540", Length = "0x128")]
	[Token(Token = "0x6000C24")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x13435D0", Offset = "0x13429D0", Length = "0x522")]
	[Token(Token = "0x6000C25")]
	public override bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { }

	[Address(RVA = "0x1349D80", Offset = "0x1349180", Length = "0x9B8")]
	[Token(Token = "0x6000C2A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13457A0", Offset = "0x1344BA0", Length = "0xD54")]
	[Token(Token = "0x6000C2C")]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[Address(RVA = "0x134A760", Offset = "0x1349B60", Length = "0x621")]
	[Token(Token = "0x6000C29")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x134D2E0", Offset = "0x134C6E0", Length = "0x55B")]
	[Token(Token = "0x6000C26")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x134D890", Offset = "0x134CC90", Length = "0x48")]
	[Token(Token = "0x6000C2B")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x134E0E0", Offset = "0x134D4E0", Length = "0x1F1")]
	[Token(Token = "0x6000C27")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x134D890", Offset = "0x134CC90", Length = "0x48")]
	[Token(Token = "0x6000C2D")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x134E2E0", Offset = "0x134D6E0", Length = "0x747")]
	[Token(Token = "0x6000C2F")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x1350400", Offset = "0x134F800", Length = "0x91")]
	[Token(Token = "0x6000C30")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x1351770", Offset = "0x1350B70", Length = "0x79B")]
	[Token(Token = "0x6000C2E")]
	public virtual string ToString() { }

}


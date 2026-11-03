namespace System;

[Token(Token = "0x2000157")]
public struct ValueTuple : IEquatable<ValueTuple`6<T1, T2, T3, T4, T5, T6>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`6<T1, T2, T3, T4, T5, T6>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048C")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048D")]
	public T2 Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048E")]
	public T3 Item3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048F")]
	public T4 Item4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000490")]
	public T5 Item5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000491")]
	public T6 Item6; //Field offset: 0x0

	[Token(Token = "0x170000F9")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
		[Token(Token = "0x6000C14")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x1335D50", Offset = "0x1335150", Length = "0x9D")]
	[Token(Token = "0x6000C07")]
	public ValueTuple`6(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { }

	[Address(RVA = "0x132D860", Offset = "0x132CC60", Length = "0x29B")]
	[Token(Token = "0x6000C0C")]
	public override int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6> other) { }

	[Address(RVA = "0x132EB20", Offset = "0x132DF20", Length = "0x143")]
	[Token(Token = "0x6000C08")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x132E880", Offset = "0x132DC80", Length = "0x29A")]
	[Token(Token = "0x6000C09")]
	public override bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6> other) { }

	[Address(RVA = "0x13306E0", Offset = "0x132FAE0", Length = "0x251")]
	[Token(Token = "0x6000C0E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x132EC70", Offset = "0x132E070", Length = "0x28F")]
	[Token(Token = "0x6000C10")]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[Address(RVA = "0x13314D0", Offset = "0x13308D0", Length = "0x555")]
	[Token(Token = "0x6000C0D")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x1331A30", Offset = "0x1330E30", Length = "0x45F")]
	[Token(Token = "0x6000C0A")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x13329F0", Offset = "0x1331DF0", Length = "0x48")]
	[Token(Token = "0x6000C0F")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x1332A40", Offset = "0x1331E40", Length = "0x227")]
	[Token(Token = "0x6000C0B")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x13329F0", Offset = "0x1331DF0", Length = "0x48")]
	[Token(Token = "0x6000C11")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x1334260", Offset = "0x1333660", Length = "0x363")]
	[Token(Token = "0x6000C13")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
	[Token(Token = "0x6000C14")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x13359B0", Offset = "0x1334DB0", Length = "0x393")]
	[Token(Token = "0x6000C12")]
	public virtual string ToString() { }

}


namespace System;

[Token(Token = "0x2000154")]
public struct ValueTuple : IEquatable<ValueTuple`3<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`3<T1, T2, T3>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000480")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000481")]
	public T2 Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000482")]
	public T3 Item3; //Field offset: 0x0

	[Token(Token = "0x170000F6")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6000BEA")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x12F4C70", Offset = "0x12F4070", Length = "0x208")]
	[Token(Token = "0x6000BDD")]
	public ValueTuple`3(T1 item1, T2 item2, T3 item3) { }

	[Address(RVA = "0x12F1740", Offset = "0x12F0B40", Length = "0x16B")]
	[Token(Token = "0x6000BE2")]
	public override int CompareTo(ValueTuple<T1, T2, T3> other) { }

	[Address(RVA = "0x12F1AE0", Offset = "0x12F0EE0", Length = "0x121")]
	[Token(Token = "0x6000BDE")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x12F1C10", Offset = "0x12F1010", Length = "0x265")]
	[Token(Token = "0x6000BDF")]
	public override bool Equals(ValueTuple<T1, T2, T3> other) { }

	[Address(RVA = "0x12F25D0", Offset = "0x12F19D0", Length = "0xE0")]
	[Token(Token = "0x6000BE4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x12F2240", Offset = "0x12F1640", Length = "0x145")]
	[Token(Token = "0x6000BE6")]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[Address(RVA = "0x12F2780", Offset = "0x12F1B80", Length = "0x381")]
	[Token(Token = "0x6000BE3")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x12F3720", Offset = "0x12F2B20", Length = "0x2BB")]
	[Token(Token = "0x6000BE0")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x12F3A80", Offset = "0x12F2E80", Length = "0x48")]
	[Token(Token = "0x6000BE5")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x12F3AD0", Offset = "0x12F2ED0", Length = "0x1E3")]
	[Token(Token = "0x6000BE1")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x12F3A80", Offset = "0x12F2E80", Length = "0x48")]
	[Token(Token = "0x6000BE7")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x12F4070", Offset = "0x12F3470", Length = "0x210")]
	[Token(Token = "0x6000BE9")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6000BEA")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x12F4620", Offset = "0x12F3A20", Length = "0x23A")]
	[Token(Token = "0x6000BE8")]
	public virtual string ToString() { }

}


namespace System;

[Token(Token = "0x2000156")]
public struct ValueTuple : IEquatable<ValueTuple`5<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`5<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000487")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000488")]
	public T2 Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000489")]
	public T3 Item3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048A")]
	public T4 Item4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400048B")]
	public T5 Item5; //Field offset: 0x0

	[Token(Token = "0x170000F8")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
		[Token(Token = "0x6000C06")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x132CB20", Offset = "0x132BF20", Length = "0x3F")]
	[Token(Token = "0x6000BF9")]
	public ValueTuple`5(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { }

	[Address(RVA = "0x13207E0", Offset = "0x131FBE0", Length = "0x1FA")]
	[Token(Token = "0x6000BFE")]
	public override int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other) { }

	[Address(RVA = "0x1322750", Offset = "0x1321B50", Length = "0x11F")]
	[Token(Token = "0x6000BFA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1321690", Offset = "0x1320A90", Length = "0x2F7")]
	[Token(Token = "0x6000BFB")]
	public override bool Equals(ValueTuple<T1, T2, T3, T4, T5> other) { }

	[Address(RVA = "0x1323C80", Offset = "0x1323080", Length = "0x12E")]
	[Token(Token = "0x6000C00")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1323AA0", Offset = "0x1322EA0", Length = "0x1D8")]
	[Token(Token = "0x6000C02")]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[Address(RVA = "0x1325E50", Offset = "0x1325250", Length = "0x453")]
	[Token(Token = "0x6000BFF")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x1326F60", Offset = "0x1326360", Length = "0x38E")]
	[Token(Token = "0x6000BFC")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x13285B0", Offset = "0x13279B0", Length = "0x48")]
	[Token(Token = "0x6000C01")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x1328600", Offset = "0x1327A00", Length = "0x1DF")]
	[Token(Token = "0x6000BFD")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x13285B0", Offset = "0x13279B0", Length = "0x48")]
	[Token(Token = "0x6000C03")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x132A840", Offset = "0x1329C40", Length = "0x269")]
	[Token(Token = "0x6000C05")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
	[Token(Token = "0x6000C06")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x132AAB0", Offset = "0x1329EB0", Length = "0x293")]
	[Token(Token = "0x6000C04")]
	public virtual string ToString() { }

}


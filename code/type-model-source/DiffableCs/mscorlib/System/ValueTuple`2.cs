namespace System;

[Token(Token = "0x2000153")]
public struct ValueTuple : IEquatable<ValueTuple`2<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`2<T1, T2>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400047E")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400047F")]
	public T2 Item2; //Field offset: 0x0

	[Token(Token = "0x170000F5")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000BDC")]
		private get { } //Length: 6
	}

	[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
	[Token(Token = "0x6000BCF")]
	public ValueTuple`2(T1 item1, T2 item2) { }

	[Address(RVA = "0x123D2C0", Offset = "0x123C6C0", Length = "0xC4")]
	[Token(Token = "0x6000BD4")]
	public override int CompareTo(ValueTuple<T1, T2> other) { }

	[Address(RVA = "0x1240980", Offset = "0x123FD80", Length = "0x116")]
	[Token(Token = "0x6000BD0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x12439F0", Offset = "0x1242DF0", Length = "0xD4")]
	[Token(Token = "0x6000BD1")]
	public override bool Equals(ValueTuple<T1, T2> other) { }

	[Address(RVA = "0x1245B70", Offset = "0x1244F70", Length = "0xD8")]
	[Token(Token = "0x6000BD6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1244850", Offset = "0x1243C50", Length = "0xED")]
	[Token(Token = "0x6000BD8")]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[Address(RVA = "0x1246AB0", Offset = "0x1245EB0", Length = "0x2CC")]
	[Token(Token = "0x6000BD5")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x124E8B0", Offset = "0x124DCB0", Length = "0x215")]
	[Token(Token = "0x6000BD2")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x1250670", Offset = "0x124FA70", Length = "0x48")]
	[Token(Token = "0x6000BD7")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x12520D0", Offset = "0x12514D0", Length = "0x1CB")]
	[Token(Token = "0x6000BD3")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x1250670", Offset = "0x124FA70", Length = "0x48")]
	[Token(Token = "0x6000BD9")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x1254660", Offset = "0x1253A60", Length = "0x128")]
	[Token(Token = "0x6000BDB")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000BDC")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x1257CB0", Offset = "0x12570B0", Length = "0x1C2")]
	[Token(Token = "0x6000BDA")]
	public virtual string ToString() { }

}


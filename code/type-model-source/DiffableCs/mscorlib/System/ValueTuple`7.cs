namespace System;

[Token(Token = "0x2000158")]
public struct ValueTuple : IEquatable<ValueTuple`7<T1, T2, T3, T4, T5, T6, T7>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`7<T1, T2, T3, T4, T5, T6, T7>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000492")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000493")]
	public T2 Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000494")]
	public T3 Item3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000495")]
	public T4 Item4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000496")]
	public T5 Item5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000497")]
	public T6 Item6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000498")]
	public T7 Item7; //Field offset: 0x0

	[Token(Token = "0x170000FA")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
		[Token(Token = "0x6000C22")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x1338590", Offset = "0x1337990", Length = "0xB4")]
	[Token(Token = "0x6000C15")]
	public ValueTuple`7(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { }

	[Address(RVA = "0x1336300", Offset = "0x1335700", Length = "0x302")]
	[Token(Token = "0x6000C1A")]
	public override int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) { }

	[Address(RVA = "0x1336610", Offset = "0x1335A10", Length = "0x14F")]
	[Token(Token = "0x6000C16")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1336760", Offset = "0x1335B60", Length = "0x301")]
	[Token(Token = "0x6000C17")]
	public override bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7> other) { }

	[Address(RVA = "0x1336D60", Offset = "0x1336160", Length = "0x2A9")]
	[Token(Token = "0x6000C1C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1336A70", Offset = "0x1335E70", Length = "0x2EF")]
	[Token(Token = "0x6000C1E")]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[Address(RVA = "0x1337010", Offset = "0x1336410", Length = "0x5ED")]
	[Token(Token = "0x6000C1B")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x1337600", Offset = "0x1336A00", Length = "0x4ED")]
	[Token(Token = "0x6000C18")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x1337AF0", Offset = "0x1336EF0", Length = "0x48")]
	[Token(Token = "0x6000C1D")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x1337B40", Offset = "0x1336F40", Length = "0x23F")]
	[Token(Token = "0x6000C19")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x1337AF0", Offset = "0x1336EF0", Length = "0x48")]
	[Token(Token = "0x6000C1F")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x1337D80", Offset = "0x1337180", Length = "0x3E8")]
	[Token(Token = "0x6000C21")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x9E1910", Offset = "0x9E0D10", Length = "0x6")]
	[Token(Token = "0x6000C22")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x1338170", Offset = "0x1337570", Length = "0x418")]
	[Token(Token = "0x6000C20")]
	public virtual string ToString() { }

}


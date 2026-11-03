namespace System;

[Token(Token = "0x2000155")]
public struct ValueTuple : IEquatable<ValueTuple`4<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`4<T1, T2, T3, T4>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000483")]
	public T1 Item1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000484")]
	public T2 Item2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000485")]
	public T3 Item3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000486")]
	public T4 Item4; //Field offset: 0x0

	[Token(Token = "0x170000F7")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x6000BF8")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x1320000", Offset = "0x131F400", Length = "0x36")]
	[Token(Token = "0x6000BEB")]
	public ValueTuple`4(T1 item1, T2 item2, T3 item3, T4 item4) { }

	[Address(RVA = "0x13130C0", Offset = "0x13124C0", Length = "0x1BD")]
	[Token(Token = "0x6000BF0")]
	public override int CompareTo(ValueTuple<T1, T2, T3, T4> other) { }

	[Address(RVA = "0x1315B00", Offset = "0x1314F00", Length = "0x121")]
	[Token(Token = "0x6000BEC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1315820", Offset = "0x1314C20", Length = "0x1B6")]
	[Token(Token = "0x6000BED")]
	public override bool Equals(ValueTuple<T1, T2, T3, T4> other) { }

	[Address(RVA = "0x1316C10", Offset = "0x1316010", Length = "0x10F")]
	[Token(Token = "0x6000BF2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13163E0", Offset = "0x13157E0", Length = "0x139")]
	[Token(Token = "0x6000BF4")]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[Address(RVA = "0x1318A60", Offset = "0x1317E60", Length = "0x33E")]
	[Token(Token = "0x6000BF1")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x131B570", Offset = "0x131A970", Length = "0x271")]
	[Token(Token = "0x6000BEE")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x131B840", Offset = "0x131AC40", Length = "0x48")]
	[Token(Token = "0x6000BF3")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x131C630", Offset = "0x131BA30", Length = "0x1E3")]
	[Token(Token = "0x6000BEF")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x131B840", Offset = "0x131AC40", Length = "0x48")]
	[Token(Token = "0x6000BF5")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x131C820", Offset = "0x131BC20", Length = "0x221")]
	[Token(Token = "0x6000BF7")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x6000BF8")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x131F800", Offset = "0x131EC00", Length = "0x24B")]
	[Token(Token = "0x6000BF6")]
	public virtual string ToString() { }

}


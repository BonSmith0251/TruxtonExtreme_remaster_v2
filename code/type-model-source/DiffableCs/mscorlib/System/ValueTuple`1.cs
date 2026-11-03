namespace System;

[Token(Token = "0x2000152")]
public struct ValueTuple : IEquatable<ValueTuple`1<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`1<T1>>, IValueTupleInternal, ITuple
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400047D")]
	public T1 Item1; //Field offset: 0x0

	[Token(Token = "0x170000F4")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000BCE")]
		private get { } //Length: 6
	}

	[Address(RVA = "0x123BF80", Offset = "0x123B380", Length = "0x3")]
	[Token(Token = "0x6000BC2")]
	public ValueTuple`1(T1 item1) { }

	[Address(RVA = "0x1238CD0", Offset = "0x12380D0", Length = "0x67")]
	[Token(Token = "0x6000BC7")]
	public override int CompareTo(ValueTuple<T1> other) { }

	[Address(RVA = "0x1239210", Offset = "0x1238610", Length = "0x10B")]
	[Token(Token = "0x6000BC3")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1239020", Offset = "0x1238420", Length = "0x67")]
	[Token(Token = "0x6000BC4")]
	public override bool Equals(ValueTuple<T1> other) { }

	[Address(RVA = "0x1239B30", Offset = "0x1238F30", Length = "0x57")]
	[Token(Token = "0x6000BC9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x123A190", Offset = "0x1239590", Length = "0x237")]
	[Token(Token = "0x6000BC8")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x123A3D0", Offset = "0x12397D0", Length = "0x17A")]
	[Token(Token = "0x6000BC5")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x123AA80", Offset = "0x1239E80", Length = "0x95")]
	[Token(Token = "0x6000BCA")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x123B250", Offset = "0x123A650", Length = "0x1D7")]
	[Token(Token = "0x6000BC6")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x123B600", Offset = "0x123AA00", Length = "0x95")]
	[Token(Token = "0x6000BCB")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x123B6A0", Offset = "0x123AAA0", Length = "0x85")]
	[Token(Token = "0x6000BCD")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000BCE")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x123BBA0", Offset = "0x123AFA0", Length = "0xA5")]
	[Token(Token = "0x6000BCC")]
	public virtual string ToString() { }

}


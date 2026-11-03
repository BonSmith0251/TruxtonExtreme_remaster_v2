namespace System;

[Token(Token = "0x2000151")]
public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple
{

	[Token(Token = "0x170000F3")]
	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000BB9")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x2056FF0", Offset = "0x20563F0", Length = "0x20B")]
	[Token(Token = "0x6000BC1")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8) { }

	[Address(RVA = "0x2056AC0", Offset = "0x2055EC0", Length = "0x189")]
	[Token(Token = "0x6000BBF")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6) { }

	[Address(RVA = "0x2056970", Offset = "0x2055D70", Length = "0x148")]
	[Token(Token = "0x6000BBE")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5) { }

	[Address(RVA = "0x2056E20", Offset = "0x2056220", Length = "0x107")]
	[Token(Token = "0x6000BBD")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	[Address(RVA = "0x2056F30", Offset = "0x2056330", Length = "0xBB")]
	[Token(Token = "0x6000BBC")]
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	[Address(RVA = "0x2056900", Offset = "0x2055D00", Length = "0x6F")]
	[Token(Token = "0x6000BBB")]
	internal static int CombineHashCodes(int h1, int h2) { }

	[Address(RVA = "0x2056C50", Offset = "0x2056050", Length = "0x1CA")]
	[Token(Token = "0x6000BC0")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BB2")]
	public override int CompareTo(ValueTuple other) { }

	[Address(RVA = "0x9E4200", Offset = "0x9E3600", Length = "0x73")]
	[Token(Token = "0x6000BBA")]
	public static ValueTuple<T1, T2> Create(T1 item1, T2 item2) { }

	[Address(RVA = "0x2057200", Offset = "0x2056600", Length = "0x46")]
	[Token(Token = "0x6000BAE")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000BAF")]
	public override bool Equals(ValueTuple other) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BB4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2057250", Offset = "0x2056650", Length = "0x110")]
	[Token(Token = "0x6000BB3")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x2057370", Offset = "0x2056770", Length = "0x46")]
	[Token(Token = "0x6000BB0")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BB5")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x20573C0", Offset = "0x20567C0", Length = "0x110")]
	[Token(Token = "0x6000BB1")]
	private override int System.IComparable.CompareTo(object other) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BB6")]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x20574E0", Offset = "0x20568E0", Length = "0x2C")]
	[Token(Token = "0x6000BB8")]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BB9")]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[Address(RVA = "0x2057510", Offset = "0x2056910", Length = "0x2C")]
	[Token(Token = "0x6000BB7")]
	public virtual string ToString() { }

}


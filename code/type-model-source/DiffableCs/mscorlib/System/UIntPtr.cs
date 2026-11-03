namespace System;

[CLSCompliant(False)]
[ComVisible(True)]
[IsReadOnly]
[Token(Token = "0x20001DB")]
public struct UIntPtr : ISerializable, IEquatable<UIntPtr>
{
	[Token(Token = "0x400091C")]
	public static readonly UIntPtr Zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400091D")]
	private readonly Void* _pointer; //Field offset: 0x0

	[Token(Token = "0x17000176")]
	public static int Size
	{
		[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
		[Token(Token = "0x60010B9")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x20A95D0", Offset = "0x20A89D0", Length = "0x16")]
	[Token(Token = "0x60010BB")]
	private static UIntPtr() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x60010AC")]
	public UIntPtr(Void* value) { }

	[Address(RVA = "0x20A9600", Offset = "0x20A8A00", Length = "0x6")]
	[Token(Token = "0x60010AA")]
	public UIntPtr(ulong value) { }

	[Address(RVA = "0x20A95F0", Offset = "0x20A89F0", Length = "0x6")]
	[Token(Token = "0x60010AB")]
	public UIntPtr(uint value) { }

	[Address(RVA = "0x20A94B0", Offset = "0x20A88B0", Length = "0x5A")]
	[Token(Token = "0x60010AD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x60010B9")]
	public static int get_Size() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60010AE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x60010B3")]
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x60010B5")]
	public static UIntPtr op_Explicit(ulong value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x60010B6")]
	public static UIntPtr op_Explicit(Void* value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x60010B7")]
	public static Void* op_Explicit(UIntPtr value) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x60010B8")]
	public static UIntPtr op_Explicit(uint value) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x60010B4")]
	public static bool op_Inequality(UIntPtr value1, UIntPtr value2) { }

	[Address(RVA = "0x604730", Offset = "0x603B30", Length = "0x7")]
	[Token(Token = "0x60010BA")]
	private override bool System.IEquatable<System.UIntPtr>.Equals(UIntPtr other) { }

	[Address(RVA = "0x20A9510", Offset = "0x20A8910", Length = "0x98")]
	[Token(Token = "0x60010B2")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CLSCompliant(False)]
	[Token(Token = "0x60010B0")]
	public Void* ToPointer() { }

	[Address(RVA = "0x20A95B0", Offset = "0x20A89B0", Length = "0x1D")]
	[Token(Token = "0x60010B1")]
	public virtual string ToString() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60010AF")]
	public ulong ToUInt64() { }

}


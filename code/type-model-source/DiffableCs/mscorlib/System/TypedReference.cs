namespace System;

[CLSCompliant(False)]
[ComVisible(True)]
[IsByRefLike]
[NonVersionable]
[Token(Token = "0x2000199")]
public struct TypedReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400065A")]
	private RuntimeTypeHandle type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400065B")]
	private IntPtr Value; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400065C")]
	private IntPtr Type; //Field offset: 0x10

	[Token(Token = "0x17000144")]
	internal bool IsNull
	{
		[Address(RVA = "0x2091150", Offset = "0x2090550", Length = "0x13")]
		[Token(Token = "0x6000EFB")]
		internal get { } //Length: 19
	}

	[Address(RVA = "0x2090A60", Offset = "0x208FE60", Length = "0x5F")]
	[Token(Token = "0x6000EFA")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2091150", Offset = "0x2090550", Length = "0x13")]
	[Token(Token = "0x6000EFB")]
	internal bool get_IsNull() { }

	[Address(RVA = "0x2090AC0", Offset = "0x208FEC0", Length = "0x60")]
	[Token(Token = "0x6000EF9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2090B30", Offset = "0x208FF30", Length = "0x5")]
	[Token(Token = "0x6000EF8")]
	private static void InternalMakeTypedReference(Void* result, object target, IntPtr[] flds, RuntimeType lastFieldType) { }

	[Address(RVA = "0x2090B40", Offset = "0x208FF40", Length = "0x5B1")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000EF7")]
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	[Address(RVA = "0x2091100", Offset = "0x2090500", Length = "0x4E")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000EFC")]
	public static void SetTypedReference(TypedReference target, object value) { }

}


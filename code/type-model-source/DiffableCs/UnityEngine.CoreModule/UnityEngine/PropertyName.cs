namespace UnityEngine;

[Token(Token = "0x2000175")]
[UsedByNativeCode]
public struct PropertyName : IEquatable<PropertyName>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400060E")]
	internal int id; //Field offset: 0x0

	[Address(RVA = "0x306F910", Offset = "0x306ED10", Length = "0x1E")]
	[Token(Token = "0x600120D")]
	public PropertyName(string name) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600120E")]
	public PropertyName(PropertyName other) { }

	[Address(RVA = "0x306F810", Offset = "0x306EC10", Length = "0x81")]
	[Token(Token = "0x6001212")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x2FD0220", Offset = "0x2FCF620", Length = "0x8")]
	[Token(Token = "0x6001213")]
	public override bool Equals(PropertyName other) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6001211")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x306F8A0", Offset = "0x306ECA0", Length = "0x8")]
	[Token(Token = "0x600120F")]
	public static bool IsNullOrEmpty(PropertyName prop) { }

	[Address(RVA = "0x306F930", Offset = "0x306ED30", Length = "0x8")]
	[Token(Token = "0x6001210")]
	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	[Address(RVA = "0x306F940", Offset = "0x306ED40", Length = "0x9")]
	[Token(Token = "0x6001214")]
	public static PropertyName op_Implicit(string name) { }

	[Address(RVA = "0x306F8B0", Offset = "0x306ECB0", Length = "0x54")]
	[Token(Token = "0x6001215")]
	public virtual string ToString() { }

}


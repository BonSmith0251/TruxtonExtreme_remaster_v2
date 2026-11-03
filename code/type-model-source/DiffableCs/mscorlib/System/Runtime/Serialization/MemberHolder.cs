namespace System.Runtime.Serialization;

[Token(Token = "0x20003DE")]
internal sealed class MemberHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F2C")]
	internal readonly Type _memberType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F2D")]
	internal readonly StreamingContext _context; //Field offset: 0x18

	[Address(RVA = "0x10A5A10", Offset = "0x10A4E10", Length = "0x50")]
	[Token(Token = "0x6001DA5")]
	internal MemberHolder(Type type, StreamingContext ctx) { }

	[Address(RVA = "0x1F06B30", Offset = "0x1F05F30", Length = "0x73")]
	[Token(Token = "0x6001DA7")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1E3ED90", Offset = "0x1E3E190", Length = "0x2A")]
	[Token(Token = "0x6001DA6")]
	public virtual int GetHashCode() { }

}


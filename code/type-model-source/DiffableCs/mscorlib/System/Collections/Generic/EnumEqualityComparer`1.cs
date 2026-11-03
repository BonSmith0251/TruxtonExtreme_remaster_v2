namespace System.Collections.Generic;

[Token(Token = "0x2000621")]
internal class EnumEqualityComparer : EqualityComparer<T>, ISerializable
{

	[Address(RVA = "0xDAAD40", Offset = "0xDAA140", Length = "0x14")]
	[Token(Token = "0x6002DC0")]
	public EnumEqualityComparer`1() { }

	[Address(RVA = "0x1952F70", Offset = "0x1952370", Length = "0x14")]
	[Token(Token = "0x6002DC1")]
	protected EnumEqualityComparer`1(SerializationInfo information, StreamingContext context) { }

	[Address(RVA = "0x1952D10", Offset = "0x1952110", Length = "0x5C")]
	[Token(Token = "0x6002DBE")]
	public virtual bool Equals(T x, T y) { }

	[Address(RVA = "0xD9A4D0", Offset = "0xD998D0", Length = "0x72")]
	[Token(Token = "0x6002DC3")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1952E60", Offset = "0x1952260", Length = "0x38")]
	[Token(Token = "0x6002DBF")]
	public virtual int GetHashCode(T obj) { }

	[Address(RVA = "0xCF02A0", Offset = "0xCEF6A0", Length = "0x51")]
	[Token(Token = "0x6002DC4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1952EA0", Offset = "0x19522A0", Length = "0xCA")]
	[Token(Token = "0x6002DC2")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}


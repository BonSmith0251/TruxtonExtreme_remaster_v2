namespace System.Collections.Generic;

[Token(Token = "0x2000622")]
internal sealed class SByteEnumEqualityComparer : EnumEqualityComparer<T>, ISerializable
{

	[Address(RVA = "0xF52FC0", Offset = "0xF523C0", Length = "0x14")]
	[Token(Token = "0x6002DC5")]
	public SByteEnumEqualityComparer`1() { }

	[Address(RVA = "0xF54B80", Offset = "0xF53F80", Length = "0x14")]
	[Token(Token = "0x6002DC6")]
	public SByteEnumEqualityComparer`1(SerializationInfo information, StreamingContext context) { }

	[Address(RVA = "0xF54AD0", Offset = "0xF53ED0", Length = "0xAA")]
	[Token(Token = "0x6002DC7")]
	public virtual int GetHashCode(T obj) { }

}


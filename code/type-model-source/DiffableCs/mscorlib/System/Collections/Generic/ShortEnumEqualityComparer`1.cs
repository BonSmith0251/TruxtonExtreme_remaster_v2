namespace System.Collections.Generic;

[Token(Token = "0x2000623")]
internal sealed class ShortEnumEqualityComparer : EnumEqualityComparer<T>, ISerializable
{

	[Address(RVA = "0xF52FC0", Offset = "0xF523C0", Length = "0x14")]
	[Token(Token = "0x6002DC8")]
	public ShortEnumEqualityComparer`1() { }

	[Address(RVA = "0xF54B80", Offset = "0xF53F80", Length = "0x14")]
	[Token(Token = "0x6002DC9")]
	public ShortEnumEqualityComparer`1(SerializationInfo information, StreamingContext context) { }

	[Address(RVA = "0xF62590", Offset = "0xF61990", Length = "0xAD")]
	[Token(Token = "0x6002DCA")]
	public virtual int GetHashCode(T obj) { }

}


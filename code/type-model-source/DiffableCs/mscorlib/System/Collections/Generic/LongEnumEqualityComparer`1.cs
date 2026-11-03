namespace System.Collections.Generic;

[Token(Token = "0x2000624")]
internal sealed class LongEnumEqualityComparer : EqualityComparer<T>, ISerializable
{

	[Address(RVA = "0xB0D4D0", Offset = "0xB0C8D0", Length = "0x15")]
	[Token(Token = "0x6002DCF")]
	public LongEnumEqualityComparer`1() { }

	[Address(RVA = "0xCF0410", Offset = "0xCEF810", Length = "0x15")]
	[Token(Token = "0x6002DD0")]
	public LongEnumEqualityComparer`1(SerializationInfo information, StreamingContext context) { }

	[Address(RVA = "0xCF0190", Offset = "0xCEF590", Length = "0x10B")]
	[Token(Token = "0x6002DCB")]
	public virtual bool Equals(T x, T y) { }

	[Address(RVA = "0xCF0140", Offset = "0xCEF540", Length = "0x47")]
	[Token(Token = "0x6002DCD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xCF0300", Offset = "0xCEF700", Length = "0xAE")]
	[Token(Token = "0x6002DCC")]
	public virtual int GetHashCode(T obj) { }

	[Address(RVA = "0xCF02A0", Offset = "0xCEF6A0", Length = "0x51")]
	[Token(Token = "0x6002DCE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xCF03B0", Offset = "0xCEF7B0", Length = "0x5D")]
	[Token(Token = "0x6002DD1")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}


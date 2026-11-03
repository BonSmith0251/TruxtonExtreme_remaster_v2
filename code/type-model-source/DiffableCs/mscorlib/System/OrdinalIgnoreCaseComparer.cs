namespace System;

[Token(Token = "0x2000138")]
internal sealed class OrdinalIgnoreCaseComparer : OrdinalComparer, ISerializable
{

	[Address(RVA = "0x2044740", Offset = "0x2043B40", Length = "0x4E")]
	[Token(Token = "0x6000A3B")]
	public OrdinalIgnoreCaseComparer() { }

	[Address(RVA = "0x20445F0", Offset = "0x20439F0", Length = "0x17")]
	[Token(Token = "0x6000A3C")]
	public virtual int Compare(string x, string y) { }

	[Address(RVA = "0x2044610", Offset = "0x2043A10", Length = "0x17")]
	[Token(Token = "0x6000A3D")]
	public virtual bool Equals(string x, string y) { }

	[Address(RVA = "0x2044630", Offset = "0x2043A30", Length = "0x57")]
	[Token(Token = "0x6000A3E")]
	public virtual int GetHashCode(string obj) { }

	[Address(RVA = "0x2044690", Offset = "0x2043A90", Length = "0xAE")]
	[Token(Token = "0x6000A3F")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}


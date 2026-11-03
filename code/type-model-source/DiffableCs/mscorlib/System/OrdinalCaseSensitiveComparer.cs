namespace System;

[Token(Token = "0x2000137")]
internal sealed class OrdinalCaseSensitiveComparer : OrdinalComparer, ISerializable
{

	[Address(RVA = "0x2044310", Offset = "0x2043710", Length = "0x4E")]
	[Token(Token = "0x6000A36")]
	public OrdinalCaseSensitiveComparer() { }

	[Address(RVA = "0x1F34BA0", Offset = "0x1F33FA0", Length = "0x11")]
	[Token(Token = "0x6000A37")]
	public virtual int Compare(string x, string y) { }

	[Address(RVA = "0x1F34CA0", Offset = "0x1F340A0", Length = "0x11")]
	[Token(Token = "0x6000A38")]
	public virtual bool Equals(string x, string y) { }

	[Address(RVA = "0x2044230", Offset = "0x2043630", Length = "0x2E")]
	[Token(Token = "0x6000A39")]
	public virtual int GetHashCode(string obj) { }

	[Address(RVA = "0x2044260", Offset = "0x2043660", Length = "0xAE")]
	[Token(Token = "0x6000A3A")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

